using HRManagementApp.Models;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace HRManagementApp.Controllers
{
    public class DisciplineController
    {
        private readonly HRManagementForm form;
        private readonly DatabaseManager dbManager;

        public DisciplineController(HRManagementForm form)
        {
            this.form = form;
            dbManager = new DatabaseManager();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public DataTable GetDisciplines()
        {
            try
            {
                return dbManager.GetDisciplines();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách kỷ luật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public void LoadDisciplines()
        {
            try
            {
                DataTable dt = dbManager.GetDisciplines();
                form.UpdateDisciplineGrid(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách kỷ luật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowDisciplineDetails(string disciplineId)
        {
            try
            {
                DataTable dt = dbManager.GetDisciplines();
                DataRow[] rows = dt.Select($"DisciplineId = '{disciplineId}'");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    form.txtDisciplineId.Text = row["DisciplineId"]?.ToString();
                    form.cbDisciplineEmployee.SelectedValue = row["EmployeeId"]?.ToString();
                    form.txtViolationPath.Text = row["ViolationPath"]?.ToString();
                    form.txtDisciplinaryDecisionPath.Text = row["DisciplinaryDecisionPath"]?.ToString();
                    form.txtResignationLetterPath.Text = row["ResignationLetterPath"]?.ToString();
                    form.txtTerminationDecisionPath.Text = row["TerminationDecisionPath"]?.ToString();
                    form.txtHandoverPath.Text = row["HandoverPath"]?.ToString();
                    form.txtLiquidationPath.Text = row["LiquidationPath"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết kỷ luật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            try
            {
                dbManager.AddDiscipline(discipline);
                LoadDisciplines();
                form.ClearDisciplineFields();
                MessageBox.Show("Thêm kỷ luật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm kỷ luật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDiscipline(Discipline discipline)
        {
            try
            {
                dbManager.UpdateDiscipline(discipline);
                LoadDisciplines();
                form.ClearDisciplineFields();
                MessageBox.Show("Cập nhật kỷ luật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật kỷ luật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteDiscipline(string disciplineId)
        {
            try
            {
                dbManager.DeleteDiscipline(disciplineId);
                LoadDisciplines();
                form.ClearDisciplineFields();
                MessageBox.Show("Xóa kỷ luật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa kỷ luật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportDisciplinesToExcel()
        {
            try
            {
                DataTable dt = dbManager.GetDisciplines();
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Disciplines");
                    worksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    worksheet.Cells.AutoFitColumns();

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files|*.xlsx",
                        FileName = "Disciplines.xlsx"
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