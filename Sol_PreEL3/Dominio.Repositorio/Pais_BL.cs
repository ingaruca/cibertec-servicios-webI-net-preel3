using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Entidades;
using Infraestructura.Data.SqlServer;

namespace Dominio.Repositorio
{
    public class Pais_BL
    {
        Pais_DAL pais = new Pais_DAL();

        public List<Pais> listado()
        {
            return pais.listado();
        }
    }
}
