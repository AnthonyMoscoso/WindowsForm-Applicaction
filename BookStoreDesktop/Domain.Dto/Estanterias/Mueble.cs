using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Estanterias
{
    public class Mueble
    {
        public int EstanteNum { get; set; }
        public int Piso { get; set; }
        public string SeccionName { get; set; }
        public string TipoDeMueble { get; set; }
    }
}
