using System;

namespace HRManagementApp.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime? DOB { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string CCCD { get; set; }
        public DateTime? CCCDIssueDate { get; set; }
        public string CCCDIssuePlace { get; set; }
        public string PermanentAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MaritalStatus { get; set; }
        public int? Dependents { get; set; }
        public string SocialInsuranceNumber { get; set; }
        public string TaxCode { get; set; }
        public string JobDescription { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Rank { get; set; }
        public string Manager { get; set; }
        public string WorkSchedule { get; set; }
    }
}