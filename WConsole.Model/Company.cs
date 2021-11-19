using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WConsole.Model
{
    public sealed class Company : BaseModel
    {
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public DateTime dateTime
        {
            get => _createTime;
            set => _createTime = value;
        }

        private string _name;
        private DateTime _createTime;
    }
}
