using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Dominio.Entidades;

namespace Infraestructura.Data.SqlServer
{
    public class Pais_DAL
    {
        Conexion_DAL cn = new Conexion_DAL();

        public List<Pais> listado()
        {
            List<Pais> lista = new List<Pais>();

            try
            {
                SqlCommand cmd = new SqlCommand("select * from Ventas.paises", cn.getConexion);
                cn.getConexion.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Pais reg = new Pais();
                    reg.idpais = dr.GetString(0);
                    reg.nombrepais = dr.GetString(1);
                    lista.Add(reg);
                }

                dr.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                cn.getConexion.Close();
            }

            return lista;
        }
    }
}
