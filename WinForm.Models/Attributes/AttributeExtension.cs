using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace WinForm.Model.Attributes
{
    public static class AttributeExtension
    {
        public static List<string> InputRequiredValidation<T>(this T obj) where T : class
        {
            Type type = typeof(T);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            List<string> msgs = new List<string>();
            foreach (PropertyInfo prop in props)
            {
                if (prop.IsDefined(typeof(RequiredAttribute), true))
                {
                    RequiredAttribute[] attributes = (RequiredAttribute[])prop.GetCustomAttributes(typeof(RequiredAttribute), true);
                    foreach (RequiredAttribute attribute in attributes)
                    {
                        if (!attribute.RequiredValidate(prop.GetValue(obj, null)))
                        {
                            msgs.Add($"{prop.Name}字段不能为空或所输入的内容不合法，请确认后重新填写！");
                        }
                    }
                }
            }
            return msgs;
        }
    }
}
