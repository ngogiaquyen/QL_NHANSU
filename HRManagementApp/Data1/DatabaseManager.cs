using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
                               "e.address AS [Địa chỉ], e.phone AS [Số điện thoại], e.email AS [Email], d.name AS [Phòng ban], p.name AS [Chức vụ], " +
                               "e.hire_date AS [Ngày tuyển dụng] " +
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
                string query = "SELECT c.id AS [ID], c.employee_id AS [ID Nhân viên], c.type AS [Loại hợp đồng], c.start_date AS [Ngày bắt đầu], " +
                               "c.end_date AS [Ngày kết thúc], c.salary AS [Lương], c.status AS [Trạng thái] FROM contracts c";
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
                string query = "SELECT a.id AS [ID], a.employee_id AS [ID Nhân viên], a.[date] AS [Ngày], a.check_in AS [Giờ vào], " +
                               "a.check_out AS [Giờ ra], a.status AS [Trạng thái] FROM attendance a";
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
                string query = "SELECT id, CONCAT(first_name, ' ', last_name) AS full_name FROM employees";
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        var defaultRow = table.NewRow();
                        defaultRow["id"] = -1;
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
                        defaultRow["name"] = "-- Chọn phòng ban --";
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
                string query = "INSERT INTO employees (first_name, last_name, birth_date, gender, address, phone, email, department_id, position_id, hire_date) " +
                               "VALUES (@first_name, @last_name, @birth_date, @gender, @address, @phone, @email, @department_id, @position_id, @hire_date)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first_name", employee.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", employee.LastName);
                    cmd.Parameters.AddWithValue("@birth_date", employee.BirthDate);
                    cmd.Parameters.AddWithValue("@gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@address", employee.Address);
                    cmd.Parameters.AddWithValue("@phone", employee.Phone);
                    cmd.Parameters.AddWithValue("@email", employee.Email);
                    cmd.Parameters.AddWithValue("@department_id", employee.DepartmentId);
                    cmd.Parameters.AddWithValue("@position_id", employee.PositionId);
                    cmd.Parameters.AddWithValue("@hire_date", employee.HireDate);
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
                               "hire_date = @hire_date WHERE id = @id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", employee.Id);
                    cmd.Parameters.AddWithValue("@first_name", employee.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", employee.LastName);
                    cmd.Parameters.AddWithValue("@birth_date", employee.BirthDate);
                    cmd.Parameters.AddWithValue("@gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@address", employee.Address);
                    cmd.Parameters.AddWithValue("@phone", employee.Phone);
                    cmd.Parameters.AddWithValue("@email", employee.Email);
                    cmd.Parameters.AddWithValue("@department_id", employee.DepartmentId);
                    cmd.Parameters.AddWithValue("@position_id", employee.PositionId);
                    cmd.Parameters.AddWithValue("@hire_date", employee.HireDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEmployee(int id)
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

        public void AddContract(Contract contract)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO contracts (employee_id, type, start_date, end_date, salary, status) " +
                               "VALUES (@employee_id, @type, @start_date, @end_date, @salary, @status)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employee_id", contract.EmployeeId);
                    cmd.Parameters.AddWithValue("@type", contract.Type);
                    cmd.Parameters.AddWithValue("@start_date", contract.StartDate);
                    cmd.Parameters.AddWithValue("@end_date", contract.EndDate);
                    cmd.Parameters.AddWithValue("@salary", contract.Salary);
                    cmd.Parameters.AddWithValue("@status", contract.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateContract(Contract contract)
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
                    cmd.Parameters.AddWithValue("@end_date", contract.EndDate);
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
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO attendance (employee_id, [date], check_in, check_out, status) " +
                               "VALUES (@employee_id, @date, @check_in, @check_out, @status)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employee_id", attendance.EmployeeId);
                    cmd.Parameters.AddWithValue("@date", attendance.Date);
                    cmd.Parameters.AddWithValue("@check_in", attendance.CheckIn);
                    cmd.Parameters.AddWithValue("@check_out", attendance.CheckOut);
                    cmd.Parameters.AddWithValue("@status", attendance.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateAttendance(Attendance attendance)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE attendance SET employee_id = @employee_id, [date] = @date, check_in = @check_in, check_out = @check_out, status = @status WHERE id = @id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", attendance.Id);
                    cmd.Parameters.AddWithValue("@employee_id", attendance.EmployeeId);
                    cmd.Parameters.AddWithValue("@date", attendance.Date);
                    cmd.Parameters.AddWithValue("@check_in", attendance.CheckIn);
                    cmd.Parameters.AddWithValue("@check_out", attendance.CheckOut);
                    cmd.Parameters.AddWithValue("@status", attendance.Status);
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
    }
}