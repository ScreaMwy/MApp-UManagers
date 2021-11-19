using System;
using System.Collections.Generic;
using System.Text;

namespace MConsole.MAttributes
{
    public abstract class AVaildationAttribute : Attribute
    {
        public abstract bool Vaildate(object value);
    }
}
