using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Infraestructura.Data.SqlServer
{
    class Conexion_DAL
    {
        SqlConnection cn = new SqlConnection("server=.; DataBase=Negocios2018; uid=sa; pwd=sql");

        public SqlConnection getConexion
        {
            get { return cn; }
        }
    }
}
