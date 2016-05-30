using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace RxOne.Rx1
{
    class SequenceOfNumbers : IObservable<int>
    {
        public IDisposable Subscribe(IObserver<int> observer)
        {
            observer.OnNext(2);
            observer.OnNext(3);
            observer.OnNext(4);
            observer.OnCompleted();
            return Disposable.Empty;
            
        }
    }
}
