using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using MConsole.MAttributes;
using MConsole.Models;

namespace MConsole.Extensions
{
    public static class Extension
    {
        #region  Get RemarkAttribute Message in (Enum)UserState Extension Function

        public static string GetRemark(this Enum value)
        {
            Type type = value.GetType();
            FieldInfo fieldInfo = type.GetField(value.ToString());
            if (fieldInfo.IsDefined(typeof(RemarkAttribute), true))
            {
                var attribute = fieldInfo.GetCustomAttribute(typeof(RemarkAttribute), true) as RemarkAttribute;
                return attribute["Remark"];
                //return attribute.Remark;
            }
            else
            {
                return default(UserState).ToString();
            }
        }
        #endregion



        #region Get VaildateAttribute Message in User Extension Function

        public static bool Vaildate<T>(this T value)
        {
            //Type type = typeof(T);
            Type type = value.GetType();

            foreach (var prop in type.GetProperties())
            {
                if (prop.IsDefined(typeof(AVaildationAttribute), true))
                {
                    object[] attributes = prop.GetCustomAttributes(typeof(AVaildationAttribute), true);

                    foreach (AVaildationAttribute attribute in attributes)
                    {
                        if (!attribute.Vaildate(prop.GetValue(value)))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        #endregion
    }
}
