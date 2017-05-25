using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05面向对象计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                JiSuanQi jsq = null;
                Console.WriteLine("number 1 :");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("操作符");
                string czf = Console.ReadLine();

                Console.WriteLine("number 2");
                int n2 = Convert.ToInt32(Console.ReadLine());

                jsq = GetJiSuanObject(n1, czf, n2);

                if (jsq != null)
                {
                    double result = jsq.JiSuan();
                    Console.WriteLine(" 结果：{0}", result);
                }
                Console.ReadLine();
            }
        }


        //简单工厂设计模式
        private static JiSuanQi GetJiSuanObject(int n1, string czf, int n2)
        {
            JiSuanQi jsq = null;
            switch (czf)
            {
                case "+":
                    jsq = new Add(n1, n2);
                    break;
                case "-":
                    jsq = new Sub(n1, n2);
                    break;
                case "/":
                    jsq = new Div(n1, n2);
                    break;
            }
            return jsq;
        }
    }
}
