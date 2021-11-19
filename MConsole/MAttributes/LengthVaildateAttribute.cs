using System;
using System.Collections.Generic;
using System.Text;

namespace MConsole.MAttributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class LengthVaildateAttribute : AVaildationAttribute
    {
        public LengthVaildateAttribute()
        {
        }

        public LengthVaildateAttribute(long min, long max)
        {
            _max = max;
            _min = min;
        }

        public override bool Vaildate(object value)
        {
            if (value != null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                int length = value.ToString().Length;
                if (length >= _min && length <= _max)
                {
                    return true;
                }
            }
            return false;
        }

        public long this[string key]
        {
            get
            {
                switch (key)
                {
                    case "Max":
                        return _max;
                    case "Min":
                        return _min;
                    default:
                        throw new Exception("无效索引值");
                }
            }
        }

        private readonly long _max;
        private readonly long _min;
    }
}
