using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProj.DB.Data.Entity
{
    [Index(nameof(AlumnoId), nameof(Anno), Name = "Cooperadora-AlumnoAnno_UQ", IsUnique = true)]
    public class Cooperadora : EntityBase
    {
        [Required(ErrorMessage = "El ID del alumno es obligatorio")]
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
        [Required(ErrorMessage = "El año donde es vigente el precio de insripción es obligatorio")]
        public int Anno { get; set; }
        [Required(ErrorMessage = "El costo de inscripción es obligatorio")]
        public decimal CostoInscripcion { get; set; }
        public decimal Cuota1 { get; set; } = decimal.Zero;
        public decimal Cuota2 { get; set; } = decimal.Zero;
        public decimal Cuota3 { get; set; } = decimal.Zero;
        public decimal Deuda { get; set; } = decimal.Zero;
        public decimal PagosRecibidos { get; set; } = decimal.Zero;
        public bool Vencido { get; set; } = false;

        [Required(ErrorMessage = "La fehca de vencimiento de la ultima cuota es obligatoria")]
        public DateTime FechaVencimiento { get; set; }
    }
}
