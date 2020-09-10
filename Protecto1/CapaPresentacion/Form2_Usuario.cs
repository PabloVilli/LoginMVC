using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class Form2_Usuario : Form
    {
        public Form2_Usuario()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PrivilegiosUsuario()
        {
            if (Program.tipoUsuario != 1)
            {
                pestañaUsuarioToolStripMenuItem.Enabled = false; 
            }

            if (Program.tipoUsuario == 1)
            {
                pestañaUsuarioToolStripMenuItem.Enabled = false;
            }

            if (Program.tipoUsuario == 1)
            {
                pestañaUsuarioToolStripMenuItem.Enabled = false;
            }

        }

        private void AbrirFormHijo(object formHijo)
        {
            if (this.contenedorMainFormsPanel.Controls.Count > 0)
                this.contenedorMainFormsPanel.Controls.RemoveAt(0);
            Form objForm = formHijo as Form;
            objForm.TopLevel = false;
            objForm.Dock = DockStyle.Fill;

            this.contenedorMainFormsPanel.Controls.Add(objForm);

            this.contenedorMainFormsPanel.Tag = objForm;
            objForm.Show();
        }

        private void Form2_Usuario_Load(object sender, EventArgs e)
        {
            PrivilegiosUsuario();
        }

        private void contenedorSuperiorPictureBoxPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void maximizarPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizarPictureBox.Visible = false;
            normalPictureBox.Visible = true;
        }

        private void minimizarPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void normalPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            normalPictureBox.Visible = false;
            maximizarPictureBox.Visible = true;
        }

        private void cerrarPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}