using Proeventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeventos.Domain
{
    public class RedeSocial
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string URL { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; } // Assuming Evento is a class defined elsewhere in your project
        public int PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; } // Assuming Propriedade is a class defined elsewhere in your project
    }
}
