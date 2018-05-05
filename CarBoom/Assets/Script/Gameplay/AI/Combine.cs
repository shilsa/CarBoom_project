using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script.Gameplay.AI
{
    class Combine
    {
        private int a;
        private int b;
        public Combine(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int getA()
        {
            return this.a;
        }
        public int getB()
        {
            return this.b;
        }
    }
}
