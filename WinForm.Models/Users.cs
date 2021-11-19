using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using WinForm.Utility;

namespace WinForm.Model
{
    public sealed class Users
    {
        public static List<Users> ListAll()
        {
            DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM users");
            List<Users> users = new List<Users>();
            foreach (DataRow dr in dt.Rows)
            {
                users.Add(dr.DataRowToModel<Users>());
            }
            return users;
        }

        public static int Insert(Users users)
        {
            return SqlHelper.ExecuteNonQuery<Users>($@"INSERT INTO {nameof(users)}(Name, Sex, IsDel, BaseTypeId) VALUES(@Name, @Sex, @IsDel, @BaseTypeId)", 
                users);
        }
        
        public static int Update(Users users)
        {
            return SqlHelper.ExecuteNonQueryId<Users>(
                $@"UPDATE {nameof(users)} SET Name=@Name, Sex=@Sex, IsDel=@IsDel, BaseTypeId=@BaseTypeId WHERE Id=@Id",
                users);
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Gender Sex { get; set; }

        public NonJob IsDel { get; set; }

        public int BaseTypeId { get; set; }
    }
}
