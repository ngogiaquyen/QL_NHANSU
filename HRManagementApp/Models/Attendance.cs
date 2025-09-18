using System;

namespace HRManagementApp.Models
{
    public class Attendance
    {
        public string AttendanceId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public string Status { get; set; }
        public decimal? AdminHours { get; set; }
        public decimal? OvertimeHours { get; set; }
    }
}