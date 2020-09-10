using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace CapaDatos
{
    public class CDUsuario
    {
        private CDConexion conexion = new CDConexion();
        private SqlDataReader leer;
        private string _email, _nombre, _contrasena;
        private string mensaje, mensaje2;
        private SqlCommand comando1 = new SqlCommand();
        private string error;
        private List<string> mensajes = new List<string>(); 

        public List<string> RecuperarDatosCorreo(string usuario)
        {
            mensajes.Clear();
            comando1.Connection = conexion.AbrirConexion();
            comando1.CommandText = "SELECT * FROM tbl_Usuarios WHERE usuario ='" + usuario + "'";
            leer = comando1.ExecuteReader();
         
            if(leer.Read() == true)
            {
                _nombre = leer["nombre"].ToString();
                _contrasena = leer["contrasena"].ToString();
                _email = leer["email"].ToString();
                mensaje2 = EnviarEmail();
                mensajes.Add(mensaje2);
                mensaje = "Estimado " + _nombre + " se ha enviado la contraseña al correo: " + _email + ", por favor verifique su bandeja de entrada.";
                mensajes.Add(mensaje);
                leer.Close();//es importante cerrar ya que esta variable se utiliiza en varios metodos y podria fallar.
            }
            else
            {
                mensaje = "No existe el usuario";
                mensajes.Add(mensaje);
                leer.Close();
            }
            return mensajes; 
        }

        public string EnviarEmail()
        {
        //Correo
            MailMessage correoNuevo = new MailMessage();
            correoNuevo.From = new MailAddress("villi623@gmail.com");
            correoNuevo.To.Add(_email);
            correoNuevo.Subject = ("Solicitud de datos");
            correoNuevo.Body = "Estimado " + _nombre + " solicitaste recuperar tu contraseña, si no reconoces esta actividad notifica a la persona a cargo.\nContraseña: " + _contrasena;
            correoNuevo.Priority = MailPriority.Normal;
        //SMTP
            
            SmtpClient serverMail = new SmtpClient();
            serverMail.Credentials = new NetworkCredential("villi623@gmail.com", "Villicana1");
            serverMail.Host = "smtp.gmail.com";
            serverMail.Port = 587;
            serverMail.EnableSsl = true;
            try
            {
                serverMail.Send(correoNuevo);
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
            }
            serverMail.Dispose();
            return error;
        }

        public SqlDataReader IniciarSesion(string usuario, string contraseña)
        {
            SqlCommand comando = new SqlCommand("sp_UsuarioExistente", conexion.AbrirConexion());
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure; 
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasena", contraseña);
            leer = comando.ExecuteReader();
            return leer;
            leer.Close();
        } 
    }
}
