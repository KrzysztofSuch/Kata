using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RxOne.Rx1;

namespace RxOne
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new SequenceOfNumbers();
            var observer = new ConsoleObserver<int>();
            numbers.Subscribe(observer);


//            IEnumerable a = new List<int>()
//            {
//                
//                1,2,3,4
//            };
//
//            Console.WriteLine("START");
//
//            Console.WriteLine(a.GetEnumerator().MoveNext());
//
//            foreach (var variable in a)
//            {
//                Console.WriteLine(variable);
//            }


//            Console.WriteLine(a.GetEnumerator());
//
//            Console.WriteLine(a.GetEnumerator().MoveNext());
//
//            Console.WriteLine(a.GetEnumerator());

//            Console.WriteLine("End");



            Console.ReadLine();
        }
    }
}
