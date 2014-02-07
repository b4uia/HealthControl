using HealthControl.PCL.Model.Auxiliares;
using System;
using System.Collections.Generic;

namespace HealthControl.PCL.Model.Principais
{
    public class Perfil
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Avatar { get; set; }
        public string Idade { get; set; }
        public string Notas { get; set; }
        public Sos DadosSos { get; set; }
        public string Lang { get; set; }
        public List<Contactos> Contactos { get; set; }
    }
}
