using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoria.GGR.Lib.Models
{
    public class PersonagemHasPoder : Base
    {
        public int PersonagemID { get; set; }
        public Personagem Personagem { get; set; }
        public int PoderID { get; set; }
        public Poder Poder { get; set; }
    }
}
