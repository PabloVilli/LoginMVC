namespace CapaPresentacion
{
    partial class Form3_RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_RecuperarContraseña));
            this.RecuperarPanel = new System.Windows.Forms.Panel();
            this.msjLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.returnPictureBox = new System.Windows.Forms.PictureBox();
            this.recuperarButton = new System.Windows.Forms.Button();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.RecuperarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RecuperarPanel
            // 
            this.RecuperarPanel.BackColor = System.Drawing.Color.Lavender;
            this.RecuperarPanel.Controls.Add(this.msjLabel);
            this.RecuperarPanel.Controls.Add(this.ResultTextBox);
            this.RecuperarPanel.Controls.Add(this.returnPictureBox);
            this.RecuperarPanel.Controls.Add(this.recuperarButton);
            this.RecuperarPanel.Controls.Add(this.usuarioTextBox);
            this.RecuperarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecuperarPanel.Location = new System.Drawing.Point(0, 0);
            this.RecuperarPanel.Name = "RecuperarPanel";
            this.RecuperarPanel.Size = new System.Drawing.Size(496, 275);
            this.RecuperarPanel.TabIndex = 6;
            this.RecuperarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecuperarPanel_MouseDown);
            // 
            // msjLabel
            // 
            this.msjLabel.AutoSize = true;
            this.msjLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msjLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.msjLabel.Location = new System.Drawing.Point(12, 215);
            this.msjLabel.Name = "msjLabel";
            this.msjLabel.Size = new System.Drawing.Size(0, 17);
            this.msjLabel.TabIndex = 11;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.Lavender;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ResultTextBox.Location = new System.Drawing.Point(13, 95);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(471, 104);
            this.ResultTextBox.TabIndex = 10;
            // 
            // returnPictureBox
            // 
            this.returnPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("returnPictureBox.Image")));
            this.returnPictureBox.Location = new System.Drawing.Point(467, 2);
            this.returnPictureBox.Name = "returnPictureBox";
            this.returnPictureBox.Size = new System.Drawing.Size(25, 25);
            this.returnPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.returnPictureBox.TabIndex = 9;
            this.returnPictureBox.TabStop = false;
            this.returnPictureBox.Click += new System.EventHandler(this.returnPictureBox_Click);
            // 
            // recuperarButton
            // 
            this.recuperarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.recuperarButton.FlatAppearance.BorderSize = 0;
            this.recuperarButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.recuperarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.recuperarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recuperarButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuperarButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.recuperarButton.Location = new System.Drawing.Point(163, 63);
            this.recuperarButton.Name = "recuperarButton";
            this.recuperarButton.Size = new System.Drawing.Size(175, 26);
            this.recuperarButton.TabIndex = 1;
            this.recuperarButton.Text = "Recuperar";
            this.recuperarButton.UseVisualStyleBackColor = false;
            this.recuperarButton.Click += new System.EventHandler(this.recuperarButton_Click);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.usuarioTextBox.Location = new System.Drawing.Point(12, 34);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(472, 23);
            this.usuarioTextBox.TabIndex = 5;
            this.usuarioTextBox.Text = "Ingresa tu usuario";
            this.usuarioTextBox.Enter += new System.EventHandler(this.usuarioTextBox_Enter);
            this.usuarioTextBox.Leave += new System.EventHandler(this.usuarioTextBox_Leave);
            // 
            // Form3_RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 275);
            this.Controls.Add(this.RecuperarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3_RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3_RecuperarContraseña";
            this.RecuperarPanel.ResumeLayout(false);
            this.RecuperarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RecuperarPanel;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Button recuperarButton;
        private System.Windows.Forms.PictureBox returnPictureBox;
        private System.Windows.Forms.Label msjLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}