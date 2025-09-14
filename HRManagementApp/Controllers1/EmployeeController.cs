using System;
using System.Data;
using System.Windows.Forms;
using HRManagementApp.Data;
using HRManagementApp.Models;
using HRManagementApp.Views;

namespace HRManagementApp.Controllers
{
    public class EmployeeController
    {
        private readonly DatabaseManager dbManager;
        private readonly HRManagementForm view;

        public EmployeeController(HRManagementForm view)
        {
            this.view = view;
            dbManager = new DatabaseManager();
        }

        public void LoadEmployees()
        {
            try
            {
                view.UpdateEmployeeGrid(dbManager.GetEmployees());
                view.LoadEmployeesToComboBox(dbManager.GetEmployeesForComboBox());
                view.LoadDepartments(dbManager.GetDepartments());
                view.LoadPositions(dbManager.GetPositions());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(employee.FirstName) || string.IsNullOrWhiteSpace(employee.LastName) ||
                    string.IsNullOrWhiteSpace(employee.Address) || string.IsNullOrWhiteSpace(employee.Phone) ||
                    string.IsNullOrWhiteSpace(employee.Email) || string.IsNullOrWhiteSpace(employee.Gender) ||
                    employee.DepartmentId == -1 || employee.PositionId == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbManager.AddEmployee(employee);
                MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                view.ClearEmployeeFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                if (employee.Id == 0)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(employee.FirstName) || string.IsNullOrWhiteSpace(employee.LastName) ||
                    string.IsNullOrWhiteSpace(employee.Address) || string.IsNullOrWhiteSpace(employee.Phone) ||
                    string.IsNullOrWhiteSpace(employee.Email) || string.IsNullOrWhiteSpace(employee.Gender) ||
                    employee.DepartmentId == -1 || employee.PositionId == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbManager.UpdateEmployee(employee);
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteEmployee(int id)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này? Hành động này sẽ xóa tất cả hợp đồng và chấm công liên quan.", 
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                dbManager.DeleteEmployee(id);
                MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                view.ClearEmployeeFields();
                view.ClearDetailPanels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowEmployeeDetails(DataGridViewRow row)
        {
            view.ShowEmployeeDetails(row);
        }
    }
}