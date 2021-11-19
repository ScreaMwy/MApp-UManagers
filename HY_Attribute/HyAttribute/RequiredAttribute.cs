using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY_Attribute.HyAttribute
{
    // 校验必填内容
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class RequiredAttribute : AVaildationAttribute
    {
        public RequiredAttribute(string message) : base(message)
        {
        }

        ~RequiredAttribute()
        { 
        }

        public override bool Vaildated(object value)
        {
            if (value == null || ((string)value).ToString() == string.Empty || string.IsNullOrWhiteSpace((string)value))
            {
                return false;
            }
            return true;
        }
    }
}
