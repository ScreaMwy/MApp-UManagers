using System;
using System.Collections;
using System.Reflection; 
using HY_Console.Model;
using HY_Console.Extension;

namespace HY_Console
{
     public delegate void Feedback(Int32 value);

    public sealed class ProgramOld
    { 
        public static void MainOld(string[] args)
        {
            #region Attribute && Extension Test
            /*
            // phone: "15912345680"
            User user = new(id: 100, name: "Guozy", phone: string.Empty, address: null, createTime: null);
            ArrayList uList = user.Vaildate<User>();
            foreach (var u in uList)
            {
                Console.WriteLine($"{u}");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"{user.Id}\n{user.Name}\n{user.Phone}\n{user.Address}\n{user.CreateTime}");


            Console.WriteLine("888888888888888888888888888888888");
            Type type = typeof(DiyList);
            MethodInfo methodShow = type.GetMethod("Show");
            object obj = Activator.CreateInstance(type);
            methodShow.Invoke(obj, null);
            */
            #endregion

            #region Delegate Test
            StaticDelegateDemo();
            #endregion
        } 

        #region Delegate
        public static void StaticDelegateDemo()
        {
            Console.WriteLine($"-----Static Delegat Demo-----");
            Counter(1, 3, null);
            Counter(1, 3, FeedbackToConsole);
            Counter(1, 3, new Feedback(FeedbackToMessage));
            Console.Write("\n");
        }

        private static void Counter(Int32 start, Int32 end, Feedback fb)
        {
            for (Int32 val = start; val <= end; val++)
            {
                /*
                 * if (fb != null)
                 * {
                 *      fb.Invoke(val);
                 * }
                 */
                fb?.Invoke(val);
            }
        }


        private static void FeedbackToConsole(Int32 value) 
        {
            Console.WriteLine($"[Console]Item:{value}");
        }

        private static void FeedbackToMessage(Int32 value)
        {
            Console.WriteLine($"[MessageBox]Item:{value}");
        }

        private static void FeedbackToFile(Int32 value)
        {
            Console.WriteLine($"[File]Item:{value}");
        }
        #endregion
    }
}
