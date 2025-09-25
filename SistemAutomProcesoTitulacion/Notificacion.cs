using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemAutomProcesoTitulacion
{
    public class Notificacion
    {
        public int IdNotificacion { get; set; }
        public int IdUsuario { get; set; } // Coordinador que envía
        public string Para { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }

        // Estado individual por estudiante
        public bool Leido { get; set; }
        public bool Estado { get; set; }

        // Obtiene notificaciones para un estudiante específico
        public static DataTable ObtenerNotificacionesUsuario(int idUsuario, string rol, bool? soloNoLeidos = null)
        {
            using (SqlConnection conn = ConexionBD.ObtenerNuevaConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerNotificacionesUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@Rol", rol);
                if (soloNoLeidos.HasValue)
                    cmd.Parameters.AddWithValue("@SoloNoLeidos", soloNoLeidos.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void MarcarComoLeido(int idNotificacion, int idUsuario)
        {
            using (SqlConnection conn = ConexionBD.ObtenerNuevaConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_MarcarNotificacionLeida", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdNotificacion", idNotificacion);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.ExecuteNonQuery();
            }
        }

        public static void OcultarNotificacion(int idNotificacion, int idUsuario)
        {
            using (SqlConnection conn = ConexionBD.ObtenerNuevaConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_OcultarNotificacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdNotificacion", idNotificacion);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
