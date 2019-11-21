using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIEducagame.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIEducagame.Controllers
{
    [Route("api/SalasAlunos")]
    [ApiController]
    public class Salas_Aluno_Controller : ControllerBase
    {

        private readonly AppContexto _context;


        public Salas_Aluno_Controller(AppContexto context)
        {
            _context = context;
        }

        //// POST api/values

        [HttpPost]
        public void Post([FromBody] tbl_aluno_salas n)
        {
            try
            {
                _context.tbl_Aluno_Salas.Add(n);
                _context.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
    }
}
