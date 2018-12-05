using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSigfe.Models
{
    public class Envio
    {
        public string Ticket { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaRespuesta { get; set; }
        public int Estado { get; set; }
        public string Folio { get; set; }
        public string areaTransaccional { get; set; }

        public string mensaje { get; set; }

        public List<string> errores { get; set; }
    }
}