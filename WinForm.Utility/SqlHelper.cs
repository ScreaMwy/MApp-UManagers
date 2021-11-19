using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WinForm.Utility
{
    public sealed class SqlHelper
    {
        internal SqlHelper()
        {

        }

        ~SqlHelper()
        { 
        }

        public static DataTable ExecuteTable(string cmdText)
        {
            using (MySqlConnection conn = new MySqlConnection(_conString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
        }

        public static int ExecuteNonQuery<TObject>(string cmdText, TObject obj)
        {
            using (MySqlConnection conn = new MySqlConnection(_conString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.Inject<TObject>(obj);
                int rows = cmd.ExecuteNonQuery();
                if (rows <= 0)
                {
                    throw new Exception($"数据库操作失败！");
                }
                return rows;
            }
        }

        public static int ExecuteNonQueryId<TObject>(string cmdText, TObject obj)
        {
            using (MySqlConnection conn = new MySqlConnection(_conString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);
                cmd.InjectWithId<TObject>(obj);
                int rows = cmd.ExecuteNonQuery();
                if (rows <= 0)
                {
                    throw new Exception();
                }
                return rows;
            }
        }

        public static string ConString
        {
            get => _conString;
            set => _conString = value;
        }

        private static string _conString;
    }
}
