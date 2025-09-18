using System;

namespace HRManagementApp.Models
{
    public class Contract
    {
        public string ContractId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ContractType { get; set; }
        public string ContractAnnexPath { get; set; }
        public string ConfidentialityAgreementPath { get; set; }
        public string NonCompeteAgreementPath { get; set; }
        public string AppointmentDecisionPath { get; set; }
        public string SalaryIncreaseDecisionPath { get; set; }
        public string RewardDecisionPath { get; set; }
    }
}