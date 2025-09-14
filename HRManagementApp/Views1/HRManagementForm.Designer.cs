namespace HRManagementApp.Views
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
            components = new System.ComponentModel.Container();

            // TabControl
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabContract = new System.Windows.Forms.TabPage();
            this.tabAttendance = new System.Windows.Forms.TabPage();

            // Employee Tab Components
            this.inputPanelEmployee = new System.Windows.Forms.Panel();
            this.detailPanelEmployee = new System.Windows.Forms.Panel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnRefreshEmployees = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();

            // Contract Tab Components
            this.inputPanelContract = new System.Windows.Forms.Panel();
            this.detailPanelContract = new System.Windows.Forms.Panel();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.btnRefreshContracts = new System.Windows.Forms.Button();
            this.btnDeleteContract = new System.Windows.Forms.Button();
            this.btnUpdateContract = new System.Windows.Forms.Button();
            this.cmbContractEmployeeId = new System.Windows.Forms.ComboBox();
            this.txtContractType = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtContractSalary = new System.Windows.Forms.TextBox();
            this.cmbContractStatus = new System.Windows.Forms.ComboBox();
            this.lblContractEmployee = new System.Windows.Forms.Label();
            this.lblContractType = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblContractSalary = new System.Windows.Forms.Label();
            this.lblContractStatus = new System.Windows.Forms.Label();

            // Attendance Tab Components
            this.inputPanelAttendance = new System.Windows.Forms.Panel();
            this.detailPanelAttendance = new System.Windows.Forms.Panel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.btnAddAttendance = new System.Windows.Forms.Button();
            this.btnRefreshAttendance = new System.Windows.Forms.Button();
            this.btnDeleteAttendance = new System.Windows.Forms.Button();
            this.btnUpdateAttendance = new System.Windows.Forms.Button();
            this.cmbAttendanceEmployeeId = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.cmbAttendanceStatus = new System.Windows.Forms.ComboBox();
            this.lblAttendanceEmployee = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();

            // Suspend Layout
            this.tabControlMain.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.inputPanelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.tabContract.SuspendLayout();
            this.inputPanelContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.tabAttendance.SuspendLayout();
            this.inputPanelAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();

            // tabControlMain
            this.tabControlMain.Controls.Add(this.tabEmployee);
            this.tabControlMain.Controls.Add(this.tabContract);
            this.tabControlMain.Controls.Add(this.tabAttendance);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1100, 750);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.BackColor = Color.Transparent;

            // tabEmployee
            this.tabEmployee.Controls.Add(this.inputPanelEmployee);
            this.tabEmployee.Controls.Add(this.detailPanelEmployee);
            this.tabEmployee.Controls.Add(this.dgvEmployees);
            this.tabEmployee.Location = new System.Drawing.Point(4, 24);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(5);
            this.tabEmployee.Size = new System.Drawing.Size(1092, 722);
            this.tabEmployee.TabIndex = 0;
            this.tabEmployee.Text = "Quản lý Nhân viên";
            this.tabEmployee.BackColor = Color.White;

            // inputPanelEmployee
            this.inputPanelEmployee.Controls.Add(this.btnUpdateEmployee);
            this.inputPanelEmployee.Controls.Add(this.btnDeleteEmployee);
            this.inputPanelEmployee.Controls.Add(this.btnRefreshEmployees);
            this.inputPanelEmployee.Controls.Add(this.btnAddEmployee);
            this.inputPanelEmployee.Controls.Add(this.dtpHireDate);
            this.inputPanelEmployee.Controls.Add(this.cmbPosition);
            this.inputPanelEmployee.Controls.Add(this.cmbDepartment);
            this.inputPanelEmployee.Controls.Add(this.txtEmail);
            this.inputPanelEmployee.Controls.Add(this.txtPhone);
            this.inputPanelEmployee.Controls.Add(this.txtAddress);
            this.inputPanelEmployee.Controls.Add(this.cmbGender);
            this.inputPanelEmployee.Controls.Add(this.dtpBirthDate);
            this.inputPanelEmployee.Controls.Add(this.txtLastName);
            this.inputPanelEmployee.Controls.Add(this.txtFirstName);
            this.inputPanelEmployee.Controls.Add(this.lblHireDate);
            this.inputPanelEmployee.Controls.Add(this.lblPosition);
            this.inputPanelEmployee.Controls.Add(this.lblDepartment);
            this.inputPanelEmployee.Controls.Add(this.lblEmail);
            this.inputPanelEmployee.Controls.Add(this.lblPhone);
            this.inputPanelEmployee.Controls.Add(this.lblAddress);
            this.inputPanelEmployee.Controls.Add(this.lblGender);
            this.inputPanelEmployee.Controls.Add(this.lblBirthDate);
            this.inputPanelEmployee.Controls.Add(this.lblLastName);
            this.inputPanelEmployee.Controls.Add(this.lblFirstName);
            this.inputPanelEmployee.Location = new System.Drawing.Point(10, 10);
            this.inputPanelEmployee.Name = "inputPanelEmployee";
            this.inputPanelEmployee.Size = new System.Drawing.Size(520, 350);
            this.inputPanelEmployee.BackColor = Color.White;
            this.inputPanelEmployee.BorderStyle = BorderStyle.FixedSingle;
            this.inputPanelEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // detailPanelEmployee
            this.detailPanelEmployee.Location = new System.Drawing.Point(540, 10);
            this.detailPanelEmployee.Name = "detailPanelEmployee";
            this.detailPanelEmployee.Size = new System.Drawing.Size(520, 350);
            this.detailPanelEmployee.BackColor = Color.White;
            this.detailPanelEmployee.BorderStyle = BorderStyle.FixedSingle;
            this.detailPanelEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // dgvEmployees
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(10, 370);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(1070, 340);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // btnAddEmployee
            this.btnAddEmployee.Location = new System.Drawing.Point(110, 270);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(290, 30);
            this.btnAddEmployee.TabIndex = 17;
            this.btnAddEmployee.Text = "Thêm Nhân viên";
            this.btnAddEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnRefreshEmployees
            this.btnRefreshEmployees.Location = new System.Drawing.Point(10, 310);
            this.btnRefreshEmployees.Name = "btnRefreshEmployees";
            this.btnRefreshEmployees.Size = new System.Drawing.Size(100, 30);
            this.btnRefreshEmployees.TabIndex = 18;
            this.btnRefreshEmployees.Text = "Tải lại";
            this.btnRefreshEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnDeleteEmployee
            this.btnDeleteEmployee.Location = new System.Drawing.Point(110, 310);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteEmployee.TabIndex = 19;
            this.btnDeleteEmployee.Text = "Xóa Nhân viên";
            this.btnDeleteEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnUpdateEmployee
            this.btnUpdateEmployee.Location = new System.Drawing.Point(210, 310);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateEmployee.TabIndex = 20;
            this.btnUpdateEmployee.Text = "Sửa Nhân viên";
            this.btnUpdateEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(360, 0);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 25);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(110, 0);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 25);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // dtpBirthDate
            this.dtpBirthDate.Location = new System.Drawing.Point(110, 30);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(290, 25);
            this.dtpBirthDate.TabIndex = 8;
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // cmbGender
            this.cmbGender.Location = new System.Drawing.Point(110, 60);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(290, 25);
            this.cmbGender.TabIndex = 9;
            this.cmbGender.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            this.cmbGender.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(110, 90);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(290, 25);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(110, 120);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(290, 25);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(110, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 25);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // cmbDepartment
            this.cmbDepartment.Location = new System.Drawing.Point(110, 180);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(290, 25);
            this.cmbDepartment.TabIndex = 13;
            this.cmbDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // cmbPosition
            this.cmbPosition.Location = new System.Drawing.Point(110, 210);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(290, 25);
            this.cmbPosition.TabIndex = 14;
            this.cmbPosition.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // dtpHireDate
            this.dtpHireDate.Location = new System.Drawing.Point(110, 240);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(290, 25);
            this.dtpHireDate.TabIndex = 15;
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(260, 3);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Tên:";
            this.lblFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 3);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(30, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Họ:";
            this.lblLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblBirthDate
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(10, 33);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(60, 13);
            this.lblBirthDate.TabIndex = 0;
            this.lblBirthDate.Text = "Ngày sinh:";
            this.lblBirthDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblGender
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(10, 63);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Giới tính:";
            this.lblGender.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(10, 93);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa chỉ:";
            this.lblAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(10, 123);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Số điện thoại:";
            this.lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblDepartment
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(10, 183);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(60, 13);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Phòng ban:";
            this.lblDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblPosition
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(10, 213);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(45, 13);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Chức vụ:";
            this.lblPosition.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblHireDate
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(10, 243);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(80, 13);
            this.lblHireDate.TabIndex = 4;
            this.lblHireDate.Text = "Ngày tuyển dụng:";
            this.lblHireDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // tabContract
            this.tabContract.Controls.Add(this.inputPanelContract);
            this.tabContract.Controls.Add(this.detailPanelContract);
            this.tabContract.Controls.Add(this.dgvContracts);
            this.tabContract.Location = new System.Drawing.Point(4, 24);
            this.tabContract.Name = "tabContract";
            this.tabContract.Padding = new System.Windows.Forms.Padding(5);
            this.tabContract.Size = new System.Drawing.Size(1092, 722);
            this.tabContract.TabIndex = 1;
            this.tabContract.Text = "Quản lý Hợp đồng";
            this.tabContract.BackColor = Color.White;

            // inputPanelContract
            this.inputPanelContract.Controls.Add(this.btnUpdateContract);
            this.inputPanelContract.Controls.Add(this.btnDeleteContract);
            this.inputPanelContract.Controls.Add(this.btnRefreshContracts);
            this.inputPanelContract.Controls.Add(this.btnAddContract);
            this.inputPanelContract.Controls.Add(this.cmbContractStatus);
            this.inputPanelContract.Controls.Add(this.txtContractSalary);
            this.inputPanelContract.Controls.Add(this.txtEndDate);
            this.inputPanelContract.Controls.Add(this.txtStartDate);
            this.inputPanelContract.Controls.Add(this.txtContractType);
            this.inputPanelContract.Controls.Add(this.cmbContractEmployeeId);
            this.inputPanelContract.Controls.Add(this.lblContractStatus);
            this.inputPanelContract.Controls.Add(this.lblContractSalary);
            this.inputPanelContract.Controls.Add(this.lblEndDate);
            this.inputPanelContract.Controls.Add(this.lblStartDate);
            this.inputPanelContract.Controls.Add(this.lblContractType);
            this.inputPanelContract.Controls.Add(this.lblContractEmployee);
            this.inputPanelContract.Location = new System.Drawing.Point(10, 10);
            this.inputPanelContract.Name = "inputPanelContract";
            this.inputPanelContract.Size = new System.Drawing.Size(520, 350);
            this.inputPanelContract.BackColor = Color.White;
            this.inputPanelContract.BorderStyle = BorderStyle.FixedSingle;
            this.inputPanelContract.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // detailPanelContract
            this.detailPanelContract.Location = new System.Drawing.Point(540, 10);
            this.detailPanelContract.Name = "detailPanelContract";
            this.detailPanelContract.Size = new System.Drawing.Size(520, 350);
            this.detailPanelContract.BackColor = Color.White;
            this.detailPanelContract.BorderStyle = BorderStyle.FixedSingle;
            this.detailPanelContract.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // dgvContracts
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(10, 370);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.Size = new System.Drawing.Size(1070, 340);
            this.dgvContracts.TabIndex = 0;
            this.dgvContracts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // btnAddContract
            this.btnAddContract.Location = new System.Drawing.Point(110, 270);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(290, 30);
            this.btnAddContract.TabIndex = 17;
            this.btnAddContract.Text = "Thêm Hợp đồng";
            this.btnAddContract.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnRefreshContracts
            this.btnRefreshContracts.Location = new System.Drawing.Point(10, 310);
            this.btnRefreshContracts.Name = "btnRefreshContracts";
            this.btnRefreshContracts.Size = new System.Drawing.Size(100, 30);
            this.btnRefreshContracts.TabIndex = 18;
            this.btnRefreshContracts.Text = "Tải lại";
            this.btnRefreshContracts.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnDeleteContract
            this.btnDeleteContract.Location = new System.Drawing.Point(110, 310);
            this.btnDeleteContract.Name = "btnDeleteContract";
            this.btnDeleteContract.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteContract.TabIndex = 19;
            this.btnDeleteContract.Text = "Xóa Hợp đồng";
            this.btnDeleteContract.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnUpdateContract
            this.btnUpdateContract.Location = new System.Drawing.Point(210, 310);
            this.btnUpdateContract.Name = "btnUpdateContract";
            this.btnUpdateContract.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateContract.TabIndex = 20;
            this.btnUpdateContract.Text = "Sửa Hợp đồng";
            this.btnUpdateContract.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // cmbContractEmployeeId
            this.cmbContractEmployeeId.Location = new System.Drawing.Point(110, 0);
            this.cmbContractEmployeeId.Name = "cmbContractEmployeeId";
            this.cmbContractEmployeeId.Size = new System.Drawing.Size(290, 25);
            this.cmbContractEmployeeId.TabIndex = 10;
            this.cmbContractEmployeeId.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtContractType
            this.txtContractType.Location = new System.Drawing.Point(110, 30);
            this.txtContractType.Name = "txtContractType";
            this.txtContractType.Size = new System.Drawing.Size(290, 25);
            this.txtContractType.TabIndex = 11;
            this.txtContractType.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtStartDate
            this.txtStartDate.Location = new System.Drawing.Point(110, 60);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(290, 25);
            this.txtStartDate.TabIndex = 12;
            this.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtEndDate
            this.txtEndDate.Location = new System.Drawing.Point(110, 90);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(290, 25);
            this.txtEndDate.TabIndex = 13;
            this.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtContractSalary
            this.txtContractSalary.Location = new System.Drawing.Point(110, 120);
            this.txtContractSalary.Name = "txtContractSalary";
            this.txtContractSalary.Size = new System.Drawing.Size(290, 25);
            this.txtContractSalary.TabIndex = 14;
            this.txtContractSalary.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // cmbContractStatus
            this.cmbContractStatus.Location = new System.Drawing.Point(110, 150);
            this.cmbContractStatus.Name = "cmbContractStatus";
            this.cmbContractStatus.Size = new System.Drawing.Size(290, 25);
            this.cmbContractStatus.TabIndex = 15;
            this.cmbContractStatus.Items.AddRange(new object[] { "Đang hiệu lực", "Hết hiệu lực", "Tạm hoãn" });
            this.cmbContractStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblContractEmployee
            this.lblContractEmployee.AutoSize = true;
            this.lblContractEmployee.Location = new System.Drawing.Point(10, 3);
            this.lblContractEmployee.Name = "lblContractEmployee";
            this.lblContractEmployee.Size = new System.Drawing.Size(60, 13);
            this.lblContractEmployee.TabIndex = 0;
            this.lblContractEmployee.Text = "Nhân viên:";
            this.lblContractEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblContractType
            this.lblContractType.AutoSize = true;
            this.lblContractType.Location = new System.Drawing.Point(10, 33);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(80, 13);
            this.lblContractType.TabIndex = 0;
            this.lblContractType.Text = "Loại hợp đồng:";
            this.lblContractType.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblStartDate
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(10, 63);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(70, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Ngày bắt đầu:";
            this.lblStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblEndDate
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(10, 93);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(70, 13);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "Ngày kết thúc:";
            this.lblEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblContractSalary
            this.lblContractSalary.AutoSize = true;
            this.lblContractSalary.Location = new System.Drawing.Point(10, 123);
            this.lblContractSalary.Name = "lblContractSalary";
            this.lblContractSalary.Size = new System.Drawing.Size(45, 13);
            this.lblContractSalary.TabIndex = 0;
            this.lblContractSalary.Text = "Lương:";
            this.lblContractSalary.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblContractStatus
            this.lblContractStatus.AutoSize = true;
            this.lblContractStatus.Location = new System.Drawing.Point(10, 153);
            this.lblContractStatus.Name = "lblContractStatus";
            this.lblContractStatus.Size = new System.Drawing.Size(60, 13);
            this.lblContractStatus.TabIndex = 0;
            this.lblContractStatus.Text = "Trạng thái:";
            this.lblContractStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // tabAttendance
            this.tabAttendance.Controls.Add(this.inputPanelAttendance);
            this.tabAttendance.Controls.Add(this.detailPanelAttendance);
            this.tabAttendance.Controls.Add(this.dgvAttendance);
            this.tabAttendance.Location = new System.Drawing.Point(4, 24);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Padding = new System.Windows.Forms.Padding(5);
            this.tabAttendance.Size = new System.Drawing.Size(1092, 722);
            this.tabAttendance.TabIndex = 2;
            this.tabAttendance.Text = "Quản lý Chấm công";
            this.tabAttendance.BackColor = Color.White;

            // inputPanelAttendance
            this.inputPanelAttendance.Controls.Add(this.btnUpdateAttendance);
            this.inputPanelAttendance.Controls.Add(this.btnDeleteAttendance);
            this.inputPanelAttendance.Controls.Add(this.btnRefreshAttendance);
            this.inputPanelAttendance.Controls.Add(this.btnAddAttendance);
            this.inputPanelAttendance.Controls.Add(this.cmbAttendanceStatus);
            this.inputPanelAttendance.Controls.Add(this.txtCheckOut);
            this.inputPanelAttendance.Controls.Add(this.txtCheckIn);
            this.inputPanelAttendance.Controls.Add(this.txtDate);
            this.inputPanelAttendance.Controls.Add(this.cmbAttendanceEmployeeId);
            this.inputPanelAttendance.Controls.Add(this.lblAttendanceStatus);
            this.inputPanelAttendance.Controls.Add(this.lblCheckOut);
            this.inputPanelAttendance.Controls.Add(this.lblCheckIn);
            this.inputPanelAttendance.Controls.Add(this.lblDate);
            this.inputPanelAttendance.Controls.Add(this.lblAttendanceEmployee);
            this.inputPanelAttendance.Location = new System.Drawing.Point(10, 10);
            this.inputPanelAttendance.Name = "inputPanelAttendance";
            this.inputPanelAttendance.Size = new System.Drawing.Size(520, 350);
            this.inputPanelAttendance.BackColor = Color.White;
            this.inputPanelAttendance.BorderStyle = BorderStyle.FixedSingle;
            this.inputPanelAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // detailPanelAttendance
            this.detailPanelAttendance.Location = new System.Drawing.Point(540, 10);
            this.detailPanelAttendance.Name = "detailPanelAttendance";
            this.detailPanelAttendance.Size = new System.Drawing.Size(520, 350);
            this.detailPanelAttendance.BackColor = Color.White;
            this.detailPanelAttendance.BorderStyle = BorderStyle.FixedSingle;
            this.detailPanelAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // dgvAttendance
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(10, 370);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.Size = new System.Drawing.Size(1070, 340);
            this.dgvAttendance.TabIndex = 0;
            this.dgvAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // btnAddAttendance
            this.btnAddAttendance.Location = new System.Drawing.Point(110, 270);
            this.btnAddAttendance.Name = "btnAddAttendance";
            this.btnAddAttendance.Size = new System.Drawing.Size(290, 30);
            this.btnAddAttendance.TabIndex = 17;
            this.btnAddAttendance.Text = "Thêm Chấm công";
            this.btnAddAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnRefreshAttendance
            this.btnRefreshAttendance.Location = new System.Drawing.Point(10, 310);
            this.btnRefreshAttendance.Name = "btnRefreshAttendance";
            this.btnRefreshAttendance.Size = new System.Drawing.Size(100, 30);
            this.btnRefreshAttendance.TabIndex = 18;
            this.btnRefreshAttendance.Text = "Tải lại";
            this.btnRefreshAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnDeleteAttendance
            this.btnDeleteAttendance.Location = new System.Drawing.Point(110, 310);
            this.btnDeleteAttendance.Name = "btnDeleteAttendance";
            this.btnDeleteAttendance.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteAttendance.TabIndex = 19;
            this.btnDeleteAttendance.Text = "Xóa Chấm công";
            this.btnDeleteAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnUpdateAttendance
            this.btnUpdateAttendance.Location = new System.Drawing.Point(210, 310);
            this.btnUpdateAttendance.Name = "btnUpdateAttendance";
            this.btnUpdateAttendance.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateAttendance.TabIndex = 20;
            this.btnUpdateAttendance.Text = "Sửa Chấm công";
            this.btnUpdateAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // cmbAttendanceEmployeeId
            this.cmbAttendanceEmployeeId.Location = new System.Drawing.Point(110, 0);
            this.cmbAttendanceEmployeeId.Name = "cmbAttendanceEmployeeId";
            this.cmbAttendanceEmployeeId.Size = new System.Drawing.Size(290, 25);
            this.cmbAttendanceEmployeeId.TabIndex = 10;
            this.cmbAttendanceEmployeeId.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtDate
            this.txtDate.Location = new System.Drawing.Point(110, 30);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(290, 25);
            this.txtDate.TabIndex = 11;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtCheckIn
            this.txtCheckIn.Location = new System.Drawing.Point(110, 60);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(290, 25);
            this.txtCheckIn.TabIndex = 12;
            this.txtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtCheckIn.ShowUpDown = true;
            this.txtCheckIn.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // txtCheckOut
            this.txtCheckOut.Location = new System.Drawing.Point(110, 90);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(290, 25);
            this.txtCheckOut.TabIndex = 13;
            this.txtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtCheckOut.ShowUpDown = true;
            this.txtCheckOut.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // cmbAttendanceStatus
            this.cmbAttendanceStatus.Location = new System.Drawing.Point(110, 120);
            this.cmbAttendanceStatus.Name = "cmbAttendanceStatus";
            this.cmbAttendanceStatus.Size = new System.Drawing.Size(290, 25);
            this.cmbAttendanceStatus.TabIndex = 14;
            this.cmbAttendanceStatus.Items.AddRange(new object[] { "Có mặt", "Vắng mặt", "Đi muộn", "Về sớm" });
            this.cmbAttendanceStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblAttendanceEmployee
            this.lblAttendanceEmployee.AutoSize = true;
            this.lblAttendanceEmployee.Location = new System.Drawing.Point(10, 3);
            this.lblAttendanceEmployee.Name = "lblAttendanceEmployee";
            this.lblAttendanceEmployee.Size = new System.Drawing.Size(60, 13);
            this.lblAttendanceEmployee.TabIndex = 0;
            this.lblAttendanceEmployee.Text = "Nhân viên:";
            this.lblAttendanceEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Ngày:";
            this.lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblCheckIn
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(10, 63);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(50, 13);
            this.lblCheckIn.TabIndex = 0;
            this.lblCheckIn.Text = "Giờ vào:";
            this.lblCheckIn.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblCheckOut
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(10, 93);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(45, 13);
            this.lblCheckOut.TabIndex = 0;
            this.lblCheckOut.Text = "Giờ ra:";
            this.lblCheckOut.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblAttendanceStatus
            this.lblAttendanceStatus.AutoSize = true;
            this.lblAttendanceStatus.Location = new System.Drawing.Point(10, 123);
            this.lblAttendanceStatus.Name = "lblAttendanceStatus";
            this.lblAttendanceStatus.Size = new System.Drawing.Size(60, 13);
            this.lblAttendanceStatus.TabIndex = 0;
            this.lblAttendanceStatus.Text = "Trạng thái:";
            this.lblAttendanceStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Form Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.tabControlMain);
            this.Name = "HRManagementForm";
            this.Text = "Ứng dụng Quản lý Nhân sự";
            this.tabControlMain.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.inputPanelEmployee.ResumeLayout(false);
            this.inputPanelEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tabContract.ResumeLayout(false);
            this.inputPanelContract.ResumeLayout(false);
            this.inputPanelContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.tabAttendance.ResumeLayout(false);
            this.inputPanelAttendance.ResumeLayout(false);
            this.inputPanelAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabContract;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.Panel inputPanelEmployee;
        private System.Windows.Forms.Panel detailPanelEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnRefreshEmployees;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Panel inputPanelContract;
        private System.Windows.Forms.Panel detailPanelContract;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.Button btnRefreshContracts;
        private System.Windows.Forms.Button btnDeleteContract;
        private System.Windows.Forms.Button btnUpdateContract;
        private System.Windows.Forms.ComboBox cmbContractEmployeeId;
        private System.Windows.Forms.TextBox txtContractType;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.TextBox txtContractSalary;
        private System.Windows.Forms.ComboBox cmbContractStatus;
        private System.Windows.Forms.Label lblContractEmployee;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblContractSalary;
        private System.Windows.Forms.Label lblContractStatus;
        private System.Windows.Forms.Panel inputPanelAttendance;
        private System.Windows.Forms.Panel detailPanelAttendance;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button btnAddAttendance;
        private System.Windows.Forms.Button btnRefreshAttendance;
        private System.Windows.Forms.Button btnDeleteAttendance;
        private System.Windows.Forms.Button btnUpdateAttendance;
        private System.Windows.Forms.ComboBox cmbAttendanceEmployeeId;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.DateTimePicker txtCheckIn;
        private System.Windows.Forms.DateTimePicker txtCheckOut;
        private System.Windows.Forms.ComboBox cmbAttendanceStatus;
        private System.Windows.Forms.Label lblAttendanceEmployee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblAttendanceStatus;
    }
}