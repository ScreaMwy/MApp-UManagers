using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY_Console.LINQ
{
    internal delegate void NonRetnNonParamClass();
    internal delegate void GenericDelegate<T>();

    internal sealed class LambdaExpression
    {
        internal LambdaExpression()
        { 
        }

        ~LambdaExpression()
        { 
        }

        internal void Show()
        {
            // 1.0
            {
                NonRetnNonParam function = new NonRetnNonParam(this.DoNothing);
                function.Invoke();
            }

            // 2.0
            {
                NonRetnNonParam function = new NonRetnNonParam(delegate () {
                    Console.WriteLine($"This is Doing Nothing[匿名方法]");
                });
                function.Invoke();
            }

            // 3.0
            {
                NonRetnNonParam function = new NonRetnNonParam(() => {
                    Console.WriteLine($"This is Do Nothing[Lambda表达式]");
                });
                function.Invoke();
            }

            {
                NonRetnWithParam function = new NonRetnWithParam((x, y) => {
                    Console.WriteLine($"{x}, {y}");
                });

                function.Invoke(3, 5);
            }

            {
                RetnParam function = new RetnParam((out int x, in int y) => {
                    x = 12;
                    string sum = Convert.ToString((x + y));
                    return sum;
                });

                int y = 12;
                Console.WriteLine($"{function.Invoke(out int x, in y)}");
            }
        }

        private void DoNothing()
        {
            Console.WriteLine($"This is Doing Nothing");
        }

        internal delegate void NonRetnNonParam();
        internal delegate void NonRetnWithParam(int x, int y);
        internal delegate int RetnNonParam();
        internal delegate string RetnParam(out int x, in int y);
    }
}
