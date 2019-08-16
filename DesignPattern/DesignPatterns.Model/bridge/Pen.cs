using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model.bridge
{

    /// <summary>
    /// 笔
    /// </summary>
    public abstract class Pen
    {
        public readonly Color color;

        public Pen(Color color)
        {
            this.color = color;
        }
        public abstract void Wirte(string msg);
    }
}
