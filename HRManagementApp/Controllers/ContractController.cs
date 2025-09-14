using HRManagementApp.Data;
using HRManagementApp.Models;
using HRManagementApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;


namespace HRManagementApp.Controllers
{
    public class ContractController
    {
        private readonly DatabaseManager dbManager;
        private readonly HRManagementForm view;

        public ContractController(HRManagementForm view)
        {
            this.view = view;
            dbManager = new DatabaseManager();
        }

        public void LoadContracts()
        {
            try
            {
                view.UpdateContractGrid(dbManager.GetContracts());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchContracts(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    LoadContracts(); // Nếu không nhập, tải tất cả
                }
                else
                {
                    view.UpdateContractGrid(dbManager.SearchContracts(searchTerm));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddContract(Contract contract)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(contract.EmployeeId) || string.IsNullOrWhiteSpace(contract.Type) ||
                    string.IsNullOrWhiteSpace(contract.Status) || contract.Salary <= 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp đồng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra nhân viên đã có hợp đồng chưa
                try
                {
                    dbManager.AddContract(contract); // Phương thức này đã có kiểm tra trong DatabaseManager
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Thêm hợp đồng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadContracts();
                view.ClearContractFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateContract(Contract contract)
        {
            try
            {
                if (contract.Id == 0 || string.IsNullOrWhiteSpace(contract.EmployeeId) || string.IsNullOrWhiteSpace(contract.Type) ||
                    string.IsNullOrWhiteSpace(contract.Status) || contract.Salary <= 0)
                {
                    MessageBox.Show("Vui lòng chọn hợp đồng để cập nhật và điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbManager.UpdateContract(contract);
                MessageBox.Show("Cập nhật hợp đồng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadContracts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteContract(int id)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Vui lòng chọn hợp đồng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc muốn xóa hợp đồng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                dbManager.DeleteContract(id);
                MessageBox.Show("Xóa hợp đồng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadContracts();
                view.ClearContractFields();
                view.ClearDetailPanels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowContractDetails(DataGridViewRow row)
        {
            view.ShowContractDetails(row);
        }

        public void ExportContractsToExcel()
        {
            try
            {
                // EPPlus 8+: Set license mới
                ExcelPackage.License.SetNonCommercialOrganization("HRManagementApp"); // Hoặc tên tổ chức của bạn

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Hợp đồng");
                    var table = dbManager.GetContracts();
                    worksheet.Cells[1, 1].LoadFromDataTable(table, true);
                    worksheet.Cells.AutoFitColumns();

                    var saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files (*.xlsx)|*.xlsx",
                        FileName = "DanhSachHopDong.xlsx"
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