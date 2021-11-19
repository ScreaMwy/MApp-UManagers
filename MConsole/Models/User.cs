using System;
using System.Collections.Generic;
using System.Text;

using MConsole.MAttributes;
using MConsole.Extensions;

namespace MConsole.Models
{
    [Custom(Description = "这是一个用户类")]
    public sealed class User
    {
        #region Constructor
        public User()
        { 
        }

        public User(string id, string name, long qq)
        {
            _id = id;
            _name = name;
            _qq = qq;
        }
        #endregion

        #region Deconstructor
        ~User()
        {
        }
        #endregion

        #region Indexer
        public string this[string key]
        {
            get
            {
                switch (key)
                {
                    case "Id":
                        return _id;
                    case "Name":
                        return _name;
                    default:
                        throw new Exception("无效索引.");
                }
            }

            set
            {
                switch (key)
                {
                    case "Id":
                        _id = value;
                        break;
                    case "Name":
                        _name = value;
                        break;
                    default:
                        throw new Exception("无效索引.");
                }
            }
        }
        #endregion

        #region Property
        public string Id
        {
            get => _id;
            set => _id = value;
        }

        [LengthVaildate(5, 10)]
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        [IDVaildate(10001, 999999999999)]
        public long QQ
        {
            get => _qq;
            set => _qq = value;
        }
        #endregion

        #region Field
        private string _id;
        private string _name;
        private long _qq;
        #endregion
    }
}
