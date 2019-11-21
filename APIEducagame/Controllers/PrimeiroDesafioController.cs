using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIEducagame.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIEducagame.Controllers
{
    [Route("api/desafio1")]
    [ApiController]
    public class PrimeiroDesafioController : ControllerBase
    {

        private readonly AppContexto _context;


        public PrimeiroDesafioController(AppContexto context)
        {
            _context = context;
        }

        //// POST api/values

        [HttpPost]
        public int Post([FromBody] tbl_desafio1 ponto)
        {
            try
            {
                _context.tbl_Desafio1.Add(ponto);
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
