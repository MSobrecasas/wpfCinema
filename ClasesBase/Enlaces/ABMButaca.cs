using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase.Enlaces
{
    public class ABMButaca
    {
        public DataTable cargar_butacas()
        {
            SqlConnection c = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Butaca";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = c;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;

        }

        public static void nueva_butaca(Butaca butaca)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "nueva_butaca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@butF", butaca.But_Fila);
            cmd.Parameters.AddWithValue("@butN", butaca.But_Nro);
            cmd.Parameters.AddWithValue("@butD", butaca.But_Disponible);
            cmd.Parameters.AddWithValue("@idS", butaca.Sala_ID);
            cmd.Parameters.AddWithValue("@codP", butaca.Proy_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }



        public static void modificar_butaca(Butaca butaca)
        {
            SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificar_butaca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@idB", butaca.But_ID);
            cmd.Parameters.AddWithValue("@butF", butaca.But_Fila);
            cmd.Parameters.AddWithValue("@butN", butaca.But_Nro);
            cmd.Parameters.AddWithValue("@butD", butaca.But_Disponible);
            cmd.Parameters.AddWithValue("@idS", butaca.Sala_ID);
            cmd.Parameters.AddWithValue("@codP", butaca.Proy_Codigo);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public static void eliminar_butacao(Butaca butaca)
        {
            SqlConnection conexion = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "borrar_butaca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@idB",butaca.But_ID);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
