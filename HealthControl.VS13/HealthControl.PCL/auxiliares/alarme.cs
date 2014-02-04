using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthControl.PCL
{
    public class alarme
    {
        public Guid Id { get; set; }
        public string   Titulo { get; set; }
        public string Subtitulo { get; set; }
        public bool Ligado { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }

    }
}
