using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05面向对象计算器
{
    /// <summary>
    /// 计算加法的类
    /// </summary>
    public class Add : JiSuanQi
    {
        public Add(int n1, int n2)
            : base(n1, n2)
        {

        }
        public override double JiSuan()
        {
            return this.Number1 + this.Number2;
        }
    }
}
