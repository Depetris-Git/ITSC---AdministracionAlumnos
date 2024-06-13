using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProj.DB.Data.Entity
{
    public class Certificado : EntityBase
    {
        [Required(ErrorMessage = "La fecha de creaciónes obligatoria")]
        public DateTime FechaCreacion { get; set; }
    }
}
