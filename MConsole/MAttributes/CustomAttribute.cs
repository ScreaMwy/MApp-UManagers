using System;
using System.Collections.Generic;
using System.Text;

namespace MConsole.MAttributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class CustomAttribute : Attribute
    {
        public CustomAttribute()
        { 
        }

        public CustomAttribute(string description)
        {
            _description = description;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        private string _description;
    }
}
