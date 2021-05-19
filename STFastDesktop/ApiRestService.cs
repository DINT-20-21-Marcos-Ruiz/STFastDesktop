using Newtonsoft.Json;
using RestSharp;
using STFastDesktop.POJO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop
{
    public class ApiRestService
    {
        // ADMINISTRADORES
        public ObservableCollection<Administrador> GetAdministradores()
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest("administrador", Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ObservableCollection<Administrador>>(response.Content);
        }

        // JUEGOS
        public ObservableCollection<Juego> GetJuegos()
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest("juego", Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ObservableCollection<Juego>>(response.Content);
        }
        public Juego GetJuego(int id_juego)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"/juego/{id_juego}", Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<Juego>(response.Content);
        }
        public IRestResponse PostJuego(Juego nuevo)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest("juego", Method.POST);
            string data = JsonConvert.SerializeObject(nuevo);
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            var reponse = client.Execute(request);
            return reponse;
        }
        public IRestResponse PutJuego(Juego modificar)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"juego/{modificar.Id_Juego}", Method.POST);
            string data = JsonConvert.SerializeObject(modificar);
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            var reponse = client.Execute(request);
            return reponse;
        }
        public IRestResponse DeleteJuego(int id_juego)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"/juego/{id_juego}", Method.DELETE);
            var response = client.Execute(request);
            return response;
        }

        // EQUIPOS
        public ObservableCollection<Equipo> GetEquipos()
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest("equipo", Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ObservableCollection<Equipo>>(response.Content);
        }
        public Equipo GetEquipo(int id_equipo)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"/equipo/{id_equipo}", Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<Equipo>(response.Content);
        }
        public IRestResponse PostEquipo(Equipo nuevo)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest("equipo", Method.POST);
            string data = JsonConvert.SerializeObject(nuevo);
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            var reponse = client.Execute(request);
            return reponse;
        }
        public IRestResponse PutEquipo(Equipo modificar)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"equipo/{modificar.Id_Equipo}", Method.POST);
            string data = JsonConvert.SerializeObject(modificar);
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            var reponse = client.Execute(request);
            return reponse;
        }
        public IRestResponse DeleteEquipo(int id_equipo)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"/equipo/{id_equipo}", Method.DELETE);
            var response = client.Execute(request);
            return response;
        }

        // JUGADORES
        public ObservableCollection<Jugador> GetJugadores()
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest("jugador", Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ObservableCollection<Jugador>>(response.Content);
        }
        public Jugador GetJugador(int id_jugador)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"/jugador/{id_jugador}", Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<Jugador>(response.Content);
        }
        public IRestResponse PostJugador(Jugador nuevo)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest("jugador", Method.POST);
            string data = JsonConvert.SerializeObject(nuevo);
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            var reponse = client.Execute(request);
            return reponse;
        }
        public IRestResponse PutJugador(Jugador modificar)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"jugador/{modificar.Id_Jugador}", Method.POST);
            string data = JsonConvert.SerializeObject(modificar);
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            var reponse = client.Execute(request);
            return reponse;
        }
        public IRestResponse DeleteJugador(int id_jugador)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"/jugador/{id_jugador}", Method.DELETE);
            var response = client.Execute(request);
            return response;
        }

        // TORNEOS
        public ObservableCollection<Competicion> GetCompeticiones()
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest("competicion", Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<ObservableCollection<Competicion>>(response.Content);
        }
        public Jugador GetCompeticion(int id_torneo)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"/competicion/{id_torneo}", Method.GET);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<Jugador>(response.Content);
        }
        public IRestResponse PostCompeticion(Competicion nuevo)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest("competicion", Method.POST);
            string data = JsonConvert.SerializeObject(nuevo);
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            var reponse = client.Execute(request);
            return reponse;
        }
        public IRestResponse PutCompeticion(Competicion modificar)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"competicion/{modificar.Id_Competicion}", Method.POST);
            string data = JsonConvert.SerializeObject(modificar);
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            var reponse = client.Execute(request);
            return reponse;
        }
        public IRestResponse DeleteCompeticion(int id_torneo)
        {
            var client = new RestClient(Properties.Settings.Default.apiEndpoint);
            var request = new RestRequest($"/competicion/{id_torneo}", Method.DELETE);
            var response = client.Execute(request);
            return response;
        }

    }
}
