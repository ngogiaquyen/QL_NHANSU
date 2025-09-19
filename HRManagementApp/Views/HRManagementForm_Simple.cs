using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using HRManagementApp.Controllers;
using HRManagementApp.Models;

namespace HRManagementApp
{
    public partial class HRManagementForm : Form
    {
        private readonly EmployeeController employeeController;
        private readonly ContractController contractController;
        private readonly AttendanceController attendanceController;
        private readonly RecruitmentController recruitmentController;
        private readonly SalaryController salaryController;
        private readonly TrainingController trainingController;
        private readonly DisciplineController disciplineController;
        private readonly DatabaseManager databaseManager;

        public HRManagementForm()
        {
            InitializeComponent();
            try
            {
                databaseManager = new DatabaseManager();
                employeeController = new EmployeeController(this);
                contractController = new ContractController(this);
                attendanceController = new AttendanceController(this);
                recruitmentController = new RecruitmentController(this);
                salaryController = new SalaryController(this);
                trainingController = new TrainingController(this);
                disciplineController = new DisciplineController(this);
                
                InitializeDataGridViewStyles();
                LoadAllData();
                ShowPanel(dashboardPanel); // Show dashboard by default
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDataGridViewStyles()
        {
            // Style DataGridViews with modern look
            DataGridView[] grids = { dgvEmployees, dgvContracts };
            
            foreach (var grid in grids)
            {
                if (grid != null)
                {
                    grid.EnableHeadersVisualStyles = false;
                    grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
                    grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    grid.ColumnHeadersHeight = 40;
                    grid.RowTemplate.Height = 35;
                    grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
                    grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
                    grid.DefaultCellStyle.SelectionForeColor = Color.White;
                    grid.GridColor = Color.FromArgb(224, 224, 224);
                    grid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                }
            }
        }

        private void ShowPanel(Panel panel)
        {
            // Hide all panels
            Panel[] allPanels = { dashboardPanel, employeePanel, contractPanel, attendancePanel, 
                                recruitmentPanel, salaryPanel, trainingPanel, disciplinePanel };
            
            foreach (Panel p in allPanels)
            {
                if (p != null)
                    p.Visible = false;
            }
            
            // Show selected panel
            if (panel != null)
                panel.Visible = true;
        }

        private void LoadAllData()
        {
            try
            {
                employeeController.LoadEmployees();
                contractController.LoadContracts();
                attendanceController.LoadAttendances();
                recruitmentController.LoadRecruitments();
                salaryController.LoadSalaries();
                trainingController.LoadTrainings();
                disciplineController.LoadDisciplines();

                DataTable dtEmployees = employeeController.GetEmployees();
                if (dtEmployees != null && dtEmployees.Rows.Count > 0)
                {
                    if (cbContractEmployee != null)
                    {
                        cbContractEmployee.DataSource = dtEmployees;
                        cbContractEmployee.DisplayMember = "Name";
                        cbContractEmployee.ValueMember = "EmployeeId";
                    }
                }
                else
                {
                    MessageBox.Show("No employee data available to populate ComboBoxes.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Employee Methods
        public void UpdateEmployeeGrid(DataTable dt) => dgvEmployees.DataSource = dt;
        
        public void ClearEmployeeFields()
        {
            txtEmployeeId.Text = "";
            txtEmployeeName.Text = "";
            dtpDOB.Value = DateTime.Today;
            cbGender.SelectedIndex = -1;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtPosition.Text = "";
            txtDepartment.Text = "";
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee
                {
                    EmployeeId = txtEmployeeId.Text,
                    Name = txtEmployeeName.Text,
                    DOB = dtpDOB.Value,
                    Gender = cbGender.SelectedItem?.ToString(),
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Position = txtPosition.Text,
                    Department = txtDepartment.Text
                };

                // Validation
                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(employee);
                bool isValid = Validator.TryValidateObject(employee, validationContext, validationResults, true);

                if (!isValid)
                {
                    string errorMessage = string.Join("\n", validationResults.Select(vr => vr.ErrorMessage));
                    MessageBox.Show($"Dữ liệu không hợp lệ:\n{errorMessage}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                employeeController.AddEmployee(employee);
                MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee
                {
                    EmployeeId = txtEmployeeId.Text,
                    Name = txtEmployeeName.Text,
                    DOB = dtpDOB.Value,
                    Gender = cbGender.SelectedItem?.ToString(),
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Position = txtPosition.Text,
                    Department = txtDepartment.Text
                };

                // Validation
                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(employee);
                bool isValid = Validator.TryValidateObject(employee, validationContext, validationResults, true);

                if (!isValid)
                {
                    string errorMessage = string.Join("\n", validationResults.Select(vr => vr.ErrorMessage));
                    MessageBox.Show($"Dữ liệu không hợp lệ:\n{errorMessage}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                employeeController.UpdateEmployee(employee);
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.SelectedRows.Count > 0)
                {
                    string employeeId = dgvEmployees.SelectedRows[0].Cells["EmployeeId"].Value.ToString();
                    employeeController.DeleteEmployee(employeeId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                employeeController.ExportEmployeesToExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.SelectedRows.Count > 0)
                {
                    string employeeId = dgvEmployees.SelectedRows[0].Cells["EmployeeId"].Value.ToString();
                    employeeController.ShowEmployeeDetails(employeeId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing employee details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Contract Methods
        public void UpdateContractGrid(DataTable dt) => dgvContracts.DataSource = dt;
        
        public void ClearContractFields()
        {
            if (txtContractId != null) txtContractId.Text = "";
            if (cbContractEmployee != null) cbContractEmployee.SelectedIndex = -1;
            if (dtpStartDate != null) dtpStartDate.Value = DateTime.Today;
            if (dtpEndDate != null) dtpEndDate.Value = DateTime.Today;
            if (cbContractType != null) cbContractType.SelectedIndex = -1;
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            try
            {
                Contract contract = new Contract
                {
                    ContractId = txtContractId?.Text ?? "",
                    EmployeeId = cbContractEmployee?.SelectedValue?.ToString() ?? "",
                    StartDate = dtpStartDate?.Value ?? DateTime.Today,
                    EndDate = dtpEndDate?.Value ?? DateTime.Today,
                    ContractType = cbContractType?.SelectedItem?.ToString() ?? ""
                };

                // Validation
                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(contract);
                bool isValid = Validator.TryValidateObject(contract, validationContext, validationResults, true);

                if (!isValid)
                {
                    string errorMessage = string.Join("\n", validationResults.Select(vr => vr.ErrorMessage));
                    MessageBox.Show($"Dữ liệu không hợp lệ:\n{errorMessage}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                contractController.AddContract(contract);
                MessageBox.Show("Thêm hợp đồng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            try
            {
                Contract contract = new Contract
                {
                    ContractId = txtContractId?.Text ?? "",
                    EmployeeId = cbContractEmployee?.SelectedValue?.ToString() ?? "",
                    StartDate = dtpStartDate?.Value ?? DateTime.Today,
                    EndDate = dtpEndDate?.Value ?? DateTime.Today,
                    ContractType = cbContractType?.SelectedItem?.ToString() ?? ""
                };

                contractController.UpdateContract(contract);
                MessageBox.Show("Cập nhật hợp đồng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật hợp đồng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContracts.SelectedRows.Count > 0)
                {
                    string contractId = dgvContracts.SelectedRows[0].Cells["ContractId"].Value.ToString();
                    contractController.DeleteContract(contractId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting contract: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvContracts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvContracts.SelectedRows.Count > 0)
                {
                    string contractId = dgvContracts.SelectedRows[0].Cells["ContractId"].Value.ToString();
                    contractController.ShowContractDetails(contractId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing contract details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Placeholder methods for other modules
        public void UpdateAttendanceGrid(DataTable dt) { /* To be implemented */ }
        public void ClearAttendanceFields() { /* To be implemented */ }
        public void UpdateRecruitmentGrid(DataTable dt) { /* To be implemented */ }
        public void ClearRecruitmentFields() { /* To be implemented */ }
        public void UpdateSalaryGrid(DataTable dt) { /* To be implemented */ }
        public void ClearSalaryFields() { /* To be implemented */ }
        public void UpdateTrainingGrid(DataTable dt) { /* To be implemented */ }
        public void ClearTrainingFields() { /* To be implemented */ }
        public void UpdateDisciplineGrid(DataTable dt) { /* To be implemented */ }
        public void ClearDisciplineFields() { /* To be implemented */ }
    }
}
