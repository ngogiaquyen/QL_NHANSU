using HRManagementApp.Controllers;
using HRManagementApp.Data;
using HRManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OfficeOpenXml;
using System.IO;

namespace HRManagementApp.Views
{
    public partial class HRManagementForm : Form
    {
        private readonly EmployeeController employeeController;
        private readonly ContractController contractController;
        private readonly AttendanceController attendanceController;

        public HRManagementForm()
        {
            InitializeComponent();
            nudContractSalary.Maximum = 100000000; // Thêm dòng này
            nudContractSalary.Minimum = 0; // Tùy chọn
            this.Icon = new Icon("Resources/icon.ico");
            employeeController = new EmployeeController(this);
            contractController = new ContractController(this);
            attendanceController = new AttendanceController(this);
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Load data
            employeeController.LoadEmployees();
            contractController.LoadContracts();
            attendanceController.LoadAttendance();

            // Populate comboboxes
            cbEmployeeGender.Items.AddRange(new[] { "Nam", "Nữ" });
            cbEmployeeGender.SelectedIndex = 0;
            cbContractStatus.Items.AddRange(new[] { "Đang hiệu lực", "Hết hiệu lực", "Chờ ký" });
            cbContractStatus.SelectedIndex = 0;
            cbAttendanceStatus.Items.AddRange(Attendance.ValidStatuses);
            cbAttendanceStatus.SelectedIndex = 0;

            cbEmployeeDepartment.DataSource = new DatabaseManager().GetDepartments();
            cbEmployeeDepartment.DisplayMember = "name";
            cbEmployeeDepartment.ValueMember = "id";
            cbEmployeeDepartment.SelectedValue = -1;

            cbEmployeePosition.DataSource = new DatabaseManager().GetPositions();
            cbEmployeePosition.DisplayMember = "name";
            cbEmployeePosition.ValueMember = "id";
            cbEmployeePosition.SelectedValue = -1;

            cbContractEmployee.DataSource = new DatabaseManager().GetEmployeesForComboBox();
            cbContractEmployee.DisplayMember = "full_name";
            cbContractEmployee.ValueMember = "id";
            cbContractEmployee.SelectedValue = "-1";

            cbAttendanceEmployee.DataSource = new DatabaseManager().GetEmployeesForComboBox();
            cbAttendanceEmployee.DisplayMember = "full_name";
            cbAttendanceEmployee.ValueMember = "id";
            cbAttendanceEmployee.SelectedValue = "-1";

            // Initialize events
            dgvEmployees.SelectionChanged += (s, e) => employeeController.ShowEmployeeDetails(dgvEmployees.CurrentRow);
            dgvContracts.SelectionChanged += (s, e) => contractController.ShowContractDetails(dgvContracts.CurrentRow);
            dgvAttendance.SelectionChanged += (s, e) => attendanceController.ShowAttendanceDetails(dgvAttendance.CurrentRow);

            btnEmployeeAdd.Click += (s, e) =>
            {
                var employee = new Employee
                {
                    Id = txtEmployeeId.Text,
                    FirstName = txtEmployeeFirstName.Text,
                    LastName = txtEmployeeLastName.Text,
                    BirthDate = dtpEmployeeBirthDate.Value,
                    Gender = cbEmployeeGender.SelectedItem?.ToString(),
                    Address = txtEmployeeAddress.Text,
                    Phone = txtEmployeePhone.Text,
                    Email = txtEmployeeEmail.Text,
                    DepartmentId = (int?)cbEmployeeDepartment.SelectedValue ?? -1,
                    PositionId = (int?)cbEmployeePosition.SelectedValue ?? -1,
                    HireDate = dtpEmployeeHireDate.Value,
                    Education = txtEmployeeEducation.Text,
                    CCCD = txtEmployeeCCCD.Text
                };
                employeeController.AddEmployee(employee);
            };

            btnEmployeeUpdate.Click += (s, e) =>
            {
                var employee = new Employee
                {
                    Id = txtEmployeeId.Text,
                    FirstName = txtEmployeeFirstName.Text,
                    LastName = txtEmployeeLastName.Text,
                    BirthDate = dtpEmployeeBirthDate.Value,
                    Gender = cbEmployeeGender.SelectedItem?.ToString(),
                    Address = txtEmployeeAddress.Text,
                    Phone = txtEmployeePhone.Text,
                    Email = txtEmployeeEmail.Text,
                    DepartmentId = (int?)cbEmployeeDepartment.SelectedValue ?? -1,
                    PositionId = (int?)cbEmployeePosition.SelectedValue ?? -1,
                    HireDate = dtpEmployeeHireDate.Value,
                    Education = txtEmployeeEducation.Text,
                    CCCD = txtEmployeeCCCD.Text
                };
                employeeController.UpdateEmployee(employee);
            };

            btnEmployeeDelete.Click += (s, e) => employeeController.DeleteEmployee(txtEmployeeId.Text);
            btnEmployeeSearch.Click += (s, e) => employeeController.SearchEmployees(txtEmployeeSearch.Text);
            btnEmployeeExport.Click += (s, e) => employeeController.ExportEmployeesToExcel();

            btnContractAdd.Click += (s, e) =>
            {
                var contract = new Contract
                {
                    EmployeeId = cbContractEmployee.SelectedValue?.ToString(),
                    Type = txtContractType.Text,
                    StartDate = dtpContractStartDate.Value,
                    EndDate = dtpContractEndDate.Checked ? dtpContractEndDate.Value : (DateTime?)null,
                    Salary = nudContractSalary.Value,
                    Status = cbContractStatus.SelectedItem?.ToString()
                };
                contractController.AddContract(contract);
            };

            btnContractUpdate.Click += (s, e) =>
            {
                var contract = new Contract
                {
                    Id = int.Parse(txtContractId.Text),
                    EmployeeId = cbContractEmployee.SelectedValue?.ToString(),
                    Type = txtContractType.Text,
                    StartDate = dtpContractStartDate.Value,
                    EndDate = dtpContractEndDate.Checked ? dtpContractEndDate.Value : (DateTime?)null,
                    Salary = nudContractSalary.Value,
                    Status = cbContractStatus.SelectedItem?.ToString()
                };
                contractController.UpdateContract(contract);
            };

            btnContractDelete.Click += (s, e) => contractController.DeleteContract(int.Parse(txtContractId.Text));
            btnContractSearch.Click += (s, e) => contractController.SearchContracts(txtContractSearch.Text);
            btnContractExport.Click += (s, e) => contractController.ExportContractsToExcel();

            btnAttendanceAdd.Click += (s, e) =>
            {
                var attendance = new Attendance
                {
                    EmployeeId = cbAttendanceEmployee.SelectedValue?.ToString(),
                    Date = dtpAttendanceDate.Value,
                    CheckIn = dtpAttendanceCheckIn.Checked ? dtpAttendanceCheckIn.Value.TimeOfDay : (TimeSpan?)null,
                    CheckOut = dtpAttendanceCheckOut.Checked ? dtpAttendanceCheckOut.Value.TimeOfDay : (TimeSpan?)null,
                    Status = cbAttendanceStatus.SelectedItem?.ToString()
                };
                attendanceController.AddAttendance(attendance);
            };

            btnAttendanceUpdate.Click += (s, e) =>
            {
                var attendance = new Attendance
                {
                    Id = int.Parse(txtAttendanceId.Text),
                    EmployeeId = cbAttendanceEmployee.SelectedValue?.ToString(),
                    Date = dtpAttendanceDate.Value,
                    CheckIn = dtpAttendanceCheckIn.Checked ? dtpAttendanceCheckIn.Value.TimeOfDay : (TimeSpan?)null,
                    CheckOut = dtpAttendanceCheckOut.Checked ? dtpAttendanceCheckOut.Value.TimeOfDay : (TimeSpan?)null,
                    Status = cbAttendanceStatus.SelectedItem?.ToString()
                };
                attendanceController.UpdateAttendance(attendance);
            };

            btnAttendanceDelete.Click += (s, e) => attendanceController.DeleteAttendance(int.Parse(txtAttendanceId.Text));
            btnAttendanceSearch.Click += (s, e) => attendanceController.SearchAttendance(txtAttendanceSearch.Text);
            btnAttendanceExport.Click += (s, e) => attendanceController.ExportAttendanceToExcel();

            btnExportFullReport.Click += (s, e) =>
            {
                try
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("FullReport");
                        var table = new DatabaseManager().GetFullReport();
                        worksheet.Cells[1, 1].LoadFromDataTable(table, true);
                        worksheet.Cells.AutoFitColumns();

                        var saveFileDialog = new SaveFileDialog
                        {
                            Filter = "Excel files (*.xlsx)|*.xlsx",
                            FileName = "FullReport.xlsx"
                        };
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                            MessageBox.Show("Xuất báo cáo Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất báo cáo Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        public void UpdateEmployeeGrid(DataTable table)
        {
            dgvEmployees.DataSource = table;
        }

        public void UpdateContractGrid(DataTable table)
        {
            dgvContracts.DataSource = table;
        }

        public void UpdateAttendanceGrid(DataTable table)
        {
            dgvAttendance.DataSource = table;
        }

        public void ShowEmployeeDetails(DataGridViewRow row)
        {
            if (row == null) return;
            txtEmployeeId.Text = row.Cells["ID"].Value?.ToString();
            txtEmployeeFirstName.Text = row.Cells["Tên"].Value?.ToString();
            txtEmployeeLastName.Text = row.Cells["Họ"].Value?.ToString();
            dtpEmployeeBirthDate.Value = row.Cells["Ngày sinh"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["Ngày sinh"].Value) : DateTime.Today;
            cbEmployeeGender.SelectedItem = row.Cells["Giới tính"].Value?.ToString();
            txtEmployeeAddress.Text = row.Cells["Địa chỉ"].Value?.ToString();
            txtEmployeePhone.Text = row.Cells["Số điện thoại"].Value?.ToString();
            txtEmployeeEmail.Text = row.Cells["Email"].Value?.ToString();
            cbEmployeeDepartment.SelectedValue = row.Cells["Chức danh"].Value != DBNull.Value ? new DatabaseManager().GetDepartments().AsEnumerable()
                .FirstOrDefault(r => r.Field<string>("name") == row.Cells["Chức danh"].Value?.ToString())?.Field<int>("id") ?? -1 : -1;
            cbEmployeePosition.SelectedValue = row.Cells["Chức vụ"].Value != DBNull.Value ? new DatabaseManager().GetPositions().AsEnumerable()
                .FirstOrDefault(r => r.Field<string>("name") == row.Cells["Chức vụ"].Value?.ToString())?.Field<int>("id") ?? -1 : -1;
            dtpEmployeeHireDate.Value = row.Cells["Ngày tuyển dụng"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["Ngày tuyển dụng"].Value) : DateTime.Today;
            txtEmployeeEducation.Text = row.Cells["Học vấn"].Value?.ToString();
            txtEmployeeCCCD.Text = row.Cells["CCCD"].Value?.ToString();
        }

        public void ShowContractDetails(DataGridViewRow row)
        {
            if (row == null) return;
            txtContractId.Text = row.Cells["ID"].Value?.ToString();
            cbContractEmployee.SelectedValue = row.Cells["ID Nhân viên"].Value?.ToString() ?? "-1";
            txtContractType.Text = row.Cells["Loại hợp đồng"].Value?.ToString();
            dtpContractStartDate.Value = row.Cells["Ngày bắt đầu"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["Ngày bắt đầu"].Value) : DateTime.Today;
            dtpContractEndDate.Checked = row.Cells["Ngày kết thúc"].Value != DBNull.Value;
            dtpContractEndDate.Value = row.Cells["Ngày kết thúc"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["Ngày kết thúc"].Value) : DateTime.Today;
            nudContractSalary.Value = row.Cells["Lương"].Value != DBNull.Value ? Convert.ToDecimal(row.Cells["Lương"].Value) : 0;
            cbContractStatus.SelectedItem = row.Cells["Trạng thái"].Value?.ToString();
            txtContractEmployeeCCCD.Text = row.Cells["CCCD"].Value?.ToString();
            txtContractEmployeePhone.Text = row.Cells["Số điện thoại"].Value?.ToString();
            txtContractEmployeeEmail.Text = row.Cells["Email"].Value?.ToString();
            txtContractEmployeeDepartment.Text = row.Cells["Chức danh"].Value?.ToString();
            txtContractEmployeePosition.Text = row.Cells["Chức vụ"].Value?.ToString();
        }

        public void ShowAttendanceDetails(DataGridViewRow row)
        {
            if (row == null) return;
            txtAttendanceId.Text = row.Cells["ID"].Value?.ToString();
            cbAttendanceEmployee.SelectedValue = row.Cells["ID Nhân viên"].Value?.ToString() ?? "-1";
            dtpAttendanceDate.Value = row.Cells["Ngày"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["Ngày"].Value) : DateTime.Today;
            dtpAttendanceCheckIn.Checked = row.Cells["Giờ vào"].Value != DBNull.Value;
            dtpAttendanceCheckIn.Value = row.Cells["Giờ vào"].Value != DBNull.Value ? DateTime.Today.Add((TimeSpan)row.Cells["Giờ vào"].Value) : DateTime.Today;
            dtpAttendanceCheckOut.Checked = row.Cells["Giờ ra"].Value != DBNull.Value;
            dtpAttendanceCheckOut.Value = row.Cells["Giờ ra"].Value != DBNull.Value ? DateTime.Today.Add((TimeSpan)row.Cells["Giờ ra"].Value) : DateTime.Today;
            cbAttendanceStatus.SelectedItem = row.Cells["Trạng thái"].Value?.ToString();
            txtAttendanceAdminHours.Text = row.Cells["Giờ hành chính"].Value?.ToString();
            txtAttendanceOvertimeHours.Text = row.Cells["Giờ tăng ca"].Value?.ToString();
        }

        public void ClearEmployeeFields()
        {
            txtEmployeeId.Clear();
            txtEmployeeFirstName.Clear();
            txtEmployeeLastName.Clear();
            dtpEmployeeBirthDate.Value = DateTime.Today;
            cbEmployeeGender.SelectedIndex = 0;
            txtEmployeeAddress.Clear();
            txtEmployeePhone.Clear();
            txtEmployeeEmail.Clear();
            cbEmployeeDepartment.SelectedValue = -1;
            cbEmployeePosition.SelectedValue = -1;
            dtpEmployeeHireDate.Value = DateTime.Today;
            txtEmployeeEducation.Clear();
            txtEmployeeCCCD.Clear();
        }

        public void ClearContractFields()
        {
            txtContractId.Clear();
            cbContractEmployee.SelectedValue = "-1";
            txtContractType.Clear();
            dtpContractStartDate.Value = DateTime.Today;
            dtpContractEndDate.Checked = false;
            nudContractSalary.Value = 0;
            cbContractStatus.SelectedIndex = 0;
            txtContractEmployeeCCCD.Clear();
            txtContractEmployeePhone.Clear();
            txtContractEmployeeEmail.Clear();
            txtContractEmployeeDepartment.Clear();
            txtContractEmployeePosition.Clear();
        }

        public void ClearAttendanceFields()
        {
            txtAttendanceId.Clear();
            cbAttendanceEmployee.SelectedValue = "-1";
            dtpAttendanceDate.Value = DateTime.Today;
            dtpAttendanceCheckIn.Checked = false;
            dtpAttendanceCheckOut.Checked = false;
            cbAttendanceStatus.SelectedIndex = 0;
            txtAttendanceAdminHours.Clear();
            txtAttendanceOvertimeHours.Clear();
        }

        public void ClearDetailPanels()
        {
            ClearEmployeeFields();
            ClearContractFields();
            ClearAttendanceFields();
        }
    }
}
