using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WConsole.Config
{
    public sealed class StaticConstant
    {
        public static readonly string SqlServerConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }
}
