using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stores.API.Data;
using Stores.Shared.Entities;

namespace Stores.API.Controllers
{
    [ApiController]
    [Route("/api/countries")]
    public class CountriesControllers:ControllerBase
    {
        //su funcion es ir a la bd y hacer operaciones en las tablas
        private readonly DataContext _context;

        public CountriesControllers(DataContext context)
        { 
            _context = context;

        }
        [HttpPost]

        //TODOS LOS METODOS SON ASINCRONOS PARA QUE UTILICE TODOS LOS PROCESADORES DEL PC
        //notacion diamante <>
        public async Task<ActionResult> Post(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();  
            return Ok();    
        }

        [HttpGet]

        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Countries.ToListAsync());
        }





    }
}
