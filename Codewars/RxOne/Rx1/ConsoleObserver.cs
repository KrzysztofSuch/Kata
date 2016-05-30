using System;

namespace RxOne.Rx1
{
    internal class ConsoleObserver<T> : IObserver<T>
    {
        public void OnNext(T value)
        {
            Console.WriteLine("Value: {0}", value);
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            Console.WriteLine("end.");
        }
    }
}