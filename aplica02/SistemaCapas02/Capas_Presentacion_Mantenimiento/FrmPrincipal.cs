using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capas_Presentacion_Mantenimiento
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tIPOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (FrmLogin.tipousuario == "ADMINISTRADOR")
            {
                menuStrip1.Items[0].Visible = true;
                menuStrip1.Items[1].Visible = true;
                menuStrip1.Items[2].Visible = true;
            }
            else
            {
                if (FrmLogin.tipousuario == "USUARIO")
                {
                    menuStrip1.Items[0].Visible = false;
                    menuStrip1.Items[1].Visible = true;
                    menuStrip1.Items[2].Visible = true;
                }
                
            }
    }

        private void uSUARIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se crea un objeto fvusuario de tipo FrmUsuario
            FrmUsuario fvusuario = new FrmUsuario();
            //Se define al objeto fvusuario como formulario hijo
            fvusuario.MdiParent = this;
            //Se muestra el formulario
            fvusuario.Show();
        }
}
}