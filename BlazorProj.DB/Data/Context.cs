using BlazorProj.DB.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProj.DB.Data
{
    public class Context : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Certificado> Certificados { get; set; }
        public DbSet<Cooperadora> Cooperadoras { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<PlanDeEstudio> PlanesDeEstudio { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Tecnicatura> Tecnicaturas { get; set; }
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFks = modelBuilder.Model.GetEntityTypes()
                                                .SelectMany(t => t.GetForeignKeys())
                                                .Where(fk => !fk.IsOwnership
                                                && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFks)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
