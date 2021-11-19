using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace WinForm.Utility
{
    public static class ParamsInjection
    {
        public static void Inject<TClass>(this MySqlCommand cmd, TClass obj)
        {
            Type type = typeof(TClass);
            foreach (PropertyInfo prop in type.GetProperties())
            {
                if (prop.Name == "Id")
                {
                    continue;
                }
                cmd.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(obj, null));
            }
        }

        public static void InjectWithId<TClass>(this MySqlCommand cmd, TClass obj)
        {
            Type type = typeof(TClass);
            foreach (PropertyInfo prop in type.GetProperties())
            {
                cmd.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(obj));
            }
        }
    }
}
