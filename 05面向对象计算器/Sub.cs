using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05面向对象计算器
{
    /// <summary>
    /// 计算减法
    /// </summary>
    public class Sub : JiSuanQi
    {
        public Sub(int n1, int n2)
            : base(n1, n2)
        {

        }

        public override double JiSuan()
        {
            return this.Number1 - this.Number2;
        }
    }
}
