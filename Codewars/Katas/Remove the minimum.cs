using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class Remove_the_minimum
    {
        public static List<int> RemoveSmallest(List<int> numbersList)
        {
            if (numbersList.Count == 0)
                return numbersList;

            var smalestNumber = findSmalest(numbersList);
            numbersList = removeFirst(smalestNumber, numbersList);

            return numbersList;
        }

        private static List<int> removeFirst(int smalestNumber, List<Int32> numbersList)
        {

            numbersList.Remove(smalestNumber);
            return numbersList;
        }

        private static int findSmalest(List<Int32> numbersList)
        {
            return numbersList.Min();
        }
    }
}
