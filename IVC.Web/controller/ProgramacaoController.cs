using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IVC.Web.controller
{
    public class ProgramacaoController : ApiController
    {
        // GET: api/Programacao
        public IEnumerable<String> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Programacao/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Programacao
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Programacao/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Programacao/5
        public void Delete(int id)
        {
        }
    }
}
