using System;
using System.Data;
using System.Windows.Forms;
using HRManagementApp.Data;
using HRManagementApp.Models;
using HRManagementApp.Views;

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

        public void AddContract(Contract contract)
        {
            try
            {
                if (contract.EmployeeId == -1 || string.IsNullOrWhiteSpace(contract.Type) || 
                    string.IsNullOrWhiteSpace(contract.Status) || contract.Salary == 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp đồng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbManager.AddContract(contract);
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
                if (contract.Id == 0)
                {
                    MessageBox.Show("Vui lòng chọn hợp đồng để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (contract.EmployeeId == -1 || string.IsNullOrWhiteSpace(contract.Type) || 
                    string.IsNullOrWhiteSpace(contract.Status) || contract.Salary == 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp đồng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}