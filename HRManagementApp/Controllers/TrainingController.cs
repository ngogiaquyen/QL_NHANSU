using HRManagementApp.Models;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace HRManagementApp.Controllers
{
    public class TrainingController
    {
        private readonly HRManagementForm form;
        private readonly DatabaseManager dbManager;

        public TrainingController(HRManagementForm form)
        {
            this.form = form;
            dbManager = new DatabaseManager();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void LoadTrainings()
        {
            try
            {
                DataTable dt = dbManager.GetTrainings();
                form.UpdateTrainingGrid(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách đào tạo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchTrainings(string searchTerm)
        {
            try
            {
                DataTable dt = dbManager.SearchTrainings(searchTerm);
                form.UpdateTrainingGrid(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm đào tạo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowTrainingDetails(string trainingId)
        {
            try
            {
                DataTable dt = dbManager.GetTrainings();
                DataRow[] rows = dt.Select($"TrainingId = '{trainingId}'");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    form.txtTrainingId.Text = row["TrainingId"]?.ToString();
                    form.cbTrainingEmployee.SelectedValue = row["EmployeeId"]?.ToString();
                    form.txtTrainingPlanPath.Text = row["TrainingPlanPath"]?.ToString();
                    form.txtCertificatePath.Text = row["CertificatePath"]?.ToString();
                    form.txtEvaluationPath.Text = row["EvaluationPath"]?.ToString();
                    form.txtCareerPath.Text = row["CareerPath"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết đào tạo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddTraining(Training training)
        {
            try
            {
                dbManager.AddTraining(training);
                LoadTrainings();
                form.ClearTrainingFields();
                MessageBox.Show("Thêm đào tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm đào tạo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateTraining(Training training)
        {
            try
            {
                dbManager.UpdateTraining(training);
                LoadTrainings();
                form.ClearTrainingFields();
                MessageBox.Show("Cập nhật đào tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật đào tạo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteTraining(string trainingId)
        {
            try
            {
                dbManager.DeleteTraining(trainingId);
                LoadTrainings();
                form.ClearTrainingFields();
                MessageBox.Show("Xóa đào tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa đào tạo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportTrainingsToExcel()
        {
            try
            {
                DataTable dt = dbManager.GetTrainings();
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Trainings");
                    worksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    worksheet.Cells.AutoFitColumns();

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files|*.xlsx",
                        FileName = "Trainings.xlsx"
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