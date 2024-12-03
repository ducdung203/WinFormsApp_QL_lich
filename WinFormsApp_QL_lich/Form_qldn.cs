using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace WinFormsApp_QL_lich
{

    public partial class Form_qldn : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-18M9N62S;Initial Catalog=QL_lich;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT user_id as ID , username , password_hash as passwword , role as quyen , teacher_id as ma_gv FROM Users ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_qldn.DataSource = table;

            // Cài đặt chiều rộng cho các cột theo tỷ lệ
            dgv_qldn.Columns["ID"].Width = (int)(dgv_qldn.Width * 0.10); //  15% chiều rộng
            dgv_qldn.Columns["username"].Width = (int)(dgv_qldn.Width * 0.30); //  30% chiều rộng
            dgv_qldn.Columns["passwword"].Width = (int)(dgv_qldn.Width * 0.25); //  25% chiều rộng
            dgv_qldn.Columns["quyen"].Width = (int)(dgv_qldn.Width * 0.15); //  15% chiều rộng
            dgv_qldn.Columns["ma_gv"].Width = (int)(dgv_qldn.Width * 0.15); // 15% chiều rộng

            // Tùy chỉnh thêm (ví dụ, thay đổi font của tiêu đề cột)
            dgv_qldn.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Đổi font của tiêu đề cột
        }
        public Form_qldn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_qldn_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgv_qldn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                int i = dgv_qldn.CurrentRow.Index;
                txtID.Text = dgv_qldn.Rows[i].Cells[0].Value.ToString();
                txtTK.Text = dgv_qldn.Rows[i].Cells[1].Value.ToString();
                txtMK.Text = dgv_qldn.Rows[i].Cells[2].Value.ToString();
                cb_role.Text = dgv_qldn.Rows[i].Cells[3].Value.ToString();
                txt_idGV.Text = dgv_qldn.Rows[i].Cells[4].Value.ToString();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        { // Kiểm tra xem ID có bị trùng trong cơ sở dữ liệu không
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE user_id = @ID";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@ID", txtID.Text);
                int count = (int)checkCommand.ExecuteScalar(); // Kiểm tra số lượng bản ghi có ID trùng

                if (count > 0)
                {
                    // Nếu ID đã tồn tại, thông báo lỗi
                    MessageBox.Show("ID này đã tồn tại. Vui lòng chọn ID khác.");
                    return; // Không thực hiện thêm bản ghi
                }
            }
            // Kiểm tra xem teacher_id có tồn tại trong bảng Teachers hay không
            if (!string.IsNullOrEmpty(txt_idGV.Text))
            {
                string checkTeacherQuery = "SELECT COUNT(*) FROM Teachers WHERE teacher_id = @TeacherID";
                using (SqlCommand checkCommand = new SqlCommand(checkTeacherQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@TeacherID", txt_idGV.Text);
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
            string query = "INSERT INTO Users (user_id, username, password_hash, role, teacher_id) VALUES (@ID, @Username, @PasswordHash, @Role, @IdGV)";

            // Tạo command và kết nối
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.Parameters.AddWithValue("@Username", txtTK.Text);
                command.Parameters.AddWithValue("@PasswordHash", txtMK.Text);  // Hash mật khẩu nếu cần
                command.Parameters.AddWithValue("@Role", cb_role.Text);


                // Nếu teacher_id rỗng, truyền NULL vào
                if (string.IsNullOrEmpty(txt_idGV.Text))
                {
                    command.Parameters.AddWithValue("@IdGV", DBNull.Value); // Truyền NULL vào SQL
                }
                else
                {
                    command.Parameters.AddWithValue("@IdGV", txt_idGV.Text);
                }


                // Thực thi câu lệnh INSERT
                command.ExecuteNonQuery();
            }

            // Load lại dữ liệu sau khi thêm mới
            MessageBox.Show("Thêm mới thành công.");
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu các textbox không trống
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtTK.Text) || string.IsNullOrEmpty(txtMK.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Tạo câu lệnh SQL để cập nhật thông tin người dùng
            string query = "UPDATE Users SET username = @Username, password_hash = @PasswordHash, role = @Role, teacher_id = @IdGV WHERE user_id = @ID";

            // Tạo command và kết nối
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.Parameters.AddWithValue("@Username", txtTK.Text);
                command.Parameters.AddWithValue("@PasswordHash", txtMK.Text);  // Hash mật khẩu nếu cần
                command.Parameters.AddWithValue("@Role", cb_role.Text);

                // Nếu teacher_id rỗng, truyền NULL vào
                if (string.IsNullOrEmpty(txt_idGV.Text))
                {
                    command.Parameters.AddWithValue("@IdGV", DBNull.Value); // Truyền NULL vào SQL
                }
                else
                {
                    command.Parameters.AddWithValue("@IdGV", txt_idGV.Text);
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
            if (dgv_qldn.SelectedRows.Count > 0)
            {
                // Lấy user_id của dòng được chọn
                string userId = dgv_qldn.SelectedRows[0].Cells[0].Value.ToString();

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xóa người dùng", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Câu lệnh SQL để xóa bản ghi
                    string query = "DELETE FROM Users WHERE user_id = @UserId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@UserId", userId);

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
