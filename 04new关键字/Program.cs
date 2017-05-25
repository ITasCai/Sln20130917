using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04new关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Chinese();
            //p.Say();
            //Console.ReadKey();


            //Chinese c = new Chinese();
            Person c = new Chinese();
            c.Say();
            Console.ReadKey();


        }
    }


    class Person
    {
        public virtual void Say()
        {
            Console.WriteLine("Say in Person");
        }

    }


    class Japanese : Person
    {

        //sealed关键字与override关键字一起使用，禁止其他的之类继续重写该方法。
        public sealed override void Say()
        {
            Console.WriteLine("Say in Japanese");
        }
    }

    //class Tokyo : Japanese
    //{
    //    public override void Say()
    //    {
    //        base.Say();
    //    }
    //}



    class Chinese : Person
    {
        //public override void Say()
        //{
        //    Console.WriteLine("Say in Chinese.");
        //}

        public new void Say()
        {
            Console.WriteLine("Say in Chinese.");
        }
    }

    class HeBeiRen : Chinese
    {
        public new void Say()
        {
            Console.WriteLine("Say in Chinese.");
        }
    }

}
