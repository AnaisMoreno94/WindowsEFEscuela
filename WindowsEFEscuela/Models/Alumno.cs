using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WindowsEFEscuela.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int AlumnoId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Apellido { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime FechaNacimiento { get; set; }

        public int profId { get; set; }
        #region Propiedades de Navegacion
        [ForeignKey("profId")]
        public Profesor Profesor { get; set; }
        #endregion


    }
}
