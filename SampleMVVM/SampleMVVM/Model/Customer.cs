using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVVM.Model
{
 
    [Serializable]
    class Customer:BaseEntity
    {
        private string customerId;
        private string customerName;
        private string customerAddress;

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; NotifyPropertyChanged("CustomerId"); }
        }

        public string Customername
        {
            get { return customerName; }
            set { customerName = value; NotifyPropertyChanged("Customername"); }
        }

        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; NotifyPropertyChanged("CustomerAddress"); }
        }

        public override string ToString()
        {
            return String.Format(@"{0} , {1} , {2}", this.customerId, this.customerName, this.customerAddress);
        }

    }
}
