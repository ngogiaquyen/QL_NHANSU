using HRManagementApp.Models;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace HRManagementApp.Controllers
{
    public class AttendanceController
    {
        private readonly HRManagementForm form;
        private readonly DatabaseManager dbManager;

        public AttendanceController(HRManagementForm form)
        {
            this.form = form;
            dbManager = new DatabaseManager();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void LoadAttendances()
        {
            try
            {
                DataTable dt = dbManager.GetAttendances();
                form.UpdateAttendanceGrid(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách chấm công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetAttendances()
        {
            try
            {
                return dbManager.GetAttendances();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách chấm công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public void ShowAttendanceDetails(string attendanceId)
        {
            try
            {
                DataTable dt = dbManager.GetAttendances();
                DataRow[] rows = dt.Select($"AttendanceId = '{attendanceId}'");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    form.txtAttendanceId.Text = row["AttendanceId"]?.ToString();
                    form.cbAttendanceEmployee.SelectedValue = row["EmployeeId"]?.ToString();
                    form.dtpAttendanceDate.Value = row["AttendanceDate"] != DBNull.Value ? Convert.ToDateTime(row["AttendanceDate"]) : DateTime.Today;
                    form.dtpCheckInTime.Value = row["CheckInTime"] != DBNull.Value ? Convert.ToDateTime(row["CheckInTime"]) : DateTime.Now;
                    form.dtpCheckOutTime.Value = row["CheckOutTime"] != DBNull.Value ? Convert.ToDateTime(row["CheckOutTime"]) : DateTime.Now;
                    form.cbStatus.Text = row["Status"]?.ToString();
                    form.txtAdminHours.Text = row["AdminHours"] != DBNull.Value ? row["AdminHours"].ToString() : "";
                    form.txtOvertimeHours.Text = row["OvertimeHours"] != DBNull.Value ? row["OvertimeHours"].ToString() : "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết chấm công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddAttendance(Attendance attendance)
        {
            try
            {
                dbManager.AddAttendance(attendance);
                LoadAttendances();
                form.ClearAttendanceFields();
                MessageBox.Show("Thêm chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm chấm công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateAttendance(Attendance attendance)
        {
            try
            {
                dbManager.UpdateAttendance(attendance);
                LoadAttendances();
                form.ClearAttendanceFields();
                MessageBox.Show("Cập nhật chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật chấm công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteAttendance(string attendanceId)
        {
            try
            {
                dbManager.DeleteAttendance(attendanceId);
                LoadAttendances();
                form.ClearAttendanceFields();
                MessageBox.Show("Xóa chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa chấm công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportAttendancesToExcel()
        {
            try
            {
                DataTable dt = dbManager.GetAttendances();
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Attendances");
                    worksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    worksheet.Cells.AutoFitColumns();

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files|*.xlsx",
                        FileName = "Attendances.xlsx"
                    };
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                        MessageBox.Show("Xuất file Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}