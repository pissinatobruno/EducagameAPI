using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIEducagame.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIEducagame.Controllers
{
    [Route("api/desafio3")]
    [ApiController]
    public class TerceiroDesafioController : ControllerBase
    {

        private readonly AppContexto _context;
        tbl_aluno_salas _Aluno_Salas;

        public TerceiroDesafioController(AppContexto context)
        {
            _context = context;
        }

        //// POST api/values

        [HttpPost]
        public int Post([FromBody] tbl_desafio3 ponto)
        {
            try
            {
                _context.tbl_Desafio3.Add(ponto); 
                _context.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw;
            }

            return ponto.Id; ;
        }
    }
}
