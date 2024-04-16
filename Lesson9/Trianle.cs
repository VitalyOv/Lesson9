using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    public class Triangle: Shape
    {
        private int _a;
        private int _b;
        private int _c;

        public Triangle(int a, int b, int c) : base()
        {
            if(a < 0)
            {
                throw new ArgumentException();
            }

            _a = a;
            _b = b;
            _c = c;
        }

        public override double GetSquare()
        {
            return (_a * _b) / 2;
        }
    }
}
