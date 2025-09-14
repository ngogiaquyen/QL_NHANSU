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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchEmployees(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    LoadEmployees(); // Nếu không nhập, tải tất cả
                }
                else
                {
                    view.UpdateEmployeeGrid(dbManager.SearchEmployees(searchTerm));
                }
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
                // Cho phép ID rỗng hoặc nhập thủ công, nhưng cảnh báo nếu rỗng
                if (string.IsNullOrWhiteSpace(employee.FirstName) || string.IsNullOrWhiteSpace(employee.LastName) ||
                    employee.BirthDate == default || string.IsNullOrWhiteSpace(employee.Gender) || employee.HireDate == default)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên (trừ ID)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(employee.Id))
                {
                    MessageBox.Show("Vui lòng nhập ID nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (string.IsNullOrWhiteSpace(employee.Id))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(employee.FirstName) || string.IsNullOrWhiteSpace(employee.LastName) ||
                    employee.BirthDate == default || string.IsNullOrWhiteSpace(employee.Gender) || employee.HireDate == default)
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

        public void DeleteEmployee(string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này? Hành động này sẽ xóa tất cả hợp đồng và chấm công liên quan.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

        public void ExportEmployeesToExcel()
        {
            try
            {
                // EPPlus 8+: Set license mới
                ExcelPackage.License.SetNonCommercialOrganization("HRManagementApp"); // Hoặc tên tổ chức của bạn

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Nhân viên");
                    var table = dbManager.GetEmployees();
                    worksheet.Cells[1, 1].LoadFromDataTable(table, true);
                    worksheet.Cells.AutoFitColumns();

                    var saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel files (*.xlsx)|*.xlsx",
                        FileName = "DanhSachNhanVien.xlsx"
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
