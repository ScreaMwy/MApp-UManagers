using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY_Attribute.HyAttribute
{
    public abstract class AVaildationAttribute : Attribute
    {
        protected AVaildationAttribute(string message)
        {
            _message = message;
        }

        public abstract bool Vaildated(object value);

        public string Message
        {
            get => _message;
        }
        private string _message;
    }
}
