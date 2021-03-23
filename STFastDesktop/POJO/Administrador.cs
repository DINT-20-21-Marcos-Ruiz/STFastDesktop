using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop.POJO
{
    class Administrador : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Passwd { get; set; }

        public Administrador()
        {

        }

        public Administrador(int id, string usuario, string passwd)
        {
            Id = id;
            Usuario = usuario;
            Passwd = passwd;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
