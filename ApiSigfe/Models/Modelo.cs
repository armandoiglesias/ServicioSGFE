using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApiSigfe.Models
{
    public class Modelo
    {
        public List<Envio> getEnvios()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DCCPPlanCompras"].ConnectionString))
            {
                string sql = @"
select top 100 e.Ticket, e.FechaCreacion, e.FechaRespuesta, e.Estado, e.FolioRespuesta as folio, e.areaTransaccional , err.descripcion as Mensaje
from SIGFE.EnvioDipres e
left join SIGFE.ErroresDipres err on e.id = err.idenvio
order by e.id desc
";
                return db.Query<Envio>(sql, commandType: CommandType.Text).ToList();
            }
        }
    }
}