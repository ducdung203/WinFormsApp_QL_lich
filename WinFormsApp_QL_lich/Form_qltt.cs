using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp_QL_lich
{

    public partial class Form_qltt : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-18M9N62S;Initial Catalog=QL_lich;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT t.teacher_id AS ID, t.name AS Ten_GiangVien, t.email AS email,  t.phone, t.department_id AS Ma_KHoa FROM Teachers t ; ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_qltt.DataSource = table;

            // Tính toán và thiết lập chiều rộng cột theo tỷ lệ
            dgv_qltt.Columns["ID"].Width = (int)(dgv_qltt.Width * 0.1); //10%
            dgv_qltt.Columns["Ten_GiangVien"].Width = (int)(dgv_qltt.Width * 0.30); // 30%
            dgv_qltt.Columns["email"].Width = (int)(dgv_qltt.Width * 0.30); // 30%
            dgv_qltt.Columns["phone"].Width = (int)(dgv_qltt.Width * 0.15); // 15%
            dgv_qltt.Columns["Ma_KHoa"].Width = (int)(dgv_qltt.Width * 0.10); // 10%

            // Tùy chỉnh thêm (ví dụ, thay đổi font của tiêu đề cột)
            dgv_qltt.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Đổi font của tiêu đề cột
        }
        public Form_qltt()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem ID có bị trùng trong cơ sở dữ liệu không
            string checkQuery = "SELECT COUNT(*) FROM Teachers WHERE teacher_id = @ID";
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
            // Kiểm tra xem department_id có tồn tại trong bảng department hay không
            if (!string.IsNullOrEmpty(txtMa_khoa.Text))
            {
                string checkTeacherQuery = "SELECT COUNT(*) FROM Departments WHERE department_id = @Khoa_ID";
                using (SqlCommand checkCommand = new SqlCommand(checkTeacherQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Khoa_ID", txtMa_khoa.Text);
                    int count = (int)checkCommand.ExecuteScalar(); // Kiểm tra số lượng bản ghi có teacher_id trùng

                    if (count == 0)
                    {
                        // Nếu teacher_id không tồn tại trong bảng Teachers
                        MessageBox.Show("không tồn tại mã khoa này này.");
                        return; // Không thực hiện thêm bản ghi
                    }
                }
            }
            // Tạo câu lệnh SQL để thêm bản ghi
            string query = "INSERT INTO Teachers (teacher_id, name, email, phone, department_id) VALUES (@ID, @name, @email, @so, @Makhoa)";

            // Tạo command và kết nối
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ID", txt_id.Text);
                command.Parameters.AddWithValue("@name", txt_Ten.Text);
                command.Parameters.AddWithValue("@email", txt_email.Text);
                command.Parameters.AddWithValue("@so", txt_So.Text);



                // Nếu teacher_id rỗng, truyền NULL vào
                if (string.IsNullOrEmpty(txtMa_khoa.Text))
                {
                    command.Parameters.AddWithValue("@Makhoa", DBNull.Value); // Truyền NULL vào SQL
                }
                else
                {
                    command.Parameters.AddWithValue("@Makhoa", txtMa_khoa.Text);
                }


                // Thực thi câu lệnh INSERT
                command.ExecuteNonQuery();
            }

            // Load lại dữ liệu sau khi thêm mới
            MessageBox.Show("Thêm mới thành công.");
            loaddata();
        }

        private void Form_qltt_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu các textbox không trống
            if (string.IsNullOrEmpty(txt_id.Text) || string.IsNullOrEmpty(txt_Ten.Text) || string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_So.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Tạo câu lệnh SQL để cập nhật thông tin người dùng
            string query = "UPDATE Teachers SET name = @name, email = @email, phone = @so, department_id = @Makhoa WHERE teacher_id = @ID";

            // Tạo command và kết nối
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ID", txt_id.Text);
                command.Parameters.AddWithValue("@name", txt_Ten.Text);
                command.Parameters.AddWithValue("@email", txt_email.Text);
                command.Parameters.AddWithValue("@so", txt_So.Text);

                // Nếu teacher_id rỗng, truyền NULL vào
                if (string.IsNullOrEmpty(txtMa_khoa.Text))
                {
                    command.Parameters.AddWithValue("@Makhoa", DBNull.Value); // Truyền NULL vào SQL
                }
                else
                {
                    command.Parameters.AddWithValue("@Makhoa", txtMa_khoa.Text);
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
            if (dgv_qltt.SelectedRows.Count > 0)
            {
                // Lấy teacher_id của dòng được chọn
                string teacherid = dgv_qltt.SelectedRows[0].Cells[0].Value.ToString();

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xóa thông tin người dùng", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Câu lệnh SQL để xóa bản ghi
                    string query = "DELETE FROM Teachers WHERE teacher_id = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@ID", teacherid);

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

        private void dgv_qltt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_qltt.CurrentRow.Index;
            txt_id.Text = dgv_qltt.Rows[i].Cells[0].Value.ToString();
            txt_Ten.Text = dgv_qltt.Rows[i].Cells[1].Value.ToString();
            txt_email.Text = dgv_qltt.Rows[i].Cells[2].Value.ToString();
            txt_So.Text = dgv_qltt.Rows[i].Cells[3].Value.ToString();
            txtMa_khoa.Text = dgv_qltt.Rows[i].Cells[4].Value.ToString();
        }
    }
}
