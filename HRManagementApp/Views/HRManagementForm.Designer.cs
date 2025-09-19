using System;

namespace HRManagementApp
{
    partial class HRManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabContract = new System.Windows.Forms.TabPage();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.tabRecruitment = new System.Windows.Forms.TabPage();
            this.tabSalary = new System.Windows.Forms.TabPage();
            this.tabTraining = new System.Windows.Forms.TabPage();
            this.tabDiscipline = new System.Windows.Forms.TabPage();

            // Employee Controls
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCCCDIssueDate = new System.Windows.Forms.Label();
            this.dtpCCCDIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblCCCDIssuePlace = new System.Windows.Forms.Label();
            this.txtCCCDIssuePlace = new System.Windows.Forms.TextBox();
            this.lblPermanentAddress = new System.Windows.Forms.Label();
            this.txtPermanentAddress = new System.Windows.Forms.TextBox();
            this.lblCurrentAddress = new System.Windows.Forms.Label();
            this.txtCurrentAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.cbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblDependents = new System.Windows.Forms.Label();
            this.txtDependents = new System.Windows.Forms.TextBox();
            this.lblSocialInsuranceNumber = new System.Windows.Forms.Label();
            this.txtSocialInsuranceNumber = new System.Windows.Forms.TextBox();
            this.lblTaxCode = new System.Windows.Forms.Label();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.lblJobDescription = new System.Windows.Forms.Label();
            this.txtJobDescription = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.lblWorkSchedule = new System.Windows.Forms.Label();
            this.txtWorkSchedule = new System.Windows.Forms.TextBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnExportEmployees = new System.Windows.Forms.Button();

            // Contract Controls
            this.lblContractId = new System.Windows.Forms.Label();
            this.txtContractId = new System.Windows.Forms.TextBox();
            this.lblContractEmployee = new System.Windows.Forms.Label();
            this.cbContractEmployee = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblContractType = new System.Windows.Forms.Label();
            this.cbContractType = new System.Windows.Forms.ComboBox();
            this.lblContractAnnexPath = new System.Windows.Forms.Label();
            this.txtContractAnnexPath = new System.Windows.Forms.TextBox();
            this.lblConfidentialityAgreementPath = new System.Windows.Forms.Label();
            this.txtConfidentialityAgreementPath = new System.Windows.Forms.TextBox();
            this.lblNonCompeteAgreementPath = new System.Windows.Forms.Label();
            this.txtNonCompeteAgreementPath = new System.Windows.Forms.TextBox();
            this.lblAppointmentDecisionPath = new System.Windows.Forms.Label();
            this.txtAppointmentDecisionPath = new System.Windows.Forms.TextBox();
            this.lblSalaryIncreaseDecisionPath = new System.Windows.Forms.Label();
            this.txtSalaryIncreaseDecisionPath = new System.Windows.Forms.TextBox();
            this.lblRewardDecisionPath = new System.Windows.Forms.Label();
            this.txtRewardDecisionPath = new System.Windows.Forms.TextBox();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.btnUpdateContract = new System.Windows.Forms.Button();
            this.btnDeleteContract = new System.Windows.Forms.Button();
            this.btnExportContracts = new System.Windows.Forms.Button();
            this.btnBrowseContractAnnex = new System.Windows.Forms.Button();
            this.btnOpenContractAnnex = new System.Windows.Forms.Button();
            this.btnBrowseConfidentiality = new System.Windows.Forms.Button();
            this.btnOpenConfidentiality = new System.Windows.Forms.Button();
            this.btnBrowseNonCompete = new System.Windows.Forms.Button();
            this.btnOpenNonCompete = new System.Windows.Forms.Button();
            this.btnBrowseAppointment = new System.Windows.Forms.Button();
            this.btnOpenAppointment = new System.Windows.Forms.Button();
            this.btnBrowseSalaryIncrease = new System.Windows.Forms.Button();
            this.btnOpenSalaryIncrease = new System.Windows.Forms.Button();
            this.btnBrowseReward = new System.Windows.Forms.Button();
            this.btnOpenReward = new System.Windows.Forms.Button();
            
            // Recruitment file buttons
            this.btnBrowseJobApplication = new System.Windows.Forms.Button();
            this.btnOpenJobApplication = new System.Windows.Forms.Button();
            this.btnBrowseResume = new System.Windows.Forms.Button();
            this.btnOpenResume = new System.Windows.Forms.Button();
            this.btnBrowseDegrees = new System.Windows.Forms.Button();
            this.btnOpenDegrees = new System.Windows.Forms.Button();
            this.btnBrowseHealthCheck = new System.Windows.Forms.Button();
            this.btnOpenHealthCheck = new System.Windows.Forms.Button();
            this.btnBrowseCV = new System.Windows.Forms.Button();
            this.btnOpenCV = new System.Windows.Forms.Button();
            this.btnBrowseReferenceLetter = new System.Windows.Forms.Button();
            this.btnOpenReferenceLetter = new System.Windows.Forms.Button();
            this.btnBrowseInterviewMinutes = new System.Windows.Forms.Button();
            this.btnOpenInterviewMinutes = new System.Windows.Forms.Button();
            this.btnBrowseOfferLetter = new System.Windows.Forms.Button();
            this.btnOpenOfferLetter = new System.Windows.Forms.Button();
            
            // Salary file buttons
            this.btnBrowsePaySlip = new System.Windows.Forms.Button();
            this.btnOpenPaySlip = new System.Windows.Forms.Button();
            
            // Training file buttons
            this.btnBrowseTrainingPlan = new System.Windows.Forms.Button();
            this.btnOpenTrainingPlan = new System.Windows.Forms.Button();
            this.btnBrowseCertificate = new System.Windows.Forms.Button();
            this.btnOpenCertificate = new System.Windows.Forms.Button();
            this.btnBrowseEvaluation = new System.Windows.Forms.Button();
            this.btnOpenEvaluation = new System.Windows.Forms.Button();
            this.btnBrowseCareer = new System.Windows.Forms.Button();
            this.btnOpenCareer = new System.Windows.Forms.Button();
            
            // Discipline file buttons
            this.btnBrowseViolation = new System.Windows.Forms.Button();
            this.btnOpenViolation = new System.Windows.Forms.Button();
            this.btnBrowseDisciplinaryDecision = new System.Windows.Forms.Button();
            this.btnOpenDisciplinaryDecision = new System.Windows.Forms.Button();
            this.btnBrowseResignationLetter = new System.Windows.Forms.Button();
            this.btnOpenResignationLetter = new System.Windows.Forms.Button();
            this.btnBrowseTerminationDecision = new System.Windows.Forms.Button();
            this.btnOpenTerminationDecision = new System.Windows.Forms.Button();
            this.btnBrowseHandover = new System.Windows.Forms.Button();
            this.btnOpenHandover = new System.Windows.Forms.Button();
            this.btnBrowseLiquidation = new System.Windows.Forms.Button();
            this.btnOpenLiquidation = new System.Windows.Forms.Button();

            // Attendance Controls
            this.lblAttendanceId = new System.Windows.Forms.Label();
            this.txtAttendanceId = new System.Windows.Forms.TextBox();
            this.lblAttendanceEmployee = new System.Windows.Forms.Label();
            this.cbAttendanceEmployee = new System.Windows.Forms.ComboBox();
            this.lblAttendanceDate = new System.Windows.Forms.Label();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.dtpCheckInTime = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutTime = new System.Windows.Forms.Label();
            this.dtpCheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblAdminHours = new System.Windows.Forms.Label();
            this.txtAdminHours = new System.Windows.Forms.TextBox();
            this.lblOvertimeHours = new System.Windows.Forms.Label();
            this.txtOvertimeHours = new System.Windows.Forms.TextBox();
            this.dgvAttendances = new System.Windows.Forms.DataGridView();
            this.btnAddAttendance = new System.Windows.Forms.Button();
            this.btnUpdateAttendance = new System.Windows.Forms.Button();
            this.btnDeleteAttendance = new System.Windows.Forms.Button();
            this.btnExportAttendances = new System.Windows.Forms.Button();

            // Recruitment Controls
            this.lblRecruitmentId = new System.Windows.Forms.Label();
            this.txtRecruitmentId = new System.Windows.Forms.TextBox();
            this.lblRecruitmentEmployee = new System.Windows.Forms.Label();
            this.cbRecruitmentEmployee = new System.Windows.Forms.ComboBox();
            this.lblJobApplicationPath = new System.Windows.Forms.Label();
            this.txtJobApplicationPath = new System.Windows.Forms.TextBox();
            this.lblResumePath = new System.Windows.Forms.Label();
            this.txtResumePath = new System.Windows.Forms.TextBox();
            this.lblDegreesPath = new System.Windows.Forms.Label();
            this.txtDegreesPath = new System.Windows.Forms.TextBox();
            this.lblHealthCheckPath = new System.Windows.Forms.Label();
            this.txtHealthCheckPath = new System.Windows.Forms.TextBox();
            this.lblCVPath = new System.Windows.Forms.Label();
            this.txtCVPath = new System.Windows.Forms.TextBox();
            this.lblReferenceLetterPath = new System.Windows.Forms.Label();
            this.txtReferenceLetterPath = new System.Windows.Forms.TextBox();
            this.lblInterviewMinutesPath = new System.Windows.Forms.Label();
            this.txtInterviewMinutesPath = new System.Windows.Forms.TextBox();
            this.lblOfferLetterPath = new System.Windows.Forms.Label();
            this.txtOfferLetterPath = new System.Windows.Forms.TextBox();
            this.dgvRecruitments = new System.Windows.Forms.DataGridView();
            this.btnAddRecruitment = new System.Windows.Forms.Button();
            this.btnUpdateRecruitment = new System.Windows.Forms.Button();
            this.btnDeleteRecruitment = new System.Windows.Forms.Button();
            this.btnExportRecruitments = new System.Windows.Forms.Button();

            // Salary Controls
            this.lblSalaryId = new System.Windows.Forms.Label();
            this.txtSalaryId = new System.Windows.Forms.TextBox();
            this.lblSalaryEmployee = new System.Windows.Forms.Label();
            this.cbSalaryEmployee = new System.Windows.Forms.ComboBox();
            this.lblMonthlySalary = new System.Windows.Forms.Label();
            this.txtMonthlySalary = new System.Windows.Forms.TextBox();
            this.lblPaySlipPath = new System.Windows.Forms.Label();
            this.txtPaySlipPath = new System.Windows.Forms.TextBox();
            this.lblSalaryIncreaseDecisionPath = new System.Windows.Forms.Label();
            this.txtSalaryIncreaseDecisionPath = new System.Windows.Forms.TextBox();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.txtBankAccount = new System.Windows.Forms.TextBox();
            this.lblInsuranceInfo = new System.Windows.Forms.Label();
            this.txtInsuranceInfo = new System.Windows.Forms.TextBox();
            this.lblAllowances = new System.Windows.Forms.Label();
            this.txtAllowances = new System.Windows.Forms.TextBox();
            this.lblBonuses = new System.Windows.Forms.Label();
            this.txtBonuses = new System.Windows.Forms.TextBox();
            this.lblLeavePolicy = new System.Windows.Forms.Label();
            this.txtLeavePolicy = new System.Windows.Forms.TextBox();
            this.dgvSalaries = new System.Windows.Forms.DataGridView();
            this.btnAddSalary = new System.Windows.Forms.Button();
            this.btnUpdateSalary = new System.Windows.Forms.Button();
            this.btnDeleteSalary = new System.Windows.Forms.Button();
            this.btnExportSalaries = new System.Windows.Forms.Button();

            // Training Controls
            this.lblTrainingId = new System.Windows.Forms.Label();
            this.txtTrainingId = new System.Windows.Forms.TextBox();
            this.lblTrainingEmployee = new System.Windows.Forms.Label();
            this.cbTrainingEmployee = new System.Windows.Forms.ComboBox();
            this.lblTrainingPlanPath = new System.Windows.Forms.Label();
            this.txtTrainingPlanPath = new System.Windows.Forms.TextBox();
            this.lblCertificatePath = new System.Windows.Forms.Label();
            this.txtCertificatePath = new System.Windows.Forms.TextBox();
            this.lblEvaluationPath = new System.Windows.Forms.Label();
            this.txtEvaluationPath = new System.Windows.Forms.TextBox();
            this.lblCareerPath = new System.Windows.Forms.Label();
            this.txtCareerPath = new System.Windows.Forms.TextBox();
            this.lblSearchTraining = new System.Windows.Forms.Label();
            this.txtSearchTraining = new System.Windows.Forms.TextBox();
            this.btnSearchTraining = new System.Windows.Forms.Button();
            this.dgvTrainings = new System.Windows.Forms.DataGridView();
            this.btnAddTraining = new System.Windows.Forms.Button();
            this.btnUpdateTraining = new System.Windows.Forms.Button();
            this.btnDeleteTraining = new System.Windows.Forms.Button();
            this.btnExportTrainings = new System.Windows.Forms.Button();

