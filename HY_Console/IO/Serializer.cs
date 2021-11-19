using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace HY_Console.IO
{
    public sealed class Serializer<T> where T : class
    {
        public Serializer()
        { 
        }

        ~Serializer()
        {
        }

        #region Serialize/Deserialize To File
        public static Stream SerializerToMemory(T @object)
        {
            string filePath = Path.Combine(Constant.LogRoot, "Objective.txt");
            if (!File.Exists(filePath))
            {
                string newPath = Directory.CreateDirectory(filePath).FullName;
                Path.Combine(newPath, "Objective.txt");
            }


            FileStream fileStream = default(FileStream);

            Stream memStream = default(MemoryStream);
            using (memStream =  new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter();
                binFormatter.Serialize(memStream, @object);
            }
            return memStream;
        }

        public static object DeserializerFromMemory(Stream stream)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            return binFormatter.Deserialize(stream);
        }
        #endregion

        #region Serialize/Deserialize To XML

        public static void SerializerToXml(T @object, string path)
        {
            XmlSerializer serializer = new (typeof(T));
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                serializer.Serialize(fileStream, @object);
            }
        }

        public static string SerializerToXmlString(T @object)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (MemoryStream memStream = new MemoryStream())
            {
                serializer.Serialize(memStream, @object);
                string xmlString = Encoding.UTF8.GetString(memStream.ToArray());
                return xmlString;
            }
        }
        #endregion

        #region Serialize/Deserialize To Json
        /// <summary>
        ///     将对象序列化为Json格式的文件
        /// </summary>
        /// <param name="object"></param>
        public static void SerializerToJson(T @object, string path)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                jsonSerializer.WriteObject(fileStream, @object);
            }
        }

        public static string SerializerToJsonString(T @object)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream memStream = new MemoryStream())
            {
                jsonSerializer.WriteObject(memStream, @object);
                string jsonString = Encoding.UTF8.GetString(memStream.ToArray());
                return jsonString;
            }
        }
        #endregion
    }
}
