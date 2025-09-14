using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }  
        public string Type { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } 
        public decimal Salary { get; set; }
        public string Status { get; set; }
    }
}
