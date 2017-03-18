using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DependencyPropertyExample.Extensions
{
    //class CustomListBox:ListBox
    //{
    //    public ICommand Command
    //    {
    //        get { return (ICommand)GetValue(CommandProperty); }
    //        set { SetValue(CommandProperty, value); }
    //    }

    //    public static readonly DependencyProperty CommandProperty =
    //        DependencyProperty.Register("Command", typeof(ICommand), typeof(CustomListBox), null);

    //}


    class CommandProviders
    {
        public static ICommand GetCommand(DependencyObject depObject)
        {
            return (ICommand)depObject.GetValue(CommandProprtey);
        }

        public static void SetCommand(DependencyObject depobject, ICommand value)
        {
            depobject.SetValue(CommandProprtey, value);
        }

        public static readonly DependencyProperty CommandProprtey =
            DependencyProperty.RegisterAttached("Command", typeof(ICommand), typeof(CommandProviders), null);
    }


}
