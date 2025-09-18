using System;
using System.Data;
using System.Windows.Forms;
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

        public HRManagementForm()
        {
            InitializeComponent();
            try
            {
                employeeController = new EmployeeController(this);
                contractController = new ContractController(this);
                attendanceController = new AttendanceController(this);
                recruitmentController = new RecruitmentController(this);
                salaryController = new SalaryController(this);
                trainingController = new TrainingController(this);
                disciplineController = new DisciplineController(this);
                LoadAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    cbContractEmployee.DataSource = dtEmployees;
                    cbContractEmployee.DisplayMember = "Name";
                    cbContractEmployee.ValueMember = "EmployeeId";
                    cbAttendanceEmployee.DataSource = dtEmployees.Copy();
                    cbAttendanceEmployee.DisplayMember = "Name";
                    cbAttendanceEmployee.ValueMember = "EmployeeId";
                    cbRecruitmentEmployee.DataSource = dtEmployees.Copy();
                    cbRecruitmentEmployee.DisplayMember = "Name";
                    cbRecruitmentEmployee.ValueMember = "EmployeeId";
                    cbSalaryEmployee.DataSource = dtEmployees.Copy();
                    cbSalaryEmployee.DisplayMember = "Name";
                    cbSalaryEmployee.ValueMember = "EmployeeId";
                    cbTrainingEmployee.DataSource = dtEmployees.Copy();
                    cbTrainingEmployee.DisplayMember = "Name";
                    cbTrainingEmployee.ValueMember = "EmployeeId";
                    cbDisciplineEmployee.DataSource = dtEmployees.Copy();
                    cbDisciplineEmployee.DisplayMember = "Name";
                    cbDisciplineEmployee.ValueMember = "EmployeeId";
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
            txtGender.Text = "";
            txtNationality.Text = "";
            txtCCCD.Text = "";
            dtpCCCDIssueDate.Value = DateTime.Today;
            txtCCCDIssuePlace.Text = "";
            txtPermanentAddress.Text = "";
            txtCurrentAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtMaritalStatus.Text = "";
            txtDependents.Text = "";
            txtSocialInsuranceNumber.Text = "";
            txtTaxCode.Text = "";
            txtJobDescription.Text = "";
            txtPosition.Text = "";
            txtDepartment.Text = "";
            txtRank.Text = "";
            txtManager.Text = "";
            txtWorkSchedule.Text = "";
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
                    Gender = txtGender.Text,
                    Nationality = txtNationality.Text,
                    CCCD = txtCCCD.Text,
                    CCCDIssueDate = dtpCCCDIssueDate.Value,
                    CCCDIssuePlace = txtCCCDIssuePlace.Text,
                    PermanentAddress = txtPermanentAddress.Text,
                    CurrentAddress = txtCurrentAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    MaritalStatus = txtMaritalStatus.Text,
                    Dependents = string.IsNullOrEmpty(txtDependents.Text) ? null : (int?)int.Parse(txtDependents.Text),
                    SocialInsuranceNumber = txtSocialInsuranceNumber.Text,
                    TaxCode = txtTaxCode.Text,
                    JobDescription = txtJobDescription.Text,
                    Position = txtPosition.Text,
                    Department = txtDepartment.Text,
                    Rank = txtRank.Text,
                    Manager = txtManager.Text,
                    WorkSchedule = txtWorkSchedule.Text
                };
                employeeController.AddEmployee(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Gender = txtGender.Text,
                    Nationality = txtNationality.Text,
                    CCCD = txtCCCD.Text,
                    CCCDIssueDate = dtpCCCDIssueDate.Value,
                    CCCDIssuePlace = txtCCCDIssuePlace.Text,
                    PermanentAddress = txtPermanentAddress.Text,
                    CurrentAddress = txtCurrentAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    MaritalStatus = txtMaritalStatus.Text,
                    Dependents = string.IsNullOrEmpty(txtDependents.Text) ? null : (int?)int.Parse(txtDependents.Text),
                    SocialInsuranceNumber = txtSocialInsuranceNumber.Text,
                    TaxCode = txtTaxCode.Text,
                    JobDescription = txtJobDescription.Text,
                    Position = txtPosition.Text,
                    Department = txtDepartment.Text,
                    Rank = txtRank.Text,
                    Manager = txtManager.Text,
                    WorkSchedule = txtWorkSchedule.Text
                };
                employeeController.UpdateEmployee(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtContractId.Text = "";
            cbContractEmployee.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            txtContractType.Text = "";
            txtContractAnnexPath.Text = "";
            txtConfidentialityAgreementPath.Text = "";
            txtNonCompeteAgreementPath.Text = "";
            txtAppointmentDecisionPath.Text = "";
            txtSalaryIncreaseDecisionPath.Text = "";
            txtRewardDecisionPath.Text = "";
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            try
            {
                Contract contract = new Contract
                {
                    ContractId = txtContractId.Text,
                    EmployeeId = cbContractEmployee.SelectedValue?.ToString(),
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value,
                    ContractType = txtContractType.Text,
                    ContractAnnexPath = txtContractAnnexPath.Text,
                    ConfidentialityAgreementPath = txtConfidentialityAgreementPath.Text,
                    NonCompeteAgreementPath = txtNonCompeteAgreementPath.Text,
                    AppointmentDecisionPath = txtAppointmentDecisionPath.Text,
                    SalaryIncreaseDecisionPath = txtSalaryIncreaseDecisionPath.Text,
                    RewardDecisionPath = txtRewardDecisionPath.Text
                };
                contractController.AddContract(contract);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding contract: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            try
            {
                Contract contract = new Contract
                {
                    ContractId = txtContractId.Text,
                    EmployeeId = cbContractEmployee.SelectedValue?.ToString(),
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value,
                    ContractType = txtContractType.Text,
                    ContractAnnexPath = txtContractAnnexPath.Text,
                    ConfidentialityAgreementPath = txtConfidentialityAgreementPath.Text,
                    NonCompeteAgreementPath = txtNonCompeteAgreementPath.Text,
                    AppointmentDecisionPath = txtAppointmentDecisionPath.Text,
                    SalaryIncreaseDecisionPath = txtSalaryIncreaseDecisionPath.Text,
                    RewardDecisionPath = txtRewardDecisionPath.Text
                };
                contractController.UpdateContract(contract);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating contract: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnExportContracts_Click(object sender, EventArgs e)
        {
            try
            {
                contractController.ExportContractsToExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting contracts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Attendance Methods
        public void UpdateAttendanceGrid(DataTable dt) => dgvAttendances.DataSource = dt;
        public void ClearAttendanceFields()
        {
            txtAttendanceId.Text = "";
            cbAttendanceEmployee.SelectedIndex = -1;
            dtpAttendanceDate.Value = DateTime.Today;
            dtpCheckInTime.Value = DateTime.Now;
            dtpCheckOutTime.Value = DateTime.Now;
            txtStatus.Text = "";
            txtAdminHours.Text = "";
            txtOvertimeHours.Text = "";
        }

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                Attendance attendance = new Attendance
                {
                    AttendanceId = txtAttendanceId.Text,
                    EmployeeId = cbAttendanceEmployee.SelectedValue?.ToString(),
                    AttendanceDate = dtpAttendanceDate.Value,
                    CheckInTime = dtpCheckInTime.Value,
                    CheckOutTime = dtpCheckOutTime.Value,
                    Status = txtStatus.Text,
                    AdminHours = string.IsNullOrEmpty(txtAdminHours.Text) ? null : (decimal?)decimal.Parse(txtAdminHours.Text),
                    OvertimeHours = string.IsNullOrEmpty(txtOvertimeHours.Text) ? null : (decimal?)decimal.Parse(txtOvertimeHours.Text)
                };
                attendanceController.AddAttendance(attendance);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding attendance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                Attendance attendance = new Attendance
                {
                    AttendanceId = txtAttendanceId.Text,
                    EmployeeId = cbAttendanceEmployee.SelectedValue?.ToString(),
                    AttendanceDate = dtpAttendanceDate.Value,
                    CheckInTime = dtpCheckInTime.Value,
                    CheckOutTime = dtpCheckOutTime.Value,
                    Status = txtStatus.Text,
                    AdminHours = string.IsNullOrEmpty(txtAdminHours.Text) ? null : (decimal?)decimal.Parse(txtAdminHours.Text),
                    OvertimeHours = string.IsNullOrEmpty(txtOvertimeHours.Text) ? null : (decimal?)decimal.Parse(txtOvertimeHours.Text)
                };
                attendanceController.UpdateAttendance(attendance);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating attendance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAttendances.SelectedRows.Count > 0)
                {
                    string attendanceId = dgvAttendances.SelectedRows[0].Cells["AttendanceId"].Value.ToString();
                    attendanceController.DeleteAttendance(attendanceId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting attendance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportAttendances_Click(object sender, EventArgs e)
        {
            try
            {
                attendanceController.ExportAttendancesToExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting attendances: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAttendances_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvAttendances.SelectedRows.Count > 0)
                {
                    string attendanceId = dgvAttendances.SelectedRows[0].Cells["AttendanceId"].Value.ToString();
                    attendanceController.ShowAttendanceDetails(attendanceId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing attendance details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Recruitment Methods
        public void UpdateRecruitmentGrid(DataTable dt) => dgvRecruitments.DataSource = dt;
        public void ClearRecruitmentFields()
        {
            txtRecruitmentId.Text = "";
            cbRecruitmentEmployee.SelectedIndex = -1;
            txtJobApplicationPath.Text = "";
            txtResumePath.Text = "";
            txtDegreesPath.Text = "";
            txtHealthCheckPath.Text = "";
            txtCVPath.Text = "";
            txtReferenceLetterPath.Text = "";
            txtInterviewMinutesPath.Text = "";
            txtOfferLetterPath.Text = "";
        }

        private void btnAddRecruitment_Click(object sender, EventArgs e)
        {
            try
            {
                Recruitment recruitment = new Recruitment
                {
                    RecruitmentId = txtRecruitmentId.Text,
                    EmployeeId = cbRecruitmentEmployee.SelectedValue?.ToString(),
                    JobApplicationPath = txtJobApplicationPath.Text,
                    ResumePath = txtResumePath.Text,
                    DegreesPath = txtDegreesPath.Text,
                    HealthCheckPath = txtHealthCheckPath.Text,
                    CVPath = txtCVPath.Text,
                    ReferenceLetterPath = txtReferenceLetterPath.Text,
                    InterviewMinutesPath = txtInterviewMinutesPath.Text,
                    OfferLetterPath = txtOfferLetterPath.Text
                };
                recruitmentController.AddRecruitment(recruitment);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding recruitment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateRecruitment_Click(object sender, EventArgs e)
        {
            try
            {
                Recruitment recruitment = new Recruitment
                {
                    RecruitmentId = txtRecruitmentId.Text,
                    EmployeeId = cbRecruitmentEmployee.SelectedValue?.ToString(),
                    JobApplicationPath = txtJobApplicationPath.Text,
                    ResumePath = txtResumePath.Text,
                    DegreesPath = txtDegreesPath.Text,
                    HealthCheckPath = txtHealthCheckPath.Text,
                    CVPath = txtCVPath.Text,
                    ReferenceLetterPath = txtReferenceLetterPath.Text,
                    InterviewMinutesPath = txtInterviewMinutesPath.Text,
                    OfferLetterPath = txtOfferLetterPath.Text
                };
                recruitmentController.UpdateRecruitment(recruitment);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating recruitment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRecruitment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRecruitments.SelectedRows.Count > 0)
                {
                    string recruitmentId = dgvRecruitments.SelectedRows[0].Cells["RecruitmentId"].Value.ToString();
                    recruitmentController.DeleteRecruitment(recruitmentId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting recruitment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportRecruitments_Click(object sender, EventArgs e)
        {
            try
            {
                recruitmentController.ExportRecruitmentsToExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting recruitments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRecruitments_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvRecruitments.SelectedRows.Count > 0)
                {
                    string recruitmentId = dgvRecruitments.SelectedRows[0].Cells["RecruitmentId"].Value.ToString();
                    recruitmentController.ShowRecruitmentDetails(recruitmentId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing recruitment details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Salary Methods
        public void UpdateSalaryGrid(DataTable dt) => dgvSalaries.DataSource = dt;
        public void ClearSalaryFields()
        {
            txtSalaryId.Text = "";
            cbSalaryEmployee.SelectedIndex = -1;
            txtMonthlySalary.Text = "";
            txtPaySlipPath.Text = "";
            txtSalaryIncreaseDecisionPath.Text = "";
            txtBankAccount.Text = "";
            txtInsuranceInfo.Text = "";
            txtAllowances.Text = "";
            txtBonuses.Text = "";
            txtLeavePolicy.Text = "";
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            try
            {
                Salary salary = new Salary
                {
                    SalaryId = txtSalaryId.Text,
                    EmployeeId = cbSalaryEmployee.SelectedValue?.ToString(),
                    MonthlySalary = string.IsNullOrEmpty(txtMonthlySalary.Text) ? null : (decimal?)decimal.Parse(txtMonthlySalary.Text),
                    PaySlipPath = txtPaySlipPath.Text,
                    SalaryIncreaseDecisionPath = txtSalaryIncreaseDecisionPath.Text,
                    BankAccount = txtBankAccount.Text,
                    InsuranceInfo = txtInsuranceInfo.Text,
                    Allowances = string.IsNullOrEmpty(txtAllowances.Text) ? null : (decimal?)decimal.Parse(txtAllowances.Text),
                    Bonuses = string.IsNullOrEmpty(txtBonuses.Text) ? null : (decimal?)decimal.Parse(txtBonuses.Text),
                    LeavePolicy = txtLeavePolicy.Text
                };
                salaryController.AddSalary(salary);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding salary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            try
            {
                Salary salary = new Salary
                {
                    SalaryId = txtSalaryId.Text,
                    EmployeeId = cbSalaryEmployee.SelectedValue?.ToString(),
                    MonthlySalary = string.IsNullOrEmpty(txtMonthlySalary.Text) ? null : (decimal?)decimal.Parse(txtMonthlySalary.Text),
                    PaySlipPath = txtPaySlipPath.Text,
                    SalaryIncreaseDecisionPath = txtSalaryIncreaseDecisionPath.Text,
                    BankAccount = txtBankAccount.Text,
                    InsuranceInfo = txtInsuranceInfo.Text,
                    Allowances = string.IsNullOrEmpty(txtAllowances.Text) ? null : (decimal?)decimal.Parse(txtAllowances.Text),
                    Bonuses = string.IsNullOrEmpty(txtBonuses.Text) ? null : (decimal?)decimal.Parse(txtBonuses.Text),
                    LeavePolicy = txtLeavePolicy.Text
                };
                salaryController.UpdateSalary(salary);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating salary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSalary_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalaries.SelectedRows.Count > 0)
                {
                    string salaryId = dgvSalaries.SelectedRows[0].Cells["SalaryId"].Value.ToString();
                    salaryController.DeleteSalary(salaryId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting salary: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportSalaries_Click(object sender, EventArgs e)
        {
            try
            {
                salaryController.ExportSalariesToExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting salaries: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSalaries_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalaries.SelectedRows.Count > 0)
                {
                    string salaryId = dgvSalaries.SelectedRows[0].Cells["SalaryId"].Value.ToString();
                    salaryController.ShowSalaryDetails(salaryId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing salary details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Training Methods
        public void UpdateTrainingGrid(DataTable dt) => dgvTrainings.DataSource = dt;
        public void ClearTrainingFields()
        {
            txtTrainingId.Text = "";
            cbTrainingEmployee.SelectedIndex = -1;
            txtTrainingPlanPath.Text = "";
            txtCertificatePath.Text = "";
            txtEvaluationPath.Text = "";
            txtCareerPath.Text = "";
        }

        private void btnAddTraining_Click(object sender, EventArgs e)
        {
            try
            {
                Training training = new Training
                {
                    TrainingId = txtTrainingId.Text,
                    EmployeeId = cbTrainingEmployee.SelectedValue?.ToString(),
                    TrainingPlanPath = txtTrainingPlanPath.Text,
                    CertificatePath = txtCertificatePath.Text,
                    EvaluationPath = txtEvaluationPath.Text,
                    CareerPath = txtCareerPath.Text
                };
                trainingController.AddTraining(training);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding training: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateTraining_Click(object sender, EventArgs e)
        {
            try
            {
                Training training = new Training
                {
                    TrainingId = txtTrainingId.Text,
                    EmployeeId = cbTrainingEmployee.SelectedValue?.ToString(),
                    TrainingPlanPath = txtTrainingPlanPath.Text,
                    CertificatePath = txtCertificatePath.Text,
                    EvaluationPath = txtEvaluationPath.Text,
                    CareerPath = txtCareerPath.Text
                };
                trainingController.UpdateTraining(training);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating training: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTraining_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTrainings.SelectedRows.Count > 0)
                {
                    string trainingId = dgvTrainings.SelectedRows[0].Cells["TrainingId"].Value.ToString();
                    trainingController.DeleteTraining(trainingId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting training: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportTrainings_Click(object sender, EventArgs e)
        {
            try
            {
                trainingController.ExportTrainingsToExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting trainings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchTraining_Click(object sender, EventArgs e)
        {
            try
            {
                trainingController.SearchTrainings(txtSearchTraining.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching trainings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTrainings_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTrainings.SelectedRows.Count > 0)
                {
                    string trainingId = dgvTrainings.SelectedRows[0].Cells["TrainingId"].Value.ToString();
                    trainingController.ShowTrainingDetails(trainingId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing training details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Discipline Methods
        public void UpdateDisciplineGrid(DataTable dt) => dgvDisciplines.DataSource = dt;
        public void ClearDisciplineFields()
        {
            txtDisciplineId.Text = "";
            cbDisciplineEmployee.SelectedIndex = -1;
            txtViolationPath.Text = "";
            txtDisciplinaryDecisionPath.Text = "";
            txtResignationLetterPath.Text = "";
            txtTerminationDecisionPath.Text = "";
            txtHandoverPath.Text = "";
            txtLiquidationPath.Text = "";
        }

        private void btnAddDiscipline_Click(object sender, EventArgs e)
        {
            try
            {
                Discipline discipline = new Discipline
                {
                    DisciplineId = txtDisciplineId.Text,
                    EmployeeId = cbDisciplineEmployee.SelectedValue?.ToString(),
                    ViolationPath = txtViolationPath.Text,
                    DisciplinaryDecisionPath = txtDisciplinaryDecisionPath.Text,
                    ResignationLetterPath = txtResignationLetterPath.Text,
                    TerminationDecisionPath = txtTerminationDecisionPath.Text,
                    HandoverPath = txtHandoverPath.Text,
                    LiquidationPath = txtLiquidationPath.Text
                };
                disciplineController.AddDiscipline(discipline);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding discipline: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateDiscipline_Click(object sender, EventArgs e)
        {
            try
            {
                Discipline discipline = new Discipline
                {
                    DisciplineId = txtDisciplineId.Text,
                    EmployeeId = cbDisciplineEmployee.SelectedValue?.ToString(),
                    ViolationPath = txtViolationPath.Text,
                    DisciplinaryDecisionPath = txtDisciplinaryDecisionPath.Text,
                    ResignationLetterPath = txtResignationLetterPath.Text,
                    TerminationDecisionPath = txtTerminationDecisionPath.Text,
                    HandoverPath = txtHandoverPath.Text,
                    LiquidationPath = txtLiquidationPath.Text
                };
                disciplineController.UpdateDiscipline(discipline);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating discipline: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteDiscipline_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDisciplines.SelectedRows.Count > 0)
                {
                    string disciplineId = dgvDisciplines.SelectedRows[0].Cells["DisciplineId"].Value.ToString();
                    disciplineController.DeleteDiscipline(disciplineId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting discipline: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportDisciplines_Click(object sender, EventArgs e)
        {
            try
            {
                disciplineController.ExportDisciplinesToExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting disciplines: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDisciplines_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDisciplines.SelectedRows.Count > 0)
                {
                    string disciplineId = dgvDisciplines.SelectedRows[0].Cells["DisciplineId"].Value.ToString();
                    disciplineController.ShowDisciplineDetails(disciplineId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing discipline details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}