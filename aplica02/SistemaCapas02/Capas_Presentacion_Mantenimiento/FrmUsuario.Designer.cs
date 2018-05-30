namespace Capas_Presentacion_Mantenimiento
{
    partial class FrmUsuario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBXUSUARIOS = new System.Windows.Forms.GroupBox();
            this.CBOESTADOUSU = new System.Windows.Forms.ComboBox();
            this.CBOTIPO = new System.Windows.Forms.ComboBox();
            this.TXTCLAVE = new System.Windows.Forms.TextBox();
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.TXTCODUSU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNCERRARUSU = new System.Windows.Forms.Button();
            this.BTNELIUSU = new System.Windows.Forms.Button();
            this.BTNACTUSU = new System.Windows.Forms.Button();
            this.BTNBUSCARUSU = new System.Windows.Forms.Button();
            this.BTNGRABARUSU = new System.Windows.Forms.Button();
            this.BTNCANCELARUSU = new System.Windows.Forms.Button();
            this.BTNNUEVOUSU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBXUSUARIOS.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capas_Presentacion_Mantenimiento.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(6, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GBXUSUARIOS
            // 
            this.GBXUSUARIOS.Controls.Add(this.CBOESTADOUSU);
            this.GBXUSUARIOS.Controls.Add(this.CBOTIPO);
            this.GBXUSUARIOS.Controls.Add(this.TXTCLAVE);
            this.GBXUSUARIOS.Controls.Add(this.TXTUSUARIO);
            this.GBXUSUARIOS.Controls.Add(this.TXTCODUSU);
            this.GBXUSUARIOS.Controls.Add(this.label5);
            this.GBXUSUARIOS.Controls.Add(this.label4);
            this.GBXUSUARIOS.Controls.Add(this.label3);
            this.GBXUSUARIOS.Controls.Add(this.label2);
            this.GBXUSUARIOS.Controls.Add(this.label1);
            this.GBXUSUARIOS.Enabled = false;
            this.GBXUSUARIOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXUSUARIOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBXUSUARIOS.Location = new System.Drawing.Point(177, 70);
            this.GBXUSUARIOS.Name = "GBXUSUARIOS";
            this.GBXUSUARIOS.Size = new System.Drawing.Size(516, 229);
            this.GBXUSUARIOS.TabIndex = 1;
            this.GBXUSUARIOS.TabStop = false;
            this.GBXUSUARIOS.Text = "USUARIOS";
            // 
            // CBOESTADOUSU
            // 
            this.CBOESTADOUSU.FormattingEnabled = true;
            this.CBOESTADOUSU.Items.AddRange(new object[] {
            "<<ESTADO..>>",
            "ACTIVO",
            "BLOQUEADO"});
            this.CBOESTADOUSU.Location = new System.Drawing.Point(130, 180);
            this.CBOESTADOUSU.Name = "CBOESTADOUSU";
            this.CBOESTADOUSU.Size = new System.Drawing.Size(255, 32);
            this.CBOESTADOUSU.TabIndex = 10;
            // 
            // CBOTIPO
            // 
            this.CBOTIPO.FormattingEnabled = true;
            this.CBOTIPO.Location = new System.Drawing.Point(130, 143);
            this.CBOTIPO.Name = "CBOTIPO";
            this.CBOTIPO.Size = new System.Drawing.Size(255, 32);
            this.CBOTIPO.TabIndex = 9;
            // 
            // TXTCLAVE
            // 
            this.TXTCLAVE.Location = new System.Drawing.Point(130, 106);
            this.TXTCLAVE.Name = "TXTCLAVE";
            this.TXTCLAVE.Size = new System.Drawing.Size(372, 29);
            this.TXTCLAVE.TabIndex = 7;
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.Location = new System.Drawing.Point(130, 67);
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(372, 29);
            this.TXTUSUARIO.TabIndex = 6;
            // 
            // TXTCODUSU
            // 
            this.TXTCODUSU.Location = new System.Drawing.Point(130, 28);
            this.TXTCODUSU.Name = "TXTCODUSU";
            this.TXTCODUSU.ReadOnly = true;
            this.TXTCODUSU.Size = new System.Drawing.Size(143, 29);
            this.TXTCODUSU.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "ESTADO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIPO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "CLAVE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNCERRARUSU);
            this.groupBox2.Controls.Add(this.BTNELIUSU);
            this.groupBox2.Controls.Add(this.BTNACTUSU);
            this.groupBox2.Controls.Add(this.BTNBUSCARUSU);
            this.groupBox2.Controls.Add(this.BTNGRABARUSU);
            this.groupBox2.Controls.Add(this.BTNCANCELARUSU);
            this.groupBox2.Controls.Add(this.BTNNUEVOUSU);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(699, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 344);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPCIONES";
            // 
            // BTNCERRARUSU
            // 
            this.BTNCERRARUSU.Location = new System.Drawing.Point(8, 292);
            this.BTNCERRARUSU.Name = "BTNCERRARUSU";
            this.BTNCERRARUSU.Size = new System.Drawing.Size(148, 38);
            this.BTNCERRARUSU.TabIndex = 6;
            this.BTNCERRARUSU.Text = "CERRAR";
            this.BTNCERRARUSU.UseVisualStyleBackColor = true;
            // 
            // BTNELIUSU
            // 
            this.BTNELIUSU.Enabled = false;
            this.BTNELIUSU.Location = new System.Drawing.Point(8, 248);
            this.BTNELIUSU.Name = "BTNELIUSU";
            this.BTNELIUSU.Size = new System.Drawing.Size(148, 38);
            this.BTNELIUSU.TabIndex = 5;
            this.BTNELIUSU.Text = "ELIMINAR";
            this.BTNELIUSU.UseVisualStyleBackColor = true;
            // 
            // BTNACTUSU
            // 
            this.BTNACTUSU.Enabled = false;
            this.BTNACTUSU.Location = new System.Drawing.Point(8, 204);
            this.BTNACTUSU.Name = "BTNACTUSU";
            this.BTNACTUSU.Size = new System.Drawing.Size(148, 38);
            this.BTNACTUSU.TabIndex = 4;
            this.BTNACTUSU.Text = "ACTUALIZAR";
            this.BTNACTUSU.UseVisualStyleBackColor = true;
            // 
            // BTNBUSCARUSU
            // 
            this.BTNBUSCARUSU.Enabled = false;
            this.BTNBUSCARUSU.Location = new System.Drawing.Point(8, 160);
            this.BTNBUSCARUSU.Name = "BTNBUSCARUSU";
            this.BTNBUSCARUSU.Size = new System.Drawing.Size(148, 38);
            this.BTNBUSCARUSU.TabIndex = 3;
            this.BTNBUSCARUSU.Text = "BUSCAR";
            this.BTNBUSCARUSU.UseVisualStyleBackColor = true;
            // 
            // BTNGRABARUSU
            // 
            this.BTNGRABARUSU.Enabled = false;
            this.BTNGRABARUSU.Location = new System.Drawing.Point(8, 116);
            this.BTNGRABARUSU.Name = "BTNGRABARUSU";
            this.BTNGRABARUSU.Size = new System.Drawing.Size(148, 38);
            this.BTNGRABARUSU.TabIndex = 2;
            this.BTNGRABARUSU.Text = "GRABAR";
            this.BTNGRABARUSU.UseVisualStyleBackColor = true;
            // 
            // BTNCANCELARUSU
            // 
            this.BTNCANCELARUSU.Enabled = false;
            this.BTNCANCELARUSU.Location = new System.Drawing.Point(8, 72);
            this.BTNCANCELARUSU.Name = "BTNCANCELARUSU";
            this.BTNCANCELARUSU.Size = new System.Drawing.Size(148, 38);
            this.BTNCANCELARUSU.TabIndex = 1;
            this.BTNCANCELARUSU.Text = "CANCELAR";
            this.BTNCANCELARUSU.UseVisualStyleBackColor = true;
            // 
            // BTNNUEVOUSU
            // 
            this.BTNNUEVOUSU.Location = new System.Drawing.Point(8, 28);
            this.BTNNUEVOUSU.Name = "BTNNUEVOUSU";
            this.BTNNUEVOUSU.Size = new System.Drawing.Size(148, 38);
            this.BTNNUEVOUSU.TabIndex = 0;
            this.BTNNUEVOUSU.Text = "NUEVO";
            this.BTNNUEVOUSU.UseVisualStyleBackColor = true;
            this.BTNNUEVOUSU.Click += new System.EventHandler(this.BTNNUEVOUSU_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(875, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GBXUSUARIOS);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENIMIENTO DE USUARIOS";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBXUSUARIOS.ResumeLayout(false);
            this.GBXUSUARIOS.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GBXUSUARIOS;
        private System.Windows.Forms.ComboBox CBOTIPO;
        private System.Windows.Forms.TextBox TXTCLAVE;
        private System.Windows.Forms.TextBox TXTUSUARIO;
        private System.Windows.Forms.TextBox TXTCODUSU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNCERRARUSU;
        private System.Windows.Forms.Button BTNELIUSU;
        private System.Windows.Forms.Button BTNACTUSU;
        private System.Windows.Forms.Button BTNBUSCARUSU;
        private System.Windows.Forms.Button BTNGRABARUSU;
        private System.Windows.Forms.Button BTNCANCELARUSU;
        private System.Windows.Forms.Button BTNNUEVOUSU;
        private System.Windows.Forms.ComboBox CBOESTADOUSU;
    }
}