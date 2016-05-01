using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class DigitalRoots
    {
        public int DigitalRoot(long n)
        {

            if (n < 10)
                return (int)n;

            var sum = n.ToString().ToArray().Sum(parser());

            if (sum > 9)
                sum = DigitalRoot(sum);

            return sum;
        }

        private static Func<Char, Int32> parser()
        {


            return a => int.Parse(a.ToString());
        }
    }
}
