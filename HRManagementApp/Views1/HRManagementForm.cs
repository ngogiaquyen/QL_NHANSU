using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using HRManagementApp.Controllers;

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
            this.Icon = new Icon("Resources/icon.ico");
            employeeController = new EmployeeController(this);
            contractController = new ContractController(this);
            attendanceController = new AttendanceController(this);
            CustomizeUI();
            InitializeEventHandlers();
            LoadInitialData();
        }

        private void InitializeEventHandlers()
        {
            btnAddEmployee.Click += (s, e) => 
            {
                var employee = new Models.Employee
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dtpBirthDate.Value,
                    Gender = cmbGender.SelectedItem?.ToString(),
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    DepartmentId = (int)cmbDepartment.SelectedValue,
                    PositionId = (int)cmbPosition.SelectedValue,
                    HireDate = dtpHireDate.Value
                };
                employeeController.AddEmployee(employee);
            };

            btnUpdateEmployee.Click += (s, e) => 
            {
                if (dgvEmployees.SelectedRows.Count > 0 && int.TryParse(dgvEmployees.SelectedRows[0].Cells["ID"].Value?.ToString(), out int id))
                {
                    var employee = new Models.Employee
                    {
                        Id = id,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        BirthDate = dtpBirthDate.Value,
                        Gender = cmbGender.SelectedItem?.ToString(),
                        Address = txtAddress.Text,
                        Phone = txtPhone.Text,
                        Email = txtEmail.Text,
                        DepartmentId = (int)cmbDepartment.SelectedValue,
                        PositionId = (int)cmbPosition.SelectedValue,
                        HireDate = dtpHireDate.Value
                    };
                    employeeController.UpdateEmployee(employee);
                }
            };

            btnDeleteEmployee.Click += (s, e) => 
            {
                if (dgvEmployees.SelectedRows.Count > 0 && int.TryParse(dgvEmployees.SelectedRows[0].Cells["ID"].Value?.ToString(), out int id))
                {
                    employeeController.DeleteEmployee(id);
                }
            };

            btnRefreshEmployees.Click += (s, e) => employeeController.LoadEmployees();

            btnAddContract.Click += (s, e) => 
            {
                var contract = new Models.Contract
                {
                    EmployeeId = (int)cmbContractEmployeeId.SelectedValue,
                    Type = txtContractType.Text,
                    StartDate = txtStartDate.Value,
                    EndDate = txtEndDate.Value,
                    Salary = decimal.TryParse(txtContractSalary.Text, out decimal salary) ? salary : 0,
                    Status = cmbContractStatus.SelectedItem?.ToString()
                };
                contractController.AddContract(contract);
            };

            btnUpdateContract.Click += (s, e) => 
            {
                if (dgvContracts.SelectedRows.Count > 0 && int.TryParse(dgvContracts.SelectedRows[0].Cells["ID"].Value?.ToString(), out int id))
                {
                    var contract = new Models.Contract
                    {
                        Id = id,
                        EmployeeId = (int)cmbContractEmployeeId.SelectedValue,
                        Type = txtContractType.Text,
                        StartDate = txtStartDate.Value,
                        EndDate = txtEndDate.Value,
                        Salary = decimal.TryParse(txtContractSalary.Text, out decimal salary) ? salary : 0,
                        Status = cmbContractStatus.SelectedItem?.ToString()
                    };
                    contractController.UpdateContract(contract);
                }
            };

            btnDeleteContract.Click += (s, e) => 
            {
                if (dgvContracts.SelectedRows.Count > 0 && int.TryParse(dgvContracts.SelectedRows[0].Cells["ID"].Value?.ToString(), out int id))
                {
                    contractController.DeleteContract(id);
                }
            };

            btnRefreshContracts.Click += (s, e) => contractController.LoadContracts();

            btnAddAttendance.Click += (s, e) => 
            {
                var attendance = new Models.Attendance
                {
                    EmployeeId = (int)cmbAttendanceEmployeeId.SelectedValue,
                    Date = txtDate.Value,
                    CheckIn = txtCheckIn.Value.TimeOfDay,
                    CheckOut = txtCheckOut.Value.TimeOfDay,
                    Status = cmbAttendanceStatus.SelectedItem?.ToString()
                };
                attendanceController.AddAttendance(attendance);
            };

            btnUpdateAttendance.Click += (s, e) => 
            {
                if (dgvAttendance.SelectedRows.Count > 0 && int.TryParse(dgvAttendance.SelectedRows[0].Cells["ID"].Value?.ToString(), out int id))
                {
                    var attendance = new Models.Attendance
                    {
                        Id = id,
                        EmployeeId = (int)cmbAttendanceEmployeeId.SelectedValue,
                        Date = txtDate.Value,
                        CheckIn = txtCheckIn.Value.TimeOfDay,
                        CheckOut = txtCheckOut.Value.TimeOfDay,
                        Status = cmbAttendanceStatus.SelectedItem?.ToString()
                    };
                    attendanceController.UpdateAttendance(attendance);
                }
            };

            btnDeleteAttendance.Click += (s, e) => 
            {
                if (dgvAttendance.SelectedRows.Count > 0 && int.TryParse(dgvAttendance.SelectedRows[0].Cells["ID"].Value?.ToString(), out int id))
                {
                    attendanceController.DeleteAttendance(id);
                }
            };

            btnRefreshAttendance.Click += (s, e) => attendanceController.LoadAttendance();

            dgvEmployees.CellClick += (s, e) => 
            {
                if (e.RowIndex >= 0 && !dgvEmployees.Rows[e.RowIndex].IsNewRow)
                {
                    employeeController.ShowEmployeeDetails(dgvEmployees.Rows[e.RowIndex]);
                    UpdateEmployeeFields(dgvEmployees.Rows[e.RowIndex]);
                }
            };

            dgvContracts.CellClick += (s, e) => 
            {
                if (e.RowIndex >= 0 && !dgvContracts.Rows[e.RowIndex].IsNewRow)
                {
                    contractController.ShowContractDetails(dgvContracts.Rows[e.RowIndex]);
                    UpdateContractFields(dgvContracts.Rows[e.RowIndex]);
                }
            };

            dgvAttendance.CellClick += (s, e) => 
            {
                if (e.RowIndex >= 0 && !dgvAttendance.Rows[e.RowIndex].IsNewRow)
                {
                    attendanceController.ShowAttendanceDetails(dgvAttendance.Rows[e.RowIndex]);
                    UpdateAttendanceFields(dgvAttendance.Rows[e.RowIndex]);
                }
            };
        }

        private void LoadInitialData()
        {
            employeeController.LoadEmployees();
            contractController.LoadContracts();
            attendanceController.LoadAttendance();
        }

        private void CustomizeUI()
        {
            this.Font = new Font("Segoe UI", 9F);
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(800, 600);
            this.BackColor = Color.White;

            CustomizeDataGridView(dgvEmployees);
            CustomizeDataGridView(dgvContracts);
            CustomizeDataGridView(dgvAttendance);

            CustomizeButton(btnAddEmployee);
            CustomizeButton(btnRefreshEmployees);
            CustomizeButton(btnDeleteEmployee);
            CustomizeButton(btnUpdateEmployee);
            CustomizeButton(btnAddContract);
            CustomizeButton(btnRefreshContracts);
            CustomizeButton(btnDeleteContract);
            CustomizeButton(btnUpdateContract);
            CustomizeButton(btnAddAttendance);
            CustomizeButton(btnRefreshAttendance);
            CustomizeButton(btnDeleteAttendance);
            CustomizeButton(btnUpdateAttendance);

            CustomizeInput(txtFirstName);
            CustomizeInput(txtLastName);
            CustomizeInput(txtAddress);
            CustomizeInput(txtPhone);
            CustomizeInput(txtEmail);
            CustomizeInput(txtContractType);
            CustomizeInput(txtContractSalary);

            CustomizeDateTimePicker(dtpBirthDate);
            CustomizeDateTimePicker(dtpHireDate);
            CustomizeDateTimePicker(txtStartDate);
            CustomizeDateTimePicker(txtEndDate);
            CustomizeDateTimePicker(txtDate);
            CustomizeDateTimePicker(txtCheckIn);
            CustomizeDateTimePicker(txtCheckOut);

            CustomizeComboBox(cmbGender);
            CustomizeComboBox(cmbDepartment);
            CustomizeComboBox(cmbPosition);
            CustomizeComboBox(cmbContractEmployeeId);
            CustomizeComboBox(cmbAttendanceEmployeeId);
            CustomizeComboBox(cmbAttendanceStatus);
            CustomizeComboBox(cmbContractStatus);

            CustomizeLabel(lblFirstName);
            CustomizeLabel(lblLastName);
            CustomizeLabel(lblBirthDate);
            CustomizeLabel(lblGender);
            CustomizeLabel(lblAddress);
            CustomizeLabel(lblPhone);
            CustomizeLabel(lblEmail);
            CustomizeLabel(lblDepartment);
            CustomizeLabel(lblPosition);
            CustomizeLabel(lblHireDate);
            CustomizeLabel(lblContractEmployee);
            CustomizeLabel(lblContractType);
            CustomizeLabel(lblStartDate);
            CustomizeLabel(lblEndDate);
            CustomizeLabel(lblContractSalary);
            CustomizeLabel(lblContractStatus);
            CustomizeLabel(lblAttendanceEmployee);
            CustomizeLabel(lblDate);
            CustomizeLabel(lblCheckIn);
            CustomizeLabel(lblCheckOut);
            CustomizeLabel(lblAttendanceStatus);

            CustomizeDetailPanel(detailPanelEmployee);
            CustomizeDetailPanel(detailPanelContract);
            CustomizeDetailPanel(detailPanelAttendance);

            tabControlMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlMain.DrawItem += (s, e) =>
            {
                var g = e.Graphics;
                var tabBounds = tabControlMain.GetTabRect(e.Index);
                using (var brush = new SolidBrush(e.State == DrawItemState.Selected ? Color.FromArgb(2, 136, 209) : Color.White))
                {
                    g.FillRectangle(brush, tabBounds);
                }
                using (var font = new Font("Segoe UI", 9F, FontStyle.Regular))
                {
                    var textColor = e.State == DrawItemState.Selected ? Brushes.White : new SolidBrush(Color.FromArgb(2, 136, 209));
                    var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(tabControlMain.TabPages[e.Index].Text, font, textColor, tabBounds, format);
                }
            };

            var toolTip = new ToolTip();
            toolTip.SetToolTip(btnAddEmployee, "Thêm một nhân viên mới vào hệ thống");
            toolTip.SetToolTip(btnDeleteEmployee, "Xóa nhân viên đang chọn");
            toolTip.SetToolTip(btnRefreshEmployees, "Tải lại danh sách nhân viên");
            toolTip.SetToolTip(btnUpdateEmployee, "Cập nhật thông tin nhân viên đang chọn");
            toolTip.SetToolTip(txtFirstName, "Nhập tên của nhân viên");
            toolTip.SetToolTip(txtLastName, "Nhập họ của nhân viên");
            toolTip.SetToolTip(cmbContractEmployeeId, "Chọn nhân viên cho hợp đồng");
            toolTip.SetToolTip(cmbAttendanceEmployeeId, "Chọn nhân viên để chấm công");
        }

        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(2, 136, 209);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.RowTemplate.Height = 30;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            dgv.CellPainting += (s, e) =>
            {
                if (e.RowIndex == -1 && e.ColumnIndex == -1)
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using (var pen = new Pen(Color.FromArgb(179, 229, 252), 2))
                    {
                        var rect = new Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1, e.CellBounds.Width - 2, e.CellBounds.Height - 2);
                        e.Graphics.DrawRectangle(pen, rect);
                    }
                    e.Handled = true;
                }
            };
        }

        private void CustomizeButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.FromArgb(2, 136, 209);
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(1, 87, 155);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 87, 155);
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Height = 36;
            btn.Cursor = Cursors.Hand;
            btn.MouseEnter += (s, e) => btn.Top -= 2;
            btn.MouseLeave += (s, e) => btn.Top += 2;
            btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 8, 8));
        }

        private void CustomizeInput(Control input)
        {
            input.BackColor = Color.White;
            input.ForeColor = Color.FromArgb(33, 33, 33);
            input.Font = new Font("Segoe UI", 9F);
            input.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var pen = new Pen(Color.FromArgb(179, 229, 252), 1))
                {
                    var rect = new Rectangle(0, 0, input.Width - 1, input.Height - 1);
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };
        }

        private void CustomizeComboBox(ComboBox cmb)
        {
            cmb.BackColor = Color.White;
            cmb.ForeColor = Color.FromArgb(33, 33, 33);
            cmb.Font = new Font("Segoe UI", 9F);
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.DropDownWidth = 300;
            cmb.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var pen = new Pen(Color.FromArgb(179, 229, 252), 1))
                {
                    var rect = new Rectangle(0, 0, cmb.Width - 1, cmb.Height - 1);
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };
        }

        private void CustomizeDateTimePicker(DateTimePicker dtp)
        {
            dtp.BackColor = Color.White;
            dtp.ForeColor = Color.FromArgb(33, 33, 33);
            dtp.Font = new Font("Segoe UI", 9F);
            dtp.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var pen = new Pen(Color.FromArgb(179, 229, 252), 1))
                {
                    var rect = new Rectangle(0, 0, dtp.Width - 1, dtp.Height - 1);
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };
        }

        private void CustomizeLabel(Label lbl)
        {
            lbl.ForeColor = Color.FromArgb(33, 33, 33);
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        }

        private void CustomizeDetailPanel(Panel panel)
        {
            panel.BackColor = Color.White;
            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                var rect = new Rectangle(2, 2, panel.Width - 4, panel.Height - 4);
                using (var pen = new Pen(Color.FromArgb(179, 229, 252), 2))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
                ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
                    Color.FromArgb(0, 0, 0, 20), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(0, 0, 0, 20), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(0, 0, 0, 20), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(0, 0, 0, 20), 1, ButtonBorderStyle.Solid);
            };
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

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

        public void LoadEmployeesToComboBox(DataTable table)
        {
            cmbContractEmployeeId.DataSource = table;
            cmbContractEmployeeId.DisplayMember = "full_name";
            cmbContractEmployeeId.ValueMember = "id";
            cmbContractEmployeeId.SelectedIndex = 0;

            cmbAttendanceEmployeeId.DataSource = table.Copy();
            cmbAttendanceEmployeeId.DisplayMember = "full_name";
            cmbAttendanceEmployeeId.ValueMember = "id";
            cmbAttendanceEmployeeId.SelectedIndex = 0;
        }

        public void LoadDepartments(DataTable table)
        {
            cmbDepartment.DataSource = table;
            cmbDepartment.DisplayMember = "name";
            cmbDepartment.ValueMember = "id";
            cmbDepartment.SelectedIndex = 0;
        }

        public void LoadPositions(DataTable table)
        {
            cmbPosition.DataSource = table;
            cmbPosition.DisplayMember = "name";
            cmbPosition.ValueMember = "id";
            cmbPosition.SelectedIndex = 0;
        }

        public void ShowEmployeeDetails(DataGridViewRow row)
        {
            detailPanelEmployee.Controls.Clear();
            var lblTitle = new Label
            {
                Text = "Chi tiết Nhân viên",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(2, 136, 209),
                AutoSize = true,
                Location = new Point(10, 10)
            };
            var lblInfo = new Label
            {
                Text = $"ID: {row.Cells["ID"].Value}\n" +
                       $"Họ: {row.Cells["Họ"].Value}\n" +
                       $"Tên: {row.Cells["Tên"].Value}\n" +
                       $"Ngày sinh: {((DateTime)row.Cells["Ngày sinh"].Value).ToShortDateString()}\n" +
                       $"Giới tính: {row.Cells["Giới tính"].Value}\n" +
                       $"Địa chỉ: {row.Cells["Địa chỉ"].Value}\n" +
                       $"Số điện thoại: {row.Cells["Số điện thoại"].Value}\n" +
                       $"Email: {row.Cells["Email"].Value}\n" +
                       $"Phòng ban: {row.Cells["Phòng ban"].Value}\n" +
                       $"Chức vụ: {row.Cells["Chức vụ"].Value}\n" +
                       $"Ngày tuyển dụng: {((DateTime)row.Cells["Ngày tuyển dụng"].Value).ToShortDateString()}",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(33, 33, 33),
                AutoSize = true,
                Location = new Point(10, 35)
            };
            detailPanelEmployee.Controls.Add(lblTitle);
            detailPanelEmployee.Controls.Add(lblInfo);
        }

        public void ShowContractDetails(DataGridViewRow row)
        {
            detailPanelContract.Controls.Clear();
            var lblTitle = new Label
            {
                Text = "Chi tiết Hợp đồng",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(2, 136, 209),
                AutoSize = true,
                Location = new Point(10, 10)
            };
            var lblInfo = new Label
            {
                Text = $"ID Nhân viên: {row.Cells["ID Nhân viên"].Value}\n" +
                       $"Loại hợp đồng: {row.Cells["Loại hợp đồng"].Value}\n" +
                       $"Ngày bắt đầu: {((DateTime)row.Cells["Ngày bắt đầu"].Value).ToShortDateString()}\n" +
                       $"Ngày kết thúc: {((DateTime)row.Cells["Ngày kết thúc"].Value).ToShortDateString()}\n" +
                       $"Lương: {row.Cells["Lương"].Value}\n" +
                       $"Trạng thái: {row.Cells["Trạng thái"].Value}",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(33, 33, 33),
                AutoSize = true,
                Location = new Point(10, 35)
            };
            detailPanelContract.Controls.Add(lblTitle);
            detailPanelContract.Controls.Add(lblInfo);
        }

        public void ShowAttendanceDetails(DataGridViewRow row)
        {
            detailPanelAttendance.Controls.Clear();
            var lblTitle = new Label
            {
                Text = "Chi tiết Chấm công",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(2, 136, 209),
                AutoSize = true,
                Location = new Point(10, 10)
            };
            var lblInfo = new Label
            {
                Text = $"ID Nhân viên: {row.Cells["ID Nhân viên"].Value}\n" +
                       $"Ngày: {((DateTime)row.Cells["Ngày"].Value).ToShortDateString()}\n" +
                       $"Giờ vào: {row.Cells["Giờ vào"].Value}\n" +
                       $"Giờ ra: {row.Cells["Giờ ra"].Value}\n" +
                       $"Trạng thái: {row.Cells["Trạng thái"].Value}",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(33, 33, 33),
                AutoSize = true,
                Location = new Point(10, 35)
            };
            detailPanelAttendance.Controls.Add(lblTitle);
            detailPanelAttendance.Controls.Add(lblInfo);
        }

        private void UpdateEmployeeFields(DataGridViewRow row)
        {
            txtFirstName.Text = row.Cells["Tên"].Value?.ToString() ?? string.Empty;
            txtLastName.Text = row.Cells["Họ"].Value?.ToString() ?? string.Empty;
            dtpBirthDate.Value = row.Cells["Ngày sinh"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["Ngày sinh"].Value) : DateTime.Today;
            cmbGender.SelectedItem = row.Cells["Giới tính"].Value?.ToString();
            txtAddress.Text = row.Cells["Địa chỉ"].Value?.ToString() ?? string.Empty;
            txtPhone.Text = row.Cells["Số điện thoại"].Value?.ToString() ?? string.Empty;
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
            cmbDepartment.Text = row.Cells["Phòng ban"].Value?.ToString() ?? string.Empty;
            cmbPosition.Text = row.Cells["Chức vụ"].Value?.ToString() ?? string.Empty;
            dtpHireDate.Value = row.Cells["Ngày tuyển dụng"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["Ngày tuyển dụng"].Value) : DateTime.Today;
        }

        private void UpdateContractFields(DataGridViewRow row)
        {
            if (int.TryParse(row.Cells["ID Nhân viên"].Value?.ToString(), out int empId))
                cmbContractEmployeeId.SelectedValue = empId;
            else
                cmbContractEmployeeId.SelectedValue = -1;

            txtContractType.Text = row.Cells["Loại hợp đồng"].Value?.ToString() ?? string.Empty;
            txtStartDate.Value = row.Cells["Ngày bắt đầu"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["Ngày bắt đầu"].Value) : DateTime.Today;
            txtEndDate.Value = row.Cells["Ngày kết thúc"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["Ngày kết thúc"].Value) : DateTime.Today;
            txtContractSalary.Text = row.Cells["Lương"].Value?.ToString() ?? string.Empty;
            cmbContractStatus.SelectedItem = row.Cells["Trạng thái"].Value?.ToString();
        }

        private void UpdateAttendanceFields(DataGridViewRow row)
        {
            if (int.TryParse(row.Cells["ID Nhân viên"].Value?.ToString(), out int empId))
                cmbAttendanceEmployeeId.SelectedValue = empId;

            txtDate.Value = Convert.ToDateTime(row.Cells["Ngày"].Value);
            txtCheckIn.Value = row.Cells["Giờ vào"].Value != null && row.Cells["Giờ vào"].Value is TimeSpan checkInTime
                ? DateTime.Today.Add(checkInTime)
                : DateTime.Now;
            txtCheckOut.Value = row.Cells["Giờ ra"].Value != null && row.Cells["Giờ ra"].Value is TimeSpan checkOutTime
                ? DateTime.Today.Add(checkOutTime)
                : DateTime.Now;
            cmbAttendanceStatus.SelectedItem = row.Cells["Trạng thái"].Value?.ToString();
        }

        public void ClearEmployeeFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpBirthDate.Value = DateTime.Now;
            cmbGender.SelectedIndex = -1;
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cmbDepartment.SelectedIndex = 0;
            cmbPosition.SelectedIndex = 0;
            dtpHireDate.Value = DateTime.Now;
        }

        public void ClearContractFields()
        {
            cmbContractEmployeeId.SelectedIndex = 0;
            txtContractType.Clear();
            txtStartDate.Value = DateTime.Now;
            txtEndDate.Value = DateTime.Now;
            txtContractSalary.Clear();
            cmbContractStatus.SelectedIndex = -1;
        }

        public void ClearAttendanceFields()
        {
            cmbAttendanceEmployeeId.SelectedIndex = 0;
            txtDate.Value = DateTime.Now;
            txtCheckIn.Value = DateTime.Now;
            txtCheckOut.Value = DateTime.Now;
            cmbAttendanceStatus.SelectedIndex = -1;
        }

        public void ClearDetailPanels()
        {
            detailPanelEmployee.Controls.Clear();
            detailPanelContract.Controls.Clear();
            detailPanelAttendance.Controls.Clear();
        }
    }
}