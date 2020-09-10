
namespace CapaPresentacion
{
    partial class Form2_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Usuario));
            this.contenedorSuperiorPictureBoxPanel = new System.Windows.Forms.Panel();
            this.maximizarPictureBox = new System.Windows.Forms.PictureBox();
            this.minimizarPictureBox = new System.Windows.Forms.PictureBox();
            this.normalPictureBox = new System.Windows.Forms.PictureBox();
            this.cerrarPictureBox = new System.Windows.Forms.PictureBox();
            this.contenedorSuperiorMenuPanel = new System.Windows.Forms.Panel();
            this.menuGeneralMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pestañaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAdministrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCrearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pestañaSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenedorMainFormsPanel = new System.Windows.Forms.Panel();
            this.contenedorSuperiorPictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPictureBox)).BeginInit();
            this.contenedorSuperiorMenuPanel.SuspendLayout();
            this.menuGeneralMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedorSuperiorPictureBoxPanel
            // 
            this.contenedorSuperiorPictureBoxPanel.BackColor = System.Drawing.Color.White;
            this.contenedorSuperiorPictureBoxPanel.Controls.Add(this.maximizarPictureBox);
            this.contenedorSuperiorPictureBoxPanel.Controls.Add(this.minimizarPictureBox);
            this.contenedorSuperiorPictureBoxPanel.Controls.Add(this.normalPictureBox);
            this.contenedorSuperiorPictureBoxPanel.Controls.Add(this.cerrarPictureBox);
            this.contenedorSuperiorPictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorSuperiorPictureBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.contenedorSuperiorPictureBoxPanel.Name = "contenedorSuperiorPictureBoxPanel";
            this.contenedorSuperiorPictureBoxPanel.Size = new System.Drawing.Size(989, 27);
            this.contenedorSuperiorPictureBoxPanel.TabIndex = 0;
            this.contenedorSuperiorPictureBoxPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.contenedorSuperiorPictureBoxPanel_MouseDown);
            // 
            // maximizarPictureBox
            // 
            this.maximizarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("maximizarPictureBox.Image")));
            this.maximizarPictureBox.Location = new System.Drawing.Point(936, 1);
            this.maximizarPictureBox.Name = "maximizarPictureBox";
            this.maximizarPictureBox.Size = new System.Drawing.Size(25, 25);
            this.maximizarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.maximizarPictureBox.TabIndex = 3;
            this.maximizarPictureBox.TabStop = false;
            this.maximizarPictureBox.Click += new System.EventHandler(this.maximizarPictureBox_Click);
            // 
            // minimizarPictureBox
            // 
            this.minimizarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizarPictureBox.Image")));
            this.minimizarPictureBox.Location = new System.Drawing.Point(910, 1);
            this.minimizarPictureBox.Name = "minimizarPictureBox";
            this.minimizarPictureBox.Size = new System.Drawing.Size(25, 25);
            this.minimizarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizarPictureBox.TabIndex = 2;
            this.minimizarPictureBox.TabStop = false;
            this.minimizarPictureBox.Click += new System.EventHandler(this.minimizarPictureBox_Click);
            // 
            // normalPictureBox
            // 
            this.normalPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.normalPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("normalPictureBox.Image")));
            this.normalPictureBox.Location = new System.Drawing.Point(936, 1);
            this.normalPictureBox.Name = "normalPictureBox";
            this.normalPictureBox.Size = new System.Drawing.Size(25, 25);
            this.normalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.normalPictureBox.TabIndex = 1;
            this.normalPictureBox.TabStop = false;
            this.normalPictureBox.Visible = false;
            this.normalPictureBox.Click += new System.EventHandler(this.normalPictureBox_Click);
            // 
            // cerrarPictureBox
            // 
            this.cerrarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cerrarPictureBox.Image")));
            this.cerrarPictureBox.Location = new System.Drawing.Point(962, 1);
            this.cerrarPictureBox.Name = "cerrarPictureBox";
            this.cerrarPictureBox.Size = new System.Drawing.Size(25, 25);
            this.cerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cerrarPictureBox.TabIndex = 0;
            this.cerrarPictureBox.TabStop = false;
            this.cerrarPictureBox.Click += new System.EventHandler(this.cerrarPictureBox_Click);
            // 
            // contenedorSuperiorMenuPanel
            // 
            this.contenedorSuperiorMenuPanel.BackColor = System.Drawing.Color.White;
            this.contenedorSuperiorMenuPanel.Controls.Add(this.menuGeneralMenuStrip);
            this.contenedorSuperiorMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorSuperiorMenuPanel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedorSuperiorMenuPanel.Location = new System.Drawing.Point(0, 27);
            this.contenedorSuperiorMenuPanel.Name = "contenedorSuperiorMenuPanel";
            this.contenedorSuperiorMenuPanel.Size = new System.Drawing.Size(989, 27);
            this.contenedorSuperiorMenuPanel.TabIndex = 1;
            // 
            // menuGeneralMenuStrip
            // 
            this.menuGeneralMenuStrip.BackColor = System.Drawing.Color.Lavender;
            this.menuGeneralMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pestañaUsuarioToolStripMenuItem,
            this.pestañaSistemaToolStripMenuItem});
            this.menuGeneralMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuGeneralMenuStrip.Name = "menuGeneralMenuStrip";
            this.menuGeneralMenuStrip.Size = new System.Drawing.Size(989, 25);
            this.menuGeneralMenuStrip.TabIndex = 0;
            this.menuGeneralMenuStrip.Text = "Selecciona una opcion";
            // 
            // pestañaUsuarioToolStripMenuItem
            // 
            this.pestañaUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAdministrarUsuarioToolStripMenuItem,
            this.itemCrearUsuarioToolStripMenuItem});
            this.pestañaUsuarioToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pestañaUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pestañaUsuarioToolStripMenuItem.Image")));
            this.pestañaUsuarioToolStripMenuItem.Name = "pestañaUsuarioToolStripMenuItem";
            this.pestañaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.pestañaUsuarioToolStripMenuItem.Text = "Usuario";
            // 
            // itemAdministrarUsuarioToolStripMenuItem
            // 
            this.itemAdministrarUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("itemAdministrarUsuarioToolStripMenuItem.Image")));
            this.itemAdministrarUsuarioToolStripMenuItem.Name = "itemAdministrarUsuarioToolStripMenuItem";
            this.itemAdministrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.itemAdministrarUsuarioToolStripMenuItem.Text = "Administrar usuarios";
            // 
            // itemCrearUsuarioToolStripMenuItem
            // 
            this.itemCrearUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("itemCrearUsuarioToolStripMenuItem.Image")));
            this.itemCrearUsuarioToolStripMenuItem.Name = "itemCrearUsuarioToolStripMenuItem";
            this.itemCrearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.itemCrearUsuarioToolStripMenuItem.Text = "Crear nuevo usuario";
            // 
            // pestañaSistemaToolStripMenuItem
            // 
            this.pestañaSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemVolverToolStripMenuItem});
            this.pestañaSistemaToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pestañaSistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pestañaSistemaToolStripMenuItem.Image")));
            this.pestañaSistemaToolStripMenuItem.Name = "pestañaSistemaToolStripMenuItem";
            this.pestañaSistemaToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.pestañaSistemaToolStripMenuItem.Text = "Sistema";
            // 
            // itemVolverToolStripMenuItem
            // 
            this.itemVolverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("itemVolverToolStripMenuItem.Image")));
            this.itemVolverToolStripMenuItem.Name = "itemVolverToolStripMenuItem";
            this.itemVolverToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.itemVolverToolStripMenuItem.Text = "Volver";
            // 
            // contenedorMainFormsPanel
            // 
            this.contenedorMainFormsPanel.BackColor = System.Drawing.Color.White;
            this.contenedorMainFormsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorMainFormsPanel.Location = new System.Drawing.Point(0, 54);
            this.contenedorMainFormsPanel.Name = "contenedorMainFormsPanel";
            this.contenedorMainFormsPanel.Size = new System.Drawing.Size(989, 598);
            this.contenedorMainFormsPanel.TabIndex = 2;
            // 
            // Form2_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 652);
            this.Controls.Add(this.contenedorMainFormsPanel);
            this.Controls.Add(this.contenedorSuperiorMenuPanel);
            this.Controls.Add(this.contenedorSuperiorPictureBoxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2_User";
            this.Load += new System.EventHandler(this.Form2_Usuario_Load);
            this.contenedorSuperiorPictureBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPictureBox)).EndInit();
            this.contenedorSuperiorMenuPanel.ResumeLayout(false);
            this.contenedorSuperiorMenuPanel.PerformLayout();
            this.menuGeneralMenuStrip.ResumeLayout(false);
            this.menuGeneralMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedorSuperiorPictureBoxPanel;
        private System.Windows.Forms.PictureBox maximizarPictureBox;
        private System.Windows.Forms.PictureBox minimizarPictureBox;
        private System.Windows.Forms.PictureBox normalPictureBox;
        private System.Windows.Forms.PictureBox cerrarPictureBox;
        private System.Windows.Forms.Panel contenedorSuperiorMenuPanel;
        private System.Windows.Forms.MenuStrip menuGeneralMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pestañaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemAdministrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemCrearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pestañaSistemaToolStripMenuItem;
        private System.Windows.Forms.Panel contenedorMainFormsPanel;
        private System.Windows.Forms.ToolStripMenuItem itemVolverToolStripMenuItem;
    }
}