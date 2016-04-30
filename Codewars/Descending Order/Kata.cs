using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descending_Order
{

    public static class Kata
    {
        static void Main(string[] args)
        {
        }

        public static int DescendingOrder(int num)
        {
            var charsList = num.ToString().ToList();
            charsList.Sort();
            charsList.Reverse();
            var s = new String(charsList.ToArray());
            return int.Parse(s);
        }
    }

}
