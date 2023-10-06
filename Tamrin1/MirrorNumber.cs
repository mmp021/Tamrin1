using System.Collections;

namespace Tamrin1
{
    // Derived class for mirror numbers
    class MirrorNumber : Number
    {
        public MirrorNumber(int value) : base(value) { }

        public override bool IsMirror()
        {
            string numStr = Value.ToString();
            int len = numStr.Length;

            for (int i = 0; i < len / 2; i++)
            {
                if (numStr[i] != numStr[len - 1 - i])
                    return false;
            }

            return true;
        }
    }

}