            // Discipline Controls
            this.lblDisciplineId = new System.Windows.Forms.Label();
            this.txtDisciplineId = new System.Windows.Forms.TextBox();
            this.lblDisciplineEmployee = new System.Windows.Forms.Label();
            this.cbDisciplineEmployee = new System.Windows.Forms.ComboBox();
            this.lblViolationPath = new System.Windows.Forms.Label();
            this.txtViolationPath = new System.Windows.Forms.TextBox();
            this.lblDisciplinaryDecisionPath = new System.Windows.Forms.Label();
            this.txtDisciplinaryDecisionPath = new System.Windows.Forms.TextBox();
            this.lblResignationLetterPath = new System.Windows.Forms.Label();
            this.txtResignationLetterPath = new System.Windows.Forms.TextBox();
            this.lblTerminationDecisionPath = new System.Windows.Forms.Label();
            this.txtTerminationDecisionPath = new System.Windows.Forms.TextBox();
            this.lblHandoverPath = new System.Windows.Forms.Label();
            this.txtHandoverPath = new System.Windows.Forms.TextBox();
            this.lblLiquidationPath = new System.Windows.Forms.Label();
            this.txtLiquidationPath = new System.Windows.Forms.TextBox();
            this.dgvDisciplines = new System.Windows.Forms.DataGridView();
            this.btnAddDiscipline = new System.Windows.Forms.Button();
            this.btnUpdateDiscipline = new System.Windows.Forms.Button();
            this.btnDeleteDiscipline = new System.Windows.Forms.Button();
            this.btnExportDisciplines = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.tabContract.SuspendLayout();
            this.tabAttendance.SuspendLayout();
            this.tabRecruitment.SuspendLayout();
            this.tabSalary.SuspendLayout();
            this.tabTraining.SuspendLayout();
            this.tabDiscipline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecruitments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEmployee);
            this.tabControl.Controls.Add(this.tabContract);
            this.tabControl.Controls.Add(this.tabAttendance);
            this.tabControl.Controls.Add(this.tabRecruitment);
            this.tabControl.Controls.Add(this.tabSalary);
            this.tabControl.Controls.Add(this.tabTraining);
            this.tabControl.Controls.Add(this.tabDiscipline);
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1180, 580);
            this.tabControl.TabIndex = 0;

            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.lblEmployeeId);
            this.tabEmployee.Controls.Add(this.txtEmployeeId);
            this.tabEmployee.Controls.Add(this.lblEmployeeName);
            this.tabEmployee.Controls.Add(this.txtEmployeeName);
            this.tabEmployee.Controls.Add(this.lblDOB);
            this.tabEmployee.Controls.Add(this.dtpDOB);
            this.tabEmployee.Controls.Add(this.lblGender);
            this.tabEmployee.Controls.Add(this.cbGender);
            this.tabEmployee.Controls.Add(this.lblNationality);
            this.tabEmployee.Controls.Add(this.txtNationality);
            this.tabEmployee.Controls.Add(this.lblCCCD);
            this.tabEmployee.Controls.Add(this.txtCCCD);
            this.tabEmployee.Controls.Add(this.lblCCCDIssueDate);
            this.tabEmployee.Controls.Add(this.dtpCCCDIssueDate);
            this.tabEmployee.Controls.Add(this.lblCCCDIssuePlace);
            this.tabEmployee.Controls.Add(this.txtCCCDIssuePlace);
            this.tabEmployee.Controls.Add(this.lblPermanentAddress);
            this.tabEmployee.Controls.Add(this.txtPermanentAddress);
            this.tabEmployee.Controls.Add(this.lblCurrentAddress);
            this.tabEmployee.Controls.Add(this.txtCurrentAddress);
            this.tabEmployee.Controls.Add(this.lblPhone);
            this.tabEmployee.Controls.Add(this.txtPhone);
            this.tabEmployee.Controls.Add(this.lblEmail);
            this.tabEmployee.Controls.Add(this.txtEmail);
            this.tabEmployee.Controls.Add(this.lblMaritalStatus);
            this.tabEmployee.Controls.Add(this.cbMaritalStatus);
            this.tabEmployee.Controls.Add(this.lblDependents);
            this.tabEmployee.Controls.Add(this.txtDependents);
            this.tabEmployee.Controls.Add(this.lblSocialInsuranceNumber);
            this.tabEmployee.Controls.Add(this.txtSocialInsuranceNumber);
            this.tabEmployee.Controls.Add(this.lblTaxCode);
            this.tabEmployee.Controls.Add(this.txtTaxCode);
            this.tabEmployee.Controls.Add(this.lblJobDescription);
            this.tabEmployee.Controls.Add(this.txtJobDescription);
            this.tabEmployee.Controls.Add(this.lblPosition);
            this.tabEmployee.Controls.Add(this.txtPosition);
            this.tabEmployee.Controls.Add(this.lblDepartment);
            this.tabEmployee.Controls.Add(this.txtDepartment);
            this.tabEmployee.Controls.Add(this.lblRank);
            this.tabEmployee.Controls.Add(this.txtRank);
            this.tabEmployee.Controls.Add(this.lblManager);
            this.tabEmployee.Controls.Add(this.txtManager);
            this.tabEmployee.Controls.Add(this.lblWorkSchedule);
            this.tabEmployee.Controls.Add(this.txtWorkSchedule);
            this.tabEmployee.Controls.Add(this.dgvEmployees);
            this.tabEmployee.Controls.Add(this.btnAddEmployee);
            this.tabEmployee.Controls.Add(this.btnUpdateEmployee);
            this.tabEmployee.Controls.Add(this.btnDeleteEmployee);
            this.tabEmployee.Controls.Add(this.btnExportEmployees);
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1172, 554);
            this.tabEmployee.Text = "Nhân viên";
            this.tabEmployee.UseVisualStyleBackColor = true;

            // Employee Controls Layout (Three Columns)
            this.lblEmployeeId.Text = "Mã nhân viên:";
            this.lblEmployeeId.Location = new System.Drawing.Point(10, 10);
            this.lblEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeId.Location = new System.Drawing.Point(120, 10);
            this.txtEmployeeId.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeId.TabIndex = 0;

            this.lblEmployeeName.Text = "Tên:";
            this.lblEmployeeName.Location = new System.Drawing.Point(10, 40);
            this.lblEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeName.Location = new System.Drawing.Point(120, 40);
            this.txtEmployeeName.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeName.TabIndex = 1;

            this.lblDOB.Text = "Ngày sinh:";
            this.lblDOB.Location = new System.Drawing.Point(10, 70);
            this.lblDOB.Size = new System.Drawing.Size(100, 20);
            this.dtpDOB.Location = new System.Drawing.Point(120, 70);
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 2;

            this.lblGender.Text = "Giới tính:";
            this.lblGender.Location = new System.Drawing.Point(10, 100);
            this.lblGender.Size = new System.Drawing.Size(100, 20);
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbGender.Location = new System.Drawing.Point(120, 100);
            this.cbGender.Size = new System.Drawing.Size(200, 21);
            this.cbGender.TabIndex = 3;

            this.lblNationality.Text = "Quốc tịch:";
            this.lblNationality.Location = new System.Drawing.Point(10, 130);
            this.lblNationality.Size = new System.Drawing.Size(100, 20);
            this.txtNationality.Location = new System.Drawing.Point(120, 130);
            this.txtNationality.Size = new System.Drawing.Size(200, 20);
            this.txtNationality.TabIndex = 4;

            this.lblCCCD.Text = "CCCD:";
            this.lblCCCD.Location = new System.Drawing.Point(10, 160);
            this.lblCCCD.Size = new System.Drawing.Size(100, 20);
            this.txtCCCD.Location = new System.Drawing.Point(120, 160);
            this.txtCCCD.Size = new System.Drawing.Size(200, 20);
            this.txtCCCD.TabIndex = 5;

            this.lblCCCDIssueDate.Text = "Ngày cấp CCCD:";
            this.lblCCCDIssueDate.Location = new System.Drawing.Point(10, 190);
            this.lblCCCDIssueDate.Size = new System.Drawing.Size(100, 20);
            this.dtpCCCDIssueDate.Location = new System.Drawing.Point(120, 190);
            this.dtpCCCDIssueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCCCDIssueDate.TabIndex = 6;

            this.lblCCCDIssuePlace.Text = "Nơi cấp CCCD:";
            this.lblCCCDIssuePlace.Location = new System.Drawing.Point(10, 220);
            this.lblCCCDIssuePlace.Size = new System.Drawing.Size(100, 20);
            this.txtCCCDIssuePlace.Location = new System.Drawing.Point(120, 220);
            this.txtCCCDIssuePlace.Size = new System.Drawing.Size(200, 20);
            this.txtCCCDIssuePlace.TabIndex = 7;

            this.lblPermanentAddress.Text = "Địa chỉ thường trú:";
            this.lblPermanentAddress.Location = new System.Drawing.Point(10, 250);
            this.lblPermanentAddress.Size = new System.Drawing.Size(100, 20);
            this.txtPermanentAddress.Location = new System.Drawing.Point(120, 250);
            this.txtPermanentAddress.Size = new System.Drawing.Size(200, 20);
            this.txtPermanentAddress.TabIndex = 8;

            this.lblCurrentAddress.Text = "Địa chỉ hiện tại:";
            this.lblCurrentAddress.Location = new System.Drawing.Point(10, 280);
            this.lblCurrentAddress.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentAddress.Location = new System.Drawing.Point(120, 280);
            this.txtCurrentAddress.Size = new System.Drawing.Size(200, 20);
            this.txtCurrentAddress.TabIndex = 9;

            this.lblPhone.Text = "Số điện thoại:";
            this.lblPhone.Location = new System.Drawing.Point(350, 10);
            this.lblPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.Location = new System.Drawing.Point(460, 10);
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 10;

            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(350, 40);
            this.lblEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.Location = new System.Drawing.Point(460, 40);
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 11;

            this.lblMaritalStatus.Text = "Tình trạng hôn nhân:";
            this.lblMaritalStatus.Location = new System.Drawing.Point(350, 70);
            this.lblMaritalStatus.Size = new System.Drawing.Size(100, 20);
            this.cbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaritalStatus.FormattingEnabled = true;
            this.cbMaritalStatus.Items.AddRange(new object[] {
            "Độc thân",
            "Đã kết hôn",
            "Ly hôn",
            "Góa"});
            this.cbMaritalStatus.Location = new System.Drawing.Point(460, 70);
            this.cbMaritalStatus.Size = new System.Drawing.Size(200, 21);
            this.cbMaritalStatus.TabIndex = 12;

            this.lblDependents.Text = "Số người phụ thuộc:";
            this.lblDependents.Location = new System.Drawing.Point(350, 100);
            this.lblDependents.Size = new System.Drawing.Size(100, 20);
            this.txtDependents.Location = new System.Drawing.Point(460, 100);
            this.txtDependents.Size = new System.Drawing.Size(200, 20);
            this.txtDependents.TabIndex = 13;

            this.lblSocialInsuranceNumber.Text = "Số bảo hiểm xã hội:";
            this.lblSocialInsuranceNumber.Location = new System.Drawing.Point(350, 130);
            this.lblSocialInsuranceNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSocialInsuranceNumber.Location = new System.Drawing.Point(460, 130);
            this.txtSocialInsuranceNumber.Size = new System.Drawing.Size(200, 20);
            this.txtSocialInsuranceNumber.TabIndex = 14;

            this.lblTaxCode.Text = "Mã số thuế:";
            this.lblTaxCode.Location = new System.Drawing.Point(350, 160);
            this.lblTaxCode.Size = new System.Drawing.Size(100, 20);
            this.txtTaxCode.Location = new System.Drawing.Point(460, 160);
            this.txtTaxCode.Size = new System.Drawing.Size(200, 20);
            this.txtTaxCode.TabIndex = 15;

            this.lblJobDescription.Text = "Mô tả công việc:";
            this.lblJobDescription.Location = new System.Drawing.Point(350, 190);
            this.lblJobDescription.Size = new System.Drawing.Size(100, 20);
            this.txtJobDescription.Location = new System.Drawing.Point(460, 190);
            this.txtJobDescription.Size = new System.Drawing.Size(200, 20);
            this.txtJobDescription.TabIndex = 16;

            this.lblPosition.Text = "Chức vụ:";
            this.lblPosition.Location = new System.Drawing.Point(350, 220);
            this.lblPosition.Size = new System.Drawing.Size(100, 20);
            this.txtPosition.Location = new System.Drawing.Point(460, 220);
            this.txtPosition.Size = new System.Drawing.Size(200, 20);
            this.txtPosition.TabIndex = 17;

            this.lblDepartment.Text = "Phòng ban:";
            this.lblDepartment.Location = new System.Drawing.Point(350, 250);
            this.lblDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.Location = new System.Drawing.Point(460, 250);
            this.txtDepartment.Size = new System.Drawing.Size(200, 20);
            this.txtDepartment.TabIndex = 18;

            this.lblRank.Text = "Cấp bậc:";
            this.lblRank.Location = new System.Drawing.Point(350, 280);
            this.lblRank.Size = new System.Drawing.Size(100, 20);
            this.txtRank.Location = new System.Drawing.Point(460, 280);
            this.txtRank.Size = new System.Drawing.Size(200, 20);
            this.txtRank.TabIndex = 19;

            this.lblManager.Text = "Người quản lý:";
            this.lblManager.Location = new System.Drawing.Point(700, 10);
            this.lblManager.Size = new System.Drawing.Size(100, 20);
            this.txtManager.Location = new System.Drawing.Point(810, 10);
            this.txtManager.Size = new System.Drawing.Size(200, 20);
            this.txtManager.TabIndex = 20;

            this.lblWorkSchedule.Text = "Lịch làm việc:";
            this.lblWorkSchedule.Location = new System.Drawing.Point(700, 40);
            this.lblWorkSchedule.Size = new System.Drawing.Size(100, 20);
            this.txtWorkSchedule.Location = new System.Drawing.Point(810, 40);
            this.txtWorkSchedule.Size = new System.Drawing.Size(200, 20);
            this.txtWorkSchedule.TabIndex = 21;

            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(10, 320);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(1000, 150);
            this.dgvEmployees.TabIndex = 22;
            this.dgvEmployees.SelectionChanged += new System.EventHandler(this.dgvEmployees_SelectionChanged);

            this.btnAddEmployee.Text = "Thêm";
            this.btnAddEmployee.Location = new System.Drawing.Point(10, 480);
            this.btnAddEmployee.Size = new System.Drawing.Size(100, 30);
            this.btnAddEmployee.TabIndex = 23;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);

            this.btnUpdateEmployee.Text = "Cập nhật";
            this.btnUpdateEmployee.Location = new System.Drawing.Point(120, 480);
            this.btnUpdateEmployee.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateEmployee.TabIndex = 24;
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);

            this.btnDeleteEmployee.Text = "Xóa";
            this.btnDeleteEmployee.Location = new System.Drawing.Point(230, 480);
            this.btnDeleteEmployee.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteEmployee.TabIndex = 25;
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);

            this.btnExportEmployees.Text = "Xuất Excel";
            this.btnExportEmployees.Location = new System.Drawing.Point(340, 480);
            this.btnExportEmployees.Size = new System.Drawing.Size(100, 30);
            this.btnExportEmployees.TabIndex = 26;
            this.btnExportEmployees.UseVisualStyleBackColor = true;
            this.btnExportEmployees.Click += new System.EventHandler(this.btnExportEmployees_Click);

            // 
            // tabContract
            // 
            this.tabContract.Controls.Add(this.lblContractId);
            this.tabContract.Controls.Add(this.txtContractId);
            this.tabContract.Controls.Add(this.lblContractEmployee);
            this.tabContract.Controls.Add(this.cbContractEmployee);
            this.tabContract.Controls.Add(this.lblStartDate);
            this.tabContract.Controls.Add(this.dtpStartDate);
            this.tabContract.Controls.Add(this.lblEndDate);
            this.tabContract.Controls.Add(this.dtpEndDate);
            this.tabContract.Controls.Add(this.lblContractType);
            this.tabContract.Controls.Add(this.cbContractType);
            this.tabContract.Controls.Add(this.lblContractAnnexPath);
            this.tabContract.Controls.Add(this.txtContractAnnexPath);
            this.tabContract.Controls.Add(this.lblConfidentialityAgreementPath);
            this.tabContract.Controls.Add(this.txtConfidentialityAgreementPath);
            this.tabContract.Controls.Add(this.lblNonCompeteAgreementPath);
            this.tabContract.Controls.Add(this.txtNonCompeteAgreementPath);
            this.tabContract.Controls.Add(this.lblAppointmentDecisionPath);
            this.tabContract.Controls.Add(this.txtAppointmentDecisionPath);
            this.tabContract.Controls.Add(this.lblSalaryIncreaseDecisionPath);
            this.tabContract.Controls.Add(this.txtSalaryIncreaseDecisionPath);
            this.tabContract.Controls.Add(this.lblRewardDecisionPath);
            this.tabContract.Controls.Add(this.txtRewardDecisionPath);
            this.tabContract.Controls.Add(this.dgvContracts);
            this.tabContract.Controls.Add(this.btnAddContract);
            this.tabContract.Controls.Add(this.btnUpdateContract);
            this.tabContract.Controls.Add(this.btnDeleteContract);
            this.tabContract.Controls.Add(this.btnExportContracts);
            this.tabContract.Controls.Add(this.btnBrowseContractAnnex);
            this.tabContract.Controls.Add(this.btnOpenContractAnnex);
            this.tabContract.Controls.Add(this.btnBrowseConfidentiality);
            this.tabContract.Controls.Add(this.btnOpenConfidentiality);
            this.tabContract.Controls.Add(this.btnBrowseNonCompete);
            this.tabContract.Controls.Add(this.btnOpenNonCompete);
            this.tabContract.Controls.Add(this.btnBrowseAppointment);
            this.tabContract.Controls.Add(this.btnOpenAppointment);
            this.tabContract.Controls.Add(this.btnBrowseSalaryIncrease);
            this.tabContract.Controls.Add(this.btnOpenSalaryIncrease);
            this.tabContract.Controls.Add(this.btnBrowseReward);
            this.tabContract.Controls.Add(this.btnOpenReward);
            this.tabContract.Location = new System.Drawing.Point(4, 22);
            this.tabContract.Name = "tabContract";
            this.tabContract.Size = new System.Drawing.Size(1172, 554);
            this.tabContract.Text = "Hợp đồng";
            this.tabContract.UseVisualStyleBackColor = true;

            // Contract Controls Layout (Two Columns)
            this.lblContractId.Text = "Mã hợp đồng:";
            this.lblContractId.Location = new System.Drawing.Point(10, 10);
            this.lblContractId.Size = new System.Drawing.Size(100, 20);
            this.txtContractId.Location = new System.Drawing.Point(120, 10);
            this.txtContractId.Size = new System.Drawing.Size(200, 20);
            this.txtContractId.TabIndex = 0;

            this.lblContractEmployee.Text = "Nhân viên:";
            this.lblContractEmployee.Location = new System.Drawing.Point(10, 40);
            this.lblContractEmployee.Size = new System.Drawing.Size(100, 20);
            this.cbContractEmployee.Location = new System.Drawing.Point(120, 40);
            this.cbContractEmployee.Size = new System.Drawing.Size(200, 20);
            this.cbContractEmployee.TabIndex = 1;

            this.lblStartDate.Text = "Ngày bắt đầu:";
            this.lblStartDate.Location = new System.Drawing.Point(10, 70);
            this.lblStartDate.Size = new System.Drawing.Size(100, 20);
            this.dtpStartDate.Location = new System.Drawing.Point(120, 70);
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 2;

            this.lblEndDate.Text = "Ngày kết thúc:";
            this.lblEndDate.Location = new System.Drawing.Point(10, 100);
            this.lblEndDate.Size = new System.Drawing.Size(100, 20);
            this.dtpEndDate.Location = new System.Drawing.Point(120, 100);
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 3;

            this.lblContractType.Text = "Loại hợp đồng:";
            this.lblContractType.Location = new System.Drawing.Point(10, 130);
            this.lblContractType.Size = new System.Drawing.Size(100, 20);
            this.cbContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractType.FormattingEnabled = true;
            this.cbContractType.Items.AddRange(new object[] {
            "Hợp đồng lao động",
            "Hợp đồng thử việc",
            "Hợp đồng thời vụ",
            "Hợp đồng cộng tác viên"});
            this.cbContractType.Location = new System.Drawing.Point(120, 130);
            this.cbContractType.Size = new System.Drawing.Size(200, 21);
            this.cbContractType.TabIndex = 4;

            this.lblContractAnnexPath.Text = "Đường dẫn phụ lục hợp đồng:";
            this.lblContractAnnexPath.Location = new System.Drawing.Point(350, 10);
            this.lblContractAnnexPath.Size = new System.Drawing.Size(100, 20);
            this.txtContractAnnexPath.Location = new System.Drawing.Point(460, 10);
            this.txtContractAnnexPath.Size = new System.Drawing.Size(200, 20);
            this.txtContractAnnexPath.TabIndex = 5;

            this.lblConfidentialityAgreementPath.Text = "Đường dẫn thỏa thuận bảo mật:";
            this.lblConfidentialityAgreementPath.Location = new System.Drawing.Point(350, 40);
            this.lblConfidentialityAgreementPath.Size = new System.Drawing.Size(100, 20);
            this.txtConfidentialityAgreementPath.Location = new System.Drawing.Point(460, 40);
            this.txtConfidentialityAgreementPath.Size = new System.Drawing.Size(200, 20);
            this.txtConfidentialityAgreementPath.TabIndex = 6;

            this.lblNonCompeteAgreementPath.Text = "Đường dẫn thỏa thuận không cạnh tranh:";
            this.lblNonCompeteAgreementPath.Location = new System.Drawing.Point(350, 70);
            this.lblNonCompeteAgreementPath.Size = new System.Drawing.Size(100, 20);
            this.txtNonCompeteAgreementPath.Location = new System.Drawing.Point(460, 70);
            this.txtNonCompeteAgreementPath.Size = new System.Drawing.Size(200, 20);
            this.txtNonCompeteAgreementPath.TabIndex = 7;

            this.lblAppointmentDecisionPath.Text = "Đường dẫn quyết định bổ nhiệm:";
            this.lblAppointmentDecisionPath.Location = new System.Drawing.Point(350, 100);
            this.lblAppointmentDecisionPath.Size = new System.Drawing.Size(100, 20);
            this.txtAppointmentDecisionPath.Location = new System.Drawing.Point(460, 100);
            this.txtAppointmentDecisionPath.Size = new System.Drawing.Size(200, 20);
            this.txtAppointmentDecisionPath.TabIndex = 8;

            this.lblSalaryIncreaseDecisionPath.Text = "Đường dẫn quyết định tăng lương:";
            this.lblSalaryIncreaseDecisionPath.Location = new System.Drawing.Point(350, 130);
            this.lblSalaryIncreaseDecisionPath.Size = new System.Drawing.Size(100, 20);
            this.txtSalaryIncreaseDecisionPath.Location = new System.Drawing.Point(460, 130);
            this.txtSalaryIncreaseDecisionPath.Size = new System.Drawing.Size(200, 20);
            this.txtSalaryIncreaseDecisionPath.TabIndex = 9;

            this.lblRewardDecisionPath.Text = "Đường dẫn quyết định khen thưởng:";
            this.lblRewardDecisionPath.Location = new System.Drawing.Point(350, 160);
            this.lblRewardDecisionPath.Size = new System.Drawing.Size(100, 20);
            this.txtRewardDecisionPath.Location = new System.Drawing.Point(460, 160);
            this.txtRewardDecisionPath.Size = new System.Drawing.Size(200, 20);
            this.txtRewardDecisionPath.TabIndex = 10;

            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(10, 190);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.Size = new System.Drawing.Size(1150, 150);
            this.dgvContracts.TabIndex = 11;
            this.dgvContracts.SelectionChanged += new System.EventHandler(this.dgvContracts_SelectionChanged);

            this.btnAddContract.Text = "Thêm";
            this.btnAddContract.Location = new System.Drawing.Point(10, 350);
            this.btnAddContract.Size = new System.Drawing.Size(100, 30);
            this.btnAddContract.TabIndex = 12;
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);

            this.btnUpdateContract.Text = "Cập nhật";
            this.btnUpdateContract.Location = new System.Drawing.Point(120, 350);
            this.btnUpdateContract.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateContract.TabIndex = 13;
            this.btnUpdateContract.UseVisualStyleBackColor = true;
            this.btnUpdateContract.Click += new System.EventHandler(this.btnUpdateContract_Click);

            this.btnDeleteContract.Text = "Xóa";
            this.btnDeleteContract.Location = new System.Drawing.Point(230, 350);
            this.btnDeleteContract.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteContract.TabIndex = 14;
            this.btnDeleteContract.UseVisualStyleBackColor = true;
            this.btnDeleteContract.Click += new System.EventHandler(this.btnDeleteContract_Click);

            this.btnExportContracts.Text = "Xuất Excel";
            this.btnExportContracts.Location = new System.Drawing.Point(340, 350);
            this.btnExportContracts.Size = new System.Drawing.Size(100, 30);
            this.btnExportContracts.TabIndex = 15;
            this.btnExportContracts.UseVisualStyleBackColor = true;
            this.btnExportContracts.Click += new System.EventHandler(this.btnExportContracts_Click);

            // Contract Annex buttons
            this.btnBrowseContractAnnex.Text = "Chọn file";
            this.btnBrowseContractAnnex.Location = new System.Drawing.Point(670, 10);
            this.btnBrowseContractAnnex.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseContractAnnex.TabIndex = 16;
            this.btnBrowseContractAnnex.UseVisualStyleBackColor = true;
            this.btnBrowseContractAnnex.Click += new System.EventHandler(this.btnBrowseContractAnnex_Click);

            this.btnOpenContractAnnex.Text = "Mở";
            this.btnOpenContractAnnex.Location = new System.Drawing.Point(740, 10);
            this.btnOpenContractAnnex.Size = new System.Drawing.Size(60, 20);
            this.btnOpenContractAnnex.TabIndex = 17;
            this.btnOpenContractAnnex.UseVisualStyleBackColor = true;
            this.btnOpenContractAnnex.Click += new System.EventHandler(this.btnOpenContractAnnex_Click);

            // Confidentiality Agreement buttons
            this.btnBrowseConfidentiality.Text = "Chọn file";
            this.btnBrowseConfidentiality.Location = new System.Drawing.Point(670, 40);
            this.btnBrowseConfidentiality.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseConfidentiality.TabIndex = 18;
            this.btnBrowseConfidentiality.UseVisualStyleBackColor = true;
            this.btnBrowseConfidentiality.Click += new System.EventHandler(this.btnBrowseConfidentiality_Click);

            this.btnOpenConfidentiality.Text = "Mở";
            this.btnOpenConfidentiality.Location = new System.Drawing.Point(740, 40);
            this.btnOpenConfidentiality.Size = new System.Drawing.Size(60, 20);
            this.btnOpenConfidentiality.TabIndex = 19;
            this.btnOpenConfidentiality.UseVisualStyleBackColor = true;
            this.btnOpenConfidentiality.Click += new System.EventHandler(this.btnOpenConfidentiality_Click);

            // Non-Compete Agreement buttons
            this.btnBrowseNonCompete.Text = "Chọn file";
            this.btnBrowseNonCompete.Location = new System.Drawing.Point(670, 70);
            this.btnBrowseNonCompete.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseNonCompete.TabIndex = 20;
            this.btnBrowseNonCompete.UseVisualStyleBackColor = true;
            this.btnBrowseNonCompete.Click += new System.EventHandler(this.btnBrowseNonCompete_Click);

            this.btnOpenNonCompete.Text = "Mở";
            this.btnOpenNonCompete.Location = new System.Drawing.Point(740, 70);
            this.btnOpenNonCompete.Size = new System.Drawing.Size(60, 20);
            this.btnOpenNonCompete.TabIndex = 21;
            this.btnOpenNonCompete.UseVisualStyleBackColor = true;
            this.btnOpenNonCompete.Click += new System.EventHandler(this.btnOpenNonCompete_Click);

            // Appointment Decision buttons
            this.btnBrowseAppointment.Text = "Chọn file";
            this.btnBrowseAppointment.Location = new System.Drawing.Point(670, 100);
            this.btnBrowseAppointment.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseAppointment.TabIndex = 22;
            this.btnBrowseAppointment.UseVisualStyleBackColor = true;
            this.btnBrowseAppointment.Click += new System.EventHandler(this.btnBrowseAppointment_Click);

            this.btnOpenAppointment.Text = "Mở";
            this.btnOpenAppointment.Location = new System.Drawing.Point(740, 100);
            this.btnOpenAppointment.Size = new System.Drawing.Size(60, 20);
            this.btnOpenAppointment.TabIndex = 23;
            this.btnOpenAppointment.UseVisualStyleBackColor = true;
            this.btnOpenAppointment.Click += new System.EventHandler(this.btnOpenAppointment_Click);

            // Salary Increase Decision buttons
            this.btnBrowseSalaryIncrease.Text = "Chọn file";
            this.btnBrowseSalaryIncrease.Location = new System.Drawing.Point(670, 130);
            this.btnBrowseSalaryIncrease.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseSalaryIncrease.TabIndex = 24;
            this.btnBrowseSalaryIncrease.UseVisualStyleBackColor = true;
            this.btnBrowseSalaryIncrease.Click += new System.EventHandler(this.btnBrowseSalaryIncrease_Click);

            this.btnOpenSalaryIncrease.Text = "Mở";
            this.btnOpenSalaryIncrease.Location = new System.Drawing.Point(740, 130);
            this.btnOpenSalaryIncrease.Size = new System.Drawing.Size(60, 20);
            this.btnOpenSalaryIncrease.TabIndex = 25;
            this.btnOpenSalaryIncrease.UseVisualStyleBackColor = true;
            this.btnOpenSalaryIncrease.Click += new System.EventHandler(this.btnOpenSalaryIncrease_Click);

            // Reward Decision buttons
            this.btnBrowseReward.Text = "Chọn file";
            this.btnBrowseReward.Location = new System.Drawing.Point(670, 160);
            this.btnBrowseReward.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseReward.TabIndex = 26;
            this.btnBrowseReward.UseVisualStyleBackColor = true;
            this.btnBrowseReward.Click += new System.EventHandler(this.btnBrowseReward_Click);

            this.btnOpenReward.Text = "Mở";
            this.btnOpenReward.Location = new System.Drawing.Point(740, 160);
            this.btnOpenReward.Size = new System.Drawing.Size(60, 20);
            this.btnOpenReward.TabIndex = 27;
            this.btnOpenReward.UseVisualStyleBackColor = true;
            this.btnOpenReward.Click += new System.EventHandler(this.btnOpenReward_Click);

            // 
            // tabAttendance
            // 
            this.tabAttendance.Controls.Add(this.lblAttendanceId);
            this.tabAttendance.Controls.Add(this.txtAttendanceId);
            this.tabAttendance.Controls.Add(this.lblAttendanceEmployee);
            this.tabAttendance.Controls.Add(this.cbAttendanceEmployee);
            this.tabAttendance.Controls.Add(this.lblAttendanceDate);
            this.tabAttendance.Controls.Add(this.dtpAttendanceDate);
            this.tabAttendance.Controls.Add(this.lblCheckInTime);
            this.tabAttendance.Controls.Add(this.dtpCheckInTime);
            this.tabAttendance.Controls.Add(this.lblCheckOutTime);
            this.tabAttendance.Controls.Add(this.dtpCheckOutTime);
            this.tabAttendance.Controls.Add(this.lblStatus);
            this.tabAttendance.Controls.Add(this.cbStatus);
            this.tabAttendance.Controls.Add(this.lblAdminHours);
            this.tabAttendance.Controls.Add(this.txtAdminHours);
            this.tabAttendance.Controls.Add(this.lblOvertimeHours);
            this.tabAttendance.Controls.Add(this.txtOvertimeHours);
            this.tabAttendance.Controls.Add(this.dgvAttendances);
            this.tabAttendance.Controls.Add(this.btnAddAttendance);
            this.tabAttendance.Controls.Add(this.btnUpdateAttendance);
            this.tabAttendance.Controls.Add(this.btnDeleteAttendance);
            this.tabAttendance.Controls.Add(this.btnExportAttendances);
            this.tabAttendance.Location = new System.Drawing.Point(4, 22);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Size = new System.Drawing.Size(1172, 554);
            this.tabAttendance.Text = "Chấm công";
            this.tabAttendance.UseVisualStyleBackColor = true;

            // Attendance Controls Layout (Two Columns)
            this.lblAttendanceId.Text = "Mã chấm công:";
            this.lblAttendanceId.Location = new System.Drawing.Point(10, 10);
            this.lblAttendanceId.Size = new System.Drawing.Size(100, 20);
            this.txtAttendanceId.Location = new System.Drawing.Point(120, 10);
            this.txtAttendanceId.Size = new System.Drawing.Size(200, 20);
            this.txtAttendanceId.TabIndex = 0;

            this.lblAttendanceEmployee.Text = "Nhân viên:";
            this.lblAttendanceEmployee.Location = new System.Drawing.Point(10, 40);
            this.lblAttendanceEmployee.Size = new System.Drawing.Size(100, 20);
            this.cbAttendanceEmployee.Location = new System.Drawing.Point(120, 40);
            this.cbAttendanceEmployee.Size = new System.Drawing.Size(200, 20);
            this.cbAttendanceEmployee.TabIndex = 1;

            this.lblAttendanceDate.Text = "Ngày chấm công:";
            this.lblAttendanceDate.Location = new System.Drawing.Point(10, 70);
            this.lblAttendanceDate.Size = new System.Drawing.Size(100, 20);
            this.dtpAttendanceDate.Location = new System.Drawing.Point(120, 70);
            this.dtpAttendanceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAttendanceDate.TabIndex = 2;

            this.lblCheckInTime.Text = "Giờ vào:";
            this.lblCheckInTime.Location = new System.Drawing.Point(10, 100);
            this.lblCheckInTime.Size = new System.Drawing.Size(100, 20);
            this.dtpCheckInTime.Location = new System.Drawing.Point(120, 100);
            this.dtpCheckInTime.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckInTime.TabIndex = 3;

            this.lblCheckOutTime.Text = "Giờ ra:";
            this.lblCheckOutTime.Location = new System.Drawing.Point(10, 130);
            this.lblCheckOutTime.Size = new System.Drawing.Size(100, 20);
            this.dtpCheckOutTime.Location = new System.Drawing.Point(120, 130);
            this.dtpCheckOutTime.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOutTime.TabIndex = 4;

            this.lblStatus.Text = "Trạng thái:";
            this.lblStatus.Location = new System.Drawing.Point(330, 10);
            this.lblStatus.Size = new System.Drawing.Size(100, 20);
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Có mặt",
            "Vắng mặt",
            "Nghỉ phép",
            "Nghỉ ốm",
            "Đi muộn",
            "Về sớm"});
            this.cbStatus.Location = new System.Drawing.Point(440, 10);
            this.cbStatus.Size = new System.Drawing.Size(200, 21);
            this.cbStatus.TabIndex = 5;

            this.lblAdminHours.Text = "Số giờ hành chính:";
            this.lblAdminHours.Location = new System.Drawing.Point(330, 40);
            this.lblAdminHours.Size = new System.Drawing.Size(100, 20);
            this.txtAdminHours.Location = new System.Drawing.Point(440, 40);
            this.txtAdminHours.Size = new System.Drawing.Size(200, 20);
            this.txtAdminHours.TabIndex = 6;

            this.lblOvertimeHours.Text = "Số giờ làm thêm:";
            this.lblOvertimeHours.Location = new System.Drawing.Point(330, 70);
            this.lblOvertimeHours.Size = new System.Drawing.Size(100, 20);
            this.txtOvertimeHours.Location = new System.Drawing.Point(440, 70);
            this.txtOvertimeHours.Size = new System.Drawing.Size(200, 20);
            this.txtOvertimeHours.TabIndex = 7;

            this.dgvAttendances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendances.Location = new System.Drawing.Point(10, 160);
            this.dgvAttendances.Name = "dgvAttendances";
            this.dgvAttendances.Size = new System.Drawing.Size(1150, 150);
            this.dgvAttendances.TabIndex = 8;
            this.dgvAttendances.SelectionChanged += new System.EventHandler(this.dgvAttendances_SelectionChanged);

            this.btnAddAttendance.Text = "Thêm";
            this.btnAddAttendance.Location = new System.Drawing.Point(10, 320);
            this.btnAddAttendance.Size = new System.Drawing.Size(100, 30);
            this.btnAddAttendance.TabIndex = 9;
            this.btnAddAttendance.UseVisualStyleBackColor = true;
            this.btnAddAttendance.Click += new System.EventHandler(this.btnAddAttendance_Click);

            this.btnUpdateAttendance.Text = "Cập nhật";
            this.btnUpdateAttendance.Location = new System.Drawing.Point(120, 320);
            this.btnUpdateAttendance.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateAttendance.TabIndex = 10;
            this.btnUpdateAttendance.UseVisualStyleBackColor = true;
            this.btnUpdateAttendance.Click += new System.EventHandler(this.btnUpdateAttendance_Click);

            this.btnDeleteAttendance.Text = "Xóa";
            this.btnDeleteAttendance.Location = new System.Drawing.Point(230, 320);
            this.btnDeleteAttendance.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteAttendance.TabIndex = 11;
            this.btnDeleteAttendance.UseVisualStyleBackColor = true;
            this.btnDeleteAttendance.Click += new System.EventHandler(this.btnDeleteAttendance_Click);

            this.btnExportAttendances.Text = "Xuất Excel";
            this.btnExportAttendances.Location = new System.Drawing.Point(340, 320);
            this.btnExportAttendances.Size = new System.Drawing.Size(100, 30);
            this.btnExportAttendances.TabIndex = 12;
            this.btnExportAttendances.UseVisualStyleBackColor = true;
            this.btnExportAttendances.Click += new System.EventHandler(this.btnExportAttendances_Click);

            // 
            // tabRecruitment
            // 
            this.tabRecruitment.Controls.Add(this.lblRecruitmentId);
            this.tabRecruitment.Controls.Add(this.txtRecruitmentId);
            this.tabRecruitment.Controls.Add(this.lblRecruitmentEmployee);
            this.tabRecruitment.Controls.Add(this.cbRecruitmentEmployee);
            this.tabRecruitment.Controls.Add(this.lblJobApplicationPath);
            this.tabRecruitment.Controls.Add(this.txtJobApplicationPath);
            this.tabRecruitment.Controls.Add(this.lblResumePath);
            this.tabRecruitment.Controls.Add(this.txtResumePath);
            this.tabRecruitment.Controls.Add(this.lblDegreesPath);
            this.tabRecruitment.Controls.Add(this.txtDegreesPath);
            this.tabRecruitment.Controls.Add(this.lblHealthCheckPath);
            this.tabRecruitment.Controls.Add(this.txtHealthCheckPath);
            this.tabRecruitment.Controls.Add(this.lblCVPath);
            this.tabRecruitment.Controls.Add(this.txtCVPath);
            this.tabRecruitment.Controls.Add(this.lblReferenceLetterPath);
            this.tabRecruitment.Controls.Add(this.txtReferenceLetterPath);
            this.tabRecruitment.Controls.Add(this.lblInterviewMinutesPath);
            this.tabRecruitment.Controls.Add(this.txtInterviewMinutesPath);
            this.tabRecruitment.Controls.Add(this.lblOfferLetterPath);
            this.tabRecruitment.Controls.Add(this.txtOfferLetterPath);
            this.tabRecruitment.Controls.Add(this.dgvRecruitments);
            this.tabRecruitment.Controls.Add(this.btnAddRecruitment);
            this.tabRecruitment.Controls.Add(this.btnUpdateRecruitment);
            this.tabRecruitment.Controls.Add(this.btnDeleteRecruitment);
            this.tabRecruitment.Controls.Add(this.btnExportRecruitments);
            
            // Add file buttons to Recruitment tab
            this.tabRecruitment.Controls.Add(this.btnBrowseJobApplication);
            this.tabRecruitment.Controls.Add(this.btnOpenJobApplication);
            this.tabRecruitment.Controls.Add(this.btnBrowseResume);
            this.tabRecruitment.Controls.Add(this.btnOpenResume);
            this.tabRecruitment.Controls.Add(this.btnBrowseDegrees);
            this.tabRecruitment.Controls.Add(this.btnOpenDegrees);
            this.tabRecruitment.Controls.Add(this.btnBrowseHealthCheck);
            this.tabRecruitment.Controls.Add(this.btnOpenHealthCheck);
            this.tabRecruitment.Controls.Add(this.btnBrowseCV);
            this.tabRecruitment.Controls.Add(this.btnOpenCV);
            this.tabRecruitment.Controls.Add(this.btnBrowseReferenceLetter);
            this.tabRecruitment.Controls.Add(this.btnOpenReferenceLetter);
            this.tabRecruitment.Controls.Add(this.btnBrowseInterviewMinutes);
            this.tabRecruitment.Controls.Add(this.btnOpenInterviewMinutes);
            this.tabRecruitment.Controls.Add(this.btnBrowseOfferLetter);
            this.tabRecruitment.Controls.Add(this.btnOpenOfferLetter);
            this.tabRecruitment.Location = new System.Drawing.Point(4, 22);
            this.tabRecruitment.Name = "tabRecruitment";
            this.tabRecruitment.Size = new System.Drawing.Size(1172, 554);
            this.tabRecruitment.Text = "Tuyển dụng";
            this.tabRecruitment.UseVisualStyleBackColor = true;

            // Recruitment Controls Layout (Two Columns)
            this.lblRecruitmentId.Text = "Mã tuyển dụng:";
            this.lblRecruitmentId.Location = new System.Drawing.Point(10, 10);
            this.lblRecruitmentId.Size = new System.Drawing.Size(100, 20);
            this.txtRecruitmentId.Location = new System.Drawing.Point(120, 10);
            this.txtRecruitmentId.Size = new System.Drawing.Size(200, 20);
            this.txtRecruitmentId.TabIndex = 0;

            this.lblRecruitmentEmployee.Text = "Nhân viên:";
            this.lblRecruitmentEmployee.Location = new System.Drawing.Point(10, 40);
            this.lblRecruitmentEmployee.Size = new System.Drawing.Size(100, 20);
            this.cbRecruitmentEmployee.Location = new System.Drawing.Point(120, 40);
            this.cbRecruitmentEmployee.Size = new System.Drawing.Size(200, 20);
            this.cbRecruitmentEmployee.TabIndex = 1;

            this.lblJobApplicationPath.Text = "Đường dẫn đơn xin việc:";
            this.lblJobApplicationPath.Location = new System.Drawing.Point(10, 70);
            this.lblJobApplicationPath.Size = new System.Drawing.Size(100, 20);
            this.txtJobApplicationPath.Location = new System.Drawing.Point(120, 70);
            this.txtJobApplicationPath.Size = new System.Drawing.Size(200, 20);
            this.txtJobApplicationPath.TabIndex = 2;

            this.lblResumePath.Text = "Đường dẫn CV:";
            this.lblResumePath.Location = new System.Drawing.Point(10, 100);
            this.lblResumePath.Size = new System.Drawing.Size(100, 20);
            this.txtResumePath.Location = new System.Drawing.Point(120, 100);
            this.txtResumePath.Size = new System.Drawing.Size(200, 20);
            this.txtResumePath.TabIndex = 3;

            this.lblDegreesPath.Text = "Đường dẫn bằng cấp:";
            this.lblDegreesPath.Location = new System.Drawing.Point(10, 130);
            this.lblDegreesPath.Size = new System.Drawing.Size(100, 20);
            this.txtDegreesPath.Location = new System.Drawing.Point(120, 130);
            this.txtDegreesPath.Size = new System.Drawing.Size(200, 20);
            this.txtDegreesPath.TabIndex = 4;

            this.lblHealthCheckPath.Text = "Đường dẫn khám sức khỏe:";
            this.lblHealthCheckPath.Location = new System.Drawing.Point(10, 160);
            this.lblHealthCheckPath.Size = new System.Drawing.Size(100, 20);
            this.txtHealthCheckPath.Location = new System.Drawing.Point(120, 160);
            this.txtHealthCheckPath.Size = new System.Drawing.Size(200, 20);
            this.txtHealthCheckPath.TabIndex = 5;

            this.lblCVPath.Text = "Đường dẫn CV:";
            this.lblCVPath.Location = new System.Drawing.Point(330, 10);
            this.lblCVPath.Size = new System.Drawing.Size(100, 20);
            this.txtCVPath.Location = new System.Drawing.Point(440, 10);
            this.txtCVPath.Size = new System.Drawing.Size(200, 20);
            this.txtCVPath.TabIndex = 6;

            this.lblReferenceLetterPath.Text = "Đường dẫn thư giới thiệu:";
            this.lblReferenceLetterPath.Location = new System.Drawing.Point(330, 40);
            this.lblReferenceLetterPath.Size = new System.Drawing.Size(100, 20);
            this.txtReferenceLetterPath.Location = new System.Drawing.Point(440, 40);
            this.txtReferenceLetterPath.Size = new System.Drawing.Size(200, 20);
            this.txtReferenceLetterPath.TabIndex = 7;

            this.lblInterviewMinutesPath.Text = "Đường dẫn biên bản phỏng vấn:";
            this.lblInterviewMinutesPath.Location = new System.Drawing.Point(330, 70);
            this.lblInterviewMinutesPath.Size = new System.Drawing.Size(100, 20);
            this.txtInterviewMinutesPath.Location = new System.Drawing.Point(440, 70);
            this.txtInterviewMinutesPath.Size = new System.Drawing.Size(200, 20);
            this.txtInterviewMinutesPath.TabIndex = 8;

            this.lblOfferLetterPath.Text = "Đường dẫn thư mời làm việc:";
            this.lblOfferLetterPath.Location = new System.Drawing.Point(330, 100);
            this.lblOfferLetterPath.Size = new System.Drawing.Size(100, 20);
            this.txtOfferLetterPath.Location = new System.Drawing.Point(440, 100);
            this.txtOfferLetterPath.Size = new System.Drawing.Size(200, 20);
            this.txtOfferLetterPath.TabIndex = 9;

            this.dgvRecruitments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecruitments.Location = new System.Drawing.Point(10, 190);
            this.dgvRecruitments.Name = "dgvRecruitments";
            this.dgvRecruitments.Size = new System.Drawing.Size(1150, 150);
            this.dgvRecruitments.TabIndex = 10;
            this.dgvRecruitments.SelectionChanged += new System.EventHandler(this.dgvRecruitments_SelectionChanged);

            this.btnAddRecruitment.Text = "Thêm";
            this.btnAddRecruitment.Location = new System.Drawing.Point(10, 350);
            this.btnAddRecruitment.Size = new System.Drawing.Size(100, 30);
            this.btnAddRecruitment.TabIndex = 11;
            this.btnAddRecruitment.UseVisualStyleBackColor = true;
            this.btnAddRecruitment.Click += new System.EventHandler(this.btnAddRecruitment_Click);

            this.btnUpdateRecruitment.Text = "Cập nhật";
            this.btnUpdateRecruitment.Location = new System.Drawing.Point(120, 350);
            this.btnUpdateRecruitment.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateRecruitment.TabIndex = 12;
            this.btnUpdateRecruitment.UseVisualStyleBackColor = true;
            this.btnUpdateRecruitment.Click += new System.EventHandler(this.btnUpdateRecruitment_Click);

            this.btnDeleteRecruitment.Text = "Xóa";
            this.btnDeleteRecruitment.Location = new System.Drawing.Point(230, 350);
            this.btnDeleteRecruitment.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteRecruitment.TabIndex = 13;
            this.btnDeleteRecruitment.UseVisualStyleBackColor = true;
            this.btnDeleteRecruitment.Click += new System.EventHandler(this.btnDeleteRecruitment_Click);

            this.btnExportRecruitments.Text = "Xuất Excel";
            this.btnExportRecruitments.Location = new System.Drawing.Point(340, 350);
            this.btnExportRecruitments.Size = new System.Drawing.Size(100, 30);
            this.btnExportRecruitments.TabIndex = 14;
            this.btnExportRecruitments.UseVisualStyleBackColor = true;
            this.btnExportRecruitments.Click += new System.EventHandler(this.btnExportRecruitments_Click);

            // Recruitment file buttons configuration
            this.btnBrowseJobApplication.Text = "Chọn file";
            this.btnBrowseJobApplication.Location = new System.Drawing.Point(330, 70);
            this.btnBrowseJobApplication.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseJobApplication.TabIndex = 15;
            this.btnBrowseJobApplication.UseVisualStyleBackColor = true;
            this.btnBrowseJobApplication.Click += new System.EventHandler(this.btnBrowseJobApplication_Click);

            this.btnOpenJobApplication.Text = "Mở";
            this.btnOpenJobApplication.Location = new System.Drawing.Point(400, 70);
            this.btnOpenJobApplication.Size = new System.Drawing.Size(60, 20);
            this.btnOpenJobApplication.TabIndex = 16;
            this.btnOpenJobApplication.UseVisualStyleBackColor = true;
            this.btnOpenJobApplication.Click += new System.EventHandler(this.btnOpenJobApplication_Click);

            this.btnBrowseResume.Text = "Chọn file";
            this.btnBrowseResume.Location = new System.Drawing.Point(330, 100);
            this.btnBrowseResume.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseResume.TabIndex = 17;
            this.btnBrowseResume.UseVisualStyleBackColor = true;
            this.btnBrowseResume.Click += new System.EventHandler(this.btnBrowseResume_Click);

            this.btnOpenResume.Text = "Mở";
            this.btnOpenResume.Location = new System.Drawing.Point(400, 100);
            this.btnOpenResume.Size = new System.Drawing.Size(60, 20);
            this.btnOpenResume.TabIndex = 18;
            this.btnOpenResume.UseVisualStyleBackColor = true;
            this.btnOpenResume.Click += new System.EventHandler(this.btnOpenResume_Click);

            this.btnBrowseDegrees.Text = "Chọn file";
            this.btnBrowseDegrees.Location = new System.Drawing.Point(330, 130);
            this.btnBrowseDegrees.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseDegrees.TabIndex = 19;
            this.btnBrowseDegrees.UseVisualStyleBackColor = true;
            this.btnBrowseDegrees.Click += new System.EventHandler(this.btnBrowseDegrees_Click);

            this.btnOpenDegrees.Text = "Mở";
            this.btnOpenDegrees.Location = new System.Drawing.Point(400, 130);
            this.btnOpenDegrees.Size = new System.Drawing.Size(60, 20);
            this.btnOpenDegrees.TabIndex = 20;
            this.btnOpenDegrees.UseVisualStyleBackColor = true;
            this.btnOpenDegrees.Click += new System.EventHandler(this.btnOpenDegrees_Click);

            this.btnBrowseHealthCheck.Text = "Chọn file";
            this.btnBrowseHealthCheck.Location = new System.Drawing.Point(330, 160);
            this.btnBrowseHealthCheck.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseHealthCheck.TabIndex = 21;
            this.btnBrowseHealthCheck.UseVisualStyleBackColor = true;
            this.btnBrowseHealthCheck.Click += new System.EventHandler(this.btnBrowseHealthCheck_Click);

            this.btnOpenHealthCheck.Text = "Mở";
            this.btnOpenHealthCheck.Location = new System.Drawing.Point(400, 160);
            this.btnOpenHealthCheck.Size = new System.Drawing.Size(60, 20);
            this.btnOpenHealthCheck.TabIndex = 22;
            this.btnOpenHealthCheck.UseVisualStyleBackColor = true;
            this.btnOpenHealthCheck.Click += new System.EventHandler(this.btnOpenHealthCheck_Click);

            this.btnBrowseCV.Text = "Chọn file";
            this.btnBrowseCV.Location = new System.Drawing.Point(650, 10);
            this.btnBrowseCV.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseCV.TabIndex = 23;
            this.btnBrowseCV.UseVisualStyleBackColor = true;
            this.btnBrowseCV.Click += new System.EventHandler(this.btnBrowseCV_Click);

            this.btnOpenCV.Text = "Mở";
            this.btnOpenCV.Location = new System.Drawing.Point(720, 10);
            this.btnOpenCV.Size = new System.Drawing.Size(60, 20);
            this.btnOpenCV.TabIndex = 24;
            this.btnOpenCV.UseVisualStyleBackColor = true;
            this.btnOpenCV.Click += new System.EventHandler(this.btnOpenCV_Click);

            this.btnBrowseReferenceLetter.Text = "Chọn file";
            this.btnBrowseReferenceLetter.Location = new System.Drawing.Point(650, 40);
            this.btnBrowseReferenceLetter.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseReferenceLetter.TabIndex = 25;
            this.btnBrowseReferenceLetter.UseVisualStyleBackColor = true;
            this.btnBrowseReferenceLetter.Click += new System.EventHandler(this.btnBrowseReferenceLetter_Click);

            this.btnOpenReferenceLetter.Text = "Mở";
            this.btnOpenReferenceLetter.Location = new System.Drawing.Point(720, 40);
            this.btnOpenReferenceLetter.Size = new System.Drawing.Size(60, 20);
            this.btnOpenReferenceLetter.TabIndex = 26;
            this.btnOpenReferenceLetter.UseVisualStyleBackColor = true;
            this.btnOpenReferenceLetter.Click += new System.EventHandler(this.btnOpenReferenceLetter_Click);

            this.btnBrowseInterviewMinutes.Text = "Chọn file";
            this.btnBrowseInterviewMinutes.Location = new System.Drawing.Point(650, 70);
            this.btnBrowseInterviewMinutes.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseInterviewMinutes.TabIndex = 27;
            this.btnBrowseInterviewMinutes.UseVisualStyleBackColor = true;
            this.btnBrowseInterviewMinutes.Click += new System.EventHandler(this.btnBrowseInterviewMinutes_Click);

            this.btnOpenInterviewMinutes.Text = "Mở";
            this.btnOpenInterviewMinutes.Location = new System.Drawing.Point(720, 70);
            this.btnOpenInterviewMinutes.Size = new System.Drawing.Size(60, 20);
            this.btnOpenInterviewMinutes.TabIndex = 28;
            this.btnOpenInterviewMinutes.UseVisualStyleBackColor = true;
            this.btnOpenInterviewMinutes.Click += new System.EventHandler(this.btnOpenInterviewMinutes_Click);

            this.btnBrowseOfferLetter.Text = "Chọn file";
            this.btnBrowseOfferLetter.Location = new System.Drawing.Point(650, 100);
            this.btnBrowseOfferLetter.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseOfferLetter.TabIndex = 29;
            this.btnBrowseOfferLetter.UseVisualStyleBackColor = true;
            this.btnBrowseOfferLetter.Click += new System.EventHandler(this.btnBrowseOfferLetter_Click);

            this.btnOpenOfferLetter.Text = "Mở";
            this.btnOpenOfferLetter.Location = new System.Drawing.Point(720, 100);
            this.btnOpenOfferLetter.Size = new System.Drawing.Size(60, 20);
            this.btnOpenOfferLetter.TabIndex = 30;
            this.btnOpenOfferLetter.UseVisualStyleBackColor = true;
            this.btnOpenOfferLetter.Click += new System.EventHandler(this.btnOpenOfferLetter_Click);

            // 
            // tabSalary
            // 
            this.tabSalary.Controls.Add(this.lblSalaryId);
            this.tabSalary.Controls.Add(this.txtSalaryId);
            this.tabSalary.Controls.Add(this.lblSalaryEmployee);
            this.tabSalary.Controls.Add(this.cbSalaryEmployee);
            this.tabSalary.Controls.Add(this.lblMonthlySalary);
            this.tabSalary.Controls.Add(this.txtMonthlySalary);
            this.tabSalary.Controls.Add(this.lblPaySlipPath);
            this.tabSalary.Controls.Add(this.txtPaySlipPath);
            this.tabSalary.Controls.Add(this.lblSalaryIncreaseDecisionPath);
            this.tabSalary.Controls.Add(this.txtSalaryIncreaseDecisionPath);
            this.tabSalary.Controls.Add(this.lblBankAccount);
            this.tabSalary.Controls.Add(this.txtBankAccount);
            this.tabSalary.Controls.Add(this.lblInsuranceInfo);
            this.tabSalary.Controls.Add(this.txtInsuranceInfo);
            this.tabSalary.Controls.Add(this.lblAllowances);
            this.tabSalary.Controls.Add(this.txtAllowances);
            this.tabSalary.Controls.Add(this.lblBonuses);
            this.tabSalary.Controls.Add(this.txtBonuses);
            this.tabSalary.Controls.Add(this.lblLeavePolicy);
            this.tabSalary.Controls.Add(this.txtLeavePolicy);
            this.tabSalary.Controls.Add(this.dgvSalaries);
            this.tabSalary.Controls.Add(this.btnAddSalary);
            this.tabSalary.Controls.Add(this.btnUpdateSalary);
            this.tabSalary.Controls.Add(this.btnDeleteSalary);
            this.tabSalary.Controls.Add(this.btnExportSalaries);
            
            // Add file buttons to Salary tab
            this.tabSalary.Controls.Add(this.btnBrowsePaySlip);
            this.tabSalary.Controls.Add(this.btnOpenPaySlip);
            this.tabSalary.Location = new System.Drawing.Point(4, 22);
            this.tabSalary.Name = "tabSalary";
            this.tabSalary.Size = new System.Drawing.Size(1172, 554);
            this.tabSalary.Text = "Lương";
            this.tabSalary.UseVisualStyleBackColor = true;

            // Salary Controls Layout (Two Columns)
            this.lblSalaryId.Text = "Mã lương:";
            this.lblSalaryId.Location = new System.Drawing.Point(10, 10);
            this.lblSalaryId.Size = new System.Drawing.Size(100, 20);
            this.txtSalaryId.Location = new System.Drawing.Point(120, 10);
            this.txtSalaryId.Size = new System.Drawing.Size(200, 20);
            this.txtSalaryId.TabIndex = 0;

            this.lblSalaryEmployee.Text = "Nhân viên:";
            this.lblSalaryEmployee.Location = new System.Drawing.Point(10, 40);
            this.lblSalaryEmployee.Size = new System.Drawing.Size(100, 20);
            this.cbSalaryEmployee.Location = new System.Drawing.Point(120, 40);
            this.cbSalaryEmployee.Size = new System.Drawing.Size(200, 20);
            this.cbSalaryEmployee.TabIndex = 1;

            this.lblMonthlySalary.Text = "Lương tháng:";
            this.lblMonthlySalary.Location = new System.Drawing.Point(10, 70);
            this.lblMonthlySalary.Size = new System.Drawing.Size(100, 20);
            this.txtMonthlySalary.Location = new System.Drawing.Point(120, 70);
            this.txtMonthlySalary.Size = new System.Drawing.Size(200, 20);
            this.txtMonthlySalary.TabIndex = 2;

            this.lblPaySlipPath.Text = "Đường dẫn phiếu lương:";
            this.lblPaySlipPath.Location = new System.Drawing.Point(10, 100);
            this.lblPaySlipPath.Size = new System.Drawing.Size(100, 20);
            this.txtPaySlipPath.Location = new System.Drawing.Point(120, 100);
            this.txtPaySlipPath.Size = new System.Drawing.Size(200, 20);
            this.txtPaySlipPath.TabIndex = 3;

            this.lblSalaryIncreaseDecisionPath.Text = "Đường dẫn quyết định tăng lương:";
            this.lblSalaryIncreaseDecisionPath.Location = new System.Drawing.Point(10, 130);
            this.lblSalaryIncreaseDecisionPath.Size = new System.Drawing.Size(100, 20);
            this.txtSalaryIncreaseDecisionPath.Location = new System.Drawing.Point(120, 130);
            this.txtSalaryIncreaseDecisionPath.Size = new System.Drawing.Size(200, 20);
            this.txtSalaryIncreaseDecisionPath.TabIndex = 4;

            this.lblBankAccount.Text = "Tài khoản ngân hàng:";
            this.lblBankAccount.Location = new System.Drawing.Point(330, 10);
            this.lblBankAccount.Size = new System.Drawing.Size(100, 20);
            this.txtBankAccount.Location = new System.Drawing.Point(440, 10);
            this.txtBankAccount.Size = new System.Drawing.Size(200, 20);
            this.txtBankAccount.TabIndex = 5;

            this.lblInsuranceInfo.Text = "Thông tin bảo hiểm:";
            this.lblInsuranceInfo.Location = new System.Drawing.Point(330, 40);
            this.lblInsuranceInfo.Size = new System.Drawing.Size(100, 20);
            this.txtInsuranceInfo.Location = new System.Drawing.Point(440, 40);
            this.txtInsuranceInfo.Size = new System.Drawing.Size(200, 20);
            this.txtInsuranceInfo.TabIndex = 6;

            this.lblAllowances.Text = "Phụ cấp:";
            this.lblAllowances.Location = new System.Drawing.Point(330, 70);
            this.lblAllowances.Size = new System.Drawing.Size(100, 20);
            this.txtAllowances.Location = new System.Drawing.Point(440, 70);
            this.txtAllowances.Size = new System.Drawing.Size(200, 20);
            this.txtAllowances.TabIndex = 7;

            this.lblBonuses.Text = "Thưởng:";
            this.lblBonuses.Location = new System.Drawing.Point(330, 100);
            this.lblBonuses.Size = new System.Drawing.Size(100, 20);
            this.txtBonuses.Location = new System.Drawing.Point(440, 100);
            this.txtBonuses.Size = new System.Drawing.Size(200, 20);
            this.txtBonuses.TabIndex = 8;

            this.lblLeavePolicy.Text = "Chính sách nghỉ phép:";
            this.lblLeavePolicy.Location = new System.Drawing.Point(330, 130);
            this.lblLeavePolicy.Size = new System.Drawing.Size(100, 20);
            this.txtLeavePolicy.Location = new System.Drawing.Point(440, 130);
            this.txtLeavePolicy.Size = new System.Drawing.Size(200, 20);
            this.txtLeavePolicy.TabIndex = 9;

            this.dgvSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaries.Location = new System.Drawing.Point(10, 160);
            this.dgvSalaries.Name = "dgvSalaries";
            this.dgvSalaries.Size = new System.Drawing.Size(1150, 150);
            this.dgvSalaries.TabIndex = 10;
            this.dgvSalaries.SelectionChanged += new System.EventHandler(this.dgvSalaries_SelectionChanged);

            this.btnAddSalary.Text = "Thêm";
            this.btnAddSalary.Location = new System.Drawing.Point(10, 320);
            this.btnAddSalary.Size = new System.Drawing.Size(100, 30);
            this.btnAddSalary.TabIndex = 11;
            this.btnAddSalary.UseVisualStyleBackColor = true;
            this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);

            this.btnUpdateSalary.Text = "Cập nhật";
            this.btnUpdateSalary.Location = new System.Drawing.Point(120, 320);
            this.btnUpdateSalary.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateSalary.TabIndex = 12;
            this.btnUpdateSalary.UseVisualStyleBackColor = true;
            this.btnUpdateSalary.Click += new System.EventHandler(this.btnUpdateSalary_Click);

            this.btnDeleteSalary.Text = "Xóa";
            this.btnDeleteSalary.Location = new System.Drawing.Point(230, 320);
            this.btnDeleteSalary.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteSalary.TabIndex = 13;
            this.btnDeleteSalary.UseVisualStyleBackColor = true;
            this.btnDeleteSalary.Click += new System.EventHandler(this.btnDeleteSalary_Click);

            this.btnExportSalaries.Text = "Xuất Excel";
            this.btnExportSalaries.Location = new System.Drawing.Point(340, 320);
            this.btnExportSalaries.Size = new System.Drawing.Size(100, 30);
            this.btnExportSalaries.TabIndex = 14;
            this.btnExportSalaries.UseVisualStyleBackColor = true;
            this.btnExportSalaries.Click += new System.EventHandler(this.btnExportSalaries_Click);

            // Salary file buttons configuration
            this.btnBrowsePaySlip.Text = "Chọn file";
            this.btnBrowsePaySlip.Location = new System.Drawing.Point(330, 100);
            this.btnBrowsePaySlip.Size = new System.Drawing.Size(60, 20);
            this.btnBrowsePaySlip.TabIndex = 15;
            this.btnBrowsePaySlip.UseVisualStyleBackColor = true;
            this.btnBrowsePaySlip.Click += new System.EventHandler(this.btnBrowsePaySlip_Click);

            this.btnOpenPaySlip.Text = "Mở";
            this.btnOpenPaySlip.Location = new System.Drawing.Point(400, 100);
            this.btnOpenPaySlip.Size = new System.Drawing.Size(60, 20);
            this.btnOpenPaySlip.TabIndex = 16;
            this.btnOpenPaySlip.UseVisualStyleBackColor = true;
            this.btnOpenPaySlip.Click += new System.EventHandler(this.btnOpenPaySlip_Click);

            // 
            // tabTraining
            // 
            this.tabTraining.Controls.Add(this.lblTrainingId);
            this.tabTraining.Controls.Add(this.txtTrainingId);
            this.tabTraining.Controls.Add(this.lblTrainingEmployee);
            this.tabTraining.Controls.Add(this.cbTrainingEmployee);
            this.tabTraining.Controls.Add(this.lblTrainingPlanPath);
            this.tabTraining.Controls.Add(this.txtTrainingPlanPath);
            this.tabTraining.Controls.Add(this.lblCertificatePath);
            this.tabTraining.Controls.Add(this.txtCertificatePath);
            this.tabTraining.Controls.Add(this.lblEvaluationPath);
            this.tabTraining.Controls.Add(this.txtEvaluationPath);
            this.tabTraining.Controls.Add(this.lblCareerPath);
            this.tabTraining.Controls.Add(this.txtCareerPath);
            this.tabTraining.Controls.Add(this.lblSearchTraining);
            this.tabTraining.Controls.Add(this.txtSearchTraining);
            this.tabTraining.Controls.Add(this.btnSearchTraining);
            this.tabTraining.Controls.Add(this.dgvTrainings);
            this.tabTraining.Controls.Add(this.btnAddTraining);
            this.tabTraining.Controls.Add(this.btnUpdateTraining);
            this.tabTraining.Controls.Add(this.btnDeleteTraining);
            this.tabTraining.Controls.Add(this.btnExportTrainings);
            
            // Add file buttons to Training tab
            this.tabTraining.Controls.Add(this.btnBrowseTrainingPlan);
            this.tabTraining.Controls.Add(this.btnOpenTrainingPlan);
            this.tabTraining.Controls.Add(this.btnBrowseCertificate);
            this.tabTraining.Controls.Add(this.btnOpenCertificate);
            this.tabTraining.Controls.Add(this.btnBrowseEvaluation);
            this.tabTraining.Controls.Add(this.btnOpenEvaluation);
            this.tabTraining.Controls.Add(this.btnBrowseCareer);
            this.tabTraining.Controls.Add(this.btnOpenCareer);
            this.tabTraining.Location = new System.Drawing.Point(4, 22);
            this.tabTraining.Name = "tabTraining";
            this.tabTraining.Size = new System.Drawing.Size(1172, 554);
            this.tabTraining.Text = "Đào tạo";
            this.tabTraining.UseVisualStyleBackColor = true;

            // Training Controls Layout (Two Columns)
            this.lblTrainingId.Text = "Mã đào tạo:";
            this.lblTrainingId.Location = new System.Drawing.Point(10, 10);
            this.lblTrainingId.Size = new System.Drawing.Size(100, 20);
            this.txtTrainingId.Location = new System.Drawing.Point(120, 10);
            this.txtTrainingId.Size = new System.Drawing.Size(200, 20);
            this.txtTrainingId.TabIndex = 0;

            this.lblTrainingEmployee.Text = "Nhân viên:";
            this.lblTrainingEmployee.Location = new System.Drawing.Point(10, 40);
            this.lblTrainingEmployee.Size = new System.Drawing.Size(100, 20);
            this.cbTrainingEmployee.Location = new System.Drawing.Point(120, 40);
            this.cbTrainingEmployee.Size = new System.Drawing.Size(200, 20);
            this.cbTrainingEmployee.TabIndex = 1;

            this.lblTrainingPlanPath.Text = "Đường dẫn kế hoạch đào tạo:";
            this.lblTrainingPlanPath.Location = new System.Drawing.Point(10, 70);
            this.lblTrainingPlanPath.Size = new System.Drawing.Size(100, 20);
            this.txtTrainingPlanPath.Location = new System.Drawing.Point(120, 70);
            this.txtTrainingPlanPath.Size = new System.Drawing.Size(200, 20);
            this.txtTrainingPlanPath.TabIndex = 2;

            this.lblCertificatePath.Text = "Đường dẫn chứng chỉ:";
            this.lblCertificatePath.Location = new System.Drawing.Point(10, 100);
            this.lblCertificatePath.Size = new System.Drawing.Size(100, 20);
            this.txtCertificatePath.Location = new System.Drawing.Point(120, 100);
            this.txtCertificatePath.Size = new System.Drawing.Size(200, 20);
            this.txtCertificatePath.TabIndex = 3;

            this.lblEvaluationPath.Text = "Đường dẫn đánh giá:";
            this.lblEvaluationPath.Location = new System.Drawing.Point(10, 130);
            this.lblEvaluationPath.Size = new System.Drawing.Size(100, 20);
            this.txtEvaluationPath.Location = new System.Drawing.Point(120, 130);
            this.txtEvaluationPath.Size = new System.Drawing.Size(200, 20);
            this.txtEvaluationPath.TabIndex = 4;

            this.lblCareerPath.Text = "Đường dẫn lộ trình nghề nghiệp:";
            this.lblCareerPath.Location = new System.Drawing.Point(10, 160);
            this.lblCareerPath.Size = new System.Drawing.Size(100, 20);
            this.txtCareerPath.Location = new System.Drawing.Point(120, 160);
            this.txtCareerPath.Size = new System.Drawing.Size(200, 20);
            this.txtCareerPath.TabIndex = 5;

            this.lblSearchTraining.Text = "Tìm kiếm đào tạo:";
            this.lblSearchTraining.Location = new System.Drawing.Point(330, 10);
            this.lblSearchTraining.Size = new System.Drawing.Size(100, 20);
            this.txtSearchTraining.Location = new System.Drawing.Point(440, 10);
            this.txtSearchTraining.Size = new System.Drawing.Size(200, 20);
            this.txtSearchTraining.TabIndex = 6;

            this.btnSearchTraining.Text = "Tìm kiếm";
            this.btnSearchTraining.Location = new System.Drawing.Point(650, 10);
            this.btnSearchTraining.Size = new System.Drawing.Size(100, 30);
            this.btnSearchTraining.TabIndex = 7;
            this.btnSearchTraining.UseVisualStyleBackColor = true;
            this.btnSearchTraining.Click += new System.EventHandler(this.btnSearchTraining_Click);

            this.dgvTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainings.Location = new System.Drawing.Point(10, 190);
            this.dgvTrainings.Name = "dgvTrainings";
            this.dgvTrainings.Size = new System.Drawing.Size(1150, 150);
            this.dgvTrainings.TabIndex = 8;
            this.dgvTrainings.SelectionChanged += new System.EventHandler(this.dgvTrainings_SelectionChanged);

            this.btnAddTraining.Text = "Thêm";
            this.btnAddTraining.Location = new System.Drawing.Point(10, 350);
            this.btnAddTraining.Size = new System.Drawing.Size(100, 30);
            this.btnAddTraining.TabIndex = 9;
            this.btnAddTraining.UseVisualStyleBackColor = true;
            this.btnAddTraining.Click += new System.EventHandler(this.btnAddTraining_Click);

            this.btnUpdateTraining.Text = "Cập nhật";
            this.btnUpdateTraining.Location = new System.Drawing.Point(120, 350);
            this.btnUpdateTraining.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateTraining.TabIndex = 10;
            this.btnUpdateTraining.UseVisualStyleBackColor = true;
            this.btnUpdateTraining.Click += new System.EventHandler(this.btnUpdateTraining_Click);

            this.btnDeleteTraining.Text = "Xóa";
            this.btnDeleteTraining.Location = new System.Drawing.Point(230, 350);
            this.btnDeleteTraining.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteTraining.TabIndex = 11;
            this.btnDeleteTraining.UseVisualStyleBackColor = true;
            this.btnDeleteTraining.Click += new System.EventHandler(this.btnDeleteTraining_Click);

            this.btnExportTrainings.Text = "Xuất Excel";
            this.btnExportTrainings.Location = new System.Drawing.Point(340, 350);
            this.btnExportTrainings.Size = new System.Drawing.Size(100, 30);
            this.btnExportTrainings.TabIndex = 12;
            this.btnExportTrainings.UseVisualStyleBackColor = true;
            this.btnExportTrainings.Click += new System.EventHandler(this.btnExportTrainings_Click);

            // Training file buttons configuration
            this.btnBrowseTrainingPlan.Text = "Chọn file";
            this.btnBrowseTrainingPlan.Location = new System.Drawing.Point(330, 70);
            this.btnBrowseTrainingPlan.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseTrainingPlan.TabIndex = 13;
            this.btnBrowseTrainingPlan.UseVisualStyleBackColor = true;
            this.btnBrowseTrainingPlan.Click += new System.EventHandler(this.btnBrowseTrainingPlan_Click);

            this.btnOpenTrainingPlan.Text = "Mở";
            this.btnOpenTrainingPlan.Location = new System.Drawing.Point(400, 70);
            this.btnOpenTrainingPlan.Size = new System.Drawing.Size(60, 20);
            this.btnOpenTrainingPlan.TabIndex = 14;
            this.btnOpenTrainingPlan.UseVisualStyleBackColor = true;
            this.btnOpenTrainingPlan.Click += new System.EventHandler(this.btnOpenTrainingPlan_Click);

            this.btnBrowseCertificate.Text = "Chọn file";
            this.btnBrowseCertificate.Location = new System.Drawing.Point(330, 100);
            this.btnBrowseCertificate.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseCertificate.TabIndex = 15;
            this.btnBrowseCertificate.UseVisualStyleBackColor = true;
            this.btnBrowseCertificate.Click += new System.EventHandler(this.btnBrowseCertificate_Click);

            this.btnOpenCertificate.Text = "Mở";
            this.btnOpenCertificate.Location = new System.Drawing.Point(400, 100);
            this.btnOpenCertificate.Size = new System.Drawing.Size(60, 20);
            this.btnOpenCertificate.TabIndex = 16;
            this.btnOpenCertificate.UseVisualStyleBackColor = true;
            this.btnOpenCertificate.Click += new System.EventHandler(this.btnOpenCertificate_Click);

            this.btnBrowseEvaluation.Text = "Chọn file";
            this.btnBrowseEvaluation.Location = new System.Drawing.Point(330, 130);
            this.btnBrowseEvaluation.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseEvaluation.TabIndex = 17;
            this.btnBrowseEvaluation.UseVisualStyleBackColor = true;
            this.btnBrowseEvaluation.Click += new System.EventHandler(this.btnBrowseEvaluation_Click);

            this.btnOpenEvaluation.Text = "Mở";
            this.btnOpenEvaluation.Location = new System.Drawing.Point(400, 130);
            this.btnOpenEvaluation.Size = new System.Drawing.Size(60, 20);
            this.btnOpenEvaluation.TabIndex = 18;
            this.btnOpenEvaluation.UseVisualStyleBackColor = true;
            this.btnOpenEvaluation.Click += new System.EventHandler(this.btnOpenEvaluation_Click);

            this.btnBrowseCareer.Text = "Chọn file";
            this.btnBrowseCareer.Location = new System.Drawing.Point(330, 160);
            this.btnBrowseCareer.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseCareer.TabIndex = 19;
            this.btnBrowseCareer.UseVisualStyleBackColor = true;
            this.btnBrowseCareer.Click += new System.EventHandler(this.btnBrowseCareer_Click);

            this.btnOpenCareer.Text = "Mở";
            this.btnOpenCareer.Location = new System.Drawing.Point(400, 160);
            this.btnOpenCareer.Size = new System.Drawing.Size(60, 20);
            this.btnOpenCareer.TabIndex = 20;
            this.btnOpenCareer.UseVisualStyleBackColor = true;
            this.btnOpenCareer.Click += new System.EventHandler(this.btnOpenCareer_Click);

            // 
            // tabDiscipline
            // 
            this.tabDiscipline.Controls.Add(this.lblDisciplineId);
            this.tabDiscipline.Controls.Add(this.txtDisciplineId);
            this.tabDiscipline.Controls.Add(this.lblDisciplineEmployee);
            this.tabDiscipline.Controls.Add(this.cbDisciplineEmployee);
            this.tabDiscipline.Controls.Add(this.lblViolationPath);
            this.tabDiscipline.Controls.Add(this.txtViolationPath);
            this.tabDiscipline.Controls.Add(this.lblDisciplinaryDecisionPath);
            this.tabDiscipline.Controls.Add(this.txtDisciplinaryDecisionPath);
            this.tabDiscipline.Controls.Add(this.lblResignationLetterPath);
            this.tabDiscipline.Controls.Add(this.txtResignationLetterPath);
            this.tabDiscipline.Controls.Add(this.lblTerminationDecisionPath);
            this.tabDiscipline.Controls.Add(this.txtTerminationDecisionPath);
            this.tabDiscipline.Controls.Add(this.lblHandoverPath);
            this.tabDiscipline.Controls.Add(this.txtHandoverPath);
            this.tabDiscipline.Controls.Add(this.lblLiquidationPath);
            this.tabDiscipline.Controls.Add(this.txtLiquidationPath);
            this.tabDiscipline.Controls.Add(this.dgvDisciplines);
            this.tabDiscipline.Controls.Add(this.btnAddDiscipline);
            this.tabDiscipline.Controls.Add(this.btnUpdateDiscipline);
            this.tabDiscipline.Controls.Add(this.btnDeleteDiscipline);
            this.tabDiscipline.Controls.Add(this.btnExportDisciplines);
            
            // Add file buttons to Discipline tab
            this.tabDiscipline.Controls.Add(this.btnBrowseViolation);
            this.tabDiscipline.Controls.Add(this.btnOpenViolation);
            this.tabDiscipline.Controls.Add(this.btnBrowseDisciplinaryDecision);
            this.tabDiscipline.Controls.Add(this.btnOpenDisciplinaryDecision);
            this.tabDiscipline.Controls.Add(this.btnBrowseResignationLetter);
            this.tabDiscipline.Controls.Add(this.btnOpenResignationLetter);
            this.tabDiscipline.Controls.Add(this.btnBrowseTerminationDecision);
            this.tabDiscipline.Controls.Add(this.btnOpenTerminationDecision);
            this.tabDiscipline.Controls.Add(this.btnBrowseHandover);
            this.tabDiscipline.Controls.Add(this.btnOpenHandover);
            this.tabDiscipline.Controls.Add(this.btnBrowseLiquidation);
            this.tabDiscipline.Controls.Add(this.btnOpenLiquidation);
            this.tabDiscipline.Location = new System.Drawing.Point(4, 22);
            this.tabDiscipline.Name = "tabDiscipline";
            this.tabDiscipline.Size = new System.Drawing.Size(1172, 554);
            this.tabDiscipline.Text = "Kỷ luật";
            this.tabDiscipline.UseVisualStyleBackColor = true;

            // Discipline Controls Layout (Two Columns)
            this.lblDisciplineId.Text = "Mã kỷ luật:";
            this.lblDisciplineId.Location = new System.Drawing.Point(10, 10);
            this.lblDisciplineId.Size = new System.Drawing.Size(100, 20);
            this.txtDisciplineId.Location = new System.Drawing.Point(120, 10);
            this.txtDisciplineId.Size = new System.Drawing.Size(200, 20);
            this.txtDisciplineId.TabIndex = 0;

            this.lblDisciplineEmployee.Text = "Nhân viên:";
            this.lblDisciplineEmployee.Location = new System.Drawing.Point(10, 40);
            this.lblDisciplineEmployee.Size = new System.Drawing.Size(100, 20);
            this.cbDisciplineEmployee.Location = new System.Drawing.Point(120, 40);
            this.cbDisciplineEmployee.Size = new System.Drawing.Size(200, 20);
            this.cbDisciplineEmployee.TabIndex = 1;

            this.lblViolationPath.Text = "Đường dẫn vi phạm:";
            this.lblViolationPath.Location = new System.Drawing.Point(10, 70);
            this.lblViolationPath.Size = new System.Drawing.Size(100, 20);
            this.txtViolationPath.Location = new System.Drawing.Point(120, 70);
            this.txtViolationPath.Size = new System.Drawing.Size(200, 20);
            this.txtViolationPath.TabIndex = 2;

            this.lblDisciplinaryDecisionPath.Text = "Đường dẫn quyết định kỷ luật:";
            this.lblDisciplinaryDecisionPath.Location = new System.Drawing.Point(10, 100);
            this.lblDisciplinaryDecisionPath.Size = new System.Drawing.Size(100, 20);
            this.txtDisciplinaryDecisionPath.Location = new System.Drawing.Point(120, 100);
            this.txtDisciplinaryDecisionPath.Size = new System.Drawing.Size(200, 20);
            this.txtDisciplinaryDecisionPath.TabIndex = 3;

            this.lblResignationLetterPath.Text = "Đường dẫn đơn xin nghỉ việc:";
            this.lblResignationLetterPath.Location = new System.Drawing.Point(10, 130);
            this.lblResignationLetterPath.Size = new System.Drawing.Size(100, 20);
            this.txtResignationLetterPath.Location = new System.Drawing.Point(120, 130);
            this.txtResignationLetterPath.Size = new System.Drawing.Size(200, 20);
            this.txtResignationLetterPath.TabIndex = 4;

            this.lblTerminationDecisionPath.Text = "Đường dẫn quyết định chấm dứt hợp đồng:";
            this.lblTerminationDecisionPath.Location = new System.Drawing.Point(330, 10);
            this.lblTerminationDecisionPath.Size = new System.Drawing.Size(100, 20);
            this.txtTerminationDecisionPath.Location = new System.Drawing.Point(440, 10);
            this.txtTerminationDecisionPath.Size = new System.Drawing.Size(200, 20);
            this.txtTerminationDecisionPath.TabIndex = 5;

            this.lblHandoverPath.Text = "Đường dẫn bàn giao:";
            this.lblHandoverPath.Location = new System.Drawing.Point(330, 40);
            this.lblHandoverPath.Size = new System.Drawing.Size(100, 20);
            this.txtHandoverPath.Location = new System.Drawing.Point(440, 40);
            this.txtHandoverPath.Size = new System.Drawing.Size(200, 20);
            this.txtHandoverPath.TabIndex = 6;

            this.lblLiquidationPath.Text = "Đường dẫn thanh lý:";
            this.lblLiquidationPath.Location = new System.Drawing.Point(330, 70);
            this.lblLiquidationPath.Size = new System.Drawing.Size(100, 20);
            this.txtLiquidationPath.Location = new System.Drawing.Point(440, 70);
            this.txtLiquidationPath.Size = new System.Drawing.Size(200, 20);
            this.txtLiquidationPath.TabIndex = 7;

            this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplines.Location = new System.Drawing.Point(10, 160);
            this.dgvDisciplines.Name = "dgvDisciplines";
            this.dgvDisciplines.Size = new System.Drawing.Size(1150, 150);
            this.dgvDisciplines.TabIndex = 8;
            this.dgvDisciplines.SelectionChanged += new System.EventHandler(this.dgvDisciplines_SelectionChanged);

            this.btnAddDiscipline.Text = "Thêm";
            this.btnAddDiscipline.Location = new System.Drawing.Point(10, 320);
            this.btnAddDiscipline.Size = new System.Drawing.Size(100, 30);
            this.btnAddDiscipline.TabIndex = 9;
            this.btnAddDiscipline.UseVisualStyleBackColor = true;
            this.btnAddDiscipline.Click += new System.EventHandler(this.btnAddDiscipline_Click);


            this.btnUpdateDiscipline.Text = "Cập nhật";
            this.btnUpdateDiscipline.Location = new System.Drawing.Point(120, 320);
            this.btnUpdateDiscipline.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateDiscipline.TabIndex = 10;
            this.btnUpdateDiscipline.UseVisualStyleBackColor = true;
            this.btnUpdateDiscipline.Click += new System.EventHandler(this.btnUpdateDiscipline_Click);

            this.btnDeleteDiscipline.Text = "Xóa";
            this.btnDeleteDiscipline.Location = new System.Drawing.Point(230, 320);
            this.btnDeleteDiscipline.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteDiscipline.TabIndex = 11;
            this.btnDeleteDiscipline.UseVisualStyleBackColor = true;
            this.btnDeleteDiscipline.Click += new System.EventHandler(this.btnDeleteDiscipline_Click);

            this.btnExportDisciplines.Text = "Xuất Excel";
            this.btnExportDisciplines.Location = new System.Drawing.Point(340, 320);
            this.btnExportDisciplines.Size = new System.Drawing.Size(100, 30);
            this.btnExportDisciplines.TabIndex = 12;
            this.btnExportDisciplines.UseVisualStyleBackColor = true;
            this.btnExportDisciplines.Click += new System.EventHandler(this.btnExportDisciplines_Click);

            // Discipline file buttons configuration
            this.btnBrowseViolation.Text = "Chọn file";
            this.btnBrowseViolation.Location = new System.Drawing.Point(330, 70);
            this.btnBrowseViolation.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseViolation.TabIndex = 13;
            this.btnBrowseViolation.UseVisualStyleBackColor = true;
            this.btnBrowseViolation.Click += new System.EventHandler(this.btnBrowseViolation_Click);

            this.btnOpenViolation.Text = "Mở";
            this.btnOpenViolation.Location = new System.Drawing.Point(400, 70);
            this.btnOpenViolation.Size = new System.Drawing.Size(60, 20);
            this.btnOpenViolation.TabIndex = 14;
            this.btnOpenViolation.UseVisualStyleBackColor = true;
            this.btnOpenViolation.Click += new System.EventHandler(this.btnOpenViolation_Click);

            this.btnBrowseDisciplinaryDecision.Text = "Chọn file";
            this.btnBrowseDisciplinaryDecision.Location = new System.Drawing.Point(330, 100);
            this.btnBrowseDisciplinaryDecision.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseDisciplinaryDecision.TabIndex = 15;
            this.btnBrowseDisciplinaryDecision.UseVisualStyleBackColor = true;
            this.btnBrowseDisciplinaryDecision.Click += new System.EventHandler(this.btnBrowseDisciplinaryDecision_Click);

            this.btnOpenDisciplinaryDecision.Text = "Mở";
            this.btnOpenDisciplinaryDecision.Location = new System.Drawing.Point(400, 100);
            this.btnOpenDisciplinaryDecision.Size = new System.Drawing.Size(60, 20);
            this.btnOpenDisciplinaryDecision.TabIndex = 16;
            this.btnOpenDisciplinaryDecision.UseVisualStyleBackColor = true;
            this.btnOpenDisciplinaryDecision.Click += new System.EventHandler(this.btnOpenDisciplinaryDecision_Click);

            this.btnBrowseResignationLetter.Text = "Chọn file";
            this.btnBrowseResignationLetter.Location = new System.Drawing.Point(330, 130);
            this.btnBrowseResignationLetter.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseResignationLetter.TabIndex = 17;
            this.btnBrowseResignationLetter.UseVisualStyleBackColor = true;
            this.btnBrowseResignationLetter.Click += new System.EventHandler(this.btnBrowseResignationLetter_Click);

            this.btnOpenResignationLetter.Text = "Mở";
            this.btnOpenResignationLetter.Location = new System.Drawing.Point(400, 130);
            this.btnOpenResignationLetter.Size = new System.Drawing.Size(60, 20);
            this.btnOpenResignationLetter.TabIndex = 18;
            this.btnOpenResignationLetter.UseVisualStyleBackColor = true;
            this.btnOpenResignationLetter.Click += new System.EventHandler(this.btnOpenResignationLetter_Click);

            this.btnBrowseTerminationDecision.Text = "Chọn file";
            this.btnBrowseTerminationDecision.Location = new System.Drawing.Point(550, 10);
            this.btnBrowseTerminationDecision.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseTerminationDecision.TabIndex = 19;
            this.btnBrowseTerminationDecision.UseVisualStyleBackColor = true;
            this.btnBrowseTerminationDecision.Click += new System.EventHandler(this.btnBrowseTerminationDecision_Click);

            this.btnOpenTerminationDecision.Text = "Mở";
            this.btnOpenTerminationDecision.Location = new System.Drawing.Point(620, 10);
            this.btnOpenTerminationDecision.Size = new System.Drawing.Size(60, 20);
            this.btnOpenTerminationDecision.TabIndex = 20;
            this.btnOpenTerminationDecision.UseVisualStyleBackColor = true;
            this.btnOpenTerminationDecision.Click += new System.EventHandler(this.btnOpenTerminationDecision_Click);

            this.btnBrowseHandover.Text = "Chọn file";
            this.btnBrowseHandover.Location = new System.Drawing.Point(550, 40);
            this.btnBrowseHandover.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseHandover.TabIndex = 21;
            this.btnBrowseHandover.UseVisualStyleBackColor = true;
            this.btnBrowseHandover.Click += new System.EventHandler(this.btnBrowseHandover_Click);

            this.btnOpenHandover.Text = "Mở";
            this.btnOpenHandover.Location = new System.Drawing.Point(620, 40);
            this.btnOpenHandover.Size = new System.Drawing.Size(60, 20);
            this.btnOpenHandover.TabIndex = 22;
            this.btnOpenHandover.UseVisualStyleBackColor = true;
            this.btnOpenHandover.Click += new System.EventHandler(this.btnOpenHandover_Click);

            this.btnBrowseLiquidation.Text = "Chọn file";
            this.btnBrowseLiquidation.Location = new System.Drawing.Point(550, 70);
            this.btnBrowseLiquidation.Size = new System.Drawing.Size(60, 20);
            this.btnBrowseLiquidation.TabIndex = 23;
            this.btnBrowseLiquidation.UseVisualStyleBackColor = true;
            this.btnBrowseLiquidation.Click += new System.EventHandler(this.btnBrowseLiquidation_Click);

            this.btnOpenLiquidation.Text = "Mở";
            this.btnOpenLiquidation.Location = new System.Drawing.Point(620, 70);
            this.btnOpenLiquidation.Size = new System.Drawing.Size(60, 20);
            this.btnOpenLiquidation.TabIndex = 24;
            this.btnOpenLiquidation.UseVisualStyleBackColor = true;
            this.btnOpenLiquidation.Click += new System.EventHandler(this.btnOpenLiquidation_Click);

            // 
            // HRManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.tabControl);
            this.Name = "HRManagementForm";
            this.Text = "Hệ thống quản lý nhân sự";
            this.Load += new System.EventHandler(this.HRManagementForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            this.tabContract.ResumeLayout(false);
            this.tabContract.PerformLayout();
            this.tabAttendance.ResumeLayout(false);
            this.tabAttendance.PerformLayout();
            this.tabRecruitment.ResumeLayout(false);
            this.tabRecruitment.PerformLayout();
            this.tabSalary.ResumeLayout(false);
            this.tabSalary.PerformLayout();
            this.tabTraining.ResumeLayout(false);
            this.tabTraining.PerformLayout();
            this.tabDiscipline.ResumeLayout(false);
            this.tabDiscipline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecruitments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
            this.ResumeLayout(false);
        }

        private void HRManagementForm_Load(object sender, EventArgs e)
        {
            // Example: Load employee data
            // Add similar calls for other tabs
        }

        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage tabEmployee;
        public System.Windows.Forms.TabPage tabContract;
        public System.Windows.Forms.TabPage tabAttendance;
        public System.Windows.Forms.TabPage tabRecruitment;
        public System.Windows.Forms.TabPage tabSalary;
        public System.Windows.Forms.TabPage tabTraining;
        public System.Windows.Forms.TabPage tabDiscipline;

        // Employee Controls
        public System.Windows.Forms.Label lblEmployeeId;
        public System.Windows.Forms.TextBox txtEmployeeId;
        public System.Windows.Forms.Label lblEmployeeName;
        public System.Windows.Forms.TextBox txtEmployeeName;
        public System.Windows.Forms.Label lblDOB;
        public System.Windows.Forms.DateTimePicker dtpDOB;
        public System.Windows.Forms.Label lblGender;
        public System.Windows.Forms.ComboBox cbGender;
        public System.Windows.Forms.Label lblNationality;
        public System.Windows.Forms.TextBox txtNationality;
        public System.Windows.Forms.Label lblCCCD;
        public System.Windows.Forms.TextBox txtCCCD;
        public System.Windows.Forms.Label lblCCCDIssueDate;
        public System.Windows.Forms.DateTimePicker dtpCCCDIssueDate;
        public System.Windows.Forms.Label lblCCCDIssuePlace;
        public System.Windows.Forms.TextBox txtCCCDIssuePlace;
        public System.Windows.Forms.Label lblPermanentAddress;
        public System.Windows.Forms.TextBox txtPermanentAddress;
        public System.Windows.Forms.Label lblCurrentAddress;
        public System.Windows.Forms.TextBox txtCurrentAddress;
        public System.Windows.Forms.Label lblPhone;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Label lblMaritalStatus;
        public System.Windows.Forms.ComboBox cbMaritalStatus;
        public System.Windows.Forms.Label lblDependents;
        public System.Windows.Forms.TextBox txtDependents;
        public System.Windows.Forms.Label lblSocialInsuranceNumber;
        public System.Windows.Forms.TextBox txtSocialInsuranceNumber;
        public System.Windows.Forms.Label lblTaxCode;
        public System.Windows.Forms.TextBox txtTaxCode;
        public System.Windows.Forms.Label lblJobDescription;
        public System.Windows.Forms.TextBox txtJobDescription;
        public System.Windows.Forms.Label lblPosition;
        public System.Windows.Forms.TextBox txtPosition;
        public System.Windows.Forms.Label lblDepartment;
        public System.Windows.Forms.TextBox txtDepartment;
        public System.Windows.Forms.Label lblRank;
        public System.Windows.Forms.TextBox txtRank;
        public System.Windows.Forms.Label lblManager;
        public System.Windows.Forms.TextBox txtManager;
        public System.Windows.Forms.Label lblWorkSchedule;
        public System.Windows.Forms.TextBox txtWorkSchedule;
        public System.Windows.Forms.DataGridView dgvEmployees;
        public System.Windows.Forms.Button btnAddEmployee;
        public System.Windows.Forms.Button btnUpdateEmployee;
        public System.Windows.Forms.Button btnDeleteEmployee;
        public System.Windows.Forms.Button btnExportEmployees;

        // Contract Controls
        public System.Windows.Forms.Label lblContractId;
        public System.Windows.Forms.TextBox txtContractId;
        public System.Windows.Forms.Label lblContractEmployee;
        public System.Windows.Forms.ComboBox cbContractEmployee;
        public System.Windows.Forms.Label lblStartDate;
        public System.Windows.Forms.DateTimePicker dtpStartDate;
        public System.Windows.Forms.Label lblEndDate;
        public System.Windows.Forms.DateTimePicker dtpEndDate;
        public System.Windows.Forms.Label lblContractType;
        public System.Windows.Forms.ComboBox cbContractType;
        public System.Windows.Forms.Label lblContractAnnexPath;
        public System.Windows.Forms.TextBox txtContractAnnexPath;
        public System.Windows.Forms.Label lblConfidentialityAgreementPath;
        public System.Windows.Forms.TextBox txtConfidentialityAgreementPath;
        public System.Windows.Forms.Label lblNonCompeteAgreementPath;
        public System.Windows.Forms.TextBox txtNonCompeteAgreementPath;
        public System.Windows.Forms.Label lblAppointmentDecisionPath;
        public System.Windows.Forms.TextBox txtAppointmentDecisionPath;
        public System.Windows.Forms.Label lblSalaryIncreaseDecisionPath;
        public System.Windows.Forms.TextBox txtSalaryIncreaseDecisionPath;
        public System.Windows.Forms.Label lblRewardDecisionPath;
        public System.Windows.Forms.TextBox txtRewardDecisionPath;
        public System.Windows.Forms.DataGridView dgvContracts;
        public System.Windows.Forms.Button btnAddContract;
        public System.Windows.Forms.Button btnUpdateContract;
        public System.Windows.Forms.Button btnDeleteContract;
        public System.Windows.Forms.Button btnExportContracts;
        public System.Windows.Forms.Button btnBrowseContractAnnex;
        public System.Windows.Forms.Button btnOpenContractAnnex;
        public System.Windows.Forms.Button btnBrowseConfidentiality;
        public System.Windows.Forms.Button btnOpenConfidentiality;
        public System.Windows.Forms.Button btnBrowseNonCompete;
        public System.Windows.Forms.Button btnOpenNonCompete;
        public System.Windows.Forms.Button btnBrowseAppointment;
        public System.Windows.Forms.Button btnOpenAppointment;
        public System.Windows.Forms.Button btnBrowseSalaryIncrease;
        public System.Windows.Forms.Button btnOpenSalaryIncrease;
        public System.Windows.Forms.Button btnBrowseReward;
        public System.Windows.Forms.Button btnOpenReward;
        
        // Recruitment file buttons
        public System.Windows.Forms.Button btnBrowseJobApplication;
        public System.Windows.Forms.Button btnOpenJobApplication;
        public System.Windows.Forms.Button btnBrowseResume;
        public System.Windows.Forms.Button btnOpenResume;
        public System.Windows.Forms.Button btnBrowseDegrees;
        public System.Windows.Forms.Button btnOpenDegrees;
        public System.Windows.Forms.Button btnBrowseHealthCheck;
        public System.Windows.Forms.Button btnOpenHealthCheck;
        public System.Windows.Forms.Button btnBrowseCV;
        public System.Windows.Forms.Button btnOpenCV;
        public System.Windows.Forms.Button btnBrowseReferenceLetter;
        public System.Windows.Forms.Button btnOpenReferenceLetter;
        public System.Windows.Forms.Button btnBrowseInterviewMinutes;
        public System.Windows.Forms.Button btnOpenInterviewMinutes;
        public System.Windows.Forms.Button btnBrowseOfferLetter;
        public System.Windows.Forms.Button btnOpenOfferLetter;
        
        // Salary file buttons
        public System.Windows.Forms.Button btnBrowsePaySlip;
        public System.Windows.Forms.Button btnOpenPaySlip;
        
        // Training file buttons
        public System.Windows.Forms.Button btnBrowseTrainingPlan;
        public System.Windows.Forms.Button btnOpenTrainingPlan;
        public System.Windows.Forms.Button btnBrowseCertificate;
        public System.Windows.Forms.Button btnOpenCertificate;
        public System.Windows.Forms.Button btnBrowseEvaluation;
        public System.Windows.Forms.Button btnOpenEvaluation;
        public System.Windows.Forms.Button btnBrowseCareer;
        public System.Windows.Forms.Button btnOpenCareer;
        
        // Discipline file buttons
        public System.Windows.Forms.Button btnBrowseViolation;
        public System.Windows.Forms.Button btnOpenViolation;
        public System.Windows.Forms.Button btnBrowseDisciplinaryDecision;
        public System.Windows.Forms.Button btnOpenDisciplinaryDecision;
        public System.Windows.Forms.Button btnBrowseResignationLetter;
        public System.Windows.Forms.Button btnOpenResignationLetter;
        public System.Windows.Forms.Button btnBrowseTerminationDecision;
        public System.Windows.Forms.Button btnOpenTerminationDecision;
        public System.Windows.Forms.Button btnBrowseHandover;
        public System.Windows.Forms.Button btnOpenHandover;
        public System.Windows.Forms.Button btnBrowseLiquidation;
        public System.Windows.Forms.Button btnOpenLiquidation;

        // Attendance Controls
        public System.Windows.Forms.Label lblAttendanceId;
        public System.Windows.Forms.TextBox txtAttendanceId;
        public System.Windows.Forms.Label lblAttendanceEmployee;
        public System.Windows.Forms.ComboBox cbAttendanceEmployee;
        public System.Windows.Forms.Label lblAttendanceDate;
        public System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        public System.Windows.Forms.Label lblCheckInTime;
        public System.Windows.Forms.DateTimePicker dtpCheckInTime;
        public System.Windows.Forms.Label lblCheckOutTime;
        public System.Windows.Forms.DateTimePicker dtpCheckOutTime;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.Label lblAdminHours;
        public System.Windows.Forms.TextBox txtAdminHours;
        public System.Windows.Forms.Label lblOvertimeHours;
        public System.Windows.Forms.TextBox txtOvertimeHours;
        public System.Windows.Forms.DataGridView dgvAttendances;
        public System.Windows.Forms.Button btnAddAttendance;
        public System.Windows.Forms.Button btnUpdateAttendance;
        public System.Windows.Forms.Button btnDeleteAttendance;
        public System.Windows.Forms.Button btnExportAttendances;

        // Recruitment Controls
        public System.Windows.Forms.Label lblRecruitmentId;
        public System.Windows.Forms.TextBox txtRecruitmentId;
        public System.Windows.Forms.Label lblRecruitmentEmployee;
        public System.Windows.Forms.ComboBox cbRecruitmentEmployee;
        public System.Windows.Forms.Label lblJobApplicationPath;
        public System.Windows.Forms.TextBox txtJobApplicationPath;
        public System.Windows.Forms.Label lblResumePath;
        public System.Windows.Forms.TextBox txtResumePath;
        public System.Windows.Forms.Label lblDegreesPath;
        public System.Windows.Forms.TextBox txtDegreesPath;
        public System.Windows.Forms.Label lblHealthCheckPath;
        public System.Windows.Forms.TextBox txtHealthCheckPath;
        public System.Windows.Forms.Label lblCVPath;
        public System.Windows.Forms.TextBox txtCVPath;
        public System.Windows.Forms.Label lblReferenceLetterPath;
        public System.Windows.Forms.TextBox txtReferenceLetterPath;
        public System.Windows.Forms.Label lblInterviewMinutesPath;
        public System.Windows.Forms.TextBox txtInterviewMinutesPath;
        public System.Windows.Forms.Label lblOfferLetterPath;
        public System.Windows.Forms.TextBox txtOfferLetterPath;
        public System.Windows.Forms.DataGridView dgvRecruitments;
        public System.Windows.Forms.Button btnAddRecruitment;
        public System.Windows.Forms.Button btnUpdateRecruitment;
        public System.Windows.Forms.Button btnDeleteRecruitment;
        public System.Windows.Forms.Button btnExportRecruitments;

        // Salary Controls
        public System.Windows.Forms.Label lblSalaryId;
        public System.Windows.Forms.TextBox txtSalaryId;
        public System.Windows.Forms.Label lblSalaryEmployee;
        public System.Windows.Forms.ComboBox cbSalaryEmployee;
        public System.Windows.Forms.Label lblMonthlySalary;
        public System.Windows.Forms.TextBox txtMonthlySalary;
        public System.Windows.Forms.Label lblPaySlipPath;
        public System.Windows.Forms.TextBox txtPaySlipPath;
        //public System.Windows.Forms.Label lblSalaryIncreaseDecisionPath;
        //public System.Windows.Forms.TextBox txtSalaryIncreaseDecisionPath;
        public System.Windows.Forms.Label lblBankAccount;
        public System.Windows.Forms.TextBox txtBankAccount;
        public System.Windows.Forms.Label lblInsuranceInfo;
        public System.Windows.Forms.TextBox txtInsuranceInfo;
        public System.Windows.Forms.Label lblAllowances;
        public System.Windows.Forms.TextBox txtAllowances;
        public System.Windows.Forms.Label lblBonuses;
        public System.Windows.Forms.TextBox txtBonuses;
        public System.Windows.Forms.Label lblLeavePolicy;
        public System.Windows.Forms.TextBox txtLeavePolicy;
        public System.Windows.Forms.DataGridView dgvSalaries;
        public System.Windows.Forms.Button btnAddSalary;
        public System.Windows.Forms.Button btnUpdateSalary;
        public System.Windows.Forms.Button btnDeleteSalary;
        public System.Windows.Forms.Button btnExportSalaries;

        // Training Controls
        public System.Windows.Forms.Label lblTrainingId;
        public System.Windows.Forms.TextBox txtTrainingId;
        public System.Windows.Forms.Label lblTrainingEmployee;
        public System.Windows.Forms.ComboBox cbTrainingEmployee;
        public System.Windows.Forms.Label lblTrainingPlanPath;
        public System.Windows.Forms.TextBox txtTrainingPlanPath;
        public System.Windows.Forms.Label lblCertificatePath;
        public System.Windows.Forms.TextBox txtCertificatePath;
        public System.Windows.Forms.Label lblEvaluationPath;
        public System.Windows.Forms.TextBox txtEvaluationPath;
        public System.Windows.Forms.Label lblCareerPath;
        public System.Windows.Forms.TextBox txtCareerPath;
        public System.Windows.Forms.Label lblSearchTraining;
        public System.Windows.Forms.TextBox txtSearchTraining;
        public System.Windows.Forms.Button btnSearchTraining;
        public System.Windows.Forms.DataGridView dgvTrainings;
        public System.Windows.Forms.Button btnAddTraining;
        public System.Windows.Forms.Button btnUpdateTraining;
        public System.Windows.Forms.Button btnDeleteTraining;
        public System.Windows.Forms.Button btnExportTrainings;

        // Discipline Controls
        public System.Windows.Forms.Label lblDisciplineId;
        public System.Windows.Forms.TextBox txtDisciplineId;
        public System.Windows.Forms.Label lblDisciplineEmployee;
        public System.Windows.Forms.ComboBox cbDisciplineEmployee;
        public System.Windows.Forms.Label lblViolationPath;
        public System.Windows.Forms.TextBox txtViolationPath;
        public System.Windows.Forms.Label lblDisciplinaryDecisionPath;
        public System.Windows.Forms.TextBox txtDisciplinaryDecisionPath;
        public System.Windows.Forms.Label lblResignationLetterPath;
        public System.Windows.Forms.TextBox txtResignationLetterPath;
        public System.Windows.Forms.Label lblTerminationDecisionPath;
        public System.Windows.Forms.TextBox txtTerminationDecisionPath;
        public System.Windows.Forms.Label lblHandoverPath;
        public System.Windows.Forms.TextBox txtHandoverPath;
        public System.Windows.Forms.Label lblLiquidationPath;
        public System.Windows.Forms.TextBox txtLiquidationPath;
        public System.Windows.Forms.DataGridView dgvDisciplines;
        public System.Windows.Forms.Button btnAddDiscipline;
        public System.Windows.Forms.Button btnUpdateDiscipline;
        public System.Windows.Forms.Button btnDeleteDiscipline;
        public System.Windows.Forms.Button btnExportDisciplines;


    }
}