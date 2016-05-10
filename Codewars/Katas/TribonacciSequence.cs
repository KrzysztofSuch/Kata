using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class TribonacciSequence
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
            {
                return new double[1];
            }
            if (n == 1)
            {
                return new double[1] { signature[0] };
            }
            if (n == 2)
            {
                return new double[2] { signature[0],signature[1]};
            }

            var list = signature.ToList();
            for (int i = list.Count; i < n; i++)
            {
                var len = list.Count;
                var sum = list[len - 3] + list[len - 2] + list[len - 1];
                list.Add(sum);

            }
            signature = list.ToArray();
            return signature;
        }
    }
}
