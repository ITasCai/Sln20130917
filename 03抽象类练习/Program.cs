using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new RealDuck();
            duck.Bark();
            Console.ReadKey();
        }
    }

    abstract class Duck
    {
        public void Swim()
        {
            Console.WriteLine("鸭子水上漂.....");
        }

        public abstract void Bark();
    }

    //橡皮鸭子
    class RubberDuck : Duck
    {

        public override void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫！！");
        }
    }

    class RealDuck : Duck
    {

        public override void Bark()
        {
            Console.WriteLine("真鸭子嘎嘎叫。。");
        }
    }
}
