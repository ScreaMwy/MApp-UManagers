using System;
using System.Reflection;

namespace MConsole.MAttributes
{
    public class RemarkAttribute : Attribute
    {
        #region Constructor
        
        public RemarkAttribute()
        {
        }

        public RemarkAttribute(string remark)
        {
            _remark = remark;
        }
        
        #endregion

        #region Indexer

        public string this[string key]
        {
            get
            {
                if (key == "Remark")
                {
                    return _remark;
                }
                else
                {
                    throw new Exception("无效索引值");
                }
            }
        }

        #endregion

        #region Property

        public string Remark
        {
            get => _remark;
            set => _remark = value;
        }

        #endregion
        
        #region Field
        
        private string _remark;
        
        #endregion
    }

    public enum UserState
    {
        [Remark("正常")]
        Normal = 0,

        [Remark("冻结")]
        Frozen = 1,

        [Remark("删除")]
        Delete = 2
    }
}