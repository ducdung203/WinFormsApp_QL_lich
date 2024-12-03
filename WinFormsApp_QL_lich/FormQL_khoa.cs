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
    public partial class FormQL_khoa : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-18M9N62S;Initial Catalog=QL_lich;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT d.department_id as ID ,d.ma_khoa  , d.department_name as tên_khoa FROM Departments d";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_qlkhoa.DataSource = table;

            // Tính toán và thiết lập chiều rộng các cột theo tỷ lệ phần trăm
            dgv_qlkhoa.Columns["ID"].Width = (int)(dgv_qlkhoa.Width * 0.15); // 20% chiều rộng
            dgv_qlkhoa.Columns["ma_khoa"].Width = (int)(dgv_qlkhoa.Width * 0.40); // 40% chiều rộng
            dgv_qlkhoa.Columns["tên_khoa"].Width = (int)(dgv_qlkhoa.Width * 0.40); // 40% chiều rộng

            // Tùy chỉnh thêm (ví dụ, thay đổi font của tiêu đề cột)
            dgv_qlkhoa.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Đổi font của tiêu đề cột
        }
        public FormQL_khoa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormQL_khoa_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void dgv_qlkhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_qlkhoa.CurrentRow.Index;
            txt_id.Text = dgv_qlkhoa.Rows[i].Cells[0].Value.ToString();
            txt_makhoa.Text = dgv_qlkhoa.Rows[i].Cells[1].Value.ToString();
            txt_khoa.Text = dgv_qlkhoa.Rows[i].Cells[2].Value.ToString();
           
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem ID có bị trùng trong cơ sở dữ liệu không
            string checkQuery = "SELECT COUNT(*) FROM Departments WHERE department_id = @ID";
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
           
            // Tạo câu lệnh SQL để thêm bản ghi
            string query = "INSERT INTO Departments (department_id, ma_khoa, department_name) VALUES (@ID, @ma_khoa, @department_name)";

            // Tạo command và kết nối
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ID", txt_id.Text);
                command.Parameters.AddWithValue("@ma_khoa", txt_makhoa.Text);
                command.Parameters.AddWithValue("@department_name", txt_khoa.Text);



                // Thực thi câu lệnh INSERT
                command.ExecuteNonQuery();
            }

            // Load lại dữ liệu sau khi thêm mới
            MessageBox.Show("Thêm mới thành công.");
            loaddata();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu các textbox không trống
            if (string.IsNullOrEmpty(txt_id.Text) || string.IsNullOrEmpty(txt_makhoa.Text) || string.IsNullOrEmpty(txt_khoa.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Tạo câu lệnh SQL để cập nhật thông tin người dùng
            string query = "UPDATE Departments SET  ma_khoa = @ma_khoa,  department_name = @department_name WHERE department_id = @ID";

            // Tạo command và kết nối
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ID", txt_id.Text);
                command.Parameters.AddWithValue("@ma_khoa", txt_makhoa.Text);
                command.Parameters.AddWithValue("@department_name", txt_khoa.Text);

               
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
            if (dgv_qlkhoa.SelectedRows.Count > 0)
            {
                // Lấy user_id của dòng được chọn
                string courseId = dgv_qlkhoa.SelectedRows[0].Cells[0].Value.ToString();

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xóa khoa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Câu lệnh SQL để xóa bản ghi
                    string query = "DELETE FROM Departments WHERE department_id = @department_id";
                    try
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm tham số vào câu lệnh SQL
                            command.Parameters.AddWithValue("@department_id", courseId);

                            // Thực thi câu lệnh DELETE
                            command.ExecuteNonQuery();
                        }
                        // Thông báo thành công
                        MessageBox.Show("Xóa thành công.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("không thể xóa khoa " + ex.Message);
                    }

                    
                    

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
