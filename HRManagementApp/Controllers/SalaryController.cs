using HRManagementApp.Models;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace HRManagementApp.Controllers
{
    public class SalaryController
    {
        private readonly HRManagementForm form;
        private readonly DatabaseManager dbManager;

        public SalaryController(HRManagementForm form)
        {
            this.form = form;
            dbManager = new DatabaseManager();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public DataTable GetSalaries()
        {
            try
            {
                return dbManager.GetSalaries();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách lương: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public void LoadSalaries()
        {
            try
            {
                DataTable dt = dbManager.GetSalaries();
                form.UpdateSalaryGrid(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách lương: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowSalaryDetails(string salaryId)
        {
            try
            {
                DataTable dt = dbManager.GetSalaries();
                DataRow[] rows = dt.Select($"SalaryId = '{salaryId}'");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    form.txtSalaryId.Text = row["SalaryId"]?.ToString();
                    form.cbSalaryEmployee.SelectedValue = row["EmployeeId"]?.ToString();
                    form.txtMonthlySalary.Text = row["MonthlySalary"] != DBNull.Value ? row["MonthlySalary"].ToString() : "";
                    form.txtPaySlipPath.Text = row["PaySlipPath"]?.ToString();
                    form.txtSalaryIncreaseDecisionPath.Text = row["SalaryIncreaseDecisionPath"]?.ToString();
                    form.txtBankAccount.Text = row["BankAccount"]?.ToString();
                    form.txtInsuranceInfo.Text = row["InsuranceInfo"]?.ToString();
                    form.txtAllowances.Text = row["Allowances"] != DBNull.Value ? row["Allowances"].ToString() : "";
                    form.txtBonuses.Text = row["Bonuses"] != DBNull.Value ? row["Bonuses"].ToString() : "";
                    form.txtLeavePolicy.Text = row["LeavePolicy"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết lương: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddSalary(Salary salary)
        {
            try
            {
                dbManager.AddSalary(salary);
                LoadSalaries();
                form.ClearSalaryFields();
                MessageBox.Show("Thêm lương thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm lương: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateSalary(Salary salary)
        {
            try
            {
                dbManager.UpdateSalary(salary);
                LoadSalaries();
                form.ClearSalaryFields();
                MessageBox.Show("Cập nhật lương thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật lương: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteSalary(string salaryId)
        {
            try
            {
                dbManager.DeleteSalary(salaryId);
                LoadSalaries();
                form.ClearSalaryFields();
                MessageBox.Show("Xóa lương thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa lương: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportSalariesToExcel()
        {
            try
            {
                DataTable dt = dbManager.GetSalaries();
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Salaries");
                    worksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    worksheet.Cells.AutoFitColumns();

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files|*.xlsx",
                        FileName = "Salaries.xlsx"
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