using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm.Utility;
using System.Data;

namespace WinForm.Model
{
    public sealed class AppraisalBases
    {
        public static List<AppraisalBases> ListAll()
        {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            DataTable dt = SqlHelper.ExecuteTable($@"select * from appraisalbases");
            foreach (DataRow dr in dt.Rows)
            {
                appraisalBases.Add(ToModel(dr));
            }
            return appraisalBases;
        }

        private static AppraisalBases ToModel(DataRow dr)
        {
            AppraisalBases appraisalBases = new AppraisalBases();
            appraisalBases.Id = (int)dr["Id"];
            appraisalBases.BaseType = dr["BaseType"].ToString();
            appraisalBases.AppraisalBase = (int)dr["AppraisalBase"];
            return appraisalBases;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
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

        private int _id;
        private string _baseType;
        private int _appraisalBase;
    }
}
