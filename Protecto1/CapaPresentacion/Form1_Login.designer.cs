namespace CapaPresentacion
{
    partial class Form1_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Login));
            this.logoPanel = new System.Windows.Forms.Panel();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ingresarButton = new System.Windows.Forms.Button();
            this.olvideLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cerrarPictureBox = new System.Windows.Forms.PictureBox();
            this.minimizarPictureBox = new System.Windows.Forms.PictureBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.mensajeDbLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(75, 330);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoPanel_MouseDown);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.usuarioTextBox.Location = new System.Drawing.Point(114, 68);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(422, 23);
            this.usuarioTextBox.TabIndex = 1;
            this.usuarioTextBox.Text = "Usuario";
            this.usuarioTextBox.Enter += new System.EventHandler(this.usuarioTextBox_Enter);
            this.usuarioTextBox.Leave += new System.EventHandler(this.usuarioTextBox_Leave);
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.contraseñaTextBox.Location = new System.Drawing.Point(114, 128);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(422, 23);
            this.contraseñaTextBox.TabIndex = 2;
            this.contraseñaTextBox.Text = "Contraseña";
            this.contraseñaTextBox.Enter += new System.EventHandler(this.contraseñaTextBox_Enter);
            this.contraseñaTextBox.Leave += new System.EventHandler(this.contraseñaTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(291, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // ingresarButton
            // 
            this.ingresarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ingresarButton.FlatAppearance.BorderSize = 0;
            this.ingresarButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ingresarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ingresarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ingresarButton.Location = new System.Drawing.Point(207, 217);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(234, 29);
            this.ingresarButton.TabIndex = 3;
            this.ingresarButton.Text = "Ingresar";
            this.ingresarButton.UseVisualStyleBackColor = false;
            this.ingresarButton.Click += new System.EventHandler(this.ingresarButton_Click);
            // 
            // olvideLinkLabel
            // 
            this.olvideLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.olvideLinkLabel.AutoSize = true;
            this.olvideLinkLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvideLinkLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.olvideLinkLabel.LinkColor = System.Drawing.SystemColors.GrayText;
            this.olvideLinkLabel.Location = new System.Drawing.Point(242, 266);
            this.olvideLinkLabel.Name = "olvideLinkLabel";
            this.olvideLinkLabel.Size = new System.Drawing.Size(166, 20);
            this.olvideLinkLabel.TabIndex = 0;
            this.olvideLinkLabel.TabStop = true;
            this.olvideLinkLabel.Text = "Olvide mi contraseña";
            this.olvideLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.olvideLinkLabel_LinkClicked);
            // 
            // cerrarPictureBox
            // 
            this.cerrarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cerrarPictureBox.Image")));
            this.cerrarPictureBox.Location = new System.Drawing.Point(562, 0);
            this.cerrarPictureBox.Name = "cerrarPictureBox";
            this.cerrarPictureBox.Size = new System.Drawing.Size(20, 20);
            this.cerrarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrarPictureBox.TabIndex = 6;
            this.cerrarPictureBox.TabStop = false;
            this.cerrarPictureBox.Click += new System.EventHandler(this.cerrarPictureBox_Click);
            // 
            // minimizarPictureBox
            // 
            this.minimizarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizarPictureBox.Image")));
            this.minimizarPictureBox.Location = new System.Drawing.Point(540, 0);
            this.minimizarPictureBox.Name = "minimizarPictureBox";
            this.minimizarPictureBox.Size = new System.Drawing.Size(20, 20);
            this.minimizarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizarPictureBox.TabIndex = 7;
            this.minimizarPictureBox.TabStop = false;
            this.minimizarPictureBox.Click += new System.EventHandler(this.minimizarPictureBox_Click);
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.usuarioLabel.Location = new System.Drawing.Point(125, 98);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(0, 17);
            this.usuarioLabel.TabIndex = 8;
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.contraseñaLabel.Location = new System.Drawing.Point(124, 157);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(0, 17);
            this.contraseñaLabel.TabIndex = 9;
            // 
            // mensajeDbLabel
            // 
            this.mensajeDbLabel.AutoSize = true;
            this.mensajeDbLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeDbLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mensajeDbLabel.Location = new System.Drawing.Point(123, 187);
            this.mensajeDbLabel.Name = "mensajeDbLabel";
            this.mensajeDbLabel.Size = new System.Drawing.Size(0, 17);
            this.mensajeDbLabel.TabIndex = 10;
            // 
            // Form1_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(584, 330);
            this.Controls.Add(this.mensajeDbLabel);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.minimizarPictureBox);
            this.Controls.Add(this.cerrarPictureBox);
            this.Controls.Add(this.olvideLinkLabel);
            this.Controls.Add(this.ingresarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.logoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1_Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.cerrarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.LinkLabel olvideLinkLabel;
        private System.Windows.Forms.PictureBox cerrarPictureBox;
        private System.Windows.Forms.PictureBox minimizarPictureBox;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.Label mensajeDbLabel;
    }
}

    