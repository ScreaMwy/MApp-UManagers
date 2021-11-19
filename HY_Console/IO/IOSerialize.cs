using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Threading.Tasks;

namespace HY_Console.IO
{
    public sealed  class IOSerialize
    {
        public IOSerialize()
        { 
        }

        ~IOSerialize() 
        { 
        }

        private static Hashtable GetProperties<T>(T value)
        {
            Type type = typeof(T);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            Hashtable propMap = new Hashtable();
            foreach (PropertyInfo prop in props)
            {
                propMap.Add(prop.Name,  prop.GetValue(value));
            }
            return propMap;
        }

        public static void Writer<T>(T value)
        {
            {
                #region Directory
                if (!Directory.Exists(Constant.LogRoot))
                {
                    DirectoryInfo directoryInfo = Directory.CreateDirectory(Constant.LogRoot);
                    /*Directory.Move(Constant.LogPath, Constant.LogMovePath);
                    Directory.Delete(Constant.LogMovePath);*/
                }
                #endregion
            }

            {
                #region File
                //string fileName = Path.Combine(Constant.LogPath, "Log.txt");
                string fullName = $"{Guid.NewGuid()}.log";
                string fileName = Path.Combine(Constant.LogRoot, fullName);
                bool isExists = File.Exists(fileName);
                if (!isExists)
                {
                    Directory.CreateDirectory(Constant.LogRoot);
                }
                
                //using (FileStream fileStream = File.Create(fileName))
                using (FileStream fileStream = new(fileName, FileMode.Append, FileAccess.Write))
                {
                    //string message = $"[{DateTime.Now}] {Guid.NewGuid().ToString()}\n";
                    string message = string.Empty;

                    Hashtable resMap = GetProperties<T>(value);
                    foreach (var key in resMap.Keys)
                    {
                        message = message.Insert(message.Length, $"{key}:{resMap[key].ToString()}\n");
                    }
                    byte[] bytes = Encoding.UTF8.GetBytes(message);
                    /* fileStream.Write(bytes, 0, bytes.Length);
                     fileStream.Flush();

                     {
                         fileStream.Write(Encoding.UTF8.GetBytes($"{DateTime.Now}新的任务..."));
                         fileStream.Flush();
                         using (MemoryStream memStream = new MemoryStream())
                         {
                             memStream.WriteTo(fileStream);
                             memStream.Flush();
                         }
                     }*/

                    using (BufferedStream buffer = new BufferedStream(fileStream))
                    {
                        buffer.Write(bytes, 0, bytes.Length);
                        buffer.Flush();
                    }
                }
                #endregion
            }
        }

        public static string Reader()
        {
            string message = string.Empty;
            //string fileName = Path.Combine(Constant.LogPath, "Log.txt");
            string fileName = Constant.DailyPath;
            bool isExists = File.Exists(fileName);
            if (isExists)
            {
                using (FileStream fileStream = new(fileName, FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[fileStream.Length];
                    /*using (BinaryReader binReader = new BinaryReader(fileStream))
                    {
                        binReader.Read(bytes, 0, bytes.Length);
                        binReader.Close();
                        binReader.Dispose();
                    }*/
                    
                    using (BufferedStream buffer = new BufferedStream(fileStream))
                    {
                        buffer.Read(bytes, 0, bytes.Length);
                        buffer.Flush();
                    }
                    message = Encoding.UTF8.GetString(bytes);
                }
            }
            return message;
        }
    }
}
