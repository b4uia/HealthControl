using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthControl.PCL.Model.Auxiliares
{
   public  class Toma
    {
        // número de dias até concluir a medicação
        public int Dias { get; set; }
        // exº de x em x horas
        public int HoraA { get; set; }
        public int HoraB { get; set; }
        // exº Tomar as refeições
        public string Nota { get; set; }
    }
}
