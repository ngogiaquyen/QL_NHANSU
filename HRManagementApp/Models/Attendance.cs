using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; } // ID nhân viên kiểu string
        public DateTime Date { get; set; }
        public TimeSpan? CheckIn { get; set; } // Giờ vào (nullable)
        public TimeSpan? CheckOut { get; set; } // Giờ ra (nullable)
        public string Status { get; set; }

        // Giờ hành chính và tăng ca (tính toán tự động)
        public decimal AdminHours { get; set; } = 0;
        public decimal OvertimeHours { get; set; } = 0;

        // Tính toán tự động giờ hành chính và tăng ca dựa trên CheckIn/CheckOut
        public void CalculateHours()
        {
            if (CheckIn.HasValue && CheckOut.HasValue && CheckOut > CheckIn)
            {
                TimeSpan workDuration = CheckOut.Value - CheckIn.Value;
                decimal totalHours = (decimal)workDuration.TotalHours;

                // Logic tính toán: Nếu tổng >= 8 thì hành chính = 8, tăng ca = tổng - 8
                // Nếu tổng < 8 thì hành chính = tổng, tăng ca = 0
                AdminHours = Math.Min(totalHours, 8m);
                OvertimeHours = Math.Max(totalHours - 8m, 0m);
            }
            else
            {
                AdminHours = 0;
                OvertimeHours = 0;
            }
        }

        public static readonly string[] ValidStatuses = new[]
        {
            "Nghỉ phép",
            "Nghỉ không lương",
            "Đi muộn",
            "Về sớm",
            "Nghỉ nửa ngày phép",
            "Nghỉ nửa ngày không lương",
            "Tự ý bỏ việc",
            "Nghỉ không lý do"
        };
    }
}
