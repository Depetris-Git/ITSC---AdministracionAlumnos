﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProj.DB.Data.Entity
{
    [Index(nameof(Codigo), Name = "Materia-Codigo_UQ", IsUnique = true)]
    public class Materia : EntityBase
    {
        [Required(ErrorMessage = "El Codigo es obligatorio")]
        [MaxLength(45, ErrorMessage = "Maximo número de caracteres es {1}.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "Maximo número de caracteres es {1}.")]
        public string Nombre { get; set; }
        public string Correlatividad { get; set;}
    }
}
