using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop.POJO
{
    class Equipo : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public int Juego { get; set; }
        public int JNombre { get; set; }
        public int Logo { get; set; }

        public Equipo()
        {

        }

        public Equipo(int id, int juego, int jNombre, int logo)
        {
            Id = id;
            Juego = juego;
            JNombre = jNombre;
            Logo = logo;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
