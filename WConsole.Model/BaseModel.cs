using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WConsole.Model
{
    public class BaseModel
    {
        protected BaseModel()
        { 
        }

        protected BaseModel(int id)
        {
            _id = id;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        
        private int _id;
    }
}
