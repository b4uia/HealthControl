using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthControl.PCL
{
    public class medicamento
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Prescricao { get; set; }
        public string Unidades { get; set; }
        // número de dias até concluir a medicação
        public int Dias { get; set; }
        // exº de x em x horas
        public int horaA { get; set; }
        public int horaB { get; set; }
        // definido automaticamente ou manualmente
        public List<alarme> Alarmes { get; set; }
    }
}
