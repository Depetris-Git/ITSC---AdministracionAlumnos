using BlazorProj.DB.Data;
using BlazorProj.DB.Data.Entity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace BlazorProj.Server.Controllers
{
    [ApiController]
    [Route("/TiposDocumento")]
    public class TiposDocumentoControllers : ControllerBase
    {
        private readonly Context context;
        public TiposDocumentoControllers(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<TipoDocumento>>> Get()
        {
            return await context.TipoDocumentos.ToListAsync();
        }

        [HttpGet("existe/{Id:int}")]

        public async Task<ActionResult<TipoDocumento>> Get(int Id)
        {
            TipoDocumento? entidad = await context.TipoDocumentos.FirstOrDefaultAsync(x => x.Id == Id);
            if (entidad == null)
            {
                return NotFound($"No se encontró o no existe el registro {Id}.");
            }
            
            return entidad;
        }

        [HttpGet("lista/{Id:int}")]

        public async Task<ActionResult<List<TipoDocumento>>> GetListOf(int Id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(TipoDocumento entidad)
        {
            try
            {
                context.TipoDocumentos.Add(entidad);
                await context.SaveChangesAsync();
                return entidad.Id;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("Sube/{Id:int}")]
        public async Task<ActionResult> Put(int Id, [FromBody] TipoDocumento entidad)
        {
            if (Id != entidad.Id)
            {
                return BadRequest("Datos Incorrectos");
            }

            var pepe = await context.TipoDocumentos.
                         Where(e => e.Id == Id).FirstOrDefaultAsync();

            if (pepe == null)
            {
                return NotFound("No existe el Tipo de Documento buscado");
            }

            pepe.Codigo = entidad.Codigo;
            pepe.Nombre = entidad.Nombre;

            try
            {
                context.TipoDocumentos.Update(pepe);
                await context.SaveChangesAsync();
                return Ok("La operación se ejecutó exitosamente");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete("Borra/{Id:int}")]

    public async Task<ActionResult> Delete(int Id)
        {
            var exist = await context.TipoDocumentos.AnyAsync(x => x.Id==Id);
            if (!exist)
            {
                return NotFound($"No se encontró el registro {Id}.");
            }

            TipoDocumento entidadABorrar = new TipoDocumento();

            entidadABorrar.Id = Id;
            context.Remove(entidadABorrar);
            await context.SaveChangesAsync();
            return Ok();    
        }
    }
}
