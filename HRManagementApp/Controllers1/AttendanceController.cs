using System;
using System.Data;
using System.Windows.Forms;
using HRManagementApp.Data;
using HRManagementApp.Models;
using HRManagementApp.Views;

namespace HRManagementApp.Controllers
{
    public class AttendanceController
    {
        private readonly DatabaseManager dbManager;
        private readonly HRManagementForm view;

        public AttendanceController(HRManagementForm view)
        {
            this.view = view;
            dbManager = new DatabaseManager();
        }

        public void LoadAttendance()
        {
            try
            {
                view.UpdateAttendanceGrid(dbManager.GetAttendance());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddAttendance(Attendance attendance)
        {
            try
            {
                if (attendance.EmployeeId == -1 || string.IsNullOrWhiteSpace(attendance.Status))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin chấm công!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbManager.AddAttendance(attendance);
                MessageBox.Show("Thêm chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAttendance();
                view.ClearAttendanceFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateAttendance(Attendance attendance)
        {
            try
            {
                if (attendance.Id == 0)
                {
                    MessageBox.Show("Vui lòng chọn chấm công để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (attendance.EmployeeId == -1 || string.IsNullOrWhiteSpace(attendance.Status))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin chấm công!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbManager.UpdateAttendance(attendance);
                MessageBox.Show("Cập nhật chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteAttendance(int id)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Vui lòng chọn chấm công để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc muốn xóa chấm công này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                dbManager.DeleteAttendance(id);
                MessageBox.Show("Xóa chấm công thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAttendance();
                view.ClearAttendanceFields();
                view.ClearDetailPanels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowAttendanceDetails(DataGridViewRow row)
        {
            view.ShowAttendanceDetails(row);
        }
    }
}