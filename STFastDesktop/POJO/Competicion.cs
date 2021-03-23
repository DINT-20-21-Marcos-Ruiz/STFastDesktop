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
        public int id { get; set; }
        public Tipo Comp_id { get; set; }
        public int Capacidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Premio { get; set; }

        public Competicion()
        {

        }
        public Competicion(int id, Tipo comp_id, int capacidad, DateTime fecha)
        {
            this.id = id;
            Comp_id = comp_id;
            Capacidad = capacidad;
            Fecha = fecha;
        }

        public Competicion(int id, Tipo comp_id, int capacidad, DateTime fecha, string premio)
        {
            this.id = id;
            Comp_id = comp_id;
            Capacidad = capacidad;
            Fecha = fecha;
            Premio = premio;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
