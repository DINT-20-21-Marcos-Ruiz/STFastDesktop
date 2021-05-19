using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop.POJO
{
    public class Juego : INotifyPropertyChanged
    {
        public int Id_Juego { get; set; }
        public string JNombre { get; set; }
        public string Logo { get; set; }

        public Juego()
        {

        }
        public Juego(int id, string jNombre, string logo)
        {
            Id_Juego = id;
            JNombre = jNombre;
            Logo = logo;
        }
        public Juego(Juego juegoSeleccionado)
        {
            Id_Juego = juegoSeleccionado.Id_Juego;
            JNombre = juegoSeleccionado.JNombre;
            Logo = juegoSeleccionado.Logo;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
