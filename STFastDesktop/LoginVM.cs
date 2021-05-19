using STFastDesktop.POJO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop
{
    class LoginVM : INotifyPropertyChanged
    {
        public ObservableCollection<Administrador> ListaAdmins { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private readonly ApiRestService _api;

        public LoginVM()
        {
            _api = new ApiRestService();
            ListaAdmins = _api.GetAdministradores();
        }

        //COMPROBAR LOGIN
        public Boolean ComprobarLogin(string usuario, string contraseña)
        {
            Boolean existe = false;
            foreach (var admin in ListaAdmins)
            {
                if (admin.Usuario == usuario && admin.Passwd == contraseña) existe = true;
            }
            return existe;
        }
    }
}
