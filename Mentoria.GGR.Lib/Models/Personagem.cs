using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoria.GGR.Lib.Models
{
    public class Personagem : Base
    {
        public string Nome  { get; set; }
        public string Cidade { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
