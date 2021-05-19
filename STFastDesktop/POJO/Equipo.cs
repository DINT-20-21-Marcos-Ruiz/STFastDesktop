using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop.POJO
{
    public class Equipo : INotifyPropertyChanged
    {
        public int Id_Equipo { get; set; }
        public int Juego { get; set; }
        public string ENombre { get; set; }
        public string Logo { get; set; }
        public string Abreviacion { get; set; }

        public Equipo()
        {

        }

        public Equipo(int id, int juego, string eNombre, string logo, string abreviacion)
        {
            Id_Equipo = id;
            Juego = juego;
            ENombre = eNombre;
            Logo = logo;
            Abreviacion = abreviacion;
        }
        public Equipo(Equipo equipoSeleccionado)
        {
            Id_Equipo = equipoSeleccionado.Id_Equipo;
            Juego = equipoSeleccionado.Juego;
            ENombre = equipoSeleccionado.ENombre;
            Logo = equipoSeleccionado.Logo;
            Abreviacion = equipoSeleccionado.Abreviacion;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
