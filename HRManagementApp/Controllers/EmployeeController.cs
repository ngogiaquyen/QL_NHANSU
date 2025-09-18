using HRManagementApp.Models;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace HRManagementApp.Controllers
{
    public class EmployeeController
    {
        private readonly HRManagementForm form;
        private readonly DatabaseManager dbManager;

        public EmployeeController(HRManagementForm form)
        {
            this.form = form;
            dbManager = new DatabaseManager();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        public void LoadEmployees()
        {
            try
            {
                DataTable dt = dbManager.GetEmployees();
                form.UpdateEmployeeGrid(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetEmployees()
        {
            try
            {
                return dbManager.GetEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable(); // Return empty DataTable on error
            }
        }

        public void ShowEmployeeDetails(string employeeId)
        {
            try
            {
                DataTable dt = dbManager.GetEmployees();
                DataRow[] rows = dt.Select($"EmployeeId = '{employeeId}'");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    form.txtEmployeeId.Text = row["EmployeeId"]?.ToString();
                    form.txtEmployeeName.Text = row["Name"]?.ToString();
                    form.dtpDOB.Value = row["DOB"] != DBNull.Value ? Convert.ToDateTime(row["DOB"]) : DateTime.Today;
                    form.txtGender.Text = row["Gender"]?.ToString();
                    form.txtNationality.Text = row["Nationality"]?.ToString();
                    form.txtCCCD.Text = row["CCCD"]?.ToString();
                    form.dtpCCCDIssueDate.Value = row["CCCDIssueDate"] != DBNull.Value ? Convert.ToDateTime(row["CCCDIssueDate"]) : DateTime.Today;
                    form.txtCCCDIssuePlace.Text = row["CCCDIssuePlace"]?.ToString();
                    form.txtPermanentAddress.Text = row["PermanentAddress"]?.ToString();
                    form.txtCurrentAddress.Text = row["CurrentAddress"]?.ToString();
                    form.txtPhone.Text = row["Phone"]?.ToString();
                    form.txtEmail.Text = row["Email"]?.ToString();
                    form.txtMaritalStatus.Text = row["MaritalStatus"]?.ToString();
                    form.txtDependents.Text = row["Dependents"] != DBNull.Value ? row["Dependents"].ToString() : "";
                    form.txtSocialInsuranceNumber.Text = row["SocialInsuranceNumber"]?.ToString();
                    form.txtTaxCode.Text = row["TaxCode"]?.ToString();
                    form.txtJobDescription.Text = row["JobDescription"]?.ToString();
                    form.txtPosition.Text = row["Position"]?.ToString();
                    form.txtDepartment.Text = row["Department"]?.ToString();
                    form.txtRank.Text = row["Rank"]?.ToString();
                    form.txtManager.Text = row["Manager"]?.ToString();
                    form.txtWorkSchedule.Text = row["WorkSchedule"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                dbManager.AddEmployee(employee);
                LoadEmployees();
                form.ClearEmployeeFields();
                MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                dbManager.UpdateEmployee(employee);
                LoadEmployees();
                form.ClearEmployeeFields();
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteEmployee(string employeeId)
        {
            try
            {
                dbManager.DeleteEmployee(employeeId);
                LoadEmployees();
                form.ClearEmployeeFields();
                MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportEmployeesToExcel()
        {
            try
            {
                DataTable dt = dbManager.GetEmployees();
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Employees");
                    worksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    worksheet.Cells.AutoFitColumns();

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files|*.xlsx",
                        FileName = "Employees.xlsx"
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