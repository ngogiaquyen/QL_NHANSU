using HRManagementApp.Data;
using HRManagementApp.Models;
using HRManagementApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Windows.Forms;
using System.IO;

namespace HRManagementApp.Controllers
{
    public class AttendanceController
    {
        private readonly DatabaseManager dbManager;
        private readonly HRManagementForm view;

        public AttendanceController(HRManagementForm view)
        {
            this.view = view;
            dbManager = new DatabaseManager();
        }

        public void LoadAttendance()
        {
            try
            {
                view.UpdateAttendanceGrid(dbManager.GetAttendance());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchAttendance(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    LoadAttendance(); // Nếu không nhập, tải tất cả
                }
                else
                {
                    view.UpdateAttendanceGrid(dbManager.SearchAttendance(searchTerm));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddAttendance(Attendance attendance)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(attendance.EmployeeId) || attendance.Date == default ||
                    string.IsNullOrWhiteSpace(attendance.Status))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin chấm công (giờ hành chính và tăng ca sẽ tự động tính)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Attendance.ValidStatuses.Contains(attendance.Status))
                {
                    MessageBox.Show("Trạng thái chấm công không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tự động tính giờ hành chính và tăng ca (không cần nhập)
                attendance.CalculateHours();

                dbManager.AddAttendance(attendance);
                MessageBox.Show("Thêm chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAttendance();
                view.ClearAttendanceFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateAttendance(Attendance attendance)
        {
            try
            {
                if (attendance.Id == 0 || string.IsNullOrWhiteSpace(attendance.EmployeeId) || attendance.Date == default ||
                    string.IsNullOrWhiteSpace(attendance.Status))
                {
                    MessageBox.Show("Vui lòng chọn chấm công để cập nhật và điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Attendance.ValidStatuses.Contains(attendance.Status))
                {
                    MessageBox.Show("Trạng thái chấm công không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tự động tính giờ hành chính và tăng ca khi cập nhật
                attendance.CalculateHours();

                dbManager.UpdateAttendance(attendance);
                MessageBox.Show("Cập nhật chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteAttendance(int id)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Vui lòng chọn chấm công để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc muốn xóa chấm công này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                dbManager.DeleteAttendance(id);
                MessageBox.Show("Xóa chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAttendance();
                view.ClearAttendanceFields();
                view.ClearDetailPanels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowAttendanceDetails(DataGridViewRow row)
        {
            view.ShowAttendanceDetails(row);
        }

        public void ExportAttendanceToExcel()
        {
            try
            {
                // EPPlus 8+: Set license mới
                ExcelPackage.License.SetNonCommercialOrganization("HRManagementApp"); // Hoặc tên tổ chức của bạn

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Chấm công");
                    var table = dbManager.GetAttendance();
                    worksheet.Cells[1, 1].LoadFromDataTable(table, true);
                    worksheet.Cells.AutoFitColumns();

                    var saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files (*.xlsx)|*.xlsx",
                        FileName = "DanhSachChamCong.xlsx"
                    };
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var fileBytes = package.GetAsByteArray();
                        File.WriteAllBytes(saveFileDialog.FileName, fileBytes);
                        MessageBox.Show("Xuất Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
