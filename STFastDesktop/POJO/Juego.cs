using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop.POJO
{
    class Juego : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public int JNombre { get; set; }
        public string Logo { get; set; }

        public Juego()
        {

        }
        public Juego(int id, int jNombre, string logo)
        {
            Id = id;
            JNombre = jNombre;
            Logo = logo;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
