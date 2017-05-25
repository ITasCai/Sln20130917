using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06值类型与引用类型
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 值类型与引用类型介绍

            //// 值类型, 栈
            ////int  short byte char bool double float struct enum decimal 


            ////引用类型 string 数组 类 接口 委托 
            ////堆
            //string s = "a";
            //s = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";



            ////值类型
            //int n = 100;


            //int m = n;

            //m = m + 1;

            //Console.WriteLine(n);
            //Console.ReadLine();


            ////引用类型
            //Person p = new Person();
            //p.Age = 100;

            //Person p1 = p;

            //p1.Age = 120;

            //Console.WriteLine(p.Age);
            //Console.ReadKey();

            #endregion


            //int n = 10;
            //M1(n);
            //Console.WriteLine(n);//10
            //Console.ReadKey();



            //Person p = new Person();
            //p.Age = 100;

            //M2(p);

            //Console.WriteLine(p.Age);//101





            //Person p = new Person();
            //p.Age = 100;
            //M3(p);
            //Console.WriteLine(p.Age);//1000




            //Person p = new Person();
            //p.Age = 100;
            //M4(p);
            //Console.WriteLine(p.Age);//100



            //string name = "科比";
            //M5(name);
            //Console.WriteLine(name);//科比


            //int[] arrInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //M6(arrInt);
            ////??????????
            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    Console.WriteLine(arrInt[i]);
            //}



            //int[] arrInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //M7(arrInt);
            ////??????????
            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    Console.WriteLine(arrInt[i]);
            //}


            #region 案例练习


























            // Console.ReadKey();




            #endregion



            //int n = 10;
            //M1(ref n);
            //Console.WriteLine(n);//11
            //Console.ReadKey();



            //Person p = new Person();
            //p.Age = 100;

            //M2(ref p);

            //Console.WriteLine(p.Age);//101




            //Person p = new Person();
            //p.Age = 100;
            //M3(ref p);
            //Console.WriteLine(p.Age);//





            //Person p = new Person();
            //p.Age = 100;
            //M4(ref p);
            //Console.WriteLine(p.Age);//1



            //string name = "科比";
            //M5(ref name);
            //Console.WriteLine(name);//乔丹




            //int[] arrInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //M6(ref arrInt);
            ////0000000
            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    Console.WriteLine(arrInt[i]);
            //}





            int[] arrInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            M7(ref arrInt);
            //??????????
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]);
            }

            #region MyRegion








            Console.ReadKey();
            #endregion
        }

        #region 值类型 与 引用类型 作为参数  【引用传递】
        private static void M7(ref int[] arrInt)
        {
            for (int i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = 100;
            }
        }





        private static void M6(ref int[] arrInt)
        {
            arrInt = new int[arrInt.Length];
            for (int i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = arrInt[i] * 2;
            }
        }


        private static void M5(ref string name2)
        {
            name2 = "乔丹";
        }



        private static void M4(ref Person p1)
        {
            p1 = new Person();
            p1.Age++;
        }


        private static void M3(ref Person p1)
        {
            p1.Age = 1000;
            p1 = new Person();
            p1.Age = 200;
        }




        private static void M2(ref Person p1)
        {
            p1.Age++;
        }


        //值传递，传递的是栈中的内容，（对于值类型，栈中的内容就是对应的数据。对于引用类型栈中内容就是对象的地址）
        //引用传递，传递的是栈本身的地址，多个变量名实际上指向的是同一个栈变量。
        //引用传递必须使用ref关键字修饰。在方法调用的时候传递参数的时候也必须加ref 关键字
        private static void M1(ref int m)
        {
            m++;
        }

        










        #endregion




        #region 值类型 与 引用类型 作为参数  【值传递】


        //值传递：

        //private static void M7(int[] arrInt)
        //{
        //    for (int i = 0; i < arrInt.Length; i++)
        //    {
        //        arrInt[i] = 100;
        //    }
        //}
        //private static void M6(int[] arrInt)
        //{
        //    arrInt = new int[arrInt.Length];
        //    for (int i = 0; i < arrInt.Length; i++)
        //    {
        //        arrInt[i] = arrInt[i] * 2;
        //    }
        //}


        //private static void M5(string name2)
        //{
        //    name2 = "乔丹";
        //}

        //private static void M4(Person p1)
        //{
        //    p1 = new Person();
        //    p1.Age++;
        //}

        //private static void M3(Person p1)
        //{
        //    p1.Age = 1000;
        //    p1 = new Person();
        //    p1.Age = 200;
        //}
        //private static void M2(Person p1)
        //{
        //    p1.Age++;
        //}
        //private static void M1(int m)
        //{
        //    m++;
        //}


        #endregion














    }

    class Person
    {
        public int Age
        {
            get;
            set;
        }
    }
}
