﻿using System;

namespace HealthControl.PCL.Model.Auxiliares
{
    public class Alarme
    {
        public Guid Id { get; set; }
        public string   Titulo { get; set; }
        public string Subtitulo { get; set; }
        public bool Ligado { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }

    }
}
