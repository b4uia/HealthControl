using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthControl.PCL.Model
{
    public class perfil
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Avatar { get; set; }
        public string Idade { get; set; }
        public string notas { get; set; }
        public sos Dados_SOS { get; set; }
        public List<contactos> Contactos { get; set; }
    }
}
