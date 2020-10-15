using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using ClasesBase;

namespace ClasesBase.Enlaces

{
    public class ABMPelicula
    {

        public DataTable cargar_peliculas()
        {
            SqlConnection c = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Pelicula";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = c;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
             
        }

        public static void nueva_pelicula(Pelicula pelicula)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "nueva_pelicula";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@titP", pelicula.Peli_Titulo);
            cmd.Parameters.AddWithValue("@durP", pelicula.Peli_Duracion);
            cmd.Parameters.AddWithValue("@idC", pelicula.Cla_ID);
            cmd.Parameters.AddWithValue("@idG", pelicula.Gen_ID);
                       
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscar_pelicula_id(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscar_pelicula_id";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void modificar_pelicula(Pelicula pelicula)
        {
            SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificar_pelicula";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@idP", pelicula.Peli_ID);
            cmd.Parameters.AddWithValue("@titP", pelicula.Peli_Titulo);
            cmd.Parameters.AddWithValue("@durP", pelicula.Peli_Duracion);
            cmd.Parameters.AddWithValue("@idC", pelicula.Cla_ID);
            cmd.Parameters.AddWithValue("@idG", pelicula.Gen_ID);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public static void eliminar_pelicula(Pelicula pelicula)
        {
            SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "borrar_pelicula";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@idP", pelicula.Peli_ID);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
