using System;
using System.Reflection;

using MConsole.MAttributes;
using MConsole.Models;
using MConsole.Extensions;

namespace MConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user = new User()
            {
                Id = "123",
                Name = "Guozy",
                QQ = 1234
                
            };

            Type type = typeof(User);
            if (type.IsDefined(typeof(CustomAttribute), true))
            {
                var attribute = type.GetCustomAttribute(typeof(CustomAttribute), true) as CustomAttribute;
                Console.WriteLine($"{attribute.Description}");
            }

            Console.WriteLine($"ID:{user["Id"]}, NAME:{user["Name"]}, QQ:{user.QQ}");

            var result = string.Empty;
            if (user.Vaildate<User>())
            {
                result = "合法";
            }
            else
            {
                result = "不合法";
            }
            Console.WriteLine($"QQ账号合法校验结果：{result}\n");

            if (user.Vaildate<User>())
            {
                result = "合法";
            }
            else
            {
                result = "不合法";
            }
            Console.WriteLine($"账号名长度校验结果：{result}\n");

            

            UserState userState = UserState.Frozen;
            var stateString = userState.GetRemark();
            Console.WriteLine($"状态：{stateString}");
            
        }
    }
}
