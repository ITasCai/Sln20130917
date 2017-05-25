using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            ////  string msg = "你好China！";
            //string msg = null;//"";

            ////判断字符串是否为一个空字符串===》""
            ////if (msg == "")
            //if (string.IsNullOrEmpty(msg))
            //{
            //    Console.WriteLine("空字符串！！！！");
            //}
            //else
            //{
            //    Console.WriteLine("飞空字符串！！");
            //}
            ////Console.WriteLine(msg.Length);
            //Console.ReadKey();





            //=============
            //string msg = "hEllO";

            //// 字符串修改完毕后必须接收返回值，因为字符串具有不可变性。无法直接修改原来的字符串。
            //msg = msg.ToUpper();
            //Console.WriteLine(msg);
            //Console.ReadKey();


            //=========Equal()比较两个字符串是否相同。字符串相同：两个字符串中每个位置的字符完全相同，
            //则表示两个字符串相同。
            //string s1 = "abc";
            //string s2 = "abc";
            //////s2.IndexOf("edd",
            //// s2.LastIndexOf(

            //// 判断字符串是否相同的方式
            ////1,.
            ////if (s1==s2)
            //if (s1.Equals(s2))
            //{
            //    Console.WriteLine("ok");
            //}
            //else
            //{
            //    Console.WriteLine("不相同 ");
            //}
            //Console.ReadKey();




            ////
            //string msg = "我爱北京天安门，天安门上太阳升。我家不住天安门，天安门前有保安。";
            //int index = msg.LastIndexOf("天安门");
            //Console.WriteLine(index);
            //Console.ReadKey();



            ////substring截取字符串。
            //string msg = "听说过杨中科吗？";
            //string name= msg.Substring(3, 3);
            //Console.WriteLine(name);
            //Console.ReadKey();


            ////Split
            //string msg = "乔丹|科比|杨中科||||||||赵建业";
            //string[] names = msg.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            //string full = string.Join("====>", names);
            //Console.WriteLine(full);
            //Console.ReadKey();


            //Console.WriteLine("我叫{0},今年{1}岁了，至今{2}。","张小花","而是又把","已离异");
            //Console.ReadKey();

            //string msg = string.Format("我叫{0}今年{1}岁了。", "张胜利", 90);

            //Console.WriteLine(msg);
            //Console.ReadKey();


            //string msg = "我是博士，值类型与引用类型。北京传值博客.net培训，只要998.苏坤，蒋坤抱回家。传值博客。传值博客传值博客传值博客。传值博客";
            //string s1 = "我的手机号码是：【13888888888】。北京传值博客电话：139999999";
            ////msg = msg.Replace('值', '智').Replace('博', '播');
            //msg = msg.Replace("传值博客", "传智播客");
            //Console.WriteLine(msg);
            //Console.ReadKey();



        }
    }
}
