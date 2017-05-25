using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05面向对象计算器
{
    /// <summary>
    /// 计算器的一个抽下个父类
    /// </summary>
    public abstract class JiSuanQi
    {

        public JiSuanQi(int n1, int n2)
        {
            this.Number1 = n1;
            this.Number2 = n2;
        }

        public int Number1
        {
            get;
            set;
        }

        public int Number2
        {
            get;
            set;

        }

        public abstract double JiSuan();
    }
}
