using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY_Attribute;
using HY_Attribute.HyAttribute;

namespace HY_Console.Model
{
    [Serializable]
    public abstract class BaseModel
    {
        protected BaseModel()
        { 
        }

        protected BaseModel(int id)
        {
            _id = id;
        }

        ~BaseModel()
        { 
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        private int _id;
    }
}
