using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLcuahangsonnuoc.Class
{
    class Functions
    {
        public static SqlConnection Con;  //Khai báo đối tượng kết nối    

        static Functions()
        {
            Connect("thuychieu", "Chieu@12345");
        }

        //Phương thức tạo Connect()
        public static void Connect(string id, string password)
        {
            Con = new SqlConnection();   //Khởi tạo đối tượng
            Con.ConnectionString = string.Format(@"Server=tcp:thuychieu.database.windows.net,1433;Initial Catalog=CuaHangSon;Persist Security Info=False;User ID={0};Password={1};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;", id, password);
            Con.Open();                  //Mở kết nối
            //Kiểm tra kết nối
            if (Con.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        //Tạo phương thức Disconnect()
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	//Đóng kết nối
                Con.Dispose(); 	//Giải phóng tài nguyên
                Con = null;
            }
        }
        //Phương thức thực thi câu lệnh Select lấy dữ liệu vào bảng
        public static SqlDataAdapter GetDataAdapter(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter, ánh xạ CSDL vào dataset 
            dap.SelectCommand = new SqlCommand(); //Chứa câu lệnh SQL được truyền vào   
            dap.SelectCommand.Connection = Functions.Con; //Xác định được địa chỉ kết nối để thực thi câu lệnh sql 
            dap.SelectCommand.CommandText = sql;
            // Tự động tạo ra các câu lệnh Insert Update Delete
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dap);
            dap.InsertCommand = sqlCommandBuilder.GetInsertCommand(true);
            dap.UpdateCommand = sqlCommandBuilder.GetUpdateCommand(true);
            dap.DeleteCommand = sqlCommandBuilder.GetDeleteCommand(true);

            return dap;
        }
        //Phương thức thực thi câu lệnh Select lấy dữ liệu vào bảng
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tao doi tuong thuoc lop SQL COMMAND
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Functions.Con;
            dap.SelectCommand.CommandText = sql;
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table); //Đổ kết quả từ câu lệnh sql vào table
            return table;
        }
        //Phương thức thực thi câu lệnh Insert, Update, Delete
        public static void RunSql(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }
        //Hàm kiểm tra khoá trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }
        //trả về đường dẫn của ảnh
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }

    }
}

