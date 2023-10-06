using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin1
{
    // Derived class for prime numbers
    class PrimeNumber : Number
    {
        public PrimeNumber(int value) : base(value) { }

        public override bool IsPrime()
        {
            if (Value <= 1)
                return false;

            for (int i = 2; i * i <= Value; i++)
            {
                if (Value % i == 0)
                    return false;
            }

            return true;
        }
    }
}


