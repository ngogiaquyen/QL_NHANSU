using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HRManagementApp
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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT EmployeeId, Name, DOB, Gender, Nationality, CCCD, CCCDIssueDate, CCCDIssuePlace, 
                                PermanentAddress, CurrentAddress, Phone, Email, MaritalStatus, Dependents, 
                                SocialInsuranceNumber, TaxCode, JobDescription, Position, Department, Rank, Manager, WorkSchedule 
                                FROM Employee";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddEmployee(Models.Employee employee)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Employee (EmployeeId, Name, DOB, Gender, Nationality, CCCD, CCCDIssueDate, CCCDIssuePlace, 
                                PermanentAddress, CurrentAddress, Phone, Email, MaritalStatus, Dependents, 
                                SocialInsuranceNumber, TaxCode, JobDescription, Position, Department, Rank, Manager, WorkSchedule)
                                VALUES (@EmployeeId, @Name, @DOB, @Gender, @Nationality, @CCCD, @CCCDIssueDate, @CCCDIssuePlace, 
                                @PermanentAddress, @CurrentAddress, @Phone, @Email, @MaritalStatus, @Dependents, 
                                @SocialInsuranceNumber, @TaxCode, @JobDescription, @Position, @Department, @Rank, @Manager, @WorkSchedule)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@DOB", (object)employee.DOB ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Gender", (object)employee.Gender ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Nationality", (object)employee.Nationality ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CCCD", (object)employee.CCCD ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CCCDIssueDate", (object)employee.CCCDIssueDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CCCDIssuePlace", (object)employee.CCCDIssuePlace ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PermanentAddress", (object)employee.PermanentAddress ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CurrentAddress", (object)employee.CurrentAddress ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", (object)employee.Phone ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object)employee.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MaritalStatus", (object)employee.MaritalStatus ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Dependents", (object)employee.Dependents ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SocialInsuranceNumber", (object)employee.SocialInsuranceNumber ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TaxCode", (object)employee.TaxCode ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@JobDescription", (object)employee.JobDescription ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Position", (object)employee.Position ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Department", (object)employee.Department ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Rank", (object)employee.Rank ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Manager", (object)employee.Manager ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@WorkSchedule", (object)employee.WorkSchedule ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(Models.Employee employee)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Employee SET Name = @Name, DOB = @DOB, Gender = @Gender, Nationality = @Nationality, 
                                CCCD = @CCCD, CCCDIssueDate = @CCCDIssueDate, CCCDIssuePlace = @CCCDIssuePlace, 
                                PermanentAddress = @PermanentAddress, CurrentAddress = @CurrentAddress, Phone = @Phone, 
                                Email = @Email, MaritalStatus = @MaritalStatus, Dependents = @Dependents, 
                                SocialInsuranceNumber = @SocialInsuranceNumber, TaxCode = @TaxCode, JobDescription = @JobDescription, 
                                Position = @Position, Department = @Department, Rank = @Rank, Manager = @Manager, WorkSchedule = @WorkSchedule
                                WHERE EmployeeId = @EmployeeId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@DOB", (object)employee.DOB ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Gender", (object)employee.Gender ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Nationality", (object)employee.Nationality ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CCCD", (object)employee.CCCD ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CCCDIssueDate", (object)employee.CCCDIssueDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CCCDIssuePlace", (object)employee.CCCDIssuePlace ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PermanentAddress", (object)employee.PermanentAddress ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CurrentAddress", (object)employee.CurrentAddress ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", (object)employee.Phone ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", (object)employee.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MaritalStatus", (object)employee.MaritalStatus ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Dependents", (object)employee.Dependents ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SocialInsuranceNumber", (object)employee.SocialInsuranceNumber ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TaxCode", (object)employee.TaxCode ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@JobDescription", (object)employee.JobDescription ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Position", (object)employee.Position ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Department", (object)employee.Department ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Rank", (object)employee.Rank ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Manager", (object)employee.Manager ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@WorkSchedule", (object)employee.WorkSchedule ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(string employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Employee WHERE EmployeeId = @EmployeeId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetContracts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT ContractId, EmployeeId, StartDate, EndDate, ContractType, ContractAnnexPath, 
                                ConfidentialityAgreementPath, NonCompeteAgreementPath, AppointmentDecisionPath, 
                                SalaryIncreaseDecisionPath, RewardDecisionPath 
                                FROM Contract";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddContract(Models.Contract contract)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Contract (ContractId, EmployeeId, StartDate, EndDate, ContractType, 
                                ContractAnnexPath, ConfidentialityAgreementPath, NonCompeteAgreementPath, 
                                AppointmentDecisionPath, SalaryIncreaseDecisionPath, RewardDecisionPath)
                                VALUES (@ContractId, @EmployeeId, @StartDate, @EndDate, @ContractType, 
                                @ContractAnnexPath, @ConfidentialityAgreementPath, @NonCompeteAgreementPath, 
                                @AppointmentDecisionPath, @SalaryIncreaseDecisionPath, @RewardDecisionPath)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ContractId", contract.ContractId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)contract.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@StartDate", (object)contract.StartDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EndDate", (object)contract.EndDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ContractType", (object)contract.ContractType ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ContractAnnexPath", (object)contract.ContractAnnexPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ConfidentialityAgreementPath", (object)contract.ConfidentialityAgreementPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@NonCompeteAgreementPath", (object)contract.NonCompeteAgreementPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AppointmentDecisionPath", (object)contract.AppointmentDecisionPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SalaryIncreaseDecisionPath", (object)contract.SalaryIncreaseDecisionPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RewardDecisionPath", (object)contract.RewardDecisionPath ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateContract(Models.Contract contract)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Contract SET EmployeeId = @EmployeeId, StartDate = @StartDate, EndDate = @EndDate, 
                                ContractType = @ContractType, ContractAnnexPath = @ContractAnnexPath, 
                                ConfidentialityAgreementPath = @ConfidentialityAgreementPath, 
                                NonCompeteAgreementPath = @NonCompeteAgreementPath, 
                                AppointmentDecisionPath = @AppointmentDecisionPath, 
                                SalaryIncreaseDecisionPath = @SalaryIncreaseDecisionPath, 
                                RewardDecisionPath = @RewardDecisionPath 
                                WHERE ContractId = @ContractId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ContractId", contract.ContractId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)contract.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@StartDate", (object)contract.StartDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EndDate", (object)contract.EndDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ContractType", (object)contract.ContractType ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ContractAnnexPath", (object)contract.ContractAnnexPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ConfidentialityAgreementPath", (object)contract.ConfidentialityAgreementPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@NonCompeteAgreementPath", (object)contract.NonCompeteAgreementPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AppointmentDecisionPath", (object)contract.AppointmentDecisionPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SalaryIncreaseDecisionPath", (object)contract.SalaryIncreaseDecisionPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RewardDecisionPath", (object)contract.RewardDecisionPath ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteContract(string contractId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Contract WHERE ContractId = @ContractId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ContractId", contractId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAttendances()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT AttendanceId, EmployeeId, AttendanceDate, CheckInTime, CheckOutTime, Status, AdminHours, OvertimeHours FROM Attendance";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddAttendance(Models.Attendance attendance)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Attendance (AttendanceId, EmployeeId, AttendanceDate, CheckInTime, CheckOutTime, Status, AdminHours, OvertimeHours)
                                VALUES (@AttendanceId, @EmployeeId, @AttendanceDate, @CheckInTime, @CheckOutTime, @Status, @AdminHours, @OvertimeHours)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AttendanceId", attendance.AttendanceId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)attendance.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AttendanceDate", (object)attendance.AttendanceDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CheckInTime", (object)attendance.CheckInTime ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CheckOutTime", (object)attendance.CheckOutTime ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", (object)attendance.Status ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AdminHours", (object)attendance.AdminHours ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@OvertimeHours", (object)attendance.OvertimeHours ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAttendance(Models.Attendance attendance)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Attendance SET EmployeeId = @EmployeeId, AttendanceDate = @AttendanceDate, 
                                CheckInTime = @CheckInTime, CheckOutTime = @CheckOutTime, Status = @Status, 
                                AdminHours = @AdminHours, OvertimeHours = @OvertimeHours 
                                WHERE AttendanceId = @AttendanceId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AttendanceId", attendance.AttendanceId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)attendance.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AttendanceDate", (object)attendance.AttendanceDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CheckInTime", (object)attendance.CheckInTime ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CheckOutTime", (object)attendance.CheckOutTime ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", (object)attendance.Status ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AdminHours", (object)attendance.AdminHours ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@OvertimeHours", (object)attendance.OvertimeHours ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAttendance(string attendanceId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Attendance WHERE AttendanceId = @AttendanceId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AttendanceId", attendanceId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetRecruitments()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT RecruitmentId, EmployeeId, JobApplicationPath, ResumePath, DegreesPath, 
                                HealthCheckPath, CVPath, ReferenceLetterPath, InterviewMinutesPath, OfferLetterPath 
                                FROM Recruitment";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddRecruitment(Models.Recruitment recruitment)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Recruitment (RecruitmentId, EmployeeId, JobApplicationPath, ResumePath, 
                                DegreesPath, HealthCheckPath, CVPath, ReferenceLetterPath, InterviewMinutesPath, OfferLetterPath)
                                VALUES (@RecruitmentId, @EmployeeId, @JobApplicationPath, @ResumePath, @DegreesPath, 
                                @HealthCheckPath, @CVPath, @ReferenceLetterPath, @InterviewMinutesPath, @OfferLetterPath)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RecruitmentId", recruitment.RecruitmentId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)recruitment.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@JobApplicationPath", (object)recruitment.JobApplicationPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ResumePath", (object)recruitment.ResumePath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DegreesPath", (object)recruitment.DegreesPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@HealthCheckPath", (object)recruitment.HealthCheckPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CVPath", (object)recruitment.CVPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ReferenceLetterPath", (object)recruitment.ReferenceLetterPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@InterviewMinutesPath", (object)recruitment.InterviewMinutesPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@OfferLetterPath", (object)recruitment.OfferLetterPath ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateRecruitment(Models.Recruitment recruitment)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Recruitment SET EmployeeId = @EmployeeId, JobApplicationPath = @JobApplicationPath, 
                                ResumePath = @ResumePath, DegreesPath = @DegreesPath, HealthCheckPath = @HealthCheckPath, 
                                CVPath = @CVPath, ReferenceLetterPath = @ReferenceLetterPath, 
                                InterviewMinutesPath = @InterviewMinutesPath, OfferLetterPath = @OfferLetterPath 
                                WHERE RecruitmentId = @RecruitmentId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RecruitmentId", recruitment.RecruitmentId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)recruitment.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@JobApplicationPath", (object)recruitment.JobApplicationPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ResumePath", (object)recruitment.ResumePath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DegreesPath", (object)recruitment.DegreesPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@HealthCheckPath", (object)recruitment.HealthCheckPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CVPath", (object)recruitment.CVPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ReferenceLetterPath", (object)recruitment.ReferenceLetterPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@InterviewMinutesPath", (object)recruitment.InterviewMinutesPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@OfferLetterPath", (object)recruitment.OfferLetterPath ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRecruitment(string recruitmentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Recruitment WHERE RecruitmentId = @RecruitmentId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RecruitmentId", recruitmentId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetSalaries()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT SalaryId, EmployeeId, MonthlySalary, PaySlipPath, SalaryIncreaseDecisionPath, 
                                BankAccount, InsuranceInfo, Allowances, Bonuses, LeavePolicy 
                                FROM Salary";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddSalary(Models.Salary salary)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Salary (SalaryId, EmployeeId, MonthlySalary, PaySlipPath, 
                                SalaryIncreaseDecisionPath, BankAccount, InsuranceInfo, Allowances, Bonuses, LeavePolicy)
                                VALUES (@SalaryId, @EmployeeId, @MonthlySalary, @PaySlipPath, @SalaryIncreaseDecisionPath, 
                                @BankAccount, @InsuranceInfo, @Allowances, @Bonuses, @LeavePolicy)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SalaryId", salary.SalaryId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)salary.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MonthlySalary", (object)salary.MonthlySalary ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PaySlipPath", (object)salary.PaySlipPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SalaryIncreaseDecisionPath", (object)salary.SalaryIncreaseDecisionPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@BankAccount", (object)salary.BankAccount ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@InsuranceInfo", (object)salary.InsuranceInfo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Allowances", (object)salary.Allowances ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Bonuses", (object)salary.Bonuses ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LeavePolicy", (object)salary.LeavePolicy ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSalary(Models.Salary salary)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Salary SET EmployeeId = @EmployeeId, MonthlySalary = @MonthlySalary, 
                                PaySlipPath = @PaySlipPath, SalaryIncreaseDecisionPath = @SalaryIncreaseDecisionPath, 
                                BankAccount = @BankAccount, InsuranceInfo = @InsuranceInfo, Allowances = @Allowances, 
                                Bonuses = @Bonuses, LeavePolicy = @LeavePolicy 
                                WHERE SalaryId = @SalaryId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SalaryId", salary.SalaryId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)salary.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MonthlySalary", (object)salary.MonthlySalary ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PaySlipPath", (object)salary.PaySlipPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SalaryIncreaseDecisionPath", (object)salary.SalaryIncreaseDecisionPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@BankAccount", (object)salary.BankAccount ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@InsuranceInfo", (object)salary.InsuranceInfo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Allowances", (object)salary.Allowances ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Bonuses", (object)salary.Bonuses ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LeavePolicy", (object)salary.LeavePolicy ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSalary(string salaryId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Salary WHERE SalaryId = @SalaryId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SalaryId", salaryId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetTrainings()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TrainingId, EmployeeId, TrainingPlanPath, CertificatePath, EvaluationPath, CareerPath FROM Training";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable SearchTrainings(string searchTerm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TrainingId, EmployeeId, TrainingPlanPath, CertificatePath, EvaluationPath, CareerPath FROM Training WHERE EmployeeId LIKE @SearchTerm OR TrainingId LIKE @SearchTerm";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddTraining(Models.Training training)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Training (TrainingId, EmployeeId, TrainingPlanPath, CertificatePath, EvaluationPath, CareerPath)
                                VALUES (@TrainingId, @EmployeeId, @TrainingPlanPath, @CertificatePath, @EvaluationPath, @CareerPath)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TrainingId", training.TrainingId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)training.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TrainingPlanPath", (object)training.TrainingPlanPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CertificatePath", (object)training.CertificatePath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EvaluationPath", (object)training.EvaluationPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CareerPath", (object)training.CareerPath ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTraining(Models.Training training)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Training SET EmployeeId = @EmployeeId, TrainingPlanPath = @TrainingPlanPath, 
                                CertificatePath = @CertificatePath, EvaluationPath = @EvaluationPath, CareerPath = @CareerPath 
                                WHERE TrainingId = @TrainingId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TrainingId", training.TrainingId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)training.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TrainingPlanPath", (object)training.TrainingPlanPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CertificatePath", (object)training.CertificatePath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EvaluationPath", (object)training.EvaluationPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CareerPath", (object)training.CareerPath ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTraining(string trainingId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Training WHERE TrainingId = @TrainingId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TrainingId", trainingId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetDisciplines()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT DisciplineId, EmployeeId, ViolationPath, DisciplinaryDecisionPath, 
                                ResignationLetterPath, TerminationDecisionPath, HandoverPath, LiquidationPath 
                                FROM Discipline";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddDiscipline(Models.Discipline discipline)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Discipline (DisciplineId, EmployeeId, ViolationPath, DisciplinaryDecisionPath, 
                                ResignationLetterPath, TerminationDecisionPath, HandoverPath, LiquidationPath)
                                VALUES (@DisciplineId, @EmployeeId, @ViolationPath, @DisciplinaryDecisionPath, 
                                @ResignationLetterPath, @TerminationDecisionPath, @HandoverPath, @LiquidationPath)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DisciplineId", discipline.DisciplineId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)discipline.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ViolationPath", (object)discipline.ViolationPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DisciplinaryDecisionPath", (object)discipline.DisciplinaryDecisionPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ResignationLetterPath", (object)discipline.ResignationLetterPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TerminationDecisionPath", (object)discipline.TerminationDecisionPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@HandoverPath", (object)discipline.HandoverPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LiquidationPath", (object)discipline.LiquidationPath ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDiscipline(Models.Discipline discipline)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Discipline SET EmployeeId = @EmployeeId, ViolationPath = @ViolationPath, 
                                DisciplinaryDecisionPath = @DisciplinaryDecisionPath, ResignationLetterPath = @ResignationLetterPath, 
                                TerminationDecisionPath = @TerminationDecisionPath, HandoverPath = @HandoverPath, 
                                LiquidationPath = @LiquidationPath 
                                WHERE DisciplineId = @DisciplineId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DisciplineId", discipline.DisciplineId);
                cmd.Parameters.AddWithValue("@EmployeeId", (object)discipline.EmployeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ViolationPath", (object)discipline.ViolationPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DisciplinaryDecisionPath", (object)discipline.DisciplinaryDecisionPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ResignationLetterPath", (object)discipline.ResignationLetterPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TerminationDecisionPath", (object)discipline.TerminationDecisionPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@HandoverPath", (object)discipline.HandoverPath ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LiquidationPath", (object)discipline.LiquidationPath ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDiscipline(string disciplineId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Discipline WHERE DisciplineId = @DisciplineId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DisciplineId", disciplineId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}