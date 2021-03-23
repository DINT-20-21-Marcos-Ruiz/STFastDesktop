﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFastDesktop.POJO
{
    class Inscripcion : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public int Equipo_id { get; set; }
        public int Compet_id { get; set; }
        public Inscripcion()
        {

        }
        public Inscripcion(int id, int equipo_id, int compet_id)
        {
            Id = id;
            Equipo_id = equipo_id;
            Compet_id = compet_id;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
