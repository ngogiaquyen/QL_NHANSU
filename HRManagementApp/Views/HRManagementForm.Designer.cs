namespace HRManagementApp.Views
{
    partial class HRManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.tabContracts = new System.Windows.Forms.TabPage();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.splitContainerEmployees = new System.Windows.Forms.SplitContainer();
            this.splitContainerContracts = new System.Windows.Forms.SplitContainer();
            this.splitContainerAttendance = new System.Windows.Forms.SplitContainer();
            this.panelEmployeeInput = new System.Windows.Forms.Panel();
            this.lblEmployeeSearch = new System.Windows.Forms.Label();
            this.txtEmployeeSearch = new System.Windows.Forms.TextBox();
            this.btnEmployeeSearch = new System.Windows.Forms.Button();
            this.btnEmployeeExport = new System.Windows.Forms.Button();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeFirstName = new System.Windows.Forms.Label();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.lblEmployeeLastName = new System.Windows.Forms.Label();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.lblEmployeeBirthDate = new System.Windows.Forms.Label();
            this.dtpEmployeeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeGender = new System.Windows.Forms.Label();
            this.cbEmployeeGender = new System.Windows.Forms.ComboBox();
            this.lblEmployeeAddress = new System.Windows.Forms.Label();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.lblEmployeeDepartment = new System.Windows.Forms.Label();
            this.cbEmployeeDepartment = new System.Windows.Forms.ComboBox();
            this.lblEmployeePosition = new System.Windows.Forms.Label();
            this.cbEmployeePosition = new System.Windows.Forms.ComboBox();
            this.lblEmployeeHireDate = new System.Windows.Forms.Label();
            this.dtpEmployeeHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeEducation = new System.Windows.Forms.Label();
            this.txtEmployeeEducation = new System.Windows.Forms.TextBox();
            this.lblEmployeeCCCD = new System.Windows.Forms.Label();
            this.txtEmployeeCCCD = new System.Windows.Forms.TextBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.panelContractInput = new System.Windows.Forms.Panel();
            this.lblContractSearch = new System.Windows.Forms.Label();
            this.txtContractSearch = new System.Windows.Forms.TextBox();
            this.btnContractSearch = new System.Windows.Forms.Button();
            this.btnContractExport = new System.Windows.Forms.Button();
            this.btnContractAdd = new System.Windows.Forms.Button();
            this.btnContractUpdate = new System.Windows.Forms.Button();
            this.btnContractDelete = new System.Windows.Forms.Button();
            this.lblContractId = new System.Windows.Forms.Label();
            this.txtContractId = new System.Windows.Forms.TextBox();
            this.lblContractEmployee = new System.Windows.Forms.Label();
            this.cbContractEmployee = new System.Windows.Forms.ComboBox();
            this.lblContractType = new System.Windows.Forms.Label();
            this.txtContractType = new System.Windows.Forms.TextBox();
            this.lblContractStartDate = new System.Windows.Forms.Label();
            this.dtpContractStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblContractEndDate = new System.Windows.Forms.Label();
            this.dtpContractEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblContractSalary = new System.Windows.Forms.Label();
            this.nudContractSalary = new System.Windows.Forms.NumericUpDown();
            this.lblContractStatus = new System.Windows.Forms.Label();
            this.cbContractStatus = new System.Windows.Forms.ComboBox();
            this.lblContractEmployeeCCCD = new System.Windows.Forms.Label();
            this.txtContractEmployeeCCCD = new System.Windows.Forms.TextBox();
            this.lblContractEmployeePhone = new System.Windows.Forms.Label();
            this.txtContractEmployeePhone = new System.Windows.Forms.TextBox();
            this.lblContractEmployeeEmail = new System.Windows.Forms.Label();
            this.txtContractEmployeeEmail = new System.Windows.Forms.TextBox();
            this.lblContractEmployeeDepartment = new System.Windows.Forms.Label();
            this.txtContractEmployeeDepartment = new System.Windows.Forms.TextBox();
            this.lblContractEmployeePosition = new System.Windows.Forms.Label();
            this.txtContractEmployeePosition = new System.Windows.Forms.TextBox();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.panelAttendanceInput = new System.Windows.Forms.Panel();
            this.lblAttendanceSearch = new System.Windows.Forms.Label();
            this.txtAttendanceSearch = new System.Windows.Forms.TextBox();
            this.btnAttendanceSearch = new System.Windows.Forms.Button();
            this.btnAttendanceExport = new System.Windows.Forms.Button();
            this.btnAttendanceAdd = new System.Windows.Forms.Button();
            this.btnAttendanceUpdate = new System.Windows.Forms.Button();
            this.btnAttendanceDelete = new System.Windows.Forms.Button();
            this.lblAttendanceId = new System.Windows.Forms.Label();
            this.txtAttendanceId = new System.Windows.Forms.TextBox();
            this.lblAttendanceEmployee = new System.Windows.Forms.Label();
            this.cbAttendanceEmployee = new System.Windows.Forms.ComboBox();
            this.lblAttendanceDate = new System.Windows.Forms.Label();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.lblAttendanceCheckIn = new System.Windows.Forms.Label();
            this.dtpAttendanceCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblAttendanceCheckOut = new System.Windows.Forms.Label();
            this.dtpAttendanceCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();
            this.cbAttendanceStatus = new System.Windows.Forms.ComboBox();
            this.lblAttendanceAdminHours = new System.Windows.Forms.Label();
            this.txtAttendanceAdminHours = new System.Windows.Forms.TextBox();
            this.lblAttendanceOvertimeHours = new System.Windows.Forms.Label();
            this.txtAttendanceOvertimeHours = new System.Windows.Forms.TextBox();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.btnExportFullReport = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEmployees)).BeginInit();
            this.splitContainerEmployees.Panel1.SuspendLayout();
            this.splitContainerEmployees.Panel2.SuspendLayout();
            this.splitContainerEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContracts)).BeginInit();
            this.splitContainerContracts.Panel1.SuspendLayout();
            this.splitContainerContracts.Panel2.SuspendLayout();
            this.splitContainerContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAttendance)).BeginInit();
            this.splitContainerAttendance.Panel1.SuspendLayout();
            this.splitContainerAttendance.Panel2.SuspendLayout();
            this.splitContainerAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContractSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.tabContracts.SuspendLayout();
            this.tabAttendance.SuspendLayout();
            this.panelEmployeeInput.SuspendLayout();
            this.panelContractInput.SuspendLayout();
            this.panelAttendanceInput.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEmployees);
            this.tabControl.Controls.Add(this.tabContracts);
            this.tabControl.Controls.Add(this.tabAttendance);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(960, 600);
            this.tabControl.TabIndex = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.splitContainerEmployees);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(952, 574);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Text = "Quản lý Nhân viên";

            // 
            // splitContainerEmployees
            // 
            this.splitContainerEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEmployees.IsSplitterFixed = true; // Prevent splitter movement
            this.splitContainerEmployees.FixedPanel = System.Windows.Forms.FixedPanel.Panel1; // Fix Panel1 size
            this.splitContainerEmployees.Location = new System.Drawing.Point(3, 3);
            this.splitContainerEmployees.Name = "splitContainerEmployees";
            this.splitContainerEmployees.SplitterDistance = 400; // Fixed width for left panel
            this.splitContainerEmployees.Panel1MinSize = 400; // Minimum size for Panel1
            // 
            // splitContainerEmployees.Panel1
            // 
            this.splitContainerEmployees.Panel1.Controls.Add(this.panelEmployeeInput);
            // 
            // splitContainerEmployees.Panel2
            // 
            this.splitContainerEmployees.Panel2.Controls.Add(this.dgvEmployees);
            this.splitContainerEmployees.Size = new System.Drawing.Size(946, 568);
            this.splitContainerEmployees.TabIndex = 0;

            // 
            // panelEmployeeInput
            // 
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeSearch);
            this.panelEmployeeInput.Controls.Add(this.txtEmployeeSearch);
            this.panelEmployeeInput.Controls.Add(this.btnEmployeeSearch);
            this.panelEmployeeInput.Controls.Add(this.btnEmployeeExport);
            this.panelEmployeeInput.Controls.Add(this.btnEmployeeAdd);
            this.panelEmployeeInput.Controls.Add(this.btnEmployeeUpdate);
            this.panelEmployeeInput.Controls.Add(this.btnEmployeeDelete);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeId);
            this.panelEmployeeInput.Controls.Add(this.txtEmployeeId);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeFirstName);
            this.panelEmployeeInput.Controls.Add(this.txtEmployeeFirstName);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeLastName);
            this.panelEmployeeInput.Controls.Add(this.txtEmployeeLastName);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeBirthDate);
            this.panelEmployeeInput.Controls.Add(this.dtpEmployeeBirthDate);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeGender);
            this.panelEmployeeInput.Controls.Add(this.cbEmployeeGender);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeAddress);
            this.panelEmployeeInput.Controls.Add(this.txtEmployeeAddress);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeePhone);
            this.panelEmployeeInput.Controls.Add(this.txtEmployeePhone);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeEmail);
            this.panelEmployeeInput.Controls.Add(this.txtEmployeeEmail);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeDepartment);
            this.panelEmployeeInput.Controls.Add(this.cbEmployeeDepartment);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeePosition);
            this.panelEmployeeInput.Controls.Add(this.cbEmployeePosition);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeHireDate);
            this.panelEmployeeInput.Controls.Add(this.dtpEmployeeHireDate);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeEducation);
            this.panelEmployeeInput.Controls.Add(this.txtEmployeeEducation);
            this.panelEmployeeInput.Controls.Add(this.lblEmployeeCCCD);
            this.panelEmployeeInput.Controls.Add(this.txtEmployeeCCCD);
            this.panelEmployeeInput.Location = new System.Drawing.Point(0, 0);
            this.panelEmployeeInput.Name = "panelEmployeeInput";
            this.panelEmployeeInput.Size = new System.Drawing.Size(400, 568);
            this.panelEmployeeInput.TabIndex = 0;
            this.panelEmployeeInput.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // lblEmployeeSearch
            // 
            this.lblEmployeeSearch.AutoSize = false;
            this.lblEmployeeSearch.Location = new System.Drawing.Point(10, 10);
            this.lblEmployeeSearch.Name = "lblEmployeeSearch";
            this.lblEmployeeSearch.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeSearch.TabIndex = 0;
            this.lblEmployeeSearch.Text = "Tìm kiếm:";

            // 
            // txtEmployeeSearch
            // 
            this.txtEmployeeSearch.Location = new System.Drawing.Point(100, 7);
            this.txtEmployeeSearch.Name = "txtEmployeeSearch";
            this.txtEmployeeSearch.Size = new System.Drawing.Size(230, 20);
            this.txtEmployeeSearch.TabIndex = 1;
            this.txtEmployeeSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // btnEmployeeSearch
            // 
            this.btnEmployeeSearch.Location = new System.Drawing.Point(350, 7);
            this.btnEmployeeSearch.Name = "btnEmployeeSearch";
            this.btnEmployeeSearch.Size = new System.Drawing.Size(50, 23);
            this.btnEmployeeSearch.TabIndex = 2;
            this.btnEmployeeSearch.Text = "Tìm kiếm";
            this.btnEmployeeSearch.UseVisualStyleBackColor = true;
            this.btnEmployeeSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // 
            // btnEmployeeExport
            // 
            this.btnEmployeeExport.Location = new System.Drawing.Point(10, 520);
            this.btnEmployeeExport.Name = "btnEmployeeExport";
            this.btnEmployeeExport.Size = new System.Drawing.Size(80, 23);
            this.btnEmployeeExport.TabIndex = 3;
            this.btnEmployeeExport.Text = "Xuất Excel";
            this.btnEmployeeExport.UseVisualStyleBackColor = true;

            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = false;
            this.lblEmployeeId.Location = new System.Drawing.Point(10, 40);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeId.TabIndex = 4;
            this.lblEmployeeId.Text = "ID:";

            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(100, 37);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(300, 20);
            this.txtEmployeeId.TabIndex = 5;
            this.txtEmployeeId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeeFirstName
            // 
            this.lblEmployeeFirstName.AutoSize = false;
            this.lblEmployeeFirstName.Location = new System.Drawing.Point(10, 70);
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            this.lblEmployeeFirstName.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeFirstName.TabIndex = 6;
            this.lblEmployeeFirstName.Text = "Tên:";

            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(100, 67);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(300, 20);
            this.txtEmployeeFirstName.TabIndex = 7;
            this.txtEmployeeFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.AutoSize = false;
            this.lblEmployeeLastName.Location = new System.Drawing.Point(10, 100);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeLastName.TabIndex = 8;
            this.lblEmployeeLastName.Text = "Họ:";

            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Location = new System.Drawing.Point(100, 97);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(300, 20);
            this.txtEmployeeLastName.TabIndex = 9;
            this.txtEmployeeLastName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeeBirthDate
            // 
            this.lblEmployeeBirthDate.AutoSize = false;
            this.lblEmployeeBirthDate.Location = new System.Drawing.Point(10, 130);
            this.lblEmployeeBirthDate.Name = "lblEmployeeBirthDate";
            this.lblEmployeeBirthDate.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeBirthDate.TabIndex = 10;
            this.lblEmployeeBirthDate.Text = "Ngày sinh:";

            // 
            // dtpEmployeeBirthDate
            // 
            this.dtpEmployeeBirthDate.Location = new System.Drawing.Point(100, 127);
            this.dtpEmployeeBirthDate.Name = "dtpEmployeeBirthDate";
            this.dtpEmployeeBirthDate.Size = new System.Drawing.Size(300, 20);
            this.dtpEmployeeBirthDate.TabIndex = 11;
            this.dtpEmployeeBirthDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeeGender
            // 
            this.lblEmployeeGender.AutoSize = false;
            this.lblEmployeeGender.Location = new System.Drawing.Point(10, 160);
            this.lblEmployeeGender.Name = "lblEmployeeGender";
            this.lblEmployeeGender.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeGender.TabIndex = 12;
            this.lblEmployeeGender.Text = "Giới tính:";

            // 
            // cbEmployeeGender
            // 
            this.cbEmployeeGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployeeGender.Location = new System.Drawing.Point(100, 157);
            this.cbEmployeeGender.Name = "cbEmployeeGender";
            this.cbEmployeeGender.Size = new System.Drawing.Size(300, 21);
            this.cbEmployeeGender.TabIndex = 13;
            this.cbEmployeeGender.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeeAddress
            // 
            this.lblEmployeeAddress.AutoSize = false;
            this.lblEmployeeAddress.Location = new System.Drawing.Point(10, 190);
            this.lblEmployeeAddress.Name = "lblEmployeeAddress";
            this.lblEmployeeAddress.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeAddress.TabIndex = 14;
            this.lblEmployeeAddress.Text = "Địa chỉ:";

            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(100, 187);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(300, 20);
            this.txtEmployeeAddress.TabIndex = 15;
            this.txtEmployeeAddress.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = false;
            this.lblEmployeePhone.Location = new System.Drawing.Point(10, 220);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeePhone.TabIndex = 16;
            this.lblEmployeePhone.Text = "Số điện thoại:";

            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Location = new System.Drawing.Point(100, 217);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(300, 20);
            this.txtEmployeePhone.TabIndex = 17;
            this.txtEmployeePhone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = false;
            this.lblEmployeeEmail.Location = new System.Drawing.Point(10, 250);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeEmail.TabIndex = 18;
            this.lblEmployeeEmail.Text = "Email:";

            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Location = new System.Drawing.Point(100, 247);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEmployeeEmail.TabIndex = 19;
            this.txtEmployeeEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeeDepartment
            // 
            this.lblEmployeeDepartment.AutoSize = false;
            this.lblEmployeeDepartment.Location = new System.Drawing.Point(10, 280);
            this.lblEmployeeDepartment.Name = "lblEmployeeDepartment";
            this.lblEmployeeDepartment.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeDepartment.TabIndex = 20;
            this.lblEmployeeDepartment.Text = "Chức danh:";

            // 
            // cbEmployeeDepartment
            // 
            this.cbEmployeeDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployeeDepartment.Location = new System.Drawing.Point(100, 277);
            this.cbEmployeeDepartment.Name = "cbEmployeeDepartment";
            this.cbEmployeeDepartment.Size = new System.Drawing.Size(300, 21);
            this.cbEmployeeDepartment.TabIndex = 21;
            this.cbEmployeeDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.AutoSize = false;
            this.lblEmployeePosition.Location = new System.Drawing.Point(10, 310);
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeePosition.TabIndex = 22;
            this.lblEmployeePosition.Text = "Chức vụ:";

            // 
            // cbEmployeePosition
            // 
            this.cbEmployeePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployeePosition.Location = new System.Drawing.Point(100, 307);
            this.cbEmployeePosition.Name = "cbEmployeePosition";
            this.cbEmployeePosition.Size = new System.Drawing.Size(300, 21);
            this.cbEmployeePosition.TabIndex = 23;
            this.cbEmployeePosition.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeeHireDate
            // 
            this.lblEmployeeHireDate.AutoSize = false;
            this.lblEmployeeHireDate.Location = new System.Drawing.Point(10, 340);
            this.lblEmployeeHireDate.Name = "lblEmployeeHireDate";
            this.lblEmployeeHireDate.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeHireDate.TabIndex = 24;
            this.lblEmployeeHireDate.Text = "Ngày tuyển dụng:";

            // 
            // dtpEmployeeHireDate
            // 
            this.dtpEmployeeHireDate.Location = new System.Drawing.Point(100, 337);
            this.dtpEmployeeHireDate.Name = "dtpEmployeeHireDate";
            this.dtpEmployeeHireDate.Size = new System.Drawing.Size(300, 20);
            this.dtpEmployeeHireDate.TabIndex = 25;
            this.dtpEmployeeHireDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeeEducation
            // 
            this.lblEmployeeEducation.AutoSize = false;
            this.lblEmployeeEducation.Location = new System.Drawing.Point(10, 370);
            this.lblEmployeeEducation.Name = "lblEmployeeEducation";
            this.lblEmployeeEducation.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeEducation.TabIndex = 26;
            this.lblEmployeeEducation.Text = "Học vấn:";

            // 
            // txtEmployeeEducation
            // 
            this.txtEmployeeEducation.Location = new System.Drawing.Point(100, 367);
            this.txtEmployeeEducation.Name = "txtEmployeeEducation";
            this.txtEmployeeEducation.Size = new System.Drawing.Size(300, 20);
            this.txtEmployeeEducation.TabIndex = 27;
            this.txtEmployeeEducation.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblEmployeeCCCD
            // 
            this.lblEmployeeCCCD.AutoSize = false;
            this.lblEmployeeCCCD.Location = new System.Drawing.Point(10, 400);
            this.lblEmployeeCCCD.Name = "lblEmployeeCCCD";
            this.lblEmployeeCCCD.Size = new System.Drawing.Size(80, 13);
            this.lblEmployeeCCCD.TabIndex = 28;
            this.lblEmployeeCCCD.Text = "CCCD:";

            // 
            // txtEmployeeCCCD
            // 
            this.txtEmployeeCCCD.Location = new System.Drawing.Point(100, 397);
            this.txtEmployeeCCCD.Name = "txtEmployeeCCCD";
            this.txtEmployeeCCCD.Size = new System.Drawing.Size(300, 20);
            this.txtEmployeeCCCD.TabIndex = 29;
            this.txtEmployeeCCCD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Location = new System.Drawing.Point(10, 430);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(80, 23);
            this.btnEmployeeAdd.TabIndex = 30;
            this.btnEmployeeAdd.Text = "Thêm";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;

            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(100, 430);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnEmployeeUpdate.TabIndex = 31;
            this.btnEmployeeUpdate.Text = "Cập nhật";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = true;

            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.Location = new System.Drawing.Point(190, 430);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(80, 23);
            this.btnEmployeeDelete.TabIndex = 32;
            this.btnEmployeeDelete.Text = "Xóa";
            this.btnEmployeeDelete.UseVisualStyleBackColor = true;

            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(542, 568);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // tabContracts
            // 
            this.tabContracts.Controls.Add(this.splitContainerContracts);
            this.tabContracts.Location = new System.Drawing.Point(4, 22);
            this.tabContracts.Name = "tabContracts";
            this.tabContracts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContracts.Size = new System.Drawing.Size(952, 574);
            this.tabContracts.TabIndex = 1;
            this.tabContracts.Text = "Quản lý Hợp đồng";

            // 
            // splitContainerContracts
            // 
            this.splitContainerContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerContracts.IsSplitterFixed = true; // Prevent splitter movement
            this.splitContainerContracts.FixedPanel = System.Windows.Forms.FixedPanel.Panel1; // Fix Panel1 size
            this.splitContainerContracts.Location = new System.Drawing.Point(3, 3);
            this.splitContainerContracts.Name = "splitContainerContracts";
            this.splitContainerContracts.SplitterDistance = 400; // Fixed width for left panel
            this.splitContainerContracts.Panel1MinSize = 400; // Minimum size for Panel1
            // 
            // splitContainerContracts.Panel1
            // 
            this.splitContainerContracts.Panel1.Controls.Add(this.panelContractInput);
            // 
            // splitContainerContracts.Panel2
            // 
            this.splitContainerContracts.Panel2.Controls.Add(this.dgvContracts);
            this.splitContainerContracts.Size = new System.Drawing.Size(946, 568);
            this.splitContainerContracts.TabIndex = 0;

            // 
            // panelContractInput
            // 
            this.panelContractInput.Controls.Add(this.lblContractSearch);
            this.panelContractInput.Controls.Add(this.txtContractSearch);
            this.panelContractInput.Controls.Add(this.btnContractSearch);
            this.panelContractInput.Controls.Add(this.btnContractExport);
            this.panelContractInput.Controls.Add(this.btnContractAdd);
            this.panelContractInput.Controls.Add(this.btnContractUpdate);
            this.panelContractInput.Controls.Add(this.btnContractDelete);
            this.panelContractInput.Controls.Add(this.lblContractId);
            this.panelContractInput.Controls.Add(this.txtContractId);
            this.panelContractInput.Controls.Add(this.lblContractEmployee);
            this.panelContractInput.Controls.Add(this.cbContractEmployee);
            this.panelContractInput.Controls.Add(this.lblContractType);
            this.panelContractInput.Controls.Add(this.txtContractType);
            this.panelContractInput.Controls.Add(this.lblContractStartDate);
            this.panelContractInput.Controls.Add(this.dtpContractStartDate);
            this.panelContractInput.Controls.Add(this.lblContractEndDate);
            this.panelContractInput.Controls.Add(this.dtpContractEndDate);
            this.panelContractInput.Controls.Add(this.lblContractSalary);
            this.panelContractInput.Controls.Add(this.nudContractSalary);
            this.panelContractInput.Controls.Add(this.lblContractStatus);
            this.panelContractInput.Controls.Add(this.cbContractStatus);
            this.panelContractInput.Controls.Add(this.lblContractEmployeeCCCD);
            this.panelContractInput.Controls.Add(this.txtContractEmployeeCCCD);
            this.panelContractInput.Controls.Add(this.lblContractEmployeePhone);
            this.panelContractInput.Controls.Add(this.txtContractEmployeePhone);
            this.panelContractInput.Controls.Add(this.lblContractEmployeeEmail);
            this.panelContractInput.Controls.Add(this.txtContractEmployeeEmail);
            this.panelContractInput.Controls.Add(this.lblContractEmployeeDepartment);
            this.panelContractInput.Controls.Add(this.txtContractEmployeeDepartment);
            this.panelContractInput.Controls.Add(this.lblContractEmployeePosition);
            this.panelContractInput.Controls.Add(this.txtContractEmployeePosition);
            this.panelContractInput.Location = new System.Drawing.Point(0, 0);
            this.panelContractInput.Name = "panelContractInput";
            this.panelContractInput.Size = new System.Drawing.Size(400, 568);
            this.panelContractInput.TabIndex = 0;
            this.panelContractInput.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // lblContractSearch
            // 
            this.lblContractSearch.AutoSize = false;
            this.lblContractSearch.Location = new System.Drawing.Point(10, 10);
            this.lblContractSearch.Name = "lblContractSearch";
            this.lblContractSearch.Size = new System.Drawing.Size(80, 13);
            this.lblContractSearch.TabIndex = 0;
            this.lblContractSearch.Text = "Tìm kiếm:";

            // 
            // txtContractSearch
            // 
            this.txtContractSearch.Location = new System.Drawing.Point(100, 7);
            this.txtContractSearch.Name = "txtContractSearch";
            this.txtContractSearch.Size = new System.Drawing.Size(230, 20);
            this.txtContractSearch.TabIndex = 1;
            this.txtContractSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // btnContractSearch
            // 
            this.btnContractSearch.Location = new System.Drawing.Point(350, 7);
            this.btnContractSearch.Name = "btnContractSearch";
            this.btnContractSearch.Size = new System.Drawing.Size(50, 23);
            this.btnContractSearch.TabIndex = 2;
            this.btnContractSearch.Text = "Tìm kiếm";
            this.btnContractSearch.UseVisualStyleBackColor = true;
            this.btnContractSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // 
            // btnContractExport
            // 
            this.btnContractExport.Location = new System.Drawing.Point(10, 520);
            this.btnContractExport.Name = "btnContractExport";
            this.btnContractExport.Size = new System.Drawing.Size(80, 23);
            this.btnContractExport.TabIndex = 3;
            this.btnContractExport.Text = "Xuất Excel";
            this.btnContractExport.UseVisualStyleBackColor = true;

            // 
            // lblContractId
            // 
            this.lblContractId.AutoSize = false;
            this.lblContractId.Location = new System.Drawing.Point(10, 40);
            this.lblContractId.Name = "lblContractId";
            this.lblContractId.Size = new System.Drawing.Size(80, 13);
            this.lblContractId.TabIndex = 4;
            this.lblContractId.Text = "ID:";

            // 
            // txtContractId
            // 
            this.txtContractId.Location = new System.Drawing.Point(100, 37);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.ReadOnly = true;
            this.txtContractId.Size = new System.Drawing.Size(300, 20);
            this.txtContractId.TabIndex = 5;
            this.txtContractId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblContractEmployee
            // 
            this.lblContractEmployee.AutoSize = false;
            this.lblContractEmployee.Location = new System.Drawing.Point(10, 70);
            this.lblContractEmployee.Name = "lblContractEmployee";
            this.lblContractEmployee.Size = new System.Drawing.Size(80, 13);
            this.lblContractEmployee.TabIndex = 6;
            this.lblContractEmployee.Text = "Nhân viên:";

            // 
            // cbContractEmployee
            // 
            this.cbContractEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractEmployee.Location = new System.Drawing.Point(100, 67);
            this.cbContractEmployee.Name = "cbContractEmployee";
            this.cbContractEmployee.Size = new System.Drawing.Size(300, 21);
            this.cbContractEmployee.TabIndex = 7;
            this.cbContractEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = false;
            this.lblContractType.Location = new System.Drawing.Point(10, 100);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(80, 13);
            this.lblContractType.TabIndex = 8;
            this.lblContractType.Text = "Loại hợp đồng:";

            // 
            // txtContractType
            // 
            this.txtContractType.Location = new System.Drawing.Point(100, 97);
            this.txtContractType.Name = "txtContractType";
            this.txtContractType.Size = new System.Drawing.Size(300, 20);
            this.txtContractType.TabIndex = 9;
            this.txtContractType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblContractStartDate
            // 
            this.lblContractStartDate.AutoSize = false;
            this.lblContractStartDate.Location = new System.Drawing.Point(10, 130);
            this.lblContractStartDate.Name = "lblContractStartDate";
            this.lblContractStartDate.Size = new System.Drawing.Size(80, 13);
            this.lblContractStartDate.TabIndex = 10;
            this.lblContractStartDate.Text = "Ngày bắt đầu:";

            // 
            // dtpContractStartDate
            // 
            this.dtpContractStartDate.Location = new System.Drawing.Point(100, 127);
            this.dtpContractStartDate.Name = "dtpContractStartDate";
            this.dtpContractStartDate.Size = new System.Drawing.Size(300, 20);
            this.dtpContractStartDate.TabIndex = 11;
            this.dtpContractStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblContractEndDate
            // 
            this.lblContractEndDate.AutoSize = false;
            this.lblContractEndDate.Location = new System.Drawing.Point(10, 160);
            this.lblContractEndDate.Name = "lblContractEndDate";
            this.lblContractEndDate.Size = new System.Drawing.Size(80, 13);
            this.lblContractEndDate.TabIndex = 12;
            this.lblContractEndDate.Text = "Ngày kết thúc:";

            // 
            // dtpContractEndDate
            // 
            this.dtpContractEndDate.Location = new System.Drawing.Point(100, 157);
            this.dtpContractEndDate.Name = "dtpContractEndDate";
            this.dtpContractEndDate.Size = new System.Drawing.Size(300, 20);
            this.dtpContractEndDate.TabIndex = 13;
            this.dtpContractEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblContractSalary
            // 
            this.lblContractSalary.AutoSize = false;
            this.lblContractSalary.Location = new System.Drawing.Point(10, 190);
            this.lblContractSalary.Name = "lblContractSalary";
            this.lblContractSalary.Size = new System.Drawing.Size(80, 13);
            this.lblContractSalary.TabIndex = 14;
            this.lblContractSalary.Text = "Lương:";

            // 
            // nudContractSalary
            // 
            this.nudContractSalary.Location = new System.Drawing.Point(100, 187);
            this.nudContractSalary.Name = "nudContractSalary";
            this.nudContractSalary.Size = new System.Drawing.Size(300, 20);
            this.nudContractSalary.TabIndex = 15;
            this.nudContractSalary.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblContractStatus
            // 
            this.lblContractStatus.AutoSize = false;
            this.lblContractStatus.Location = new System.Drawing.Point(10, 220);
            this.lblContractStatus.Name = "lblContractStatus";
            this.lblContractStatus.Size = new System.Drawing.Size(80, 13);
            this.lblContractStatus.TabIndex = 16;
            this.lblContractStatus.Text = "Trạng thái:";

            // 
            // cbContractStatus
            // 
            this.cbContractStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContractStatus.Location = new System.Drawing.Point(100, 217);
            this.cbContractStatus.Name = "cbContractStatus";
            this.cbContractStatus.Size = new System.Drawing.Size(300, 21);
            this.cbContractStatus.TabIndex = 17;
            this.cbContractStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblContractEmployeeCCCD
            // 
            this.lblContractEmployeeCCCD.AutoSize = false;
            this.lblContractEmployeeCCCD.Location = new System.Drawing.Point(10, 250);
            this.lblContractEmployeeCCCD.Name = "lblContractEmployeeCCCD";
            this.lblContractEmployeeCCCD.Size = new System.Drawing.Size(80, 13);
            this.lblContractEmployeeCCCD.TabIndex = 18;
            this.lblContractEmployeeCCCD.Text = "CCCD:";

            // 
            // txtContractEmployeeCCCD
            // 
            this.txtContractEmployeeCCCD.Location = new System.Drawing.Point(100, 247);
            this.txtContractEmployeeCCCD.Name = "txtContractEmployeeCCCD";
            this.txtContractEmployeeCCCD.ReadOnly = true;
            this.txtContractEmployeeCCCD.Size = new System.Drawing.Size(300, 20);
            this.txtContractEmployeeCCCD.TabIndex = 19;
            this.txtContractEmployeeCCCD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblContractEmployeePhone
            // 
            this.lblContractEmployeePhone.AutoSize = false;
            this.lblContractEmployeePhone.Location = new System.Drawing.Point(10, 280);
            this.lblContractEmployeePhone.Name = "lblContractEmployeePhone";
            this.lblContractEmployeePhone.Size = new System.Drawing.Size(80, 13);
            this.lblContractEmployeePhone.TabIndex = 20;
            this.lblContractEmployeePhone.Text = "Số điện thoại:";

            // 
            // txtContractEmployeePhone
            // 
            this.txtContractEmployeePhone.Location = new System.Drawing.Point(100, 277);
            this.txtContractEmployeePhone.Name = "txtContractEmployeePhone";
            this.txtContractEmployeePhone.ReadOnly = true;
            this.txtContractEmployeePhone.Size = new System.Drawing.Size(300, 20);
            this.txtContractEmployeePhone.TabIndex = 21;
            this.txtContractEmployeePhone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblContractEmployeeEmail
            // 
            this.lblContractEmployeeEmail.AutoSize = false;
            this.lblContractEmployeeEmail.Location = new System.Drawing.Point(10, 310);
            this.lblContractEmployeeEmail.Name = "lblContractEmployeeEmail";
            this.lblContractEmployeeEmail.Size = new System.Drawing.Size(80, 13);
            this.lblContractEmployeeEmail.TabIndex = 22;
            this.lblContractEmployeeEmail.Text = "Email:";

            // 
            // txtContractEmployeeEmail
            // 
            this.txtContractEmployeeEmail.Location = new System.Drawing.Point(100, 307);
            this.txtContractEmployeeEmail.Name = "txtContractEmployeeEmail";
            this.txtContractEmployeeEmail.ReadOnly = true;
            this.txtContractEmployeeEmail.Size = new System.Drawing.Size(300, 20);
            this.txtContractEmployeeEmail.TabIndex = 23;
            this.txtContractEmployeeEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblContractEmployeeDepartment
            // 
            this.lblContractEmployeeDepartment.AutoSize = false;
            this.lblContractEmployeeDepartment.Location = new System.Drawing.Point(10, 340);
            this.lblContractEmployeeDepartment.Name = "lblContractEmployeeDepartment";
            this.lblContractEmployeeDepartment.Size = new System.Drawing.Size(80, 13);
            this.lblContractEmployeeDepartment.TabIndex = 24;
            this.lblContractEmployeeDepartment.Text = "Chức danh:";

            // 
            // txtContractEmployeeDepartment
            // 
            this.txtContractEmployeeDepartment.Location = new System.Drawing.Point(100, 337);
            this.txtContractEmployeeDepartment.Name = "txtContractEmployeeDepartment";
            this.txtContractEmployeeDepartment.ReadOnly = true;
            this.txtContractEmployeeDepartment.Size = new System.Drawing.Size(300, 20);
            this.txtContractEmployeeDepartment.TabIndex = 25;
            this.txtContractEmployeeDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblContractEmployeePosition
            // 
            this.lblContractEmployeePosition.AutoSize = false;
            this.lblContractEmployeePosition.Location = new System.Drawing.Point(10, 370);
            this.lblContractEmployeePosition.Name = "lblContractEmployeePosition";
            this.lblContractEmployeePosition.Size = new System.Drawing.Size(80, 13);
            this.lblContractEmployeePosition.TabIndex = 26;
            this.lblContractEmployeePosition.Text = "Chức vụ:";

            // 
            // txtContractEmployeePosition
            // 
            this.txtContractEmployeePosition.Location = new System.Drawing.Point(100, 367);
            this.txtContractEmployeePosition.Name = "txtContractEmployeePosition";
            this.txtContractEmployeePosition.ReadOnly = true;
            this.txtContractEmployeePosition.Size = new System.Drawing.Size(300, 20);
            this.txtContractEmployeePosition.TabIndex = 27;
            this.txtContractEmployeePosition.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // btnContractAdd
            // 
            this.btnContractAdd.Location = new System.Drawing.Point(10, 400);
            this.btnContractAdd.Name = "btnContractAdd";
            this.btnContractAdd.Size = new System.Drawing.Size(80, 23);
            this.btnContractAdd.TabIndex = 28;
            this.btnContractAdd.Text = "Thêm";
            this.btnContractAdd.UseVisualStyleBackColor = true;

            // 
            // btnContractUpdate
            // 
            this.btnContractUpdate.Location = new System.Drawing.Point(100, 400);
            this.btnContractUpdate.Name = "btnContractUpdate";
            this.btnContractUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnContractUpdate.TabIndex = 29;
            this.btnContractUpdate.Text = "Cập nhật";
            this.btnContractUpdate.UseVisualStyleBackColor = true;

            // 
            // btnContractDelete
            // 
            this.btnContractDelete.Location = new System.Drawing.Point(190, 400);
            this.btnContractDelete.Name = "btnContractDelete";
            this.btnContractDelete.Size = new System.Drawing.Size(80, 23);
            this.btnContractDelete.TabIndex = 30;
            this.btnContractDelete.Text = "Xóa";
            this.btnContractDelete.UseVisualStyleBackColor = true;

            // 
            // dgvContracts
            // 
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(0, 0);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.Size = new System.Drawing.Size(542, 568);
            this.dgvContracts.TabIndex = 0;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // tabAttendance
            // 
            this.tabAttendance.Controls.Add(this.splitContainerAttendance);
            this.tabAttendance.Location = new System.Drawing.Point(4, 22);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttendance.Size = new System.Drawing.Size(952, 574);
            this.tabAttendance.TabIndex = 2;
            this.tabAttendance.Text = "Quản lý Chấm công";

            // 
            // splitContainerAttendance
            // 
            this.splitContainerAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAttendance.IsSplitterFixed = true; // Prevent splitter movement
            this.splitContainerAttendance.FixedPanel = System.Windows.Forms.FixedPanel.Panel1; // Fix Panel1 size
            this.splitContainerAttendance.Location = new System.Drawing.Point(3, 3);
            this.splitContainerAttendance.Name = "splitContainerAttendance";
            this.splitContainerAttendance.SplitterDistance = 400; // Fixed width for left panel
            this.splitContainerAttendance.Panel1MinSize = 400; // Minimum size for Panel1
            // 
            // splitContainerAttendance.Panel1
            // 
            this.splitContainerAttendance.Panel1.Controls.Add(this.panelAttendanceInput);
            // 
            // splitContainerAttendance.Panel2
            // 
            this.splitContainerAttendance.Panel2.Controls.Add(this.dgvAttendance);
            this.splitContainerAttendance.Size = new System.Drawing.Size(946, 568);
            this.splitContainerAttendance.TabIndex = 0;

            // 
            // panelAttendanceInput
            // 
            this.panelAttendanceInput.Controls.Add(this.lblAttendanceSearch);
            this.panelAttendanceInput.Controls.Add(this.txtAttendanceSearch);
            this.panelAttendanceInput.Controls.Add(this.btnAttendanceSearch);
            this.panelAttendanceInput.Controls.Add(this.btnAttendanceExport);
            this.panelAttendanceInput.Controls.Add(this.btnAttendanceAdd);
            this.panelAttendanceInput.Controls.Add(this.btnAttendanceUpdate);
            this.panelAttendanceInput.Controls.Add(this.btnAttendanceDelete);
            this.panelAttendanceInput.Controls.Add(this.lblAttendanceId);
            this.panelAttendanceInput.Controls.Add(this.txtAttendanceId);
            this.panelAttendanceInput.Controls.Add(this.lblAttendanceEmployee);
            this.panelAttendanceInput.Controls.Add(this.cbAttendanceEmployee);
            this.panelAttendanceInput.Controls.Add(this.lblAttendanceDate);
            this.panelAttendanceInput.Controls.Add(this.dtpAttendanceDate);
            this.panelAttendanceInput.Controls.Add(this.lblAttendanceCheckIn);
            this.panelAttendanceInput.Controls.Add(this.dtpAttendanceCheckIn);
            this.panelAttendanceInput.Controls.Add(this.lblAttendanceCheckOut);
            this.panelAttendanceInput.Controls.Add(this.dtpAttendanceCheckOut);
            this.panelAttendanceInput.Controls.Add(this.lblAttendanceStatus);
            this.panelAttendanceInput.Controls.Add(this.cbAttendanceStatus);
            this.panelAttendanceInput.Controls.Add(this.lblAttendanceAdminHours);
            this.panelAttendanceInput.Controls.Add(this.txtAttendanceAdminHours);
            this.panelAttendanceInput.Controls.Add(this.lblAttendanceOvertimeHours);
            this.panelAttendanceInput.Controls.Add(this.txtAttendanceOvertimeHours);
            this.panelAttendanceInput.Location = new System.Drawing.Point(0, 0);
            this.panelAttendanceInput.Name = "panelAttendanceInput";
            this.panelAttendanceInput.Size = new System.Drawing.Size(400, 568);
            this.panelAttendanceInput.TabIndex = 0;
            this.panelAttendanceInput.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // lblAttendanceSearch
            // 
            this.lblAttendanceSearch.AutoSize = false;
            this.lblAttendanceSearch.Location = new System.Drawing.Point(10, 10);
            this.lblAttendanceSearch.Name = "lblAttendanceSearch";
            this.lblAttendanceSearch.Size = new System.Drawing.Size(80, 13);
            this.lblAttendanceSearch.TabIndex = 0;
            this.lblAttendanceSearch.Text = "Tìm kiếm:";

            // 
            // txtAttendanceSearch
            // 
            this.txtAttendanceSearch.Location = new System.Drawing.Point(100, 7);
            this.txtAttendanceSearch.Name = "txtAttendanceSearch";
            this.txtAttendanceSearch.Size = new System.Drawing.Size(230, 20);
            this.txtAttendanceSearch.TabIndex = 1;
            this.txtAttendanceSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // btnAttendanceSearch
            // 
            this.btnAttendanceSearch.Location = new System.Drawing.Point(350, 7);
            this.btnAttendanceSearch.Name = "btnAttendanceSearch";
            this.btnAttendanceSearch.Size = new System.Drawing.Size(50, 23);
            this.btnAttendanceSearch.TabIndex = 2;
            this.btnAttendanceSearch.Text = "Tìm kiếm";
            this.btnAttendanceSearch.UseVisualStyleBackColor = true;
            this.btnAttendanceSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // 
            // btnAttendanceExport
            // 
            this.btnAttendanceExport.Location = new System.Drawing.Point(10, 520);
            this.btnAttendanceExport.Name = "btnAttendanceExport";
            this.btnAttendanceExport.Size = new System.Drawing.Size(80, 23);
            this.btnAttendanceExport.TabIndex = 3;
            this.btnAttendanceExport.Text = "Xuất Excel";
            this.btnAttendanceExport.UseVisualStyleBackColor = true;

            // 
            // lblAttendanceId
            // 
            this.lblAttendanceId.AutoSize = false;
            this.lblAttendanceId.Location = new System.Drawing.Point(10, 40);
            this.lblAttendanceId.Name = "lblAttendanceId";
            this.lblAttendanceId.Size = new System.Drawing.Size(80, 13);
            this.lblAttendanceId.TabIndex = 4;
            this.lblAttendanceId.Text = "ID:";

            // 
            // txtAttendanceId
            // 
            this.txtAttendanceId.Location = new System.Drawing.Point(100, 37);
            this.txtAttendanceId.Name = "txtAttendanceId";
            this.txtAttendanceId.ReadOnly = true;
            this.txtAttendanceId.Size = new System.Drawing.Size(300, 20);
            this.txtAttendanceId.TabIndex = 5;
            this.txtAttendanceId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblAttendanceEmployee
            // 
            this.lblAttendanceEmployee.AutoSize = false;
            this.lblAttendanceEmployee.Location = new System.Drawing.Point(10, 70);
            this.lblAttendanceEmployee.Name = "lblAttendanceEmployee";
            this.lblAttendanceEmployee.Size = new System.Drawing.Size(80, 13);
            this.lblAttendanceEmployee.TabIndex = 6;
            this.lblAttendanceEmployee.Text = "Nhân viên:";

            // 
            // cbAttendanceEmployee
            // 
            this.cbAttendanceEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttendanceEmployee.Location = new System.Drawing.Point(100, 67);
            this.cbAttendanceEmployee.Name = "cbAttendanceEmployee";
            this.cbAttendanceEmployee.Size = new System.Drawing.Size(300, 21);
            this.cbAttendanceEmployee.TabIndex = 7;
            this.cbAttendanceEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblAttendanceDate
            // 
            this.lblAttendanceDate.AutoSize = false;
            this.lblAttendanceDate.Location = new System.Drawing.Point(10, 100);
            this.lblAttendanceDate.Name = "lblAttendanceDate";
            this.lblAttendanceDate.Size = new System.Drawing.Size(80, 13);
            this.lblAttendanceDate.TabIndex = 8;
            this.lblAttendanceDate.Text = "Ngày:";

            // 
            // dtpAttendanceDate
            // 
            this.dtpAttendanceDate.Location = new System.Drawing.Point(100, 97);
            this.dtpAttendanceDate.Name = "dtpAttendanceDate";
            this.dtpAttendanceDate.Size = new System.Drawing.Size(300, 20);
            this.dtpAttendanceDate.TabIndex = 9;
            this.dtpAttendanceDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblAttendanceCheckIn
            // 
            this.lblAttendanceCheckIn.AutoSize = false;
            this.lblAttendanceCheckIn.Location = new System.Drawing.Point(10, 130);
            this.lblAttendanceCheckIn.Name = "lblAttendanceCheckIn";
            this.lblAttendanceCheckIn.Size = new System.Drawing.Size(80, 13);
            this.lblAttendanceCheckIn.TabIndex = 10;
            this.lblAttendanceCheckIn.Text = "Giờ vào:";

            // 
            // dtpAttendanceCheckIn
            // 
            this.dtpAttendanceCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAttendanceCheckIn.Location = new System.Drawing.Point(100, 127);
            this.dtpAttendanceCheckIn.Name = "dtpAttendanceCheckIn";
            this.dtpAttendanceCheckIn.ShowCheckBox = true;
            this.dtpAttendanceCheckIn.Size = new System.Drawing.Size(300, 20);
            this.dtpAttendanceCheckIn.TabIndex = 11;
            this.dtpAttendanceCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblAttendanceCheckOut
            // 
            this.lblAttendanceCheckOut.AutoSize = false;
            this.lblAttendanceCheckOut.Location = new System.Drawing.Point(10, 160);
            this.lblAttendanceCheckOut.Name = "lblAttendanceCheckOut";
            this.lblAttendanceCheckOut.Size = new System.Drawing.Size(80, 13);
            this.lblAttendanceCheckOut.TabIndex = 12;
            this.lblAttendanceCheckOut.Text = "Giờ ra:";

            // 
            // dtpAttendanceCheckOut
            // 
            this.dtpAttendanceCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAttendanceCheckOut.Location = new System.Drawing.Point(100, 157);
            this.dtpAttendanceCheckOut.Name = "dtpAttendanceCheckOut";
            this.dtpAttendanceCheckOut.ShowCheckBox = true;
            this.dtpAttendanceCheckOut.Size = new System.Drawing.Size(300, 20);
            this.dtpAttendanceCheckOut.TabIndex = 13;
            this.dtpAttendanceCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblAttendanceStatus
            // 
            this.lblAttendanceStatus.AutoSize = false;
            this.lblAttendanceStatus.Location = new System.Drawing.Point(10, 190);
            this.lblAttendanceStatus.Name = "lblAttendanceStatus";
            this.lblAttendanceStatus.Size = new System.Drawing.Size(80, 13);
            this.lblAttendanceStatus.TabIndex = 14;
            this.lblAttendanceStatus.Text = "Trạng thái:";

            // 
            // cbAttendanceStatus
            // 
            this.cbAttendanceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttendanceStatus.Location = new System.Drawing.Point(100, 187);
            this.cbAttendanceStatus.Name = "cbAttendanceStatus";
            this.cbAttendanceStatus.Size = new System.Drawing.Size(300, 21);
            this.cbAttendanceStatus.TabIndex = 15;
            this.cbAttendanceStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblAttendanceAdminHours
            // 
            this.lblAttendanceAdminHours.AutoSize = false;
            this.lblAttendanceAdminHours.Location = new System.Drawing.Point(10, 220);
            this.lblAttendanceAdminHours.Name = "lblAttendanceAdminHours";
            this.lblAttendanceAdminHours.Size = new System.Drawing.Size(80, 13);
            this.lblAttendanceAdminHours.TabIndex = 16;
            this.lblAttendanceAdminHours.Text = "Giờ hành chính:";

            // 
            // txtAttendanceAdminHours
            // 
            this.txtAttendanceAdminHours.Location = new System.Drawing.Point(100, 217);
            this.txtAttendanceAdminHours.Name = "txtAttendanceAdminHours";
            this.txtAttendanceAdminHours.ReadOnly = true;
            this.txtAttendanceAdminHours.Size = new System.Drawing.Size(300, 20);
            this.txtAttendanceAdminHours.TabIndex = 17;
            this.txtAttendanceAdminHours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // lblAttendanceOvertimeHours
            // 
            this.lblAttendanceOvertimeHours.AutoSize = false;
            this.lblAttendanceOvertimeHours.Location = new System.Drawing.Point(10, 250);
            this.lblAttendanceOvertimeHours.Name = "lblAttendanceOvertimeHours";
            this.lblAttendanceOvertimeHours.Size = new System.Drawing.Size(80, 13);
            this.lblAttendanceOvertimeHours.TabIndex = 18;
            this.lblAttendanceOvertimeHours.Text = "Giờ tăng ca:";

            // 
            // txtAttendanceOvertimeHours
            // 
            this.txtAttendanceOvertimeHours.Location = new System.Drawing.Point(100, 247);
            this.txtAttendanceOvertimeHours.Name = "txtAttendanceOvertimeHours";
            this.txtAttendanceOvertimeHours.ReadOnly = true;
            this.txtAttendanceOvertimeHours.Size = new System.Drawing.Size(300, 20);
            this.txtAttendanceOvertimeHours.TabIndex = 19;
            this.txtAttendanceOvertimeHours.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // btnAttendanceAdd
            // 
            this.btnAttendanceAdd.Location = new System.Drawing.Point(10, 280);
            this.btnAttendanceAdd.Name = "btnAttendanceAdd";
            this.btnAttendanceAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAttendanceAdd.TabIndex = 20;
            this.btnAttendanceAdd.Text = "Thêm";
            this.btnAttendanceAdd.UseVisualStyleBackColor = true;

            // 
            // btnAttendanceUpdate
            // 
            this.btnAttendanceUpdate.Location = new System.Drawing.Point(100, 280);
            this.btnAttendanceUpdate.Name = "btnAttendanceUpdate";
            this.btnAttendanceUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnAttendanceUpdate.TabIndex = 21;
            this.btnAttendanceUpdate.Text = "Cập nhật";
            this.btnAttendanceUpdate.UseVisualStyleBackColor = true;

            // 
            // btnAttendanceDelete
            // 
            this.btnAttendanceDelete.Location = new System.Drawing.Point(190, 280);
            this.btnAttendanceDelete.Name = "btnAttendanceDelete";
            this.btnAttendanceDelete.Size = new System.Drawing.Size(80, 23);
            this.btnAttendanceDelete.TabIndex = 22;
            this.btnAttendanceDelete.Text = "Xóa";
            this.btnAttendanceDelete.UseVisualStyleBackColor = true;

            // 
            // dgvAttendance
            // 
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(0, 0);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.Size = new System.Drawing.Size(542, 568);
            this.dgvAttendance.TabIndex = 0;
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // btnExportFullReport
            // 
            this.btnExportFullReport.Location = new System.Drawing.Point(12, 620);
            this.btnExportFullReport.Name = "btnExportFullReport";
            this.btnExportFullReport.Size = new System.Drawing.Size(150, 23);
            this.btnExportFullReport.TabIndex = 24;
            this.btnExportFullReport.Text = "Xuất Báo cáo Toàn bộ";
            this.btnExportFullReport.UseVisualStyleBackColor = true;
            this.btnExportFullReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;

            // 
            // HRManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnExportFullReport);
            this.Controls.Add(this.tabControl);
            this.Name = "HRManagementForm";
            this.Text = "Ứng dụng Quản lý Nhân sự";

            this.panelEmployeeInput.ResumeLayout(false);
            this.panelEmployeeInput.PerformLayout();
            this.panelContractInput.ResumeLayout(false);
            this.panelContractInput.PerformLayout();
            this.panelAttendanceInput.ResumeLayout(false);
            this.panelAttendanceInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContractSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.splitContainerEmployees.Panel1.ResumeLayout(false);
            this.splitContainerEmployees.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEmployees)).EndInit();
            this.splitContainerEmployees.ResumeLayout(false);
            this.splitContainerContracts.Panel1.ResumeLayout(false);
            this.splitContainerContracts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContracts)).EndInit();
            this.splitContainerContracts.ResumeLayout(false);
            this.splitContainerAttendance.Panel1.ResumeLayout(false);
            this.splitContainerAttendance.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAttendance)).EndInit();
            this.splitContainerAttendance.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            this.tabContracts.ResumeLayout(false);
            this.tabAttendance.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabContracts;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.SplitContainer splitContainerEmployees;
        private System.Windows.Forms.SplitContainer splitContainerContracts;
        private System.Windows.Forms.SplitContainer splitContainerAttendance;
        private System.Windows.Forms.Panel panelEmployeeInput;
        private System.Windows.Forms.Label lblEmployeeSearch;
        private System.Windows.Forms.TextBox txtEmployeeSearch;
        private System.Windows.Forms.Button btnEmployeeSearch;
        private System.Windows.Forms.Button btnEmployeeExport;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.Button btnEmployeeUpdate;
        private System.Windows.Forms.Button btnEmployeeDelete;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblEmployeeFirstName;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.Label lblEmployeeLastName;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.Label lblEmployeeBirthDate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeBirthDate;
        private System.Windows.Forms.Label lblEmployeeGender;
        private System.Windows.Forms.ComboBox cbEmployeeGender;
        private System.Windows.Forms.Label lblEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeeDepartment;
        private System.Windows.Forms.ComboBox cbEmployeeDepartment;
        private System.Windows.Forms.Label lblEmployeePosition;
        private System.Windows.Forms.ComboBox cbEmployeePosition;
        private System.Windows.Forms.Label lblEmployeeHireDate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeHireDate;
        private System.Windows.Forms.Label lblEmployeeEducation;
        private System.Windows.Forms.TextBox txtEmployeeEducation;
        private System.Windows.Forms.Label lblEmployeeCCCD;
        private System.Windows.Forms.TextBox txtEmployeeCCCD;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel panelContractInput;
        private System.Windows.Forms.Label lblContractSearch;
        private System.Windows.Forms.TextBox txtContractSearch;
        private System.Windows.Forms.Button btnContractSearch;
        private System.Windows.Forms.Button btnContractExport;
        private System.Windows.Forms.Button btnContractAdd;
        private System.Windows.Forms.Button btnContractUpdate;
        private System.Windows.Forms.Button btnContractDelete;
        private System.Windows.Forms.Label lblContractId;
        private System.Windows.Forms.TextBox txtContractId;
        private System.Windows.Forms.Label lblContractEmployee;
        private System.Windows.Forms.ComboBox cbContractEmployee;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.TextBox txtContractType;
        private System.Windows.Forms.Label lblContractStartDate;
        private System.Windows.Forms.DateTimePicker dtpContractStartDate;
        private System.Windows.Forms.Label lblContractEndDate;
        private System.Windows.Forms.DateTimePicker dtpContractEndDate;
        private System.Windows.Forms.Label lblContractSalary;
        private System.Windows.Forms.NumericUpDown nudContractSalary;
        private System.Windows.Forms.Label lblContractStatus;
        private System.Windows.Forms.ComboBox cbContractStatus;
        private System.Windows.Forms.Label lblContractEmployeeCCCD;
        private System.Windows.Forms.TextBox txtContractEmployeeCCCD;
        private System.Windows.Forms.Label lblContractEmployeePhone;
        private System.Windows.Forms.TextBox txtContractEmployeePhone;
        private System.Windows.Forms.Label lblContractEmployeeEmail;
        private System.Windows.Forms.TextBox txtContractEmployeeEmail;
        private System.Windows.Forms.Label lblContractEmployeeDepartment;
        private System.Windows.Forms.TextBox txtContractEmployeeDepartment;
        private System.Windows.Forms.Label lblContractEmployeePosition;
        private System.Windows.Forms.TextBox txtContractEmployeePosition;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Panel panelAttendanceInput;
        private System.Windows.Forms.Label lblAttendanceSearch;
        private System.Windows.Forms.TextBox txtAttendanceSearch;
        private System.Windows.Forms.Button btnAttendanceSearch;
        private System.Windows.Forms.Button btnAttendanceExport;
        private System.Windows.Forms.Button btnAttendanceAdd;
        private System.Windows.Forms.Button btnAttendanceUpdate;
        private System.Windows.Forms.Button btnAttendanceDelete;
        private System.Windows.Forms.Label lblAttendanceId;
        private System.Windows.Forms.TextBox txtAttendanceId;
        private System.Windows.Forms.Label lblAttendanceEmployee;
        private System.Windows.Forms.ComboBox cbAttendanceEmployee;
        private System.Windows.Forms.Label lblAttendanceDate;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.Label lblAttendanceCheckIn;
        private System.Windows.Forms.DateTimePicker dtpAttendanceCheckIn;
        private System.Windows.Forms.Label lblAttendanceCheckOut;
        private System.Windows.Forms.DateTimePicker dtpAttendanceCheckOut;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.ComboBox cbAttendanceStatus;
        private System.Windows.Forms.Label lblAttendanceAdminHours;
        private System.Windows.Forms.TextBox txtAttendanceAdminHours;
        private System.Windows.Forms.Label lblAttendanceOvertimeHours;
        private System.Windows.Forms.TextBox txtAttendanceOvertimeHours;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button btnExportFullReport;
    }
}