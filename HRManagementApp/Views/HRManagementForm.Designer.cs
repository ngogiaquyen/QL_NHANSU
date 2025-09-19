using System;
using System.Drawing;
using System.Windows.Forms;

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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Main Layout Components
            this.mainSplitContainer = new SplitContainer();
            this.sidebarPanel = new Panel();
            this.contentPanel = new Panel();
            this.headerPanel = new Panel();
            
            // Sidebar Navigation
            this.btnDashboard = new Button();
            this.btnEmployees = new Button();
            this.btnContracts = new Button();
            this.btnAttendance = new Button();
            this.btnRecruitment = new Button();
            this.btnSalary = new Button();
            this.btnTraining = new Button();
            this.btnDiscipline = new Button();
            
            // Header
            this.lblTitle = new Label();
            this.lblUserInfo = new Label();
            
            // Content Panels
            this.dashboardPanel = new Panel();
            this.employeePanel = new Panel();
            this.contractPanel = new Panel();
            this.attendancePanel = new Panel();
            this.recruitmentPanel = new Panel();
            this.salaryPanel = new Panel();
            this.trainingPanel = new Panel();
            this.disciplinePanel = new Panel();

            // Employee Controls
            this.grpEmployeeInfo = new GroupBox();
            this.grpEmployeeList = new GroupBox();
            this.txtEmployeeId = new TextBox();
            this.txtEmployeeName = new TextBox();
            this.dtpDOB = new DateTimePicker();
            this.cbGender = new ComboBox();
            this.txtPhone = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPosition = new TextBox();
            this.txtDepartment = new TextBox();
            this.dgvEmployees = new DataGridView();
            this.btnAddEmployee = new Button();
            this.btnUpdateEmployee = new Button();
            this.btnDeleteEmployee = new Button();
            this.btnExportEmployees = new Button();

            // Contract Controls
            this.grpContractInfo = new GroupBox();
            this.grpContractList = new GroupBox();
            this.txtContractId = new TextBox();
            this.cbContractEmployee = new ComboBox();
            this.dtpStartDate = new DateTimePicker();
            this.dtpEndDate = new DateTimePicker();
            this.cbContractType = new ComboBox();
            this.dgvContracts = new DataGridView();
            this.btnAddContract = new Button();
            this.btnUpdateContract = new Button();
            this.btnDeleteContract = new Button();
            
            // Initialize placeholder controls
            this.dgvAttendances = new DataGridView();
            this.dgvRecruitments = new DataGridView();
            this.dgvSalaries = new DataGridView();
            this.dgvTrainings = new DataGridView();
            this.dgvDisciplines = new DataGridView();
            
            // Initialize all placeholder textboxes and comboboxes
            this.txtAttendanceId = new TextBox();
            this.cbAttendanceEmployee = new ComboBox();
            this.dtpAttendanceDate = new DateTimePicker();
            this.dtpCheckInTime = new DateTimePicker();
            this.dtpCheckOutTime = new DateTimePicker();
            this.cbStatus = new ComboBox();
            this.txtAdminHours = new TextBox();
            this.txtOvertimeHours = new TextBox();
            
            this.txtRecruitmentId = new TextBox();
            this.cbRecruitmentEmployee = new ComboBox();
            this.txtJobApplicationPath = new TextBox();
            this.txtResumePath = new TextBox();
            this.txtDegreesPath = new TextBox();
            this.txtHealthCheckPath = new TextBox();
            this.txtCVPath = new TextBox();
            this.txtReferenceLetterPath = new TextBox();
            this.txtInterviewMinutesPath = new TextBox();
            this.txtOfferLetterPath = new TextBox();
            
            this.txtSalaryId = new TextBox();
            this.cbSalaryEmployee = new ComboBox();
            this.txtMonthlySalary = new TextBox();
            this.txtPaySlipPath = new TextBox();
            this.txtSalaryIncreaseDecisionPath = new TextBox();
            this.txtBankAccount = new TextBox();
            this.txtInsuranceInfo = new TextBox();
            this.txtAllowances = new TextBox();
            this.txtBonuses = new TextBox();
            this.txtLeavePolicy = new TextBox();
            
            this.txtTrainingId = new TextBox();
            this.cbTrainingEmployee = new ComboBox();
            this.txtTrainingPlanPath = new TextBox();
            this.txtCertificatePath = new TextBox();
            this.txtEvaluationPath = new TextBox();
            this.txtCareerPath = new TextBox();
            
            this.txtDisciplineId = new TextBox();
            this.cbDisciplineEmployee = new ComboBox();
            this.txtViolationPath = new TextBox();
            this.txtDisciplinaryDecisionPath = new TextBox();
            this.txtResignationLetterPath = new TextBox();
            this.txtTerminationDecisionPath = new TextBox();
            this.txtHandoverPath = new TextBox();
            this.txtLiquidationPath = new TextBox();
            
            // Additional employee fields
            this.txtNationality = new TextBox();
            this.txtCCCD = new TextBox();
            this.dtpCCCDIssueDate = new DateTimePicker();
            this.txtCCCDIssuePlace = new TextBox();
            this.txtPermanentAddress = new TextBox();
            this.txtCurrentAddress = new TextBox();
            this.cbMaritalStatus = new ComboBox();
            this.txtDependents = new TextBox();
            this.txtSocialInsuranceNumber = new TextBox();
            this.txtTaxCode = new TextBox();
            this.txtJobDescription = new TextBox();
            this.txtRank = new TextBox();
            this.txtManager = new TextBox();
            this.txtWorkSchedule = new TextBox();
            
            // Contract additional fields
            this.txtContractAnnexPath = new TextBox();
            this.txtConfidentialityAgreementPath = new TextBox();
            this.txtNonCompeteAgreementPath = new TextBox();
            this.txtAppointmentDecisionPath = new TextBox();
            this.txtRewardDecisionPath = new TextBox();
            
            this.SuspendLayout();
            this.InitializeMainLayout();
            this.InitializeSidebar();
            this.InitializeHeader();
            this.InitializeDashboardPanel();
            this.InitializeEmployeePanel();
            this.InitializeContractPanel();
            this.InitializeAttendancePanel();
            this.InitializeRecruitmentPanel();
            this.InitializeSalaryPanel();
            this.InitializeTrainingPanel();
            this.InitializeDisciplinePanel();
            this.ResumeLayout(false);
        }

        private void InitializeMainLayout()
        {
            // Form
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1400, 800);
            this.Text = "Hệ thống quản lý nhân sự - Phiên bản 2.0";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.MinimumSize = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // Main SplitContainer
            this.mainSplitContainer.Dock = DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = FixedPanel.Panel1;
            this.mainSplitContainer.SplitterDistance = 250;
            this.mainSplitContainer.Panel1.BackColor = Color.FromArgb(51, 51, 76);
            this.mainSplitContainer.Panel2.BackColor = Color.White;
            
            // Sidebar Panel
            this.sidebarPanel.Dock = DockStyle.Fill;
            this.sidebarPanel.BackColor = Color.FromArgb(51, 51, 76);
            
            // Content Panel
            this.contentPanel.Dock = DockStyle.Fill;
            this.contentPanel.BackColor = Color.White;
            
            // Header Panel
            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Height = 60;
            this.headerPanel.BackColor = Color.FromArgb(0, 150, 136);
            
            this.mainSplitContainer.Panel1.Controls.Add(this.sidebarPanel);
            this.mainSplitContainer.Panel2.Controls.Add(this.contentPanel);
            this.contentPanel.Controls.Add(this.headerPanel);
            this.Controls.Add(this.mainSplitContainer);
        }

        private void InitializeSidebar()
        {
            Button[] navButtons = { btnDashboard, btnEmployees, btnContracts, btnAttendance, 
                                  btnRecruitment, btnSalary, btnTraining, btnDiscipline };
            string[] buttonTexts = { "📊 Dashboard", "👥 Nhân viên", "📄 Hợp đồng", "⏰ Chấm công", 
                                   "🔍 Tuyển dụng", "💰 Lương", "📚 Đào tạo", "⚖️ Kỷ luật" };
            
            for (int i = 0; i < navButtons.Length; i++)
            {
                navButtons[i].Text = buttonTexts[i];
                navButtons[i].Size = new Size(230, 50);
                navButtons[i].Location = new Point(10, 20 + i * 60);
                navButtons[i].FlatStyle = FlatStyle.Flat;
                navButtons[i].FlatAppearance.BorderSize = 0;
                navButtons[i].BackColor = Color.Transparent;
                navButtons[i].ForeColor = Color.White;
                navButtons[i].Font = new Font("Segoe UI", 11F, FontStyle.Regular);
                navButtons[i].TextAlign = ContentAlignment.MiddleLeft;
                navButtons[i].Padding = new Padding(20, 0, 0, 0);
                navButtons[i].Cursor = Cursors.Hand;
                
                // Add hover effects
                navButtons[i].MouseEnter += (s, e) => {
                    ((Button)s).BackColor = Color.FromArgb(0, 150, 136);
                };
                navButtons[i].MouseLeave += (s, e) => {
                    ((Button)s).BackColor = Color.Transparent;
                };
                
                this.sidebarPanel.Controls.Add(navButtons[i]);
            }
            
            // Add event handlers
            this.btnDashboard.Click += (s, e) => ShowPanel(dashboardPanel);
            this.btnEmployees.Click += (s, e) => ShowPanel(employeePanel);
            this.btnContracts.Click += (s, e) => ShowPanel(contractPanel);
            this.btnAttendance.Click += (s, e) => ShowPanel(attendancePanel);
            this.btnRecruitment.Click += (s, e) => ShowPanel(recruitmentPanel);
            this.btnSalary.Click += (s, e) => ShowPanel(salaryPanel);
            this.btnTraining.Click += (s, e) => ShowPanel(trainingPanel);
            this.btnDiscipline.Click += (s, e) => ShowPanel(disciplinePanel);
        }

        private void InitializeHeader()
        {
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ";
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(20, 15);
            this.lblTitle.AutoSize = true;
            
            this.lblUserInfo.Text = "Chào mừng, Admin";
            this.lblUserInfo.Font = new Font("Segoe UI", 10F);
            this.lblUserInfo.ForeColor = Color.White;
            this.lblUserInfo.Location = new Point(this.headerPanel.Width - 200, 20);
            this.lblUserInfo.AutoSize = true;
            
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblUserInfo);
        }

        private void InitializeEmployeePanel()
        {
            this.employeePanel.Dock = DockStyle.Fill;
            this.employeePanel.Padding = new Padding(20);
            this.employeePanel.Visible = false;
            
            // Employee Info Group
            this.grpEmployeeInfo.Text = "Thông tin nhân viên";
            this.grpEmployeeInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.grpEmployeeInfo.Size = new Size(400, 500);
            this.grpEmployeeInfo.Location = new Point(20, 80);
            
            // Employee List Group
            this.grpEmployeeList.Text = "Danh sách nhân viên";
            this.grpEmployeeList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.grpEmployeeList.Size = new Size(750, 500);
            this.grpEmployeeList.Location = new Point(440, 80);
            
            // Add controls to groups
            this.InitializeEmployeeControls();
            
            this.employeePanel.Controls.Add(this.grpEmployeeInfo);
            this.employeePanel.Controls.Add(this.grpEmployeeList);
            this.contentPanel.Controls.Add(this.employeePanel);
        }

        private void InitializeEmployeeControls()
        {
            // Employee form controls
            Label[] labels = new Label[8];
            string[] labelTexts = { "Mã NV:", "Họ tên:", "Ngày sinh:", "Giới tính:", 
                                  "Điện thoại:", "Email:", "Chức vụ:", "Phòng ban:" };
            Control[] controls = { txtEmployeeId, txtEmployeeName, dtpDOB, cbGender, 
                                 txtPhone, txtEmail, txtPosition, txtDepartment };
            
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = labelTexts[i];
                labels[i].Font = new Font("Segoe UI", 10F);
                labels[i].Location = new Point(20, 40 + i * 50);
                labels[i].AutoSize = true;
                
                controls[i].Location = new Point(120, 37 + i * 50);
                controls[i].Size = new Size(250, 25);
                controls[i].Font = new Font("Segoe UI", 10F);
                
                this.grpEmployeeInfo.Controls.Add(labels[i]);
                this.grpEmployeeInfo.Controls.Add(controls[i]);
            }
            
            // Gender ComboBox
            this.cbGender.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });
            this.cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            
            // Buttons
            Button[] empButtons = { btnAddEmployee, btnUpdateEmployee, btnDeleteEmployee, btnExportEmployees };
            string[] empButtonTexts = { "Thêm", "Sửa", "Xóa", "Xuất Excel" };
            
            for (int i = 0; i < empButtons.Length; i++)
            {
                empButtons[i].Text = empButtonTexts[i];
                empButtons[i].Size = new Size(80, 35);
                empButtons[i].Location = new Point(20 + i * 90, 450);
                empButtons[i].BackColor = Color.FromArgb(0, 150, 136);
                empButtons[i].ForeColor = Color.White;
                empButtons[i].FlatStyle = FlatStyle.Flat;
                empButtons[i].Font = new Font("Segoe UI", 10F);
                this.grpEmployeeInfo.Controls.Add(empButtons[i]);
            }
            
            // DataGridView
            this.dgvEmployees.Dock = DockStyle.Fill;
            this.dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.BackgroundColor = Color.White;
            this.dgvEmployees.BorderStyle = BorderStyle.None;
            this.grpEmployeeList.Controls.Add(this.dgvEmployees);
        }

        private void InitializeContractPanel()
        {
            this.contractPanel.Dock = DockStyle.Fill;
            this.contractPanel.Padding = new Padding(20);
            this.contractPanel.Visible = false;
            
            // Contract Info Group
            this.grpContractInfo.Text = "Thông tin hợp đồng";
            this.grpContractInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.grpContractInfo.Size = new Size(400, 400);
            this.grpContractInfo.Location = new Point(20, 80);
            
            // Contract List Group
            this.grpContractList.Text = "Danh sách hợp đồng";
            this.grpContractList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.grpContractList.Size = new Size(750, 400);
            this.grpContractList.Location = new Point(440, 80);
            
            this.InitializeContractControls();
            
            this.contractPanel.Controls.Add(this.grpContractInfo);
            this.contractPanel.Controls.Add(this.grpContractList);
            this.contentPanel.Controls.Add(this.contractPanel);
        }

        private void InitializeContractControls()
        {
            // Contract form controls
            Label[] labels = new Label[5];
            string[] labelTexts = { "Mã HĐ:", "Nhân viên:", "Ngày bắt đầu:", "Ngày kết thúc:", "Loại HĐ:" };
            Control[] controls = { txtContractId, cbContractEmployee, dtpStartDate, dtpEndDate, cbContractType };
            
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = labelTexts[i];
                labels[i].Font = new Font("Segoe UI", 10F);
                labels[i].Location = new Point(20, 40 + i * 50);
                labels[i].AutoSize = true;
                
                controls[i].Location = new Point(120, 37 + i * 50);
                controls[i].Size = new Size(250, 25);
                controls[i].Font = new Font("Segoe UI", 10F);
                
                this.grpContractInfo.Controls.Add(labels[i]);
                this.grpContractInfo.Controls.Add(controls[i]);
            }
            
            // Contract Type ComboBox
            this.cbContractType.Items.AddRange(new string[] { "Chính thức", "Thử việc", "Thời vụ", "Bán thời gian" });
            this.cbContractType.DropDownStyle = ComboBoxStyle.DropDownList;
            
            // Buttons
            Button[] contractButtons = { btnAddContract, btnUpdateContract, btnDeleteContract };
            string[] contractButtonTexts = { "Thêm", "Sửa", "Xóa" };
            
            for (int i = 0; i < contractButtons.Length; i++)
            {
                contractButtons[i].Text = contractButtonTexts[i];
                contractButtons[i].Size = new Size(80, 35);
                contractButtons[i].Location = new Point(20 + i * 90, 320);
                contractButtons[i].BackColor = Color.FromArgb(0, 150, 136);
                contractButtons[i].ForeColor = Color.White;
                contractButtons[i].FlatStyle = FlatStyle.Flat;
                contractButtons[i].Font = new Font("Segoe UI", 10F);
                this.grpContractInfo.Controls.Add(contractButtons[i]);
            }
            
            // DataGridView
            this.dgvContracts.Dock = DockStyle.Fill;
            this.dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.MultiSelect = false;
            this.dgvContracts.AllowUserToAddRows = false;
            this.dgvContracts.AllowUserToDeleteRows = false;
            this.dgvContracts.ReadOnly = true;
            this.dgvContracts.BackgroundColor = Color.White;
            this.dgvContracts.BorderStyle = BorderStyle.None;
            this.grpContractList.Controls.Add(this.dgvContracts);
        }

        private void InitializeDashboardPanel()
        {
            this.dashboardPanel.Dock = DockStyle.Fill;
            this.dashboardPanel.Padding = new Padding(20);
            this.dashboardPanel.Visible = false;
            
            // Dashboard title
            Label lblDashboard = new Label();
            lblDashboard.Text = "DASHBOARD - TỔNG QUAN";
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDashboard.ForeColor = Color.FromArgb(51, 51, 76);
            lblDashboard.Location = new Point(20, 80);
            lblDashboard.AutoSize = true;
            
            // Statistics cards
            Panel[] statCards = new Panel[6];
            Label[] statLabels = new Label[6];
            Label[] statValues = new Label[6];
            string[] statTitles = { "Tổng nhân viên", "Hợp đồng", "Chấm công hôm nay", "Tuyển dụng", "Lương", "Đào tạo" };
            
            for (int i = 0; i < 6; i++)
            {
                statCards[i] = new Panel();
                statCards[i].Size = new Size(180, 120);
                statCards[i].Location = new Point(20 + (i % 3) * 200, 140 + (i / 3) * 140);
                statCards[i].BackColor = Color.FromArgb(0, 150, 136);
                statCards[i].Padding = new Padding(15);
                
                statLabels[i] = new Label();
                statLabels[i].Text = statTitles[i];
                statLabels[i].ForeColor = Color.White;
                statLabels[i].Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                statLabels[i].Location = new Point(15, 15);
                statLabels[i].AutoSize = true;
                
                statValues[i] = new Label();
                statValues[i].Text = "0";
                statValues[i].ForeColor = Color.White;
                statValues[i].Font = new Font("Segoe UI", 20F, FontStyle.Bold);
                statValues[i].Location = new Point(15, 50);
                statValues[i].AutoSize = true;
                statValues[i].Name = $"lblStatValue{i}"; // For updating values later
                
                statCards[i].Controls.Add(statLabels[i]);
                statCards[i].Controls.Add(statValues[i]);
                this.dashboardPanel.Controls.Add(statCards[i]);
            }
            
            // Recent activities section
            GroupBox grpRecentActivities = new GroupBox();
            grpRecentActivities.Text = "Hoạt động gần đây";
            grpRecentActivities.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpRecentActivities.Size = new Size(600, 200);
            grpRecentActivities.Location = new Point(20, 420);
            
            ListBox lstRecentActivities = new ListBox();
            lstRecentActivities.Dock = DockStyle.Fill;
            lstRecentActivities.Font = new Font("Segoe UI", 10F);
            lstRecentActivities.Name = "lstRecentActivities";
            grpRecentActivities.Controls.Add(lstRecentActivities);
            
            this.dashboardPanel.Controls.Add(lblDashboard);
            this.dashboardPanel.Controls.Add(grpRecentActivities);
            this.contentPanel.Controls.Add(this.dashboardPanel);
        }

        private void InitializeAttendancePanel()
        {
            this.attendancePanel.Dock = DockStyle.Fill;
            this.attendancePanel.Padding = new Padding(20);
            this.attendancePanel.Visible = false;
            
            // Attendance Info Group
            GroupBox grpAttendanceInfo = new GroupBox();
            grpAttendanceInfo.Text = "Thông tin chấm công";
            grpAttendanceInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpAttendanceInfo.Size = new Size(400, 400);
            grpAttendanceInfo.Location = new Point(20, 80);
            
            // Attendance List Group
            GroupBox grpAttendanceList = new GroupBox();
            grpAttendanceList.Text = "Danh sách chấm công";
            grpAttendanceList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpAttendanceList.Size = new Size(750, 400);
            grpAttendanceList.Location = new Point(440, 80);
            
            // Add basic controls
            Label[] labels = new Label[6];
            string[] labelTexts = { "Mã chấm công:", "Nhân viên:", "Ngày:", "Giờ vào:", "Giờ ra:", "Trạng thái:" };
            Control[] controls = { txtAttendanceId, cbAttendanceEmployee, dtpAttendanceDate, dtpCheckInTime, dtpCheckOutTime, cbStatus };
            
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = labelTexts[i];
                labels[i].Font = new Font("Segoe UI", 10F);
                labels[i].Location = new Point(20, 40 + i * 50);
                labels[i].AutoSize = true;
                
                controls[i].Location = new Point(120, 37 + i * 50);
                controls[i].Size = new Size(250, 25);
                controls[i].Font = new Font("Segoe UI", 10F);
                
                grpAttendanceInfo.Controls.Add(labels[i]);
                grpAttendanceInfo.Controls.Add(controls[i]);
            }
            
            // Status ComboBox
            this.cbStatus.Items.AddRange(new string[] { "Có mặt", "Vắng mặt", "Nghỉ phép", "Nghỉ ốm" });
            this.cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            
            // Buttons
            Button[] attendanceButtons = { new Button(), new Button(), new Button(), new Button() };
            string[] attendanceButtonTexts = { "Thêm", "Sửa", "Xóa", "Xuất Excel" };
            
            for (int i = 0; i < attendanceButtons.Length; i++)
            {
                attendanceButtons[i].Text = attendanceButtonTexts[i];
                attendanceButtons[i].Size = new Size(80, 35);
                attendanceButtons[i].Location = new Point(20 + i * 90, 320);
                attendanceButtons[i].BackColor = Color.FromArgb(0, 150, 136);
                attendanceButtons[i].ForeColor = Color.White;
                attendanceButtons[i].FlatStyle = FlatStyle.Flat;
                attendanceButtons[i].Font = new Font("Segoe UI", 10F);
                grpAttendanceInfo.Controls.Add(attendanceButtons[i]);
            }
            
            // DataGridView
            this.dgvAttendances.Dock = DockStyle.Fill;
            this.dgvAttendances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendances.MultiSelect = false;
            this.dgvAttendances.AllowUserToAddRows = false;
            this.dgvAttendances.AllowUserToDeleteRows = false;
            this.dgvAttendances.ReadOnly = true;
            this.dgvAttendances.BackgroundColor = Color.White;
            this.dgvAttendances.BorderStyle = BorderStyle.None;
            grpAttendanceList.Controls.Add(this.dgvAttendances);
            
            this.attendancePanel.Controls.Add(grpAttendanceInfo);
            this.attendancePanel.Controls.Add(grpAttendanceList);
            this.contentPanel.Controls.Add(this.attendancePanel);
        }

        private void InitializeRecruitmentPanel()
        {
            this.recruitmentPanel.Dock = DockStyle.Fill;
            this.recruitmentPanel.Padding = new Padding(20);
            this.recruitmentPanel.Visible = false;
            
            // Recruitment Info Group
            GroupBox grpRecruitmentInfo = new GroupBox();
            grpRecruitmentInfo.Text = "Thông tin tuyển dụng";
            grpRecruitmentInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpRecruitmentInfo.Size = new Size(400, 500);
            grpRecruitmentInfo.Location = new Point(20, 80);
            
            // Recruitment List Group
            GroupBox grpRecruitmentList = new GroupBox();
            grpRecruitmentList.Text = "Danh sách tuyển dụng";
            grpRecruitmentList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpRecruitmentList.Size = new Size(750, 500);
            grpRecruitmentList.Location = new Point(440, 80);
            
            // Add basic controls
            Label[] labels = new Label[3];
            string[] labelTexts = { "Mã tuyển dụng:", "Nhân viên:", "Đơn xin việc:" };
            Control[] controls = { txtRecruitmentId, cbRecruitmentEmployee, txtJobApplicationPath };
            
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = labelTexts[i];
                labels[i].Font = new Font("Segoe UI", 10F);
                labels[i].Location = new Point(20, 40 + i * 50);
                labels[i].AutoSize = true;
                
                controls[i].Location = new Point(120, 37 + i * 50);
                controls[i].Size = new Size(250, 25);
                controls[i].Font = new Font("Segoe UI", 10F);
                
                grpRecruitmentInfo.Controls.Add(labels[i]);
                grpRecruitmentInfo.Controls.Add(controls[i]);
            }
            
            // Buttons
            Button[] recruitmentButtons = { new Button(), new Button(), new Button(), new Button() };
            string[] recruitmentButtonTexts = { "Thêm", "Sửa", "Xóa", "Xuất Excel" };
            
            for (int i = 0; i < recruitmentButtons.Length; i++)
            {
                recruitmentButtons[i].Text = recruitmentButtonTexts[i];
                recruitmentButtons[i].Size = new Size(80, 35);
                recruitmentButtons[i].Location = new Point(20 + i * 90, 420);
                recruitmentButtons[i].BackColor = Color.FromArgb(0, 150, 136);
                recruitmentButtons[i].ForeColor = Color.White;
                recruitmentButtons[i].FlatStyle = FlatStyle.Flat;
                recruitmentButtons[i].Font = new Font("Segoe UI", 10F);
                grpRecruitmentInfo.Controls.Add(recruitmentButtons[i]);
            }
            
            // DataGridView
            this.dgvRecruitments.Dock = DockStyle.Fill;
            this.dgvRecruitments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecruitments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecruitments.MultiSelect = false;
            this.dgvRecruitments.AllowUserToAddRows = false;
            this.dgvRecruitments.AllowUserToDeleteRows = false;
            this.dgvRecruitments.ReadOnly = true;
            this.dgvRecruitments.BackgroundColor = Color.White;
            this.dgvRecruitments.BorderStyle = BorderStyle.None;
            grpRecruitmentList.Controls.Add(this.dgvRecruitments);
            
            this.recruitmentPanel.Controls.Add(grpRecruitmentInfo);
            this.recruitmentPanel.Controls.Add(grpRecruitmentList);
            this.contentPanel.Controls.Add(this.recruitmentPanel);
        }

        private void InitializeSalaryPanel()
        {
            this.salaryPanel.Dock = DockStyle.Fill;
            this.salaryPanel.Padding = new Padding(20);
            this.salaryPanel.Visible = false;
            
            // Salary Info Group
            GroupBox grpSalaryInfo = new GroupBox();
            grpSalaryInfo.Text = "Thông tin lương";
            grpSalaryInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpSalaryInfo.Size = new Size(400, 500);
            grpSalaryInfo.Location = new Point(20, 80);
            
            // Salary List Group
            GroupBox grpSalaryList = new GroupBox();
            grpSalaryList.Text = "Danh sách lương";
            grpSalaryList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpSalaryList.Size = new Size(750, 500);
            grpSalaryList.Location = new Point(440, 80);
            
            // Add basic controls
            Label[] labels = new Label[4];
            string[] labelTexts = { "Mã lương:", "Nhân viên:", "Lương cơ bản:", "Tài khoản ngân hàng:" };
            Control[] controls = { txtSalaryId, cbSalaryEmployee, txtMonthlySalary, txtBankAccount };
            
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = labelTexts[i];
                labels[i].Font = new Font("Segoe UI", 10F);
                labels[i].Location = new Point(20, 40 + i * 50);
                labels[i].AutoSize = true;
                
                controls[i].Location = new Point(120, 37 + i * 50);
                controls[i].Size = new Size(250, 25);
                controls[i].Font = new Font("Segoe UI", 10F);
                
                grpSalaryInfo.Controls.Add(labels[i]);
                grpSalaryInfo.Controls.Add(controls[i]);
            }
            
            // Buttons
            Button[] salaryButtons = { new Button(), new Button(), new Button(), new Button() };
            string[] salaryButtonTexts = { "Thêm", "Sửa", "Xóa", "Xuất Excel" };
            
            for (int i = 0; i < salaryButtons.Length; i++)
            {
                salaryButtons[i].Text = salaryButtonTexts[i];
                salaryButtons[i].Size = new Size(80, 35);
                salaryButtons[i].Location = new Point(20 + i * 90, 420);
                salaryButtons[i].BackColor = Color.FromArgb(0, 150, 136);
                salaryButtons[i].ForeColor = Color.White;
                salaryButtons[i].FlatStyle = FlatStyle.Flat;
                salaryButtons[i].Font = new Font("Segoe UI", 10F);
                grpSalaryInfo.Controls.Add(salaryButtons[i]);
            }
            
            // DataGridView
            this.dgvSalaries.Dock = DockStyle.Fill;
            this.dgvSalaries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaries.MultiSelect = false;
            this.dgvSalaries.AllowUserToAddRows = false;
            this.dgvSalaries.AllowUserToDeleteRows = false;
            this.dgvSalaries.ReadOnly = true;
            this.dgvSalaries.BackgroundColor = Color.White;
            this.dgvSalaries.BorderStyle = BorderStyle.None;
            grpSalaryList.Controls.Add(this.dgvSalaries);
            
            this.salaryPanel.Controls.Add(grpSalaryInfo);
            this.salaryPanel.Controls.Add(grpSalaryList);
            this.contentPanel.Controls.Add(this.salaryPanel);
        }

        private void InitializeTrainingPanel()
        {
            this.trainingPanel.Dock = DockStyle.Fill;
            this.trainingPanel.Padding = new Padding(20);
            this.trainingPanel.Visible = false;
            
            // Training Info Group
            GroupBox grpTrainingInfo = new GroupBox();
            grpTrainingInfo.Text = "Thông tin đào tạo";
            grpTrainingInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpTrainingInfo.Size = new Size(400, 500);
            grpTrainingInfo.Location = new Point(20, 80);
            
            // Training List Group
            GroupBox grpTrainingList = new GroupBox();
            grpTrainingList.Text = "Danh sách đào tạo";
            grpTrainingList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpTrainingList.Size = new Size(750, 500);
            grpTrainingList.Location = new Point(440, 80);
            
            // Add basic controls
            Label[] labels = new Label[3];
            string[] labelTexts = { "Mã đào tạo:", "Nhân viên:", "Kế hoạch đào tạo:" };
            Control[] controls = { txtTrainingId, cbTrainingEmployee, txtTrainingPlanPath };
            
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = labelTexts[i];
                labels[i].Font = new Font("Segoe UI", 10F);
                labels[i].Location = new Point(20, 40 + i * 50);
                labels[i].AutoSize = true;
                
                controls[i].Location = new Point(120, 37 + i * 50);
                controls[i].Size = new Size(250, 25);
                controls[i].Font = new Font("Segoe UI", 10F);
                
                grpTrainingInfo.Controls.Add(labels[i]);
                grpTrainingInfo.Controls.Add(controls[i]);
            }
            
            // Buttons
            Button[] trainingButtons = { new Button(), new Button(), new Button(), new Button() };
            string[] trainingButtonTexts = { "Thêm", "Sửa", "Xóa", "Xuất Excel" };
            
            for (int i = 0; i < trainingButtons.Length; i++)
            {
                trainingButtons[i].Text = trainingButtonTexts[i];
                trainingButtons[i].Size = new Size(80, 35);
                trainingButtons[i].Location = new Point(20 + i * 90, 420);
                trainingButtons[i].BackColor = Color.FromArgb(0, 150, 136);
                trainingButtons[i].ForeColor = Color.White;
                trainingButtons[i].FlatStyle = FlatStyle.Flat;
                trainingButtons[i].Font = new Font("Segoe UI", 10F);
                grpTrainingInfo.Controls.Add(trainingButtons[i]);
            }
            
            // DataGridView
            this.dgvTrainings.Dock = DockStyle.Fill;
            this.dgvTrainings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrainings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainings.MultiSelect = false;
            this.dgvTrainings.AllowUserToAddRows = false;
            this.dgvTrainings.AllowUserToDeleteRows = false;
            this.dgvTrainings.ReadOnly = true;
            this.dgvTrainings.BackgroundColor = Color.White;
            this.dgvTrainings.BorderStyle = BorderStyle.None;
            grpTrainingList.Controls.Add(this.dgvTrainings);
            
            this.trainingPanel.Controls.Add(grpTrainingInfo);
            this.trainingPanel.Controls.Add(grpTrainingList);
            this.contentPanel.Controls.Add(this.trainingPanel);
        }

        private void InitializeDisciplinePanel()
        {
            this.disciplinePanel.Dock = DockStyle.Fill;
            this.disciplinePanel.Padding = new Padding(20);
            this.disciplinePanel.Visible = false;
            
            // Discipline Info Group
            GroupBox grpDisciplineInfo = new GroupBox();
            grpDisciplineInfo.Text = "Thông tin kỷ luật";
            grpDisciplineInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpDisciplineInfo.Size = new Size(400, 500);
            grpDisciplineInfo.Location = new Point(20, 80);
            
            // Discipline List Group
            GroupBox grpDisciplineList = new GroupBox();
            grpDisciplineList.Text = "Danh sách kỷ luật";
            grpDisciplineList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpDisciplineList.Size = new Size(750, 500);
            grpDisciplineList.Location = new Point(440, 80);
            
            // Add basic controls
            Label[] labels = new Label[3];
            string[] labelTexts = { "Mã kỷ luật:", "Nhân viên:", "Vi phạm:" };
            Control[] controls = { txtDisciplineId, cbDisciplineEmployee, txtViolationPath };
            
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = labelTexts[i];
                labels[i].Font = new Font("Segoe UI", 10F);
                labels[i].Location = new Point(20, 40 + i * 50);
                labels[i].AutoSize = true;
                
                controls[i].Location = new Point(120, 37 + i * 50);
                controls[i].Size = new Size(250, 25);
                controls[i].Font = new Font("Segoe UI", 10F);
                
                grpDisciplineInfo.Controls.Add(labels[i]);
                grpDisciplineInfo.Controls.Add(controls[i]);
            }
            
            // Buttons
            Button[] disciplineButtons = { new Button(), new Button(), new Button(), new Button() };
            string[] disciplineButtonTexts = { "Thêm", "Sửa", "Xóa", "Xuất Excel" };
            
            for (int i = 0; i < disciplineButtons.Length; i++)
            {
                disciplineButtons[i].Text = disciplineButtonTexts[i];
                disciplineButtons[i].Size = new Size(80, 35);
                disciplineButtons[i].Location = new Point(20 + i * 90, 420);
                disciplineButtons[i].BackColor = Color.FromArgb(0, 150, 136);
                disciplineButtons[i].ForeColor = Color.White;
                disciplineButtons[i].FlatStyle = FlatStyle.Flat;
                disciplineButtons[i].Font = new Font("Segoe UI", 10F);
                grpDisciplineInfo.Controls.Add(disciplineButtons[i]);
            }
            
            // DataGridView
            this.dgvDisciplines.Dock = DockStyle.Fill;
            this.dgvDisciplines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisciplines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisciplines.MultiSelect = false;
            this.dgvDisciplines.AllowUserToAddRows = false;
            this.dgvDisciplines.AllowUserToDeleteRows = false;
            this.dgvDisciplines.ReadOnly = true;
            this.dgvDisciplines.BackgroundColor = Color.White;
            this.dgvDisciplines.BorderStyle = BorderStyle.None;
            grpDisciplineList.Controls.Add(this.dgvDisciplines);
            
            this.disciplinePanel.Controls.Add(grpDisciplineInfo);
            this.disciplinePanel.Controls.Add(grpDisciplineList);
            this.contentPanel.Controls.Add(this.disciplinePanel);
        }

        #endregion

        #region Component Declarations

        // Main Layout
        private SplitContainer mainSplitContainer;
        private Panel sidebarPanel;
        private Panel contentPanel;
        private Panel headerPanel;
        
        // Navigation
        private Button btnDashboard;
        private Button btnEmployees;
        private Button btnContracts;
        private Button btnAttendance;
        private Button btnRecruitment;
        private Button btnSalary;
        private Button btnTraining;
        private Button btnDiscipline;
        
        // Header
        private Label lblTitle;
        private Label lblUserInfo;
        
        // Content Panels
        private Panel dashboardPanel;
        private Panel employeePanel;
        private Panel contractPanel;
        private Panel attendancePanel;
        private Panel recruitmentPanel;
        private Panel salaryPanel;
        private Panel trainingPanel;
        private Panel disciplinePanel;

        // Employee Controls
        public GroupBox grpEmployeeInfo;
        public GroupBox grpEmployeeList;
        public TextBox txtEmployeeId;
        public TextBox txtEmployeeName;
        public DateTimePicker dtpDOB;
        public ComboBox cbGender;
        public TextBox txtPhone;
        public TextBox txtEmail;
        public TextBox txtPosition;
        public TextBox txtDepartment;
        public DataGridView dgvEmployees;
        public Button btnAddEmployee;
        public Button btnUpdateEmployee;
        public Button btnDeleteEmployee;
        public Button btnExportEmployees;

        // Contract Controls
        public GroupBox grpContractInfo;
        public GroupBox grpContractList;
        public TextBox txtContractId;
        public ComboBox cbContractEmployee;
        public DateTimePicker dtpStartDate;
        public DateTimePicker dtpEndDate;
        public ComboBox cbContractType;
        public DataGridView dgvContracts;
        public Button btnAddContract;
        public Button btnUpdateContract;
        public Button btnDeleteContract;

        // Additional controls for other modules (placeholders)
        public DataGridView dgvAttendances;
        public DataGridView dgvRecruitments;
        public DataGridView dgvSalaries;
        public DataGridView dgvTrainings;
        public DataGridView dgvDisciplines;
        
        // Placeholder controls for other modules
        public TextBox txtAttendanceId;
        public ComboBox cbAttendanceEmployee;
        public DateTimePicker dtpAttendanceDate;
        public DateTimePicker dtpCheckInTime;
        public DateTimePicker dtpCheckOutTime;
        public ComboBox cbStatus;
        public TextBox txtAdminHours;
        public TextBox txtOvertimeHours;
        
        public TextBox txtRecruitmentId;
        public ComboBox cbRecruitmentEmployee;
        public TextBox txtJobApplicationPath;
        public TextBox txtResumePath;
        public TextBox txtDegreesPath;
        public TextBox txtHealthCheckPath;
        public TextBox txtCVPath;
        public TextBox txtReferenceLetterPath;
        public TextBox txtInterviewMinutesPath;
        public TextBox txtOfferLetterPath;
        
        public TextBox txtSalaryId;
        public ComboBox cbSalaryEmployee;
        public TextBox txtMonthlySalary;
        public TextBox txtPaySlipPath;
        public TextBox txtSalaryIncreaseDecisionPath;
        public TextBox txtBankAccount;
        public TextBox txtInsuranceInfo;
        public TextBox txtAllowances;
        public TextBox txtBonuses;
        public TextBox txtLeavePolicy;
        
        public TextBox txtTrainingId;
        public ComboBox cbTrainingEmployee;
        public TextBox txtTrainingPlanPath;
        public TextBox txtCertificatePath;
        public TextBox txtEvaluationPath;
        public TextBox txtCareerPath;
        
        public TextBox txtDisciplineId;
        public ComboBox cbDisciplineEmployee;
        public TextBox txtViolationPath;
        public TextBox txtDisciplinaryDecisionPath;
        public TextBox txtResignationLetterPath;
        public TextBox txtTerminationDecisionPath;
        public TextBox txtHandoverPath;
        public TextBox txtLiquidationPath;
        
        // Additional employee fields
        public TextBox txtNationality;
        public TextBox txtCCCD;
        public DateTimePicker dtpCCCDIssueDate;
        public TextBox txtCCCDIssuePlace;
        public TextBox txtPermanentAddress;
        public TextBox txtCurrentAddress;
        public ComboBox cbMaritalStatus;
        public TextBox txtDependents;
        public TextBox txtSocialInsuranceNumber;
        public TextBox txtTaxCode;
        public TextBox txtJobDescription;
        public TextBox txtRank;
        public TextBox txtManager;
        public TextBox txtWorkSchedule;
        
        // Contract additional fields
        public TextBox txtContractAnnexPath;
        public TextBox txtConfidentialityAgreementPath;
        public TextBox txtNonCompeteAgreementPath;
        public TextBox txtAppointmentDecisionPath;
        public TextBox txtRewardDecisionPath;
        
        #endregion
    }
}
