using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Capa_Entidad_Usuario;
using Capa_Entidad_Tipo_Usuario;
using Capa_Negocio_Mantenimiento;
namespace Capas_Presentacion_Mantenimiento
{
    public partial class FrmUsuario : Form
    {
        Clsentidadtipousu objtipo = new Clsentidadtipousu();
        Clsentidadusuario objusu = new Clsentidadusuario();
        public FrmUsuario()
        {
            InitializeComponent();
        }
              

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CBOTIPO.DataSource=ClsNegocioMantenimiento.ListaTiposDeUsuarios(objtipo);
            CBOTIPO.ValueMember = "CODTIPOUSU";
            CBOTIPO.DisplayMember = "NOMTIPO";
            CBOESTADOUSU.SelectedIndex = 0;
        }

        private void BTNNUEVOUSU_Click(object sender, EventArgs e)
        {
            GBXUSUARIOS.Enabled = true;
            TXTCODUSU.Text = ClsNegocioMantenimiento.CodigoGeneraUsuarios(objusu);
        }
    }
}
