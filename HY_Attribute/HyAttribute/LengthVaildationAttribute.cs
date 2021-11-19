using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY_Attribute.HyAttribute
{
    public class LengthVaildationAttribute : AVaildationAttribute
    {
        public LengthVaildationAttribute(int len, string message) : base(message)
        {
            _len = len;
        }

        public override bool Vaildated(object value)
        {
            if ((string)value != null || (string)value != string.Empty || !string.IsNullOrWhiteSpace((string)value))
            {
                if (((string)value).Length == _len)
                {
                    return true;
                }
            }
            return false;
        }

        public int Len
        {
            get => _len;
        }

        private readonly int _len;
    }
}
