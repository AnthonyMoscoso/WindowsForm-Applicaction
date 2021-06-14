using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Estanterias
{
    public class LibroEstante
    {
        public string IdLibro { get; set; }
        public string LibroName { get; set; }
        public string ISBM { get; set; }
        public int EstanteNum { get; set; }
        public int NumPiso { get; set; }
        public string Seccion { get; set; }
    }
}
