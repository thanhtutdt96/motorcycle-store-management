using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanXe.DAO
{
    public class DataProvider
    {
        public static SqlConnection conn;
        public DataProvider()
        {
            conn = new SqlConnection(@"Server=TP550LD;Database=QuanLyBanXe;Trusted_Connection=True;");
        }
        public DataTable GetData(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            conn.Open();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable GetData(string procName, SqlParameter[] para)
        {
            DataTable table = new DataTable();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = procName;
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conn;
            if (para != null)
            {
                command.Parameters.AddRange(para);
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            conn.Close();
            return table;
        }

        public int ExecuteSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            int row = command.ExecuteNonQuery();
            conn.Close();
            return row;
        }

        public int ExecuteSQL(string procName, SqlParameter[] para)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            int row = cmd.ExecuteNonQuery();
            conn.Close(); 
            return row;
        }
    }
}
