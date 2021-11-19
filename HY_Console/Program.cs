using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Threading;
using HY_Console.IO;
using HY_Console.Model;
using HY_Console.Extension;
using HY_Console.LINQ;

namespace HY_Console
{
    public sealed class Program
    {
        public static unsafe void Main()
        {
            User user = new(id: 100, name: "Guozy", phone: "18565095630", address: null, createTime: null);
            #region 输出文件
            /*IOSerialize.Writer<User>(user);
            Console.WriteLine($"{IOSerialize.Reader()}");*/
            #endregion

            #region 序列化和反序列化
            /*Stream stream = Serializer<User>.SerializerToMemory(user);
            Console.WriteLine($"{Serializer<User>.DeserializerFromMemory(stream)}");*/

            //Serializer<User>.SerializerToXml(user, Constant.SerializationPath);
            {
                Serializer<User>.SerializerToJson(user, Constant.SerializationPath);
                Console.WriteLine($"{Serializer<User>.SerializerToJsonString(user)}");

                ArrayList resList = user.Serializable<User>();
                foreach (var res in resList)
                {
                    Console.WriteLine($"{res}");
                }
            }
            #endregion

            #region LINQ
            {
                ArrayList userList = new ArrayList()
                {
                    new User(id: 100, name: "G1", phone: "18565095630", address: null, createTime: null),
                    new User(id: 101, name: "G2", phone: "18565095631", address: null, createTime: null),
                    new User(id: 102, name: "G3", phone: "18565095632", address: null, createTime: null),
                    new User(id: 103, name: "G4", phone: "18565095633", address: null, createTime: null),
                    new User(id: 104, name: "G5", phone: "18565095634", address: null, createTime: null),
                    new User(id: 105, name: "G6", phone: "18565095635", address: null, createTime: null),
                    new User(id: 106, name: "G7", phone: "18565095636", address: null, createTime: null),
                    new User(id: 107, name: "G8", phone: "18565095637", address: null, createTime: null),
                    new User(id: 108, name: "G9", phone: "18565095638", address: null, createTime: null)
                };

                //匿名类
                var varModel = new
                {
                    Name = "G9",
                    Phone = "18565095639",
                    Id = 2,
                    Address = default(string),
                    CreateTime = DateTime.Now
                };

                LambdaExpression lam = new();
                lam.Show();
            }
            #endregion

            #region 扩展方法
            {
                user.Sing<User>();
            }
            #endregion

            #region dynamic简化反射    当类成员函数的访问权限是internal，使用dynamic来简化反射时，是不会出现函数对象为空的情况，而普通反射会出现，编译器找不到相应的函数名
            {
                Type dycType = typeof(User);
                dynamic dycUser = Activator.CreateInstance(dycType);
                dycUser.Show();

                /*Type varType = typeof(User);
                var varUser = Activator.CreateInstance(varType);
                MethodInfo show = varType.GetMethod("Show", BindingFlags.Instance | BindingFlags.Public);
                show.Invoke(varUser, null);*/
            }
            #endregion



            #region Linq Demo
            {
                List<User> list = new List<User>()
                {
                    new User(id: 100, name: "G1", phone: "18565095630", address: null, createTime: null),
                    new User(id: 101, name: "G2", phone: "18565095631", address: null, createTime: null),
                    new User(id: 102, name: "G3", phone: "18565095632", address: null, createTime: null),
                    new User(id: 103, name: "G4", phone: "18565095633", address: null, createTime: null),
                    new User(id: 104, name: "G5", phone: "18565095634", address: null, createTime: null),
                    new User(id: 105, name: "G6", phone: "18565095635", address: null, createTime: null),
                    new User(id: 106, name: "G7", phone: "18565095636", address: null, createTime: null),
                    new User(id: 107, name: "G8", phone: "18565095637", address: null, createTime: null),
                    new User(id: 108, name: "G9", phone: "18565095638", address: null, createTime: null)
                };

                /*var result = list.ValueWhere(delegate (User user) {
                    return user.Id < 105 ? true : false;
                });*/

                Console.Write($"检查数据是否满足条件！");
                /*var result = list.ValueWhere((in User user) => 
                {
                    Console.Write($".");
                    Thread.Sleep(500);
                    //Console.Write($"\n");
                    return user.Id < 105;
                });*/

                var result = list.ValueWhere((in User user) =>
                {
                    Console.Write($".");
                    Thread.Sleep(500);
                    return user.Id < 105;
                })
                .Select(user => new
                {
                    Id = user.Id,
                    Name = user.Name,
                    Phone = user.Phone
                })
                .OrderBy(user => new
                {
                    Id = user.Id
                });

                Console.WriteLine($"\n");

                foreach (var item in result)
                {
                    
                }
            }
            #endregion

            #region Unsafe
            {
                int val = 10;
                int* ptr = &val;
                Console.WriteLine($"Data is {val}\nData is {ptr->ToString()}\nAddress is {(IntPtr)ptr}");


                int p = 10;
                int q = 20;
                Swap(&p, &q);


                int[] list = new int[] { 10, 100, 1000 };
                //fixed (int* listPtr = list)
                fixed (int* listPtr = &list[0])
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Address of list[{i}] = {(IntPtr)(listPtr + i)}");
                        Console.WriteLine($"Value of list[{i}] = {*(listPtr + i)}");
                    }
                }


                int number = 1024;
                byte* nptr = (byte*)&number;
                Console.WriteLine($"nptr:{nptr->ToString()}");
                
            }
            #endregion
        }

        public static unsafe string ToArray(byte* bytes)
        {
            

            return default(string);
        }

        public static unsafe void Swap(int* ptr1, int* ptr2)
        {
            int tmp = *ptr1;
            *ptr1 = *ptr2;
            *ptr2 = tmp;
            Console.WriteLine($"p = {ptr1->ToString()}\nq = {ptr2->ToString()}");
        }
    }
}