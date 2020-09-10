using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1_Login : Form
    {
        public Form1_Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void logoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void minimizarPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrarPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarioTextBox_Enter(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "Usuario")
            {
                usuarioTextBox.Text = "";
                usuarioTextBox.ForeColor = Color.Black;
            }
        }

        private void usuarioTextBox_Leave(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "")
            {
                usuarioTextBox.Text = "Usuario";
                usuarioTextBox.ForeColor = Color.DarkSlateGray;
            }
        }

        private void contraseñaTextBox_Enter(object sender, EventArgs e)
        {
            if (contraseñaTextBox.Text == "Contraseña")
            {
                contraseñaTextBox.Text = "";
                contraseñaTextBox.ForeColor = Color.Black;
                contraseñaTextBox.UseSystemPasswordChar = true;
            }
        }

        private void contraseñaTextBox_Leave(object sender, EventArgs e)
        {
            if (contraseñaTextBox.Text == "")
            {
                contraseñaTextBox.Text = "Contraseña";
                contraseñaTextBox.ForeColor = Color.DarkSlateGray;
                contraseñaTextBox.UseSystemPasswordChar = false;
            }
        }

        private void ingresarButton_Click(object sender, EventArgs e)
        {
            CNUsuario objUsuario = new CNUsuario();
            SqlDataReader loguear;

            objUsuario.Usuario = usuarioTextBox.Text;
            objUsuario.Contrasena = contraseñaTextBox.Text;
            
            if (objUsuario.Usuario == usuarioTextBox.Text)
            {
                if (objUsuario.Contrasena == contraseñaTextBox.Text)
                {
                    loguear = objUsuario.IniciarSesion();
                    if (loguear.Read() == true)
                    {
                        this.Hide();
                        Form2_Usuario objFormUser = new Form2_Usuario();
                        Program.tipoUsuario = Int32.Parse(loguear["idTipo"].ToString());                     
                        objFormUser.Show();
                    }
                    else
                    {
                        mensajeDbLabel.Text = "Datos incorrectos, por favor revisa tus credenciales.";
                        contraseñaTextBox.Text = "";
                        contraseñaLabel.Text = "";
                        usuarioTextBox.Text = "";
                        usuarioLabel.Text = "";
                        contraseñaTextBox_Leave(null, e);
                        usuarioTextBox.Focus();
                   }
                }
                else
                {
                    usuarioLabel.Text = "";
                    mensajeDbLabel.Text = "";
                    contraseñaLabel.Text = objUsuario.Contrasena;
                    contraseñaTextBox.Focus();
                }
            }
            else
            {
                contraseñaTextBox.Text = "";
                contraseñaTextBox_Leave(null, e);
                contraseñaLabel.Text = "";
                mensajeDbLabel.Text = "";
                usuarioLabel.Text = objUsuario.Usuario;
                usuarioLabel.Focus();
            }
        }

        private void olvideLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3_RecuperarContraseña objRecuperar = new Form3_RecuperarContraseña();
            objRecuperar.Show();
            this.Hide();
        }
    }
}