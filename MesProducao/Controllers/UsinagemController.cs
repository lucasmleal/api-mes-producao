using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesProducao.Controllers
{
    [Route("api/[controller]")]
    public class UsinagemController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var retorno = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                retorno.Add("Peça ID " + new Random().Next(1, 9999));
            }

            return retorno;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost("iniciar-operacao")]
        public string IniciarOperacao([FromBody]string value)
        {
            return "Iniciada operação de usinagem para nova peça. ID: " + new Random().Next(6000, 9999);
        }

        // PUT api/values/5
        [HttpPut("finalizar-operacao/{id}")]
        public string FinalizarOperacao(int id, [FromBody]string value)
        {
            return "Finalizada operação de usinagem para peça: ID: " + id;
        }

        // DELETE api/values/5
        [HttpDelete("cancelar-operacao/{id}")]
        public string Delete(int id)
        {
            return "Operação de usinagem cancelada para peça: ID: " + id;
        }
    }
}
