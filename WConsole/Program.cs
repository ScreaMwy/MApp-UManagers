using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using WConsole.Model;
using WConsole.DAL;

namespace WConsole
{

    public class Program
    {
        public static void Main(string[] args)
        {
            BaseDAL<User> baseDAL = new();
            List<User> uList = baseDAL.FindAll();
            if (uList.Count < 0)
            {
                Console.WriteLine($"用户查询结果为：{"空"}");
            }

            foreach (var user in uList)
            {
                Type type = typeof(User);
                PropertyInfo[] props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                foreach (PropertyInfo prop in props)
                {
                    Console.WriteLine($"{prop.Name}:{prop.GetValue(user)}");
                }

            }

            Console.WriteLine("*****************************************");


            {
                User user1 = baseDAL.FindById(2);
                Type type = typeof(User);
                PropertyInfo[] props = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                foreach (PropertyInfo prop in props)
                {
                    Console.WriteLine($"{prop.Name}:{prop.GetValue(user1)}");
                }
            }


            // Insert  5, "ZhangSan", Gender.Female, "18565095630"
            /*User ur = new()
            {
                Id = 5,
                Name = "ZhangSan",
                Gender = Gender.Female,
                Phone = "18565055603",
                CreateTime = DateTime.Now
            };
            string result = baseDAL.Insert(ur) > 0 ? "OK" : "Fail";
            Console.WriteLine($"Insert {result}!");*/


            //as 关键字必须与引用类型或可空类型一起使用

            /*string result = baseDAL.Update<string>(new User() { Id = 4 }, 
                "GaoGong", "name") > 0 ? "OK" : "Fail";
            Console.WriteLine($"Insert {result}!");*/
        }
    }
}
