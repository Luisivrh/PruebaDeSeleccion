using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiexamen.dll
{
    public class Apiexamen
    {
        private BDConexion connection = new BDConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable GetD()
        {
            command.Connection = connection.AbrirConexion();
            command.CommandText = "spSelectAll";
            command.CommandType = CommandType.StoredProcedure;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            connection.CerrarConexion();
            return tabla;
        }
        public void PutD(int idExamen, string Nombre, string Descripcion)
        {
            command.Connection = connection.AbrirConexion();
            command.CommandText = "spAgregar";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idExamen", idExamen);
            command.Parameters.AddWithValue("@Nombre", Nombre);
            command.Parameters.AddWithValue("@Descripcion", Descripcion);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
        public void UpdateD(int idExamen, string Nombre, string Descripcion)
        {
            command.Connection = connection.AbrirConexion();
            command.CommandText = "spActualizar";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idExamen", idExamen);
            command.Parameters.AddWithValue("@Nombre", Nombre);
            command.Parameters.AddWithValue("@Descripcion", Descripcion);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
        public void UpdateD(int idExamen)
        {
            command.Connection = connection.AbrirConexion();
            command.CommandText = "spEliminar";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idExamen", idExamen);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
        public DataTable ShowED(string Nombre, string Descripcion)
        {
            command.Connection = connection.AbrirConexion();
            command.CommandText = "spConsultar";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Nombre", Nombre);
            command.Parameters.AddWithValue("@Descripcion", Descripcion);
            leer = command.ExecuteReader();
            tabla.Load(leer);
            connection.CerrarConexion();
            return tabla;
        }
    }
}
