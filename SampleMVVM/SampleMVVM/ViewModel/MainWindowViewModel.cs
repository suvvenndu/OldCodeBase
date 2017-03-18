using SampleMVVM.CommandManager;
using SampleMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleMVVM.ViewModel
{
    class MainWindowViewModel:BaseEntity
    {
        public MainWindowViewModel()
        {
            ClickCommand = new RelayCommand(paremer =>
                {
                    var customeList = SampleMVVM.Service.Service.GetAllCustomers();
                    Customers = new ObservableCollection<Customer>(customeList);
                    NotifyPropertyChanged("Customers");

                });
        }

        #region InputCommands

       public ICommand ClickCommand { get; private set; }
        
        #endregion

        #region Output Proprties

       public ObservableCollection<Customer> Customers { get; private set; }

        #endregion

    }
}
