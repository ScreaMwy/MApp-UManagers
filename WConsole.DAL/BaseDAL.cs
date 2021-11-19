using System;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using WConsole.Config;
using WConsole.Model;

namespace WConsole.DAL
{
    public sealed class BaseDAL<T> where T : BaseModel
    {

        public BaseDAL()
        {
            _userTable = new();
        }

        ~BaseDAL()
        { 
        }

        //public List<T> FindAll() 
        public List<T> FindAll()
        {
            Type type = typeof(T);
            string columnString = GetColumn();
            string sql = $"SELECT {columnString} FROM [{type.Name}]";
            List<T> list = new();
            int key = default(int);


            using (SqlConnection conn = new(StaticConstant.SqlServerConnString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    T @object = (T)Activator.CreateInstance(type);
                    PropertyInfo[] props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                    foreach (var prop in props)
                    {
                        prop.SetValue(@object, reader[prop.Name]);

                    }
                    list.Add(@object);

                    key = (int)type.GetProperty("Id", BindingFlags.Instance | BindingFlags.Public).GetValue(@object);
                    _userTable.Add(key, @object);
                }
            }
            return list;
        }

        public T FindById(int id)
        {
            /*Type type = typeof(T);
            string columnString = GetColumn();
            string sql = $"SELECT {columnString} FROM [{type.Name}] WHERE Id = {id}";

            using (SqlConnection conn = new(StaticConstant.SqlServerConnString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    T @object = (T)Activator.CreateInstance(type);
                    foreach (var prop in type.GetProperties())
                    {
                        prop.SetValue(@object, reader[prop.Name]);
                    }
                    return @object;
                }
            }
            return default(T);*/

            return _userTable[id] as T;
        }

        public int Insert(T value)
        {
            Type type = typeof(T);
            T @object = (T)Activator.CreateInstance(type);
            string columnString = GetColumn();
            string paramString = GetParameter();
            string sql = $"INSERT INTO [{type.Name}]({columnString}) VALUES({paramString})";
            using (SqlConnection conn = new(StaticConstant.SqlServerConnString))
            {
                conn.Open();
                SqlCommand cmd = new(sql, conn);

                //遍历添加参数的值 @Param...
                cmd.Parameters.AddRange(SetParameter(value));
                int row = cmd.ExecuteNonQuery();
                return row;
            }
        }

        /*public int Update(T @object)
        {
            Type type = typeof(T);
            // T obj = (T)Activator.CreateInstance(type);
            // string sql = "UPDATE [@Table] SET [@Param] = @NewValue WHERE  [@Param] = @Value";
            int id = (int)type.GetProperty("Id", BindingFlags.Instance | BindingFlags.Public).GetValue(@object);
            string sql = $"UPDATE [{type.Name}] SET @Param = @Value WHERE [Id] = {id}";
            using (SqlConnection conn = new(StaticConstant.SqlServerConnString))
            {
                conn.Open();
                SqlCommand cmd = new(sql, conn);
                SqlParameter param = new("@Param", column);
                SqlParameter value = new("@Value", newValue);
                cmd.Parameters.Add(param);
                cmd.Parameters.Add(value);
                int row = cmd.ExecuteNonQuery();
                return row;
            }
        }

        public int UpdateName(T @object)
        {

        }*/


        #region Function Tools
        private string GetParameter()
        {
            Type type = typeof(T);
            string paramString = string.Join(", ", type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                                       .Select((PropertyInfo prop) => $"@{prop.Name}"));
            return paramString;
        }

        private string GetColumn()
        {
            Type type = typeof(T);
            string columnString = string.Join(", ", type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
                                        .Select((PropertyInfo prop) => $"[{prop.Name}]"));
            return columnString;
        }

        private SqlParameter[] SetParameter(T value)
        {
            Type type = typeof(T);
            List<SqlParameter> paramValues = new();
            
            foreach (var prop in type.GetProperties())
            {
                SqlParameter param = new($"@{prop.Name}", prop.GetValue(value));
                paramValues.Add(param);
            }

            return paramValues.ToArray<SqlParameter>();
        }
        #endregion

        #region Property
        public Hashtable UserTable
        {
            get => _userTable;
        }
        #endregion 

        #region Field
        private readonly Hashtable _userTable;
        #endregion
    }
}
