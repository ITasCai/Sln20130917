using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _02字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba“.

            //string msg = "abcdefg";
            //msg = MyReverse(msg);
            //Console.WriteLine(msg);
            //Console.ReadKey();
            #endregion


            #region 课上练习2：接收用户输入的一句英文，将其中的单词以反序输出。      “I love you"→“I evol uoy"
            //while (true)
            //{
            //    Console.WriteLine("请输入英文：");
            //    string msg = Console.ReadLine();
            //    string[] words = msg.Split(' ');
            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        words[i] = MyReverse(words[i]);
            //    }
            //    string full = string.Join(" ", words);
            //    Console.WriteLine(full);
            //}

            #endregion

            #region 课上练习3：”2012年12月21日”从日期字符串中把年月日分别取出来，打印到控制台。

            //while (true)
            //{
            //    Console.WriteLine("请输入日期:");
            //    string date = Console.ReadLine();
            //    string[] parts = date.Split(new char[] { '年', '月', '日' });
            //    Console.WriteLine("年：{0}",parts[0]);
            //    Console.WriteLine("月：{0}", parts[1]);
            //    Console.WriteLine("日：{0}", parts[2]);
            //}

            #endregion

            #region 课上练习4：把csv文件中的联系人姓名和电话显示出来。简单模拟csv文件，csv文件就是使用,分割数据的文本,输出


            //string[] lines = File.ReadAllLines("info.csv", Encoding.Default);
            ////循环遍历每一行数据
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    string[] parts = lines[i].Replace("\"", "").Split(',');
            //    Console.WriteLine("姓名：{0} 电话：{1}", parts[0] + parts[1], parts[2]);
            //}
            //Console.ReadKey();

            #endregion


            #region 练习5：123-456---7---89-----123----2把类似的字符串中重复符号”-”去掉，既得到123-456-7-89-123-2. split()、
            //string msg = "123-456---7---89-----123----2";
            //string[] parts = msg.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //string str = string.Join("-", parts);
            //Console.WriteLine(str);
            //Console.ReadLine();

            #endregion


            #region 练习6：从文件路径中提取出文件名(包含后缀) 。比如从c:\a\b.txt中提取出b.txt这个文件名出来。

            //string path = @"c:\a\b.txt";
            ////// 查找最后一个\出现的索引位置
            ////int index = path.LastIndexOf('\\');
            ////string filename = path.Substring(index + 1);
            //string filename = Path.GetFileName(path);
            //Console.WriteLine(filename);

            //"\r\n" Environment.NewLine




            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("\a");
            //}
            // Console.ReadLine();

            #endregion


            #region 192.168.10.5[port=21,type=ftp]     192.168.10.5[port=21]


            //string msg = "192.168.10.5[port=21,type=ftp]";
            //string[] parts = msg.Split(new string[] { "[port=", ",type=", "]" }, StringSplitOptions.RemoveEmptyEntries);


            //Console.WriteLine("IP:{0}\r\n  Port:{1} \r\n service:{2}", parts[0], parts[1], parts.Length == 3 ? parts[2] : "http");
            //Console.ReadLine();



            #endregion

            #region 练习8：求员工工资文件中，员工的最高工资、最低工资、平均工资

            //string[] lines = File.ReadAllLines("salary.txt", Encoding.Default);
            //string[] parts = lines[0].Split('=');

            ////假设第一个人的工资是最高工资
            //string maxName = parts[0];
            //int maxSalary = Convert.ToInt32(parts[1]);

            ////假设第一个人的工资是最低工资
            //string minName = parts[0];
            //int minSalary = Convert.ToInt32(parts[1]);

            //int sum = minSalary;//用来存储总工资。

            //int count = 1;

            ////循环遍历其他人的工资进行比对，计算最高工资与最低工资
            //for (int i = 1; i < lines.Length; i++)
            //{
            //    //跳过空行
            //    if (lines[i].Length != 0)
            //    {
            //        count++;
            //        string[] lineParts = lines[i].Split('=');
            //        int salary = Convert.ToInt32(lineParts[1]);

            //        //进行最高工资的比较
            //        if (salary > maxSalary)
            //        {
            //            maxSalary = salary;
            //            maxName = lineParts[0];

            //        }

            //        //进行最低工资的比较
            //        if (salary < minSalary)
            //        {
            //            minSalary = salary;
            //            minName = lineParts[0];
            //        }
            //        sum += salary;
            //    }

            //}

            //Console.WriteLine("最高工资：{0}  最低工资：{1}", maxSalary, minSalary);
            //Console.WriteLine("平均工资：{0}", sum * 1.0 / count);



            //Console.ReadKey();


            #endregion


            #region “北京传智播客软件培训，传智播客.net培训，传智播客Java培训。传智播客官网：http://www.itcast.cn。北京传智播客欢迎您。”。在以上字符串中请统计出”传智播客”出现的次数。找IndexOf()的重载。

            //string msg = "北京传智播客软件培训，传智播客.net培训，传智播客Java培训。传智播客官网：http://www.itcast.cn。北京传智播客欢迎您。";
            //string defaultWord = "传智播客";
            //int count = 0;
            //int index = 0;

            //while ((index = msg.IndexOf(defaultWord, index)) != -1)
            //{
            //    count++;
            //    index = index + defaultWord.Length;
            //}
            //Console.WriteLine("次数是：{0}", count);
            //Console.ReadKey();


            #endregion
        }

        /// <summary>
        /// 字符串反转
        /// </summary>
        /// <param name="msg"></param>
        private static string MyReverse(string msg)
        {
            char[] chars = msg.ToCharArray();
            for (int i = 0; i < msg.Length / 2; i++)
            {
                char ch = chars[i];
                chars[i] = chars[msg.Length - 1 - i];
                chars[msg.Length - 1 - i] = ch;
            }

            return new string(chars);

        }
    }
}
