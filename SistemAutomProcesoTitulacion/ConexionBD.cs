﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace SistemAutomProcesoTitulacion
{
    public class ConexionBD
    {

        public static string cadena = "Server=ALXJANDR07PC\\SQLEXPRESS; Database=SistemaTitulacionUTEQ; Integrated Security=true";


        private static SqlConnection conexion = new SqlConnection(cadena);

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                    MessageBox.Show("✅ Conexión exitosa a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar con la base de datos: " + ex.Message);
            }

            return conexion;
        }

        public static SqlConnection ObtenerNuevaConexion()
        {
            var conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                // Opcional: MessageBox.Show("✅ Conexión exitosa a la base de datos (nueva instancia).");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar con la base de datos: " + ex.Message);
            }
            return conexion;
        }

        public static void CerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    MessageBox.Show("🔒 Conexión cerrada correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Error al cerrar la conexión: " + ex.Message);
            }
        }
        public static void EliminarTodasLasReuniones()
        {
            try
            {
                SqlConnection conn = ObtenerConexion();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM InformacionReuniones", conn))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Todas las reuniones han sido eliminadas de la base de datos.");
                }

                CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar reuniones: " + ex.Message);
            }
        }


        public static string ValidarLogin(string correo, string contrasena)
        {
            string rol = null;

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("LoginUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            rol = reader["Rol"].ToString(); // 👌 directo desde SP
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error en la validación: " + ex.Message);
            }

            return rol;
        }


        public static DataTable ObtenerUsuarios(string estado)
        {
            DataTable dt = new DataTable();
            try
            {
                string procedimiento = estado == "Activos"
                    ? "ListarUsuarios"
                    : estado == "Inactivos"
                        ? "ListarUsuariosInactivos"
                        : "ListarUsuarios"; // Por defecto activos

                using (SqlConnection con = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand(procedimiento, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al obtener usuarios: " + ex.Message);
            }
            return dt;
        }

        public static DataTable FiltrarUsuarios(string filtro)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("FiltrarUsuarios", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Filtro", filtro);

                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al filtrar usuarios: " + ex.Message);
            }
            return dt;
        }

        

        public static bool RegistrarUsuario(string nombre, string cedula, string correo, string contrasena, string rol, int estado, string tipoUsuario)
        {
            bool exito = false;
            try
            {
                if (ConexionBD.UsuarioDuplicado(correo, cedula, contrasena))
                {
                    MessageBox.Show("⚠️ Ya existe un usuario con ese correo, cédula o la misma combinación de correo y contraseña.");
                    return exito;
                }

                using (SqlConnection con = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("RegistrarUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@CorreoInstitucional", correo);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@Rol", rol);
                        cmd.Parameters.AddWithValue("@Estado", estado);
                        cmd.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        exito = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al registrar usuario: " + ex.Message);
            }
            return exito;
        }

        public static bool UsuarioDuplicado(string correo, string cedula, string contrasena)
        {
            bool existe = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("ValidarUsuarioDuplicado", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CorreoInstitucional", correo);
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && Convert.ToInt32(result) == 1)
                        existe = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al validar duplicados: " + ex.Message);
            }
            return existe;
        }

        public static bool ActualizarUsuario(int idUsuario, string nombre, string cedula, string correo, string contrasena, string rol)
        {
            bool exito = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@CorreoInstitucional", correo);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@Rol", rol);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        exito = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al modificar usuario: " + ex.Message);
            }
            return exito;
        }

        public static bool ActualizarUsuario(int idUsuario, string nombre, string cedula, string correo, string contrasena, string rol, int estado, string tipoUsuario)
        {
            bool exito = false;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                        cmd.Parameters.AddWithValue("@Cedula", cedula);
                        cmd.Parameters.AddWithValue("@CorreoInstitucional", correo);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@Rol", rol);
                        cmd.Parameters.AddWithValue("@Estado", estado);
                        cmd.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        exito = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al modificar usuario: " + ex.Message);
            }
            return exito;
        }

        public static (int IdUsuario, string Nombre, string Rol) ValidarLoginDatos(string correo, string contrasena)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int idUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    string nombre = reader["NombreCompleto"].ToString();
                    string rol = reader["Rol"].ToString();
                    return (idUsuario, nombre, rol);
                }
                else
                {
                    return (0, null, null);
                }
            }
        }

        public static void AgregarInformacionReunion(string texto)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();

                string verificarQuery = "SELECT COUNT(*) FROM InformacionReuniones WHERE TextoInformacion = @Texto";
                using (SqlCommand verificarCmd = new SqlCommand(verificarQuery, con))
                {
                    verificarCmd.Parameters.AddWithValue("@Texto", texto);
                    int existe = (int)verificarCmd.ExecuteScalar();

                    if (existe == 0)
                    {
                        string insertarQuery = "INSERT INTO InformacionReuniones (TextoInformacion) VALUES (@Texto)";
                        using (SqlCommand insertarCmd = new SqlCommand(insertarQuery, con))
                        {
                            insertarCmd.Parameters.AddWithValue("@Texto", texto);
                            insertarCmd.ExecuteNonQuery();
                        }
                    }
                }

                con.Close();
            }
        }

        public static string ObtenerTodasLasInformacionesReuniones()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    string query = "SELECT TextoInformacion FROM InformacionReuniones ORDER BY Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int contador = 1;
                        while (reader.Read())
                        {
                            sb.AppendLine($"{contador}. {reader["TextoInformacion"]}");
                            contador++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al obtener la información de reuniones: " + ex.Message);
            }
            return sb.ToString();
        }

        public static void EliminarInformacionReunion(string texto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    string query = "DELETE FROM InformacionReuniones WHERE TextoInformacion = @Texto";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Texto", texto);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar la información de reuniones: " + ex.Message);
            }
        }

        public static int InsertarDocumento(string nombre, string tipo, byte[] datos)
        {
            int nuevoId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("sp_InsertarDocumento", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Datos", datos);

                    SqlParameter outputId = new SqlParameter("@NuevoId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    nuevoId = Convert.ToInt32(outputId.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al subir el documento: " + ex.Message);
            }
            return nuevoId;
        }

        public static DataTable ObtenerDocumentos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("SELECT IdDocumento, Nombre, Tipo, FechaSubida FROM SbrDocumento", conn))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar documentos: " + ex.Message);
            }
            return dt;
        }
        public static void GuardarDocumento(string nombre, string tipo, DateTime fecha)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                string query = "INSERT INTO Documentos (Nombre, Tipo, FechaSubida) VALUES (@Nombre, @Tipo, @Fecha)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        public static bool EliminarDocumento(int id)
        {
            bool exito = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM SbrDocumento WHERE IdDocumento = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    exito = filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar el documento: " + ex.Message);
            }
            return exito;
        }

        public static bool DescargarDocumento(int idDocumento, string destino, string rutaArchivo)
        {
            bool exito = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT DatosArchivo FROM SbrDocumento WHERE IdDocumento=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idDocumento);
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            byte[] archivoBytes = (byte[])resultado;
                            File.WriteAllBytes(destino, archivoBytes);
                            exito = true;
                        }
                        else
                        {
                            if (File.Exists(rutaArchivo))
                            {
                                File.Copy(rutaArchivo, destino, true);
                                exito = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al descargar el archivo: " + ex.Message);
            }
            return exito;
        }
        public static DataTable ObtenerDocumentosPorTipo(string tipo)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("SELECT IdDocumento, Nombre, Tipo, FechaSubida FROM SbrDocumento WHERE Tipo = @Tipo", conn))
                {
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al filtrar documentos por tipo: " + ex.Message);
            }
            return dt;
        }
        public static DataTable ObtenerDocumentosPorTipos(string[] tipos)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    List<string> parametros = new List<string>();
                    for (int i = 0; i < tipos.Length; i++)
                    {
                        string paramName = "@Tipo" + i;
                        parametros.Add(paramName);
                        cmd.Parameters.AddWithValue(paramName, tipos[i]);
                    }

                    string filtro = string.Join(", ", parametros);
                    cmd.CommandText = $"SELECT IdDocumento, Nombre, Tipo, FechaSubida FROM SbrDocumento WHERE Tipo IN ({filtro})";

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al filtrar documentos por múltiples tipos: " + ex.Message);
            }
            return dt;
        }

        public static bool VisualizarDocumento(int idDocumento)
        {
            bool exito = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                using (SqlCommand cmd = new SqlCommand("SELECT Nombre, Datos FROM SbrDocumento WHERE IdDocumento=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idDocumento);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString();
                            byte[] datos = (byte[])reader["Datos"];

                            string extension = Path.GetExtension(nombre).ToLower();
                            if (extension != ".pdf" && extension != ".doc" && extension != ".docx")
                                return false;

                            string tempPath = Path.Combine(Path.GetTempPath(), nombre);
                            File.WriteAllBytes(tempPath, datos);

                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                            {
                                FileName = tempPath,
                                UseShellExecute = true
                            });
                            exito = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al visualizar el documento: " + ex.Message);
            }
            return exito;
        }

        public static bool AgregarNotificacion(int idUsuario, string para, string asunto, string mensaje)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                using (SqlCommand cmd = new SqlCommand("AgregarNotificacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Para", para);
                    cmd.Parameters.AddWithValue("@Asunto", asunto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Mensaje", mensaje);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }
    }
}
