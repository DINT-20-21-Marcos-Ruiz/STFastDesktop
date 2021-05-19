using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace STFastDesktop
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM _vm;
        List<String> sexoCampo = new List<String> { "Hombre", "Mujer" };
        public MainWindow()
        {
            _vm = new MainWindowVM();
            InitializeComponent();
            DataContext = _vm;
            sexo_ComboBox.ItemsSource = sexoCampo;
        }

        //MOVER VENTANA MAINWINDOW
        private void MainStackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        //BOTONES DE VENTANA
        private void CerrarMain_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void MaxMain_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (WindowState == WindowState.Maximized) {
                this.WindowState = WindowState.Normal;
            }                 
        }

        private void MinMain_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void TabablzControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // JUEGOS      ---------------------------------------------------------->
        private void AñadirJuego_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.AñadirJuego();
        }

        private void ModificarJuego_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.ModificarJuego();
        }

        private void ModificarJuego_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.HayJuegoSeleccionado();
        }

        private void EliminarJuego_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.EliminarJuego();
        }

        private void EliminarJuego_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.HayJuegoSeleccionado();
        }

        private void GuardarJuego_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (_vm.JuegosDisponibles(Convert.ToInt32(IdJuego_TextBlock.Text)))
            {
                _vm.GuardarJuego();
            } else MessageBox.Show("EL JUEGO NO ESTÁ DISPONIBLE", "AVISO", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void GuardarJuego_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.JuegoFormOk();
        }



        // EQUIPOS     ---------------------------------------------------------->
        private void AñadirEquipo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.AñadirEquipo();
        }

        private void ModificarEquipo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.ModificarEquipo();
        }

        private void ModificarEquipo_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.HayEquipoSeleccionado();
        }

        private void EliminarEquipo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.EliminarEquipo();
        }

        private void EliminarEquipo_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.HayEquipoSeleccionado();
        }

        private void GuardarEquipo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.GuardarEquipo();
        }

        private void GuardarEquipo_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.EquipoFormOk();
        }

        // JUGADORES   ---------------------------------------------------------->
        private void AñadirJugador_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.AñadirJugador();
        }

        private void ModificarJugador_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.ModificarJugador();
        }

        private void ModificarJugador_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.HayJugadorSeleccionado();
        }

        private void EliminarJugador_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.EliminarJugador();
        }

        private void EliminarJugador_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.HayJugadorSeleccionado();
        }

        private void GuardarJugador_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.GuardarJugador();
        }

        private void GuardarJugador_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.JugadorFormOk();
        }

        // COMPETICIÓN ---------------------------------------------------------->

        private void AñadirCompeticion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.AñadirCompeticion();
        }

        private void ModificarCompeticion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.ModificarCompeticiono();
        }

        private void ModificarCompeticion_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.HayCompeticionSeleccionado();
        }

        private void EliminarCompeticion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.EliminarCompeticion();
        }

        private void EliminarCompeticion_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.HayCompeticionSeleccionado();
        }

        private void GuardarCompeticion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vm.GuardarCompeticion();
        }

        private void GuardarCompeticion_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _vm.CompeticionFormOk();
        }
    }
}
