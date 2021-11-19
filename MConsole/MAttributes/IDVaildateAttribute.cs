using System;
using System.Collections.Generic;
using System.Text;

namespace MConsole.MAttributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class IDVaildateAttribute : AVaildationAttribute
    {
        public IDVaildateAttribute()
        { 
        }

        public IDVaildateAttribute(long min, long max)
        {
            _max = max;
            _min = min;
        }

        public override bool Vaildate(object value)
        {
            if (value != null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                if (long.TryParse(value.ToString(), out long result))
                {
                    if (result > _min && result < _max)
                    {
                        return true;
                    }
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
