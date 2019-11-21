using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIEducagame.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIEducagame.Controllers
{
    [Route("api/desafio7")]
    [ApiController]
    public class SetimoDesafioController : ControllerBase
    {

        private readonly AppContexto _context;


        public SetimoDesafioController(AppContexto context)
        {
            _context = context;
        }

        //// POST api/values

        [HttpPost]
        public int Post([FromBody] tbl_desafio7 ponto)
        {
            try
            {
                _context.tbl_Desafio7.Add(ponto);
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
