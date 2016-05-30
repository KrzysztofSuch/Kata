using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;

namespace RxOne
{
    class MemberSerachViewModel : INotifyPropertyChanged
    {
        private IMemberSearchModel _memberSearchModel;
        private ISchedulerProvider _scheduleProvider;
        public event PropertyChangedEventHandler PropertyChanged;

        public MemberSerachViewModel(IMemberSearchModel memberSearchModel, ISchedulerProvider schedulerProvider)
        {
            _memberSearchModel = memberSearchModel;
            _scheduleProvider = schedulerProvider;

//            this.PropertyChanged(vm => vm.SearchText).Subscribe(Search);


        }

        public string SearchText { get; set; }


        private void Search(string searchText)
        {
            
        }
    }



    internal interface ISchedulerProvider
    {
    }

    internal interface IMemberSearchModel
    {
    }
}
