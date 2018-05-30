using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Entidades;
using Infraestructura.Data.SqlServer;

namespace Dominio.Repositorio
{
    public class Cliente_BL
    {
        Cliente_DAL cliente = new Cliente_DAL();

        public List<Cliente> listado()
        {
            return cliente.listado();
        }

        public string Agregar(Cliente reg)
        {
            return cliente.Agregar(reg);
        }

        public string Actualizar(Cliente reg)
        {
            return cliente.Actualizar(reg);
        }

        public string Eliminar(Cliente reg)
        {
            return cliente.Eliminar(reg);
        }

        public Cliente Registro(string id)
        {
            return cliente.Registro(id);
        }
    }
}
