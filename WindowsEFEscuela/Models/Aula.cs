using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEFEscuela.Models
{
    public class Aula
    {
        [Key]
        public int aulaId { get; set; }


        [Required]
        public int Capacidad { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        [Required]
        public string Codigo { get; set; }

    }
}
