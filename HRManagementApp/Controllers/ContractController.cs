using HRManagementApp.Models;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace HRManagementApp.Controllers
{
    public class ContractController
    {
        private readonly HRManagementForm form;
        private readonly DatabaseManager dbManager;

        public ContractController(HRManagementForm form)
        {
            this.form = form;
            dbManager = new DatabaseManager();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void LoadContracts()
        {
            try
            {
                DataTable dt = dbManager.GetContracts();
                form.UpdateContractGrid(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetContracts()
        {
            try
            {
                return dbManager.GetContracts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public void ShowContractDetails(string contractId)
        {
            try
            {
                DataTable dt = dbManager.GetContracts();
                DataRow[] rows = dt.Select($"ContractId = '{contractId}'");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    form.txtContractId.Text = row["ContractId"]?.ToString();
                    form.cbContractEmployee.SelectedValue = row["EmployeeId"]?.ToString();
                    form.dtpStartDate.Value = row["StartDate"] != DBNull.Value ? Convert.ToDateTime(row["StartDate"]) : DateTime.Today;
                    form.dtpEndDate.Value = row["EndDate"] != DBNull.Value ? Convert.ToDateTime(row["EndDate"]) : DateTime.Today;
                    form.cbContractType.Text = row["ContractType"]?.ToString();
                    form.txtContractAnnexPath.Text = row["ContractAnnexPath"]?.ToString();
                    form.txtConfidentialityAgreementPath.Text = row["ConfidentialityAgreementPath"]?.ToString();
                    form.txtNonCompeteAgreementPath.Text = row["NonCompeteAgreementPath"]?.ToString();
                    form.txtAppointmentDecisionPath.Text = row["AppointmentDecisionPath"]?.ToString();
                    form.txtSalaryIncreaseDecisionPath.Text = row["SalaryIncreaseDecisionPath"]?.ToString();
                    form.txtRewardDecisionPath.Text = row["RewardDecisionPath"]?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị chi tiết hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddContract(Contract contract)
        {
            try
            {
                dbManager.AddContract(contract);
                LoadContracts();
                form.ClearContractFields();
                MessageBox.Show("Thêm hợp đồng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateContract(Contract contract)
        {
            try
            {
                dbManager.UpdateContract(contract);
                LoadContracts();
                form.ClearContractFields();
                MessageBox.Show("Cập nhật hợp đồng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteContract(string contractId)
        {
            try
            {
                dbManager.DeleteContract(contractId);
                LoadContracts();
                form.ClearContractFields();
                MessageBox.Show("Xóa hợp đồng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportContractsToExcel()
        {
            try
            {
                DataTable dt = dbManager.GetContracts();
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Contracts");
                    worksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    worksheet.Cells.AutoFitColumns();

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files|*.xlsx",
                        FileName = "Contracts.xlsx"
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