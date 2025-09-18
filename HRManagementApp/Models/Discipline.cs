namespace HRManagementApp.Models
{
    public class Discipline
    {
        public string DisciplineId { get; set; }
        public string EmployeeId { get; set; }
        public string ViolationPath { get; set; }
        public string DisciplinaryDecisionPath { get; set; }
        public string ResignationLetterPath { get; set; }
        public string TerminationDecisionPath { get; set; }
        public string HandoverPath { get; set; }
        public string LiquidationPath { get; set; }
    }
}