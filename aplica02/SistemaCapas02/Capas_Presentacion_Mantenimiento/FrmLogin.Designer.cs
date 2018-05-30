namespace Capas_Presentacion_Mantenimiento
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBOTIPO = new System.Windows.Forms.ComboBox();
            this.TXTCONTRA = new System.Windows.Forms.TextBox();
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.BTNACEPTAR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBOTIPO);
            this.panel1.Controls.Add(this.TXTCONTRA);
            this.panel1.Controls.Add(this.TXTUSUARIO);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(272, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 156);
            this.panel1.TabIndex = 0;
            // 
            // CBOTIPO
            // 
            this.CBOTIPO.BackColor = System.Drawing.SystemColors.MenuText;
            this.CBOTIPO.ForeColor = System.Drawing.SystemColors.Window;
            this.CBOTIPO.FormattingEnabled = true;
            this.CBOTIPO.Location = new System.Drawing.Point(210, 104);
            this.CBOTIPO.Name = "CBOTIPO";
            this.CBOTIPO.Size = new System.Drawing.Size(234, 33);
            this.CBOTIPO.TabIndex = 5;
            // 
            // TXTCONTRA
            // 
            this.TXTCONTRA.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXTCONTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCONTRA.ForeColor = System.Drawing.SystemColors.Window;
            this.TXTCONTRA.Location = new System.Drawing.Point(210, 58);
            this.TXTCONTRA.MaxLength = 40;
            this.TXTCONTRA.Name = "TXTCONTRA";
            this.TXTCONTRA.PasswordChar = '*';
            this.TXTCONTRA.Size = new System.Drawing.Size(234, 31);
            this.TXTCONTRA.TabIndex = 4;
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXTUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUSUARIO.ForeColor = System.Drawing.SystemColors.Window;
            this.TXTUSUARIO.Location = new System.Drawing.Point(210, 15);
            this.TXTUSUARIO.MaxLength = 40;
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(234, 31);
            this.TXTUSUARIO.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(72, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "ACCESO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(11, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "CONTRASEÑA :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(65, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "USUARIO :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTNSALIR);
            this.panel2.Controls.Add(this.BTNACEPTAR);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(359, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 60);
            this.panel2.TabIndex = 2;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.SystemColors.ControlText;
            this.BTNSALIR.ForeColor = System.Drawing.SystemColors.Info;
            this.BTNSALIR.Location = new System.Drawing.Point(166, 10);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(141, 37);
            this.BTNSALIR.TabIndex = 1;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // BTNACEPTAR
            // 
            this.BTNACEPTAR.BackColor = System.Drawing.SystemColors.ControlText;
            this.BTNACEPTAR.ForeColor = System.Drawing.SystemColors.Info;
            this.BTNACEPTAR.Location = new System.Drawing.Point(10, 10);
            this.BTNACEPTAR.Name = "BTNACEPTAR";
            this.BTNACEPTAR.Size = new System.Drawing.Size(141, 37);
            this.BTNACEPTAR.TabIndex = 0;
            this.BTNACEPTAR.Text = "ACEPTAR";
            this.BTNACEPTAR.UseVisualStyleBackColor = false;
            this.BTNACEPTAR.Click += new System.EventHandler(this.BTNACEPTAR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capas_Presentacion_Mantenimiento.Properties.Resources.seguridad;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(761, 252);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBOTIPO;
        private System.Windows.Forms.TextBox TXTCONTRA;
        private System.Windows.Forms.TextBox TXTUSUARIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Button BTNACEPTAR;

    }
}

