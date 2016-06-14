using System;
using System.Reactive.Subjects;

namespace RxSubject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var subject = new Subject<PorcjaObliczen>();

            subject.Subscribe(Console.WriteLine);

            subject.OnNext(new PorcjaObliczen("A", 1));
            subject.OnNext(new PorcjaObliczen("B", 2));

            subject.Subscribe(Console.WriteLine);


            subject.OnNext(new PorcjaObliczen("C", 3));

            subject.OnCompleted();


            Console.ReadLine();
        }
    }

    internal class PorcjaObliczen
    {
        private readonly int _liczba;
        private readonly string _tekst;

        public PorcjaObliczen(string tekst, int liczba)
        {
            _tekst = tekst;
            _liczba = liczba;
        }

        public override string ToString()
        {
            return _tekst + _liczba;
        }
    }
}