using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY_Attribute.HyAttribute
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public sealed class SerializationAttribute : Attribute
    {
        public SerializationAttribute(string message) => _message = message;

        ~SerializationAttribute()
        { 
        }

        public string Message
        {
            get => _message;
            private set => _message = value;
        }
        private string _message;
    }
}
