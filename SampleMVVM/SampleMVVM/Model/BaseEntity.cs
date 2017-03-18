using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVVM.Model
{
    class BaseEntity:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(params string[] parmeters)
        {
            if (PropertyChanged != default(PropertyChangedEventHandler))
            {
                foreach (var parm in parmeters)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(parm));
                }
            }
        }
    }
}
