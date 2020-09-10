using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class Form3_RecuperarContraseña : Form
    {
        List<string> mensajes = new List<string>();
        public Form3_RecuperarContraseña()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        CNUsuario objUsuario = new CNUsuario();

        private void returnPictureBox_Click(object sender, EventArgs e)
        {
            Form1_Login objLogin = new Form1_Login();
            objLogin.Show();
            this.Hide();
        }

        private void recuperarButton_Click(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text != "Ingresa tu usuario")
            {
                mensajes = objUsuario.RecuperarContra(usuarioTextBox.Text);
                MessageBox.Show(mensajes.Count.ToString());
                if (mensajes.Count == 1)
                {
                    ResultTextBox.Text = mensajes[0];
                }
                if (mensajes.Count == 2)
                {
                    ResultTextBox.Text = mensajes[1];
                    msjLabel.Text = mensajes[0];
                }
            }
            else
            {
                msjLabel.ForeColor = Color.Red;
                msjLabel.Text = "Ingresa tu usuario.";
            }
        }

        private void RecuperarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void usuarioTextBox_Enter(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "Ingresa tu usuario")
            {
                usuarioTextBox.Text = "";
                usuarioTextBox.ForeColor = Color.Black;
            }
        }

        private void usuarioTextBox_Leave(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "")
            {
                usuarioTextBox.Text = "Ingresa tu usuario";
                usuarioTextBox.ForeColor = Color.DarkSlateGray;
            }
        }
    }
}
