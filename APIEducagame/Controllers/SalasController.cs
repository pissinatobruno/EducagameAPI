using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIEducagame.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIEducagame.Controllers
{
    [Route("api/salas")]
    [ApiController]
    public class SalasController : ControllerBase
    {

        private readonly AppContexto _context;


        public SalasController(AppContexto context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_salas>>> GetPontos()
        {
            return await _context.tbl_Salas.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<tbl_salas>> GetPontos(int id)
        {
            
            tbl_salas sala = await _context.tbl_Salas.FindAsync(id);

            if (sala == null)
            {
                return NotFound();
            }

            return sala;

        }

    }
}
