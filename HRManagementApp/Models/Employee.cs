using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Models
{
    public class Employee
    {
        public string Id { get; set; } // Đổi sang string
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public DateTime HireDate { get; set; }
        public string Education { get; set; } // Thêm học vấn
        public string CCCD { get; set; } // Thêm CCCD
    }
}
