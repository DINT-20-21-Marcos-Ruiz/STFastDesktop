using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace STFastDesktop
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand CerrarLogin = new RoutedUICommand(
            "CerrarLogin",
            "CerrarLogin",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.S,ModifierKeys.Control)
            });
        public static readonly RoutedUICommand CerrarMain = new RoutedUICommand(
            "CerrarMain",
            "CerrarMain",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.S,ModifierKeys.Control)
            });
        public static readonly RoutedUICommand MaxMain = new RoutedUICommand(
            "MaxMain",
            "MaxMain",
            typeof(CustomCommands),
            new InputGestureCollection
            {});
        public static readonly RoutedUICommand MinMain = new RoutedUICommand(
            "MinMain",
            "MinMain",
            typeof(CustomCommands),
            new InputGestureCollection
            {});
        public static readonly RoutedUICommand Login = new RoutedUICommand(
            "Login",
            "Login",
            typeof(CustomCommands),
            new InputGestureCollection
            {
               
            });
    }
}
