using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop.POJO
{
    public enum Tipo { Torneo,Amistoso}
    public class Competicion : INotifyPropertyChanged
    {
        public int Id_Competicion { get; set; }
        public Tipo Tipo { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Premio { get; set; }

        public Competicion()
        {

        }
        public Competicion(int id,Tipo tipo, string nombre, DateTime fecha)
        {
            Id_Competicion = id;   
            Tipo = tipo;
            Nombre = nombre;
            Capacidad = 2;
            Fecha = fecha;
        }

        public Competicion(int id, Tipo tipo, string nombre, int capacidad, DateTime fecha, string premio)
        {
            Id_Competicion = id;
            Tipo = tipo;
            Nombre = nombre;
            Capacidad = capacidad;
            Fecha = fecha;
            Premio = premio;
        }
        public Competicion(Competicion torneoSeleccionado)
        {
            Id_Competicion = torneoSeleccionado.Id_Competicion;
            Nombre = torneoSeleccionado.Nombre;
            Tipo = torneoSeleccionado.Tipo;
            Capacidad = torneoSeleccionado.Capacidad;
            Fecha = torneoSeleccionado.Fecha;
            Premio = torneoSeleccionado.Premio;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
