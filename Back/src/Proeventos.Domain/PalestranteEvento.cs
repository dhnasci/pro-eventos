using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeventos.Domain
{
    public class PalestranteEvento
    {
        public int PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; } // Assuming Palestrante is a class defined elsewhere in your project
        public int EventoId { get; set; }
        public Evento Evento { get; set; } // Assuming Evento is a class defined elsewhere in your project
       
    }
}
