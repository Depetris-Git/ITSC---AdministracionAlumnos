using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProj.DB.Data.Entity
{
    [Index(nameof(TipoDocumentoId), nameof(NroDocumento), Name = "AlumnoDoc_UQ", IsUnique = true)]
    public class Alumno : EntityBase
    {
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [MaxLength(150, ErrorMessage = "Maximo número de caracteres es {1}.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        [MaxLength(150, ErrorMessage = "Maximo número de caracteres es {1}.")]
        public string Apellido { get; set;}

        [Required(ErrorMessage = "El Tipo de documento es obligatorio")]
        public int TipoDocumentoId { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

        [Required(ErrorMessage = "El Numero de Documento es obligatorio")]
        [MaxLength(16, ErrorMessage = "Maximo número de caracteres es {1}.")]
        public string NroDocumento { get; set;}

        [Required(ErrorMessage = "El año de Cohorte es obligatorio")]
        [MaxLength(10, ErrorMessage = "Maximo número de caracteres es {1}.")]
        public string Cohorte { get; set;}

        [Required(ErrorMessage = "Llenar el campo Legajo es obligatorio")]
        [MaxLength(16, ErrorMessage = "Maximo número de caracteres es {1}.")]
        public string Legajo { get; set;}

        [Required(ErrorMessage = "El CUIL es obligatorio")]
        [MaxLength(16, ErrorMessage = "Maximo número de caracteres es {1}.")]
        public string CUIL { get; set;}
        public int Edad {  get; set;}

        [MaxLength(16, ErrorMessage = "Maximo número de caracteres es {1}.")]
        public string Sexo { get; set;}
        public DateTime FechaNac {  get; set;}
        public string Email { get; set;}
        public string Estado { get; set;}
        public string Telefono { get; set;}
        public string TituloBase { get; set;}
        public string FotocopiaDNI { get; set;}
        public string ConstCUIL { get; set;}
        public string PartidaNac { get;set;}
        public string Analítico { get; set;}
        public string Fotos4x4 { get; set;}
        public string CUS {  get; set;}
        public string LibroMatriz { get; set;}
        public string NumeroDeOrden { get; set;}

    }
}
