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
    public partial class QL_mon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-18M9N62S;Initial Catalog=QL_lich;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT c.course_id as ma_mon, c.course_name as ten_mon , c.credits as so_tin , c.department_id as ma_khoa FROM Courses c   ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dvg_qlmon.DataSource = table;

            // Cài đặt chiều rộng cho các cột
            dvg_qlmon.Columns["ma_mon"].Width = (int)(dvg_qlmon.Width * 0.20); //  25% chiều rộng
            dvg_qlmon.Columns["ten_mon"].Width = (int)(dvg_qlmon.Width * 0.40); //  40% chiều rộng
            dvg_qlmon.Columns["so_tin"].Width = (int)(dvg_qlmon.Width * 0.20); //  20% chiều rộng
            dvg_qlmon.Columns["ma_khoa"].Width = (int)(dvg_qlmon.Width * 0.15); //  15% chiều rộng

            // Tùy chỉnh thêm (ví dụ, thay đổi font của tiêu đề cột)
            dvg_qlmon.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Đổi font của tiêu đề cột
        }
        public QL_mon()
        {
            InitializeComponent();
        }

        private void QL_mon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dvg_qlmon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = dvg_qlmon.CurrentRow.Index;
            txt_id.Text = dvg_qlmon.Rows[i].Cells[0].Value.ToString();
            txt_id_khoa.Text = dvg_qlmon.Rows[i].Cells[3].Value.ToString();
            txt_mon.Text = dvg_qlmon.Rows[i].Cells[1].Value.ToString();
            txt_tin.Text = dvg_qlmon.Rows[i].Cells[2].Value.ToString();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem ID có bị trùng trong cơ sở dữ liệu không
            string checkQuery = "SELECT COUNT(*) FROM Courses WHERE course_id = @ID";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@ID", txt_id.Text);
                int count = (int)checkCommand.ExecuteScalar(); // Kiểm tra số lượng bản ghi có ID trùng

                if (count > 0)
                {
                    // Nếu ID đã tồn tại, thông báo lỗi
                    MessageBox.Show("ID này đã tồn tại. Vui lòng chọn ID khác.");
                    return; // Không thực hiện thêm bản ghi
                }
            }
            // Kiểm tra xem department_id có tồn tại trong bảng Departments hay không
            if (!string.IsNullOrEmpty(txt_id_khoa.Text))
            {
                string checkTeacherQuery = "SELECT COUNT(*) FROM Departments WHERE department_id = @khoa_id";
                using (SqlCommand checkCommand = new SqlCommand(checkTeacherQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@khoa_id", txt_id_khoa.Text);
                    int count = (int)checkCommand.ExecuteScalar(); // Kiểm tra số lượng bản ghi có teacher_id trùng

                    if (count == 0)
                    {
                        // Nếu department_id không tồn tại trong bảng Departments
                        MessageBox.Show("không tồn tại khoa_id này.");
                        return; // Không thực hiện thêm bản ghi
                    }
                }
            }
            // Tạo câu lệnh SQL để thêm bản ghi
            string query = "INSERT INTO Courses (course_id, course_name, credits, department_id) VALUES (@ID, @course_name, @credits,@khoa_id)";

            // Tạo command và kết nối
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ID", txt_id.Text);
                command.Parameters.AddWithValue("@course_name", txt_mon.Text);
                command.Parameters.AddWithValue("@credits", txt_tin.Text);  


                // Nếu teacher_id rỗng, truyền NULL vào
                if (string.IsNullOrEmpty(txt_id_khoa.Text))
                {
                    command.Parameters.AddWithValue("@khoa_id", DBNull.Value); // Truyền NULL vào SQL
                }
                else
                {
                    command.Parameters.AddWithValue("@khoa_id", txt_id_khoa.Text);
                }


                // Thực thi câu lệnh INSERT
                command.ExecuteNonQuery();
            }

            // Load lại dữ liệu sau khi thêm mới
            MessageBox.Show("Thêm mới thành công.");
            loaddata();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu các textbox không trống
            if (string.IsNullOrEmpty(txt_id.Text) || string.IsNullOrEmpty(txt_mon.Text) || string.IsNullOrEmpty(txt_tin.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Tạo câu lệnh SQL để cập nhật thông tin người dùng
            string query = "UPDATE Courses SET course_name =@course_name, credits = @credits,  department_id = @department_id WHERE course_id = @ID";

            // Tạo command và kết nối
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ID", txt_id.Text);
                command.Parameters.AddWithValue("@course_name", txt_mon.Text);
                command.Parameters.AddWithValue("@credits", txt_tin.Text); 

                // Nếu teacher_id rỗng, truyền NULL vào
                if (string.IsNullOrEmpty(txt_id_khoa.Text))
                {
                    command.Parameters.AddWithValue("@department_id", DBNull.Value); // Truyền NULL vào SQL
                }
                else
                {
                    command.Parameters.AddWithValue("@department_id", txt_id_khoa.Text);
                }

                // Thực thi câu lệnh UPDATE
                command.ExecuteNonQuery();
            }

            // Load lại dữ liệu sau khi sửa
            MessageBox.Show("Cập nhật thành công.");
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn một dòng trong DataGridView
            if (dvg_qlmon.SelectedRows.Count > 0)
            {
                // Lấy user_id của dòng được chọn
                string courseId = dvg_qlmon.SelectedRows[0].Cells[0].Value.ToString();

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xóa môn", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Câu lệnh SQL để xóa bản ghi
                    string query = "DELETE FROM Courses WHERE course_id = @course_id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@course_id", courseId);

                        // Thực thi câu lệnh DELETE
                        command.ExecuteNonQuery();
                    }

                    // Thông báo thành công
                    MessageBox.Show("Xóa thành công.");

                    // Load lại dữ liệu sau khi xóa
                    loaddata();
                }
            }
            else
            {
                // Nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn bản ghi để xóa.");
            }
        }
    }
}
