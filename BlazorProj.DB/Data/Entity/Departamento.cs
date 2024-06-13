using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProj.DB.Data.Entity
{
    [Index(nameof(Codigo), Name = "Departamento-Codigo_UQ", IsUnique = true)]
    
    public class Departamento : EntityBase
    {
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [MaxLength(150, ErrorMessage = "Maximo número de caracteres es {1}.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Codigo es obligatorio")]
        [MaxLength(45, ErrorMessage = "Maximo número de caracteres es {1}.")]

        public string Codigo { get; set; }
        public int ProvinciaId { get; set; }
        public Provincia Provincia { get; set; }
    }
}
