using ApiSigfe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiSigfe.Controllers
{

    public class SigfeController : ApiController
    {
        public List<Envio> GetEnvios()
        {
            Modelo m = new Modelo();
            return m.getEnvios();
        }
    }
}
