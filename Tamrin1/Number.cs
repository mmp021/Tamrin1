using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin1
{
    // Base class for numbers
    class Number
    {
        public int Value { get; }

        public Number(int value)
        {
            Value = value;
        }

        public virtual bool IsMirror()
        {
            return false;
        }

        public virtual bool IsPrime()
        {
            return false;
        }
    }
}
