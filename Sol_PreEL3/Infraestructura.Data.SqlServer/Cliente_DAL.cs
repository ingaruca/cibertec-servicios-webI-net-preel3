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
    public class Cliente_DAL
    {
        Conexion_DAL cn = new Conexion_DAL();

        public List<Cliente> listado()
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                SqlCommand cmd = new SqlCommand("select * from Ventas.clientes", cn.getConexion);
                cn.getConexion.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cliente reg = new Cliente();

                    reg.idcliente = dr.GetString(0);
                    reg.nombreCia = dr.GetString(1);
                    reg.direccion = dr.GetString(2);
                    reg.idpais = dr.GetString(3);
                    reg.telefono = dr.GetString(4);

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

        public string Agregar(Cliente reg)
        {
            string msg = "";
            cn.getConexion.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("insert into Ventas.clientes values(@id, @nombre, @direccion, @idpais, @telefono)", cn.getConexion);
                cmd.Parameters.AddWithValue("@id", reg.idcliente);
                cmd.Parameters.AddWithValue("@nombre", reg.nombreCia);
                cmd.Parameters.AddWithValue("@direccion", reg.direccion);
                cmd.Parameters.AddWithValue("@idpais", reg.idpais);
                cmd.Parameters.AddWithValue("@telefono", reg.telefono);

                int q = cmd.ExecuteNonQuery();
                msg = q.ToString() + " registro agregado";
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            finally
            {
                cn.getConexion.Close();
            }

            return msg;
        }

        public string Actualizar(Cliente reg)
        {
            string msg = "";
            cn.getConexion.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("update Ventas.clientes set NomCliente = @nombre, DirCliente = @direccion, idpais = @idpais, fonoCliente = @telefono where IdCliente = @id", cn.getConexion);
                cmd.Parameters.AddWithValue("@id", reg.idcliente);
                cmd.Parameters.AddWithValue("@nombre", reg.nombreCia);
                cmd.Parameters.AddWithValue("@direccion", reg.direccion);
                cmd.Parameters.AddWithValue("@idpais", reg.idpais);
                cmd.Parameters.AddWithValue("@telefono", reg.telefono);

                int q = cmd.ExecuteNonQuery();
                msg = q.ToString() + " registro actualizado";
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            finally
            {
                cn.getConexion.Close();
            }

            return msg;
        }

        public string Eliminar(Cliente reg)
        {
            string msg = "";
            cn.getConexion.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("delete Ventas.clientes where IdCliente = @id", cn.getConexion);
                cmd.Parameters.AddWithValue("@id", reg.idcliente);                

                int q = cmd.ExecuteNonQuery();
                msg = q.ToString() + " registro eliminado";
            }
            catch (SqlException e)
            {
                msg = e.Message;
            }
            finally
            {
                cn.getConexion.Close();
            }

            return msg;
        }

        public Cliente Registro(string id)
        {
            return listado().Where(c => c.idcliente == id).FirstOrDefault();
        }
    }
}
