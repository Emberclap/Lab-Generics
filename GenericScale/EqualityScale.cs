using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T left;
        private T right;
        public EqualityScale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public T Left { get; set; }
        public T Right { get; set; }
        public bool AreEqual()
        {
            if (Left.Equals(Right))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
