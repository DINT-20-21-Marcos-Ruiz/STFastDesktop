using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop.POJO
{
    public enum Sexo {Hombre, Mujer }
    class Jugador : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public int Equipo { get; set; }
        public string Apodo { get; set; }
        public string Passwd { get; set; }
        public Sexo Sexo { get; set; }

        public Jugador()
        {

        }
        public Jugador(int id, int equipo, string apodo, string passwd, Sexo sexo)
        {
            Id = id;
            Equipo = equipo;
            Apodo = apodo;
            Passwd = passwd;
            Sexo = sexo;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
