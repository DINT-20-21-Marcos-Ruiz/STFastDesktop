using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop.POJO
{
    public enum Sexo {Hombre, Mujer }
    public class Jugador : INotifyPropertyChanged
    {
        public int Id_Jugador { get; set; }
        public string ImgPerfil { get; set; }
        public int Equipo { get; set; }
        public string Apodo { get; set; }
        public string Passwd { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Jugador()
        {

        }

        public Jugador(int id, string imgPerfil, int equipo, string apodo, string passwd, Sexo sexo, DateTime fechaCreacion)
        {
            Id_Jugador = id;
            ImgPerfil = imgPerfil;
            Equipo = equipo;
            Apodo = apodo;
            Passwd = passwd;
            Sexo = sexo;
            FechaCreacion = fechaCreacion;
        }
        public Jugador(Jugador jugadorSeleccionado)
        {
            Id_Jugador = jugadorSeleccionado.Id_Jugador;
            ImgPerfil = jugadorSeleccionado.ImgPerfil;
            Equipo = jugadorSeleccionado.Equipo;
            Apodo = jugadorSeleccionado.Apodo;
            Passwd = jugadorSeleccionado.Passwd;
            Sexo = jugadorSeleccionado.Sexo;
            FechaCreacion = jugadorSeleccionado.FechaCreacion;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
