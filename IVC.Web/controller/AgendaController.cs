
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IVC.Web.controller
{
    [RoutePrefix("Api/Agenda")]
    public class AgendaController : ApiController
    {
        // GET: api/Programacao
        public List<Agenda> Get()
        {
            DAODataContext oDao = new DAODataContext();
            return oDao.Agendas.ToList();
        }


        //// GET: api/Programacao/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Programacao
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Programacao/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Programacao/5
        //public void Delete(int id)
        //{
        //}


    }

}

