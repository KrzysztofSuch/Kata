using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace TryMoqTests
{
    class Program
    {
        static void Main(string[] args)
        {
            




        }

        private static int ValueFunction()
        {
            throw new NotImplementedException();
        }
    }




    public interface ICustomer
    {
        int Age { get; set; }

        int DoShopinng(int itemsCount);

        ISeller Seller{ get; set; }
        object FooEvent { get; set; }
    }

    public interface ISeller
    {
        string Name { get; set; }
    }
}
