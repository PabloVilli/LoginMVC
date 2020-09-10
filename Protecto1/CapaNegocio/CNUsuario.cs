using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CNUsuario
    {
        private CDUsuario ObjUsuario = new CDUsuario();
        private string _Usuario;
        private string _Contrasena;
        private List<string> listaMsjs = new List<string>();     
        public string Usuario
        {
            get
            {
                return _Usuario;
            }
            set
            {
                if (value == "Usuario")
                {
                    _Usuario = "No se ha ingresado usuario";
                }
                else
                {
                    _Usuario = value;
                }
            }
        }

        public string Contrasena
        {
            get 
            {
                return _Contrasena;
            }
            set 
            {
                if (value == "Contraseña")
                {
                    _Contrasena = "No se ha ingresado contraseña";
                }
                else
                {
                    _Contrasena = value;
                }
            } 
        }

        public CNUsuario() { }
        public SqlDataReader IniciarSesion()
        {
            SqlDataReader loguear;
            loguear = ObjUsuario.IniciarSesion(Usuario, Contrasena);
            return loguear;
        }

        public List<string> RecuperarContra(string usuario)
        {
            listaMsjs = ObjUsuario.RecuperarDatosCorreo(usuario);
            return listaMsjs;
        }

    }
}