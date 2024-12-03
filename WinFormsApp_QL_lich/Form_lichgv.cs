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
    public partial class Form_lichgv : Form
    {
        public string ID_GV { get; set; }
        public Form_lichgv(string id)
        {
            InitializeComponent();
            ID_GV = id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_lichgv_Load(object sender, EventArgs e)
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
                    string query = "SELECT   c.course_name as mon_hoc_phan, cs.start_date as ngay_bat_dau,    cs.end_date as ngay_ket_thuc,  cs.day_of_week as thu,   cs.start_time as gio_bat_dau,    cs.end_time as gio_ket_thuc,   cs.room as phong,cs.soSV as so_sv FROM    ClassSections cs INNER JOIN Courses c ON cs.course_id = c.course_id INNER JOIN Teachers t ON cs.teacher_id = t.teacher_id  WHERE   t.teacher_id = @teacher_id;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số teacher_id vào câu truy vấn
                        command.Parameters.AddWithValue("@teacher_id", ID_GV);

                        // Tạo adapter để fill dữ liệu vào DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();

                        // Điền dữ liệu vào DataTable
                        adapter.Fill(dt);

                        // Kiểm tra nếu có dữ liệu
                        if (dt.Rows.Count > 0)
                        {
                            // Gán DataTable vào DataGridView
                            dgv_lichGv.DataSource = dt;
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

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string searchValue = txt_tim.Text.Trim(); // Lấy giá trị từ TextBox và loại bỏ khoảng trắng

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối đến cơ sở dữ liệu và thực hiện tìm kiếm
            string connectionString = "Server=LAPTOP-18M9N62S; Database=QL_lich; Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Câu truy vấn tìm kiếm chỉ trong phạm vi teacher_id
                    string searchQuery = @"SELECT cs.class_id as ID, cs.course_id as Ma_lop, cs.teacher_id AS Ma_GV, 
                                   cs.start_date as ngay_bat_dau, cs.end_date as ngay_ket_thuc, cs.day_of_week as thu, 
                                   cs.start_time as gio_bat_dau, cs.end_time as gio_ket_thuc, cs.room as phong, cs.soSV as so_SV
                                   FROM ClassSections cs
                                   INNER JOIN Teachers t ON cs.teacher_id = t.teacher_id
                                   WHERE (cs.class_id LIKE @SearchValue
                                   OR cs.course_id LIKE @SearchValue
                                   OR cs.teacher_id LIKE @SearchValue
                                   OR cs.start_date LIKE @SearchValue
                                   OR cs.end_date LIKE @SearchValue
                                   OR cs.day_of_week LIKE @SearchValue
                                   OR cs.start_time LIKE @SearchValue
                                   OR cs.end_time LIKE @SearchValue
                                   OR cs.room LIKE @SearchValue
                                   OR cs.soSV LIKE @SearchValue)
                                   AND t.teacher_id = @teacher_id"; // Thêm điều kiện lọc theo teacher_id

                    // Tạo lệnh SQL
                    using (SqlCommand command = new SqlCommand(searchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%"); // Thêm dấu '%' để tìm kiếm kiểu LIKE
                        command.Parameters.AddWithValue("@teacher_id", ID_GV); // Thêm tham số teacher_id vào câu truy vấn

                        // Thiết lập SqlDataAdapter và DataTable
                        SqlDataAdapter searchAdapter = new SqlDataAdapter(command);
                        DataTable searchTable = new DataTable();
                        searchAdapter.Fill(searchTable);

                        // Hiển thị kết quả trong DataGridView
                        dgv_lichGv.DataSource = searchTable;

                        // Kiểm tra xem có kết quả hay không
                        if (searchTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy lớp học nào phù hợp với từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
