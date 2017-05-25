using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05面向对象计算器
{
    /// <summary>
    /// 计算除法运算
    /// </summary>
    public class Div : JiSuanQi
    {
        public Div(int n1, int n2)
            : base(n1, n2)
        {

        }
        public override double JiSuan()
        {
            return this.Number1 / this.Number2;
        }
    }
}
