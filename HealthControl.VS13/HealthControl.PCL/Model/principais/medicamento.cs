using HealthControl.PCL.Model.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HealthControl.PCL.Model.Principais
{
    public class medicamento
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Prescricao { get; set; }
        public string Unidades { get; set; }
        public toma Toma { get; set; }
        // definido automaticamente ou manualmente
        public List<alarme> Alarmes { get; set; }
    }
}
