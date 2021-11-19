using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY_Console.IO
{
    public static class Constant
    {
        public static string LogRoot = ConfigurationManager.AppSettings["LogRoot"];
        public static string LogPath = ConfigurationManager.AppSettings["LogPath"];
        public static string LogMovePath = ConfigurationManager.AppSettings["LogMovePath"];
        public static string DailyPath = ConfigurationManager.AppSettings["DailyPath"];
        public static string SerializationPath = ConfigurationManager.AppSettings["SerializationPath"];
        public static string CurLogPath = AppDomain.CurrentDomain.BaseDirectory;
    }
}
