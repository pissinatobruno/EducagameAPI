using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIEducagame.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIEducagame.Controllers
{
    [Route("api/desafio6")]
    [ApiController]
    public class SextoDesafioController : ControllerBase
    {

        private readonly AppContexto _context;


        public SextoDesafioController(AppContexto context)
        {
            _context = context;
        }

        //// POST api/values

        [HttpPost]
        public int Post([FromBody] tbl_desafio6 ponto)
        {
            try
            {
                _context.tbl_Desafio6.Add(ponto);
                _context.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw;
            }

            return ponto.Id;
        }
    }
}
