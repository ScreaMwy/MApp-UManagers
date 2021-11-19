using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;
using HY_Console.Model;
using HY_Attribute.HyAttribute;
// => \\ /
namespace HY_Console.Extension
{
    public static class Extension
    {
        internal static  ArrayList Vaildate<T>(this T value) where T : BaseModel
        {
            Type type = typeof(T);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            _resultList = new();
            foreach (PropertyInfo prop in props)
            {
                if (prop.IsDefined(typeof(AVaildationAttribute), true))
                {
                    AVaildationAttribute[] attributes = (AVaildationAttribute[])prop.GetCustomAttributes(typeof(AVaildationAttribute), true);
                    foreach (AVaildationAttribute attribute in attributes)
                    {
                        if (attribute.Vaildated(prop.GetValue(value)))
                        {
                            _resultList.Add($"{prop.Name}:[{VaildationStatus.OK}]数据合法");
                        }
                        else
                        {
                            _resultList.Add($"{prop.Name}:{attribute.Message}"); 
                        }
                    }    
                }
            }
            return _resultList;
        }

        internal static ArrayList Serializable<T>(this T value) where T : BaseModel
        {   
            Type type = typeof(T);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            string message = string.Empty;
            ArrayList msgList = new ArrayList();
            foreach (var prop in props)
            { 
                if (prop.IsDefined(typeof(SerializationAttribute), true))
                {
                    SerializationAttribute[] attributes = (SerializationAttribute[])prop.GetCustomAttributes(typeof(SerializationAttribute), true);
                    foreach (var attribute in attributes)
                    {
                        message = $"{prop.Name}:{attribute.Message}";
                        msgList.Add(message);
                    }
                }
            }
            return msgList;
        }

        public  static void Sing<T>(this T value)
        {
            Type type = typeof(T);
            //PropertyInfo[] props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var field in fields)
            {
                Console.WriteLine($"{field.Name}:{field.GetValue(value)}");
            }
        }

        #region LinQ Demo
        public delegate bool LinqFunc(in User user);

        public static List<User> ValueWhere(this List<User> source, LinqFunc linqFunc)
        {
            var list = new List<User>();
            foreach (var item in source)
            {
                if (linqFunc.Invoke(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        // Standard Linq
        public static IEnumerable<T> EnumWhere<T>(this IEnumerable<T> source, Func<T, bool> func)
        {
            if (source == null)
            {
                throw new Exception($"source is null");
            }

            if (func == null)
            {
                throw new Exception($"func is null");
            }

            foreach (var item in source)
            {
                if (func.Invoke(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> EnumSelect<T>(this IEnumerable<T> source, Func<T, bool> func)
        {
            return default(IEnumerable<T>);
        }
        #endregion

        internal static ArrayList ResultList
        {
            get => _resultList;
        }

        private static ArrayList _resultList;
    }
}