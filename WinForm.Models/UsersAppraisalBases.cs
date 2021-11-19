using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WinForm.Utility;

namespace WinForm.Model
{
    public class UsersAppraisalBases
    {
        public static List<UsersAppraisalBases> GetListJoinAppraisal()
        {
            List<UsersAppraisalBases> usersAppraisalBasesList = new List<UsersAppraisalBases>();
            string sql = $@"select u.Id, u.Name, u.Sex, u.BaseTypeId, u.IsDel, abs.AppraisalBase, abs.BaseType 
                                    from Users u 
                                    left join AppraisalBases abs 
                                    on u.BaseTypeId = abs.Id";
            DataTable dataTable = SqlHelper.ExecuteTable(sql);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                usersAppraisalBasesList.Add(ToModel(dataRow));
            }
            return usersAppraisalBasesList;
        }

        private static UsersAppraisalBases ToModel(DataRow dataRow)
        {
            UsersAppraisalBases usersAppraisalBases = new UsersAppraisalBases();
            usersAppraisalBases.Id = (int)dataRow["Id"];
            usersAppraisalBases.Name = dataRow["Name"].ToString();
            usersAppraisalBases.Sex = (Gender)dataRow["Sex"];
            usersAppraisalBases.BaseType = dataRow["BaseType"].ToString();
            usersAppraisalBases.BaseTypeId = (int)dataRow["BaseTypeId"];
            usersAppraisalBases.AppraisalBase = (int)dataRow["AppraisalBase"];
            usersAppraisalBases.IsDel = (NonJob)dataRow["IsDel"];
            return usersAppraisalBases;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Gender Sex
        {
            get => _sex;
            set => _sex = value;
        }

        public int BaseTypeId
        {
            get => _baseTypeId;
            set => _baseTypeId = value;
        }
        
        public string BaseType
        {
            get => _baseType;
            set => _baseType = value;
        }

        public int AppraisalBase
        {
            get => _appraisalBase;
            set => _appraisalBase = value;
        }

        public NonJob IsDel
        {
            get => _isDel;
            set => _isDel = value;
        }

        private int _id;
        private string _name;
        private Gender _sex;
        private int _baseTypeId;
        private string _baseType;
        private int _appraisalBase;
        private NonJob _isDel;
    }
}
