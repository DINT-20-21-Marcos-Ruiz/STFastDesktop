using STFastDesktop.POJO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop
{
    public enum Modo { INSERT, UPDATE }
    class MainWindowVM : INotifyPropertyChanged

    {
        public Juego JuegoSeleccionado { get; set; }
        public Juego JuegoFormulario { get; set; }
        public ObservableCollection<Juego> ListaJuegos { get; set; }

        public Equipo EquipoSeleccionado { get; set; }
        public Equipo EquipoFormulario { get; set; }
        public ObservableCollection<Equipo> ListaEquipos { get; set; }

        public Jugador JugadorSeleccionado { get; set; }
        public Jugador JugadorFormulario { get; set; }
        public ObservableCollection<Jugador> ListaJugadores { get; set; }

        public Competicion CompeticionSeleccionada { get; set; }
        public Competicion CompeticionFormulario { get; set; }
        public ObservableCollection<Competicion> ListaCompeticion { get; set; }

        public Modo Accion { get; set; }

        private readonly ApiRestService _api;

        public event PropertyChangedEventHandler PropertyChanged;

        Boolean disponible;

        public MainWindowVM()
        {
            _api = new ApiRestService();
            ListaJuegos = _api.GetJuegos();
            ListaEquipos = _api.GetEquipos();
            ListaJugadores = _api.GetJugadores();
            ListaCompeticion = _api.GetCompeticiones();
            JuegoFormulario = new Juego();
            EquipoFormulario = new Equipo();
            JugadorFormulario = new Jugador();
            CompeticionFormulario = new Competicion();

            Accion = Modo.INSERT;
        }

        // JUEGOS    -------------------------------------------------------------------->
        public void AñadirJuego()
        {
            JuegoFormulario = new Juego();
            Accion = Modo.INSERT;
        }
        public void ModificarJuego()
        {
            JuegoFormulario = new Juego(JuegoSeleccionado);
            Accion = Modo.UPDATE;
        }
        public void GuardarJuego()
        {
            if (Accion == Modo.INSERT)
            {
                _api.PutJuego(JuegoFormulario);
                JuegoFormulario = new Juego();
            }
            else
            {
                _api.PostJuego(JuegoFormulario);

            }
            ListaJuegos = _api.GetJuegos();
        }
        public void EliminarJuego()
        {
            _api.DeleteJuego(JuegoSeleccionado.Id_Juego);
            ListaJuegos = _api.GetJuegos();
        }
        public Boolean JuegoFormOk()
        {
            return (JuegoFormulario.JNombre != "" && JuegoFormulario.Logo != "");
        }
        public Boolean HayJuegoSeleccionado()
        {
            return JuegoSeleccionado != null;
        }
        public Boolean JuegosDisponibles(int id)
        {
            disponible = true;
            foreach ( Juego juego in ListaJuegos)
            {
                if (juego.Id_Juego == id) disponible = false; 
            }
            return disponible;
        }

        // EQUIPOS   -------------------------------------------------------------------->
        public void AñadirEquipo()
        {
            EquipoFormulario = new Equipo();
            Accion = Modo.INSERT;
        }
        public void ModificarEquipo()
        {
            EquipoFormulario = new Equipo(EquipoSeleccionado);
            Accion = Modo.UPDATE;
        }
        public void GuardarEquipo()
        {
            if (Accion == Modo.INSERT)
            {
                _api.PutEquipo(EquipoFormulario);
                EquipoFormulario = new Equipo();
            }
            else
            {
                _api.PostEquipo(EquipoFormulario);

            }
            ListaEquipos = _api.GetEquipos();
        }
        public Boolean EquipoFormOk()
        {
            return (EquipoFormulario.ENombre != "" && EquipoFormulario.Juego > 0 && EquipoFormulario.Logo != "");
        }
        public Boolean HayEquipoSeleccionado()
        {
            return EquipoSeleccionado != null;
        }
        public void EliminarEquipo()
        {
            _api.DeleteEquipo(EquipoSeleccionado.Id_Equipo);
            ListaEquipos = _api.GetEquipos();
        }

        public Boolean EquiposDisponibles(int id)
        {
            disponible = true;
            foreach (Equipo equipo in ListaEquipos)
            {
                if (equipo.Id_Equipo == id) disponible = false;
            }
            return disponible;
        }

        // JUGADORES -------------------------------------------------------------------->
        public void AñadirJugador()
        {
            JugadorFormulario = new Jugador();
            Accion = Modo.INSERT;
        }
        public void ModificarJugador()
        {
            JugadorFormulario = new Jugador(JugadorSeleccionado);
            Accion = Modo.UPDATE;
        }
        public void GuardarJugador()
        {
            if (Accion == Modo.INSERT)
            {
                _api.PutJugador(JugadorFormulario);
                JugadorFormulario = new Jugador();
            }
            else
            {
                _api.PostJugador(JugadorFormulario);

            }
            ListaJugadores = _api.GetJugadores();
        }
        public Boolean JugadorFormOk()
        {
            return (JugadorFormulario.Equipo < 0  && JugadorFormulario.Apodo != "" && JugadorFormulario.Passwd != "");
        }
        public Boolean HayJugadorSeleccionado()
        {
            return JugadorSeleccionado != null;
        }
        public void EliminarJugador()
        {
            _api.DeleteJugador(JugadorSeleccionado.Id_Jugador);
            ListaJugadores = _api.GetJugadores();
        }
        public Boolean JugadoresDisponibles(int id)
        {
            disponible = true;
            foreach (Jugador jugador in ListaJugadores)
            {
                if (jugador.Id_Jugador == id) disponible = false;
            }
            return disponible;
        }

        // COMPETICION   ----------------------------------------------------------------->
        public void AñadirCompeticion()
        {
            CompeticionFormulario = new Competicion();
            Accion = Modo.INSERT;
        }
        public void ModificarCompeticiono()
        {
            CompeticionFormulario = new Competicion(CompeticionSeleccionada);
            Accion = Modo.UPDATE;
        }
        public void GuardarCompeticion()
        {
            if (Accion == Modo.INSERT)
            {
                _api.PutCompeticion(CompeticionFormulario);
                CompeticionFormulario = new Competicion();
            }
            else
            {
                _api.PostCompeticion(CompeticionFormulario);

            }
            ListaCompeticion = _api.GetCompeticiones();
        }
        public Boolean CompeticionFormOk()
        {
            return (JugadorFormulario.Equipo < 0 && JugadorFormulario.Apodo != "" && JugadorFormulario.Passwd != "");
        }
        public Boolean HayCompeticionSeleccionado()
        {
            return CompeticionSeleccionada != null;
        }
        public void EliminarCompeticion()
        {
            _api.DeleteCompeticion(CompeticionSeleccionada.Id_Competicion);
            ListaCompeticion = _api.GetCompeticiones();
        }

        public Boolean CompeticionDisponibles(int id)
        {
            disponible = true;
            foreach (Competicion competicion in ListaCompeticion)
            {
                if (competicion.Id_Competicion == id) disponible = false;
            }
            return disponible;
        }

    }
}
