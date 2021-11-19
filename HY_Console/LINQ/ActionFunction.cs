using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY_Console.LINQ
{
    public sealed class ActionFunction
    {
        public void Show()
        {
            Action action = delegate () { };
            Action<int> genericAction = delegate (int i) { Console.WriteLine($"{i}"); };
        }
    }
}
