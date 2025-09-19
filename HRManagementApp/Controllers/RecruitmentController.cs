using HRManagementApp.Models;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace HRManagementApp.Controllers
{
    public class RecruitmentController
    {
        private readonly HRManagementForm form;
        private readonly DatabaseManager dbManager;

        public RecruitmentController(HRManagementForm form)
        {
            this.form = form;
            dbManager = new DatabaseManager();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public DataTable GetRecruitments()
        {
            try
            {
                return dbManager.GetRecruitments();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách tuyển dụng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public void LoadRecruitments()
        {
            try
            {
                DataTable dt = dbManager.GetRecruitments();
                form.UpdateRecruitmentGrid(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách hồ sơ tuyển dụng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowRecruitmentDetails(string recruitmentId)
        {
            try
            {
                DataTable dt = dbManager.GetRecruitments();
                DataRow[] rows = dt.Select($"RecruitmentId = '{recruitmentId}'");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    form.txtRecruitmentId.Text = row["RecruitmentId"]?.ToString();
                    form.cbRecruitmentEmployee.SelectedValue = row["EmployeeId"]?.ToString();
                    form.txtJobApplicationPath.Text = row["JobApplicationPath"]?.ToString();
                    form.txtResumePath.Text = row["ResumePath"]?.ToString();
                    form.txtDegreesPath.Text = row["DegreesPath"]?.ToString();
                    form.txtHealthCheckPath.Text = row["HealthCheckPath"]?.ToString();
                    form.txtCVPath.Text = row["CVPath"]?.ToString();
                    form.txtReferenceLetterPath.Text = row["ReferenceLetterPath"]?.ToString();
                    form.txtInterviewMinutesPath.Text = row["InterviewMinutesPath"]?.ToString();
                    form.txtOfferLetterPath.Text = row["OfferLetterPath"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết hồ sơ tuyển dụng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddRecruitment(Recruitment recruitment)
        {
            try
            {
                dbManager.AddRecruitment(recruitment);
                LoadRecruitments();
                form.ClearRecruitmentFields();
                MessageBox.Show("Thêm hồ sơ tuyển dụng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm hồ sơ tuyển dụng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateRecruitment(Recruitment recruitment)
        {
            try
            {
                dbManager.UpdateRecruitment(recruitment);
                LoadRecruitments();
                form.ClearRecruitmentFields();
                MessageBox.Show("Cập nhật hồ sơ tuyển dụng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật hồ sơ tuyển dụng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteRecruitment(string recruitmentId)
        {
            try
            {
                dbManager.DeleteRecruitment(recruitmentId);
                LoadRecruitments();
                form.ClearRecruitmentFields();
                MessageBox.Show("Xóa hồ sơ tuyển dụng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa hồ sơ tuyển dụng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportRecruitmentsToExcel()
        {
            try
            {
                DataTable dt = dbManager.GetRecruitments();
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Recruitments");
                    worksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    worksheet.Cells.AutoFitColumns();

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files|*.xlsx",
                        FileName = "Recruitments.xlsx"
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