using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoria.GGR.Lib.Models
{
    public class Base
    {
        public int ID { get; set; }
        public bool Ativo { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime CriadoEm { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime AtualizadoEM { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime RemovidoEm { get; set; }
    }
}
