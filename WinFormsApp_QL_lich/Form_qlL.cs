using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_QL_lich
{
    public partial class Form_qlL : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-18M9N62S;Initial Catalog=QL_lich;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select cs.class_id as ID ,    cs.course_id as Ma_lop ,   cs.teacher_id AS Ma_GV,    cs.start_date as ngay_bat_dau,   cs.end_date as ngay_ket_thuc,  cs.day_of_week as thu,    cs.start_time as gio_bat_dau,   cs.end_time as gio_ket_thuc,   cs.room as phong,    cs.soSV as so_SV from ClassSections cs ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_qlL.DataSource = table;
            // Tự động điều chỉnh chiều rộng các cột
            dgv_qlL.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Tùy chỉnh thêm (ví dụ, thay đổi font của tiêu đề cột)
            dgv_qlL.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Đổi font của tiêu đề cột
        }
        public Form_qlL()
        {
            InitializeComponent();
        }

        private void Form_qlL_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("Vui lòng nhập ID lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txt_idGv.Text))
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng xử lý tiếp
            }
            if (string.IsNullOrEmpty(txt_idmon.Text))
            {
                MessageBox.Show("Vui lòng nhập mã môn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng xử lý tiếp
            }
            if (dtp_ngaybd.Value > dtp_ngaykt.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thời gian từ DateTimePicker
            TimeSpan gioBatDau = dtp_giobd.Value.TimeOfDay; // Giờ bắt đầu
            TimeSpan gioKetThuc = dtp_giokt.Value.TimeOfDay; // Giờ kết thúc

            if (gioBatDau >= gioKetThuc)
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng lịch
            string checkQuery1 = @"SELECT COUNT(*) 
                          FROM ClassSections 
                          WHERE day_of_week = @day_of_week
                          AND room = @room
                          AND ((start_time BETWEEN @start_time AND @end_time) OR (end_time BETWEEN @start_time AND @end_time))
                          AND start_date <= @end_date AND end_date >= @start_date";

            using (SqlCommand checkCommand = new SqlCommand(checkQuery1, connection))
            {
                checkCommand.Parameters.AddWithValue("@day_of_week", cb_thu.Text); //  Thứ trong tuần
                checkCommand.Parameters.AddWithValue("@room", txt_phong.Text); // Phòng học
                checkCommand.Parameters.AddWithValue("@start_time", gioBatDau); // Giờ bắt đầu
                checkCommand.Parameters.AddWithValue("@end_time", gioKetThuc); // Giờ kết thúc
                checkCommand.Parameters.AddWithValue("@start_date", dtp_ngaybd.Value); // Ngày bắt đầu
                checkCommand.Parameters.AddWithValue("@end_date", dtp_ngaykt.Value); // Ngày kết thúc

                int count = (int)checkCommand.ExecuteScalar(); // Trả về số lớp học trùng lịch

                if (count > 0)
                {
                    MessageBox.Show("Lịch học này đã có lớp học khác trùng phòng và giờ, vui lòng chọn lịch khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Nếu trùng lịch, dừng việc thêm lớp mới
                }
            }

            // Kiểm tra xem ID có bị trùng trong cơ sở dữ liệu không
            string checkQuery = "SELECT COUNT(*) FROM ClassSections WHERE class_id = @ID";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@ID", txtid.Text);
                int count = (int)checkCommand.ExecuteScalar(); // Kiểm tra số lượng bản ghi có ID trùng

                if (count > 0)
                {
                    // Nếu ID đã tồn tại, thông báo lỗi
                    MessageBox.Show("ID này đã tồn tại. Vui lòng chọn ID khác.");
                    return; // Không thực hiện thêm bản ghi
                }
            }
            // Kiểm tra xem course_id có tồn tại trong bảng Courses hay không
            if (!string.IsNullOrEmpty(txt_idmon.Text))
            {
                string checkTeacherQuery = "SELECT COUNT(*) FROM Courses WHERE course_id = @Mon_ID";
                using (SqlCommand checkCommand = new SqlCommand(checkTeacherQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Mon_ID", txt_idmon.Text);
                    int count = (int)checkCommand.ExecuteScalar(); // Kiểm tra số lượng bản ghi có teacher_id trùng

                    if (count == 0)
                    {
                        // Nếu teacher_id không tồn tại trong bảng Teachers
                        MessageBox.Show("không tồn tại mã môn này này.");
                        return; // Không thực hiện thêm bản ghi
                    }
                }
            }
            //Kiểm tra xem teacher_id có tồn tại trong bảng Teacher hay không
            if (!string.IsNullOrEmpty(txt_idGv.Text))
            {
                string checkTeacherQuery = "SELECT COUNT(*) FROM Teachers WHERE teacher_id = @TeacherID";
                using (SqlCommand checkCommand = new SqlCommand(checkTeacherQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@TeacherID", txt_idGv.Text);
                    int count = (int)checkCommand.ExecuteScalar(); // Kiểm tra số lượng bản ghi có teacher_id trùng

                    if (count == 0)
                    {
                        // Nếu teacher_id không tồn tại trong bảng Teachers
                        MessageBox.Show("không tồn tại teacher_id này.");
                        return; // Không thực hiện thêm bản ghi
                    }
                }
            }


            // Tạo câu lệnh SQL để thêm bản ghi
            string query = "INSERT INTO ClassSections (class_id, course_id, teacher_id, start_date, end_date, day_of_week, start_time, end_time, room, soSV) VALUES (@ID, @idmon, @idgv, @start_date, @end_date, @day_of_week, @start_time, @end_time, @room, @soSV)";


            // Tạo command và kết nối
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ID", txtid.Text);
                command.Parameters.AddWithValue("@idmon", txt_idmon.Text);
                command.Parameters.AddWithValue("@idgv", txt_idGv.Text);
                command.Parameters.AddWithValue("@start_date", dtp_ngaybd.Value);
                command.Parameters.AddWithValue("@end_date", dtp_ngaykt.Value);
                command.Parameters.AddWithValue("@day_of_week", cb_thu.Text);
                command.Parameters.AddWithValue("@start_time", gioBatDau);
                command.Parameters.AddWithValue("@end_time", gioKetThuc);
                command.Parameters.AddWithValue("@room", txt_phong.Text);
                command.Parameters.AddWithValue("@soSV", int.Parse(txt_sv.Text));


                // Thực thi câu lệnh INSERT
                command.ExecuteNonQuery();
            }

            // Load lại dữ liệu sau khi thêm mới
            MessageBox.Show("Thêm mới thành công.");
            loaddata();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn lớp học từ DataGridView chưa
            if (dgv_qlL.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem các trường nhập liệu có trống không
            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txt_idGv.Text) || string.IsNullOrEmpty(txt_idmon.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            // Kiểm tra xem thời gian bắt đầu có lớn hơn thời gian kết thúc không
            TimeSpan gioBatDau = dtp_giobd.Value.TimeOfDay;
            TimeSpan gioKetThuc = dtp_giokt.Value.TimeOfDay;

            if (gioBatDau >= gioKetThuc)
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật dữ liệu vào cơ sở dữ liệu
            string updateQuery = @"UPDATE ClassSections 
                           SET course_id = @idmon, 
                               teacher_id = @idgv, 
                               start_date = @start_date, 
                               end_date = @end_date, 
                               day_of_week = @day_of_week, 
                               start_time = @start_time, 
                               end_time = @end_time, 
                               room = @room, 
                               soSV = @soSV 
                           WHERE class_id = @ID";

            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@ID", txtid.Text);
                updateCommand.Parameters.AddWithValue("@idmon", txt_idmon.Text);
                updateCommand.Parameters.AddWithValue("@idgv", txt_idGv.Text);
                updateCommand.Parameters.AddWithValue("@start_date", dtp_ngaybd.Value);
                updateCommand.Parameters.AddWithValue("@end_date", dtp_ngaykt.Value);
                updateCommand.Parameters.AddWithValue("@day_of_week", cb_thu.Text);
                updateCommand.Parameters.AddWithValue("@start_time", gioBatDau);
                updateCommand.Parameters.AddWithValue("@end_time", gioKetThuc);
                updateCommand.Parameters.AddWithValue("@room", txt_phong.Text);
                updateCommand.Parameters.AddWithValue("@soSV", int.Parse(txt_sv.Text));

                // Thực thi câu lệnh UPDATE
                updateCommand.ExecuteNonQuery();
            }

            // Thông báo và load lại dữ liệu
            MessageBox.Show("Cập nhật thông tin lớp học thành công!");
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn lớp học cần xóa chưa
            if (dgv_qlL.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận việc xóa lớp học
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return; // Nếu người dùng chọn No, không thực hiện xóa
            }

            // Lấy thông tin class_id của lớp học cần xóa từ DataGridView
            string class_id = dgv_qlL.SelectedRows[0].Cells["ID"].Value.ToString();

            // Tạo câu lệnh SQL để xóa lớp học
            string deleteQuery = "DELETE FROM ClassSections WHERE class_id = @ID";

            using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
            {
                deleteCommand.Parameters.AddWithValue("@ID", class_id);

                // Thực thi câu lệnh DELETE
                deleteCommand.ExecuteNonQuery();
            }

            // Thông báo và load lại dữ liệu
            MessageBox.Show("Lớp học đã được xóa thành công!");
            loaddata();
        }

        private void dgv_qlL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {// Kiểm tra nếu người dùng nhấn vào một ô trong DataGridView và không phải trên tiêu đề cột
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin lớp học từ các ô trong dòng được chọn
                txtid.Text = dgv_qlL.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txt_idmon.Text = dgv_qlL.Rows[e.RowIndex].Cells["Ma_lop"].Value.ToString();
                txt_idGv.Text = dgv_qlL.Rows[e.RowIndex].Cells["Ma_GV"].Value.ToString();
                dtp_ngaybd.Value = Convert.ToDateTime(dgv_qlL.Rows[e.RowIndex].Cells["ngay_bat_dau"].Value);
                dtp_ngaykt.Value = Convert.ToDateTime(dgv_qlL.Rows[e.RowIndex].Cells["ngay_ket_thuc"].Value);
                cb_thu.Text = dgv_qlL.Rows[e.RowIndex].Cells["thu"].Value.ToString();
                dtp_giobd.Value = DateTime.Today.Add((TimeSpan)dgv_qlL.Rows[e.RowIndex].Cells["gio_bat_dau"].Value);
                dtp_giokt.Value = DateTime.Today.Add((TimeSpan)dgv_qlL.Rows[e.RowIndex].Cells["gio_ket_thuc"].Value);
                txt_phong.Text = dgv_qlL.Rows[e.RowIndex].Cells["phong"].Value.ToString();
                txt_sv.Text = dgv_qlL.Rows[e.RowIndex].Cells["so_SV"].Value.ToString();
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string searchValue = txt_tim.Text.Trim(); // Lấy giá trị từ TextBox và loại bỏ khoảng trắng

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo câu lệnh SQL tìm kiếm với điều kiện tìm kiếm
            string searchQuery = @"SELECT cs.class_id as ID, cs.course_id as Ma_lop, cs.teacher_id AS Ma_GV, 
                           cs.start_date as ngay_bat_dau, cs.end_date as ngay_ket_thuc, cs.day_of_week as thu, 
                           cs.start_time as gio_bat_dau, cs.end_time as gio_ket_thuc, cs.room as phong, cs.soSV as so_SV
                           FROM ClassSections cs
                           WHERE cs.class_id LIKE @SearchValue
                           OR cs.course_id LIKE @SearchValue
                           OR cs.teacher_id LIKE @SearchValue
                           OR cs.start_date LIKE @SearchValue
                           OR cs.end_date LIKE @SearchValue
                           OR cs.day_of_week LIKE @SearchValue
                           OR cs.start_time LIKE @SearchValue
                           OR cs.end_time LIKE @SearchValue
                           OR cs.room LIKE @SearchValue
                           OR cs.soSV LIKE @SearchValue"; // Tìm kiếm theo tất cả các trường

            // Tạo lệnh SQL
            command = new SqlCommand(searchQuery, connection);
            command.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%"); // Thêm dấu '%' để tìm kiếm kiểu LIKE

            // Thiết lập SqlDataAdapter và DataTable
            SqlDataAdapter searchAdapter = new SqlDataAdapter(command);
            DataTable searchTable = new DataTable();
            searchAdapter.Fill(searchTable);

            // Hiển thị kết quả trong DataGridView
            dgv_qlL.DataSource = searchTable;

            // Kiểm tra xem có kết quả hay không
            if (searchTable.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy lớp học nào phù hợp với từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
