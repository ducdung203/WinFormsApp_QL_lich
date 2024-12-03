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
    public partial class Form_ttcn : Form
    {
        // Thuộc tính để nhận teacher_id
        public string ID_GV { get; set; }
        public Form_ttcn(string id)
        {
            InitializeComponent();
            ID_GV = id;
            
        }
        // Hàm hiển thị dữ liệu vào trong form con
        
        private void Form_ttcn_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID_GV))
            {
                MessageBox.Show("Chưa có thông tin");
                return;
            }

            // Kết nối đến cơ sở dữ liệu và lấy thông tin giảng viên
            string connectionString = "Server=LAPTOP-18M9N62S; Database=QL_lich; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT t.*, d.department_name FROM Teachers t INNER JOIN Departments d ON t.department_id = d.department_id  WHERE teacher_id = @teacher_id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số teacher_id vào câu truy vấn
                        command.Parameters.AddWithValue("@teacher_id", ID_GV);

                        // Thực hiện truy vấn và đọc kết quả
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read()) // Kiểm tra nếu có dữ liệu
                        {
                            // Hiển thị dữ liệu vào các Label
                            labelID.Text = $"Giảng viên ID: {ID_GV}";
                            labelName.Text = $"Tên: {reader["Name"].ToString()}";
                            labelPhone.Text = $"Số điện thoại: {reader["Phone"].ToString()}";
                            labelEmail.Text = $"Email: {reader["Email"].ToString()}";
                            labelKhoa.Text = $"Khoa: {reader["department_name"].ToString()}";
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy giảng viên với ID này.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
        }
    }
}
