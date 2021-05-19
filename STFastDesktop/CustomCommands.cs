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

        public static readonly RoutedUICommand AñadirJuego = new RoutedUICommand(
            "AñadirJuego",
            "AñadirJuego",
            typeof(CustomCommands),
            new InputGestureCollection {});
        public static readonly RoutedUICommand ModificarJuego = new RoutedUICommand(
            "ModificarJuego",
            "ModificarJuego",
            typeof(CustomCommands),
            new InputGestureCollection { });
        public static readonly RoutedUICommand GuardarJuego = new RoutedUICommand(
            "GuardarJuego",
            "GuardarJuego",
            typeof(CustomCommands),
            new InputGestureCollection { });
        public static readonly RoutedUICommand EliminarJuego = new RoutedUICommand(
            "EliminarJuego",
            "EliminarJuego",
            typeof(CustomCommands),
            new InputGestureCollection { });

        public static readonly RoutedUICommand AñadirEquipo = new RoutedUICommand(
            "AñadirEquipo",
            "AñadirEquipo",
            typeof(CustomCommands),
            new InputGestureCollection { });
        public static readonly RoutedUICommand ModificarEquipo = new RoutedUICommand(
            "ModificarEquipo",
            "ModificarEquipo",
            typeof(CustomCommands),
            new InputGestureCollection { });
        public static readonly RoutedUICommand GuardarEquipo = new RoutedUICommand(
            "GuardarEquipo",
            "GuardarEquipo",
            typeof(CustomCommands),
            new InputGestureCollection { });
        public static readonly RoutedUICommand EliminarEquipo = new RoutedUICommand(
            "EliminarEquipo",
            "EliminarEquipo",
            typeof(CustomCommands),
            new InputGestureCollection { });

        public static readonly RoutedUICommand AñadirJugador = new RoutedUICommand(
            "AñadirJugador",
            "AñadirJugador",
            typeof(CustomCommands),
            new InputGestureCollection { });
        public static readonly RoutedUICommand ModificarJugador = new RoutedUICommand(
            "ModificarJugador",
            "ModificarJugador",
            typeof(CustomCommands),
            new InputGestureCollection { });
        public static readonly RoutedUICommand GuardarJugador = new RoutedUICommand(
            "GuardarJugador",
            "GuardarJugador",
            typeof(CustomCommands),
            new InputGestureCollection { });
        public static readonly RoutedUICommand EliminarJugador = new RoutedUICommand(
            "EliminarJugador",
            "EliminarJugador",
            typeof(CustomCommands),
            new InputGestureCollection { });

        public static readonly RoutedUICommand AñadirCompeticion = new RoutedUICommand(
            "AñadirCompeticion",
            "AñadirCompeticion",
            typeof(CustomCommands),
            new InputGestureCollection { });
        public static readonly RoutedUICommand ModificarCompeticion = new RoutedUICommand(
            "ModificarCompeticion",
            "ModificarCompeticion",
            typeof(CustomCommands),
            new InputGestureCollection { });
        public static readonly RoutedUICommand GuardarCompeticion = new RoutedUICommand(
            "GuardarCompeticion",
            "GuardarCompeticion",
            typeof(CustomCommands),
            new InputGestureCollection { });
        public static readonly RoutedUICommand EliminarCompeticion = new RoutedUICommand(
            "EliminarCompeticion",
            "EliminarCompeticion",
            typeof(CustomCommands),
            new InputGestureCollection { });
    }
}
