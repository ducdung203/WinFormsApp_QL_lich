using Microsoft.Data.SqlClient;

using static System.Runtime.InteropServices.JavaScript.JSType;


namespace WinFormsApp_QL_lich

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            string username = txtTaikhoan.Text;
            string password = txtMatkhau.Text;
            string connectionString = "Server=LAPTOP-18M9N62S; Database=QL_lich; Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT password_hash, Role, teacher_id FROM Users WHERE username = @username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string storedHash = reader["password_hash"].ToString();
                            string role = reader["role"].ToString();
                            string teacher_id = reader["teacher_id"].ToString();

                            if (VerifyPasswordHash(password, storedHash))
                            {
                                // Đăng nhập thành công
                                OpenMainFormWithRole(role, teacher_id);
                            }
                            else
                            {
                                MessageBox.Show("Sai mật khẩu.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập không tồn tại.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }


        }
        private void OpenMainFormWithRole(string role, string teacherid)
        {
            if (role == "admin")
            {
                FormQL f = new FormQL();
                f.Show();
                this.Hide();
            }
            else if (role == "teacher")
            {

                Form_GV f = new Form_GV(teacherid);
                f.Show();
                this.Hide();
                // Mở form giáo viên

            }

        }
        private bool VerifyPasswordHash(string inputPassword, string storedHash)
        {
            // Giả sử bạn không sử dụng hash cho mật khẩu trong ví dụ này.
            // Thực tế, bạn nên sử dụng thuật toán hash như SHA256 hoặc bcrypt
            return inputPassword == storedHash;
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ẩn mật khẩu khi người dùng nhập vào TextBox
            txtMatkhau.UseSystemPasswordChar = true;
        }
    }
}
