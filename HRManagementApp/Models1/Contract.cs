using System;

namespace HRManagementApp.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Salary { get; set; }
        public string Status { get; set; }
    }
}