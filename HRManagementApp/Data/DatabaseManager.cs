using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManagementApp.Models;

namespace HRManagementApp.Data
{
    public class DatabaseManager
    {
        private readonly string connectionString;

        public DatabaseManager()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HRConnection"].ConnectionString;
        }

        public DataTable GetEmployees()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT e.id AS [ID], e.first_name AS [Tên], e.last_name AS [Họ], e.birth_date AS [Ngày sinh], e.gender AS [Giới tính], " +
                               "e.address AS [Địa chỉ], e.phone AS [Số điện thoại], e.email AS [Email], d.name AS [Chức danh], p.name AS [Chức vụ], " +
                               "e.hire_date AS [Ngày tuyển dụng], e.education AS [Học vấn], e.cccd AS [CCCD] " +
                               "FROM employees e " +
                               "LEFT JOIN departments d ON e.department_id = d.id " +
                               "LEFT JOIN positions p ON e.position_id = p.id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        public DataTable GetContracts()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT c.id AS [ID], c.employee_id AS [ID Nhân viên], e.first_name + ' ' + e.last_name AS [Tên Nhân viên], " +
                               "c.type AS [Loại hợp đồng], c.start_date AS [Ngày bắt đầu], c.end_date AS [Ngày kết thúc], " +
                               "c.salary AS [Lương], c.status AS [Trạng thái], e.cccd AS [CCCD], e.phone AS [Số điện thoại], " +
                               "e.email AS [Email], d.name AS [Chức danh], p.name AS [Chức vụ] " +
                               "FROM contracts c " +
                               "JOIN employees e ON c.employee_id = e.id " +
                               "LEFT JOIN departments d ON e.department_id = d.id " +
                               "LEFT JOIN positions p ON e.position_id = p.id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }
        public DataTable GetAttendance()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT a.id AS [ID], a.employee_id AS [ID Nhân viên], e.first_name + ' ' + e.last_name AS [Tên Nhân viên], " +
                               "a.[date] AS [Ngày], a.check_in AS [Giờ vào], a.check_out AS [Giờ ra], a.status AS [Trạng thái], " +
                               "a.admin_hours AS [Giờ hành chính], a.overtime_hours AS [Giờ tăng ca] " +
                               "FROM attendance a " +
                               "JOIN employees e ON a.employee_id = e.id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }
        public DataTable GetEmployeesForComboBox()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, CONCAT(id, ' - ', first_name, ' ', last_name) AS full_name FROM employees";
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        var defaultRow = table.NewRow();
                        defaultRow["id"] = "-1";
                        defaultRow["full_name"] = "-- Chọn nhân viên --";
                        table.Rows.InsertAt(defaultRow, 0);
                        return table;
                    }
                }
            }
        }

        public DataTable GetDepartments()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, name FROM departments";
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        var defaultRow = table.NewRow();
                        defaultRow["id"] = -1;
                        defaultRow["name"] = "-- Chọn chức danh --";
                        table.Rows.InsertAt(defaultRow, 0);
                        return table;
                    }
                }
            }
        }

        public DataTable GetPositions()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, name FROM positions";
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        var defaultRow = table.NewRow();
                        defaultRow["id"] = -1;
                        defaultRow["name"] = "-- Chọn chức vụ --";
                        table.Rows.InsertAt(defaultRow, 0);
                        return table;
                    }
                }
            }
        }

        public void AddEmployee(Employee employee)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO employees (id, first_name, last_name, birth_date, gender, address, phone, email, department_id, position_id, hire_date, education, cccd) " +
                               "VALUES (@id, @first_name, @last_name, @birth_date, @gender, @address, @phone, @email, @department_id, @position_id, @hire_date, @education, @cccd)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", employee.Id ?? string.Empty);
                    cmd.Parameters.AddWithValue("@first_name", employee.FirstName ?? string.Empty);
                    cmd.Parameters.AddWithValue("@last_name", employee.LastName ?? string.Empty);
                    cmd.Parameters.AddWithValue("@birth_date", employee.BirthDate);
                    cmd.Parameters.AddWithValue("@gender", employee.Gender ?? string.Empty);
                    cmd.Parameters.AddWithValue("@address", employee.Address ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@phone", employee.Phone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@email", employee.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@department_id", employee.DepartmentId > 0 ? employee.DepartmentId : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@position_id", employee.PositionId > 0 ? employee.PositionId : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@hire_date", employee.HireDate);
                    cmd.Parameters.AddWithValue("@education", employee.Education ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@cccd", employee.CCCD ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void UpdateEmployee(Employee employee)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE employees SET first_name = @first_name, last_name = @last_name, birth_date = @birth_date, gender = @gender, " +
                               "address = @address, phone = @phone, email = @email, department_id = @department_id, position_id = @position_id, " +
                               "hire_date = @hire_date, education = @education, cccd = @cccd WHERE id = @id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", employee.Id);
                    cmd.Parameters.AddWithValue("@first_name", employee.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", employee.LastName);
                    cmd.Parameters.AddWithValue("@birth_date", employee.BirthDate);
                    cmd.Parameters.AddWithValue("@gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@address", employee.Address ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@phone", employee.Phone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@email", employee.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@department_id", employee.DepartmentId > 0 ? employee.DepartmentId : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@position_id", employee.PositionId > 0 ? employee.PositionId : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@hire_date", employee.HireDate);
                    cmd.Parameters.AddWithValue("@education", employee.Education ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@cccd", employee.CCCD ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEmployee(string id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string deleteAttendanceQuery = "DELETE FROM attendance WHERE employee_id = @id";
                        using (var cmd = new SqlCommand(deleteAttendanceQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteContractsQuery = "DELETE FROM contracts WHERE employee_id = @id";
                        using (var cmd = new SqlCommand(deleteContractsQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteEmployeeQuery = "DELETE FROM employees WHERE id = @id";
                        using (var cmd = new SqlCommand(deleteEmployeeQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void AddContract(HRManagementApp.Models.Contract contract)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Kiểm tra nhân viên đã có hợp đồng chưa (mỗi nhân viên chỉ 1 hợp đồng)
                string checkQuery = "SELECT COUNT(*) FROM contracts WHERE employee_id = @employee_id";
                using (var checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@employee_id", contract.EmployeeId);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount > 0)
                    {
                        throw new InvalidOperationException("Nhân viên này đã có hợp đồng. Mỗi nhân viên chỉ được có một hợp đồng.");
                    }
                }

                string query = "INSERT INTO contracts (employee_id, type, start_date, end_date, salary, status) " +
                               "VALUES (@employee_id, @type, @start_date, @end_date, @salary, @status)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employee_id", contract.EmployeeId ?? string.Empty);
                    cmd.Parameters.AddWithValue("@type", contract.Type ?? string.Empty);
                    cmd.Parameters.AddWithValue("@start_date", contract.StartDate);
                    cmd.Parameters.AddWithValue("@end_date", contract.EndDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@salary", contract.Salary);
                    cmd.Parameters.AddWithValue("@status", contract.Status ?? string.Empty);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateContract(HRManagementApp.Models.Contract contract)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE contracts SET employee_id = @employee_id, type = @type, start_date = @start_date, end_date = @end_date, " +
                               "salary = @salary, status = @status WHERE id = @id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", contract.Id);
                    cmd.Parameters.AddWithValue("@employee_id", contract.EmployeeId);
                    cmd.Parameters.AddWithValue("@type", contract.Type);
                    cmd.Parameters.AddWithValue("@start_date", contract.StartDate);
                    cmd.Parameters.AddWithValue("@end_date", contract.EndDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@salary", contract.Salary);
                    cmd.Parameters.AddWithValue("@status", contract.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteContract(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM contracts WHERE id = @id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddAttendance(Attendance attendance)
        {
            // Tính toán giờ hành chính và tăng ca tự động
            attendance.CalculateHours();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO attendance (employee_id, [date], check_in, check_out, status, admin_hours, overtime_hours) " +
                               "VALUES (@employee_id, @date, @check_in, @check_out, @status, @admin_hours, @overtime_hours)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employee_id", attendance.EmployeeId ?? string.Empty);
                    cmd.Parameters.AddWithValue("@date", attendance.Date);
                    cmd.Parameters.AddWithValue("@check_in", attendance.CheckIn ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@check_out", attendance.CheckOut ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", attendance.Status ?? string.Empty);
                    cmd.Parameters.AddWithValue("@admin_hours", attendance.AdminHours);
                    cmd.Parameters.AddWithValue("@overtime_hours", attendance.OvertimeHours);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateAttendance(Attendance attendance)
        {
            // Tính toán giờ hành chính và tăng ca tự động khi cập nhật
            attendance.CalculateHours();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE attendance SET employee_id = @employee_id, [date] = @date, check_in = @check_in, check_out = @check_out, " +
                               "status = @status, admin_hours = @admin_hours, overtime_hours = @overtime_hours WHERE id = @id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", attendance.Id);
                    cmd.Parameters.AddWithValue("@employee_id", attendance.EmployeeId ?? string.Empty);
                    cmd.Parameters.AddWithValue("@date", attendance.Date);
                    cmd.Parameters.AddWithValue("@check_in", attendance.CheckIn ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@check_out", attendance.CheckOut ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", attendance.Status ?? string.Empty);
                    cmd.Parameters.AddWithValue("@admin_hours", attendance.AdminHours);
                    cmd.Parameters.AddWithValue("@overtime_hours", attendance.OvertimeHours);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteAttendance(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM attendance WHERE id = @id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable SearchEmployees(string searchTerm)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT e.id AS [ID], e.first_name AS [Tên], e.last_name AS [Họ], e.birth_date AS [Ngày sinh], e.gender AS [Giới tính], " +
                               "e.address AS [Địa chỉ], e.phone AS [Số điện thoại], e.email AS [Email], d.name AS [Chức danh], p.name AS [Chức vụ], " +
                               "e.hire_date AS [Ngày tuyển dụng], e.education AS [Học vấn], e.cccd AS [CCCD] " +
                               "FROM employees e " +
                               "LEFT JOIN departments d ON e.department_id = d.id " +
                               "LEFT JOIN positions p ON e.position_id = p.id " +
                               "WHERE e.id LIKE @searchTerm OR e.first_name LIKE @searchTerm OR e.last_name LIKE @searchTerm";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        public DataTable SearchContracts(string searchTerm)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT c.id AS [ID], c.employee_id AS [ID Nhân viên], e.first_name + ' ' + e.last_name AS [Tên Nhân viên], " +
                               "c.type AS [Loại hợp đồng], c.start_date AS [Ngày bắt đầu], c.end_date AS [Ngày kết thúc], " +
                               "c.salary AS [Lương], c.status AS [Trạng thái], e.cccd AS [CCCD], e.phone AS [Số điện thoại], " +
                               "e.email AS [Email], d.name AS [Chức danh], p.name AS [Chức vụ] " +
                               "FROM contracts c " +
                               "JOIN employees e ON c.employee_id = e.id " +
                               "LEFT JOIN departments d ON e.department_id = d.id " +
                               "LEFT JOIN positions p ON e.position_id = p.id " +
                               "WHERE c.employee_id LIKE @searchTerm OR e.first_name LIKE @searchTerm OR e.last_name LIKE @searchTerm";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        public DataTable SearchAttendance(string searchTerm)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT a.id AS [ID], a.employee_id AS [ID Nhân viên], e.first_name + ' ' + e.last_name AS [Tên Nhân viên], " +
                               "a.[date] AS [Ngày], a.check_in AS [Giờ vào], a.check_out AS [Giờ ra], a.status AS [Trạng thái], " +
                               "a.admin_hours AS [Giờ hành chính], a.overtime_hours AS [Giờ tăng ca] " +
                               "FROM attendance a " +
                               "JOIN employees e ON a.employee_id = e.id " +
                               "WHERE a.employee_id LIKE @searchTerm OR e.first_name LIKE @searchTerm OR e.last_name LIKE @searchTerm";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        public DataTable GetFullReport()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT e.id AS [ID Nhân viên], e.first_name AS [Tên], e.last_name AS [Họ], e.birth_date AS [Ngày sinh], " +
                               "e.gender AS [Giới tính], e.address AS [Địa chỉ], e.phone AS [Số điện thoại], e.email AS [Email], " +
                               "d.name AS [Chức danh], p.name AS [Chức vụ], e.hire_date AS [Ngày tuyển dụng], e.education AS [Học vấn], " +
                               "e.cccd AS [CCCD], c.id AS [ID Hợp đồng], c.type AS [Loại hợp đồng], c.start_date AS [Ngày bắt đầu], " +
                               "c.end_date AS [Ngày kết thúc], c.salary AS [Lương], c.status AS [Trạng thái Hợp đồng], " +
                               "a.id AS [ID Chấm công], a.[date] AS [Ngày chấm công], a.check_in AS [Giờ vào], a.check_out AS [Giờ ra], " +
                               "a.status AS [Trạng thái Chấm công], a.admin_hours AS [Giờ hành chính], a.overtime_hours AS [Giờ tăng ca] " +
                               "FROM employees e " +
                               "LEFT JOIN departments d ON e.department_id = d.id " +
                               "LEFT JOIN positions p ON e.position_id = p.id " +
                               "LEFT JOIN contracts c ON e.id = c.employee_id " +
                               "LEFT JOIN attendance a ON e.id = a.employee_id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }
    }
}
