using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIEducagame.Model;
using Microsoft.AspNetCore.Mvc;

namespace APIEducagame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly AppContexto _context;


        public ValuesController(AppContexto context)
        {
            _context = context;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Ponto value)
        {
            try
            {
                _context.Ponto.Add(value);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
