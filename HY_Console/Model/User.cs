using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY_Attribute.HyAttribute;

#nullable enable

namespace HY_Console.Model
{
    [Serializable]
    public sealed class User : BaseModel
    {
        public User()
        {
        }

        public User(int id) : base(id)
        { 
        }

        public User(int id, string name, string phone, string? address, DateTime? createTime) : base(id)
        {
            _name = name;
            _phone = phone;
            _address = address ?? "中山大学旧生物楼415栋302室";
            _createTime = createTime ?? DateTime.Now;
        }

        ~User()
        { 
        }

        [Required("用户名不能为空")]
        [Serialization("已序列化")]
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        [Required("手机号不能为空")]
        [LengthVaildation(11, "手机号必须为11位有效数字")]
        [Serialization("已序列化")]
        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        [Serialization("不进行序列化")]
        public string Address
        {
            get => _address;
            set => _address = value;
        }

        [Serialization("已序列化")]
        public DateTime CreateTime
        {
            get => _createTime;
            set => _createTime = value;
        }

        public void Show()
        {
            Console.WriteLine($"User[]");
        }

        private string _name;
        private string _phone;
        [NonSerialized]
        private string _address;
        private DateTime _createTime;
    }
}
