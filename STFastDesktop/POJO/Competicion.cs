using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop.POJO
{
    public enum Tipo { Torneo,Amistoso}
    class Competicion : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public Tipo Tipo { get; set; }
        public int Capacidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Premio { get; set; }

        public Competicion()
        {

        }
        public Competicion(int id, Tipo tipo, DateTime fecha)
        {
            Id = id;
            Tipo = tipo;
            Capacidad = 2;
            Fecha = fecha;
        }

        public Competicion(int id, Tipo tipo, int capacidad, DateTime fecha, string premio)
        {
            Id = id;
            Tipo = tipo;
            Capacidad = capacidad;
            Fecha = fecha;
            Premio = premio;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
