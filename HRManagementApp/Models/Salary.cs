namespace HRManagementApp.Models
{
    public class Salary
    {
        public string SalaryId { get; set; }
        public string EmployeeId { get; set; }
        public decimal? MonthlySalary { get; set; }
        public string PaySlipPath { get; set; }
        public string SalaryIncreaseDecisionPath { get; set; }
        public string BankAccount { get; set; }
        public string InsuranceInfo { get; set; }
        public decimal? Allowances { get; set; }
        public decimal? Bonuses { get; set; }
        public string LeavePolicy { get; set; }
    }
}