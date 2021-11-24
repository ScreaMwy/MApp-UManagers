using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Model.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public sealed class RequiredAttribute : Attribute
    {
        public bool RequiredValidate(object obj)
        {
            if (obj == null || obj.ToString().Trim().Equals(String.Empty) 
                            || string.IsNullOrWhiteSpace(obj.ToString()) 
                            || obj.Equals(0) || obj.Equals(Gender.None))
            {
                return false;
            }
            return true;
        }
    }
}
