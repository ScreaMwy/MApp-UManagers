using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace WConsole.Model
{
    public sealed class User : BaseModel
    {   
        public User()
        { 
        }

        public User(int id, string name, Gender gender, string phone, DateTime? createTime) : base(id)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _gender = gender;
            _phone = phone ?? throw new ArgumentNullException(nameof(phone));
            _createTime = createTime ?? DateTime.Now;
        }

        ~User()
        { 
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Gender Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public DateTime CreateTime
        {
            get => _createTime;
            set => _createTime = value;
        }

        private string _name;
        private Gender _gender;
        private string _phone;
        private DateTime _createTime;
    }
}
