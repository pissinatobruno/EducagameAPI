using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIEducagame.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIEducagame.Controllers
{
    [Route("api/alunos")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        private readonly AppContexto _context;


        public AlunoController(AppContexto context)
        {
            _context = context;
        }

        //// POST api/values

        [HttpPost]
        public int Post([FromBody] tbl_alunos aluno)
        {
            try
            {
                _context.tbl_Alunos.Add(aluno);
                _context.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw;
            }

            return aluno.Id;
        }
    }
}
