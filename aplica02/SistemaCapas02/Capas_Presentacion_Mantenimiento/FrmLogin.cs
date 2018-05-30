using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Capa_Entidad_Tipo_Usuario;
using Capa_Negocio_Mantenimiento;
using Capa_Entidad_Usuario;


namespace Capas_Presentacion_Mantenimiento
{
    public partial class FrmLogin : Form
    {
        Clsentidadtipousu objentidadusu = new Clsentidadtipousu();
        Clsentidadusuario objusuario = new Clsentidadusuario();
        public static int contador=0;
        public static String tipousuario = "";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
         CBOTIPO.DataSource = ClsNegocioMantenimiento.ListaTiposDeUsuarios(objentidadusu);
         //valor interno
         CBOTIPO.ValueMember = "CODTIPOUSU";
        //valor a mostrar en el ComboBox
         CBOTIPO.DisplayMember="NOMTIPO";
        //Elemento con indice 0
         CBOTIPO.SelectedIndex = 0;
        }

        private void BTNACEPTAR_Click(object sender, EventArgs e)
        {
            if (this.TXTUSUARIO.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Usuario", "Pulse Clic En Aceptar");
                TXTUSUARIO.Focus();
                }else{
                    if(this.TXTCONTRA.Text.Equals("")){
                        MessageBox.Show("Ingrese Contraseña","Pulse Clic En Aceptar");
                        TXTCONTRA.Focus();
                   }else{
                       MessageBox.Show(CBOTIPO.SelectedValue.ToString());
                        //Si existe el Usuario y la Contraseña
                       objusuario.Vnomusu = TXTUSUARIO.Text.ToUpper();
                       objusuario.Vclaveusu = TXTCONTRA.Text.ToUpper();
                       objusuario.Vnomtipousuario = CBOTIPO.Text.ToString();
                       tipousuario= CBOTIPO.Text.ToString();
                       if (ClsNegocioMantenimiento.AccesoDeUsuarios(objusuario).Rows.Count- 1 >= 0)
                       {
                           FrmPrincipal objprincipal = new FrmPrincipal();
                           this.Hide();
                           objprincipal.Show();
                           
                       }else{
                           MessageBox.Show("Usuario y/o Contraseña y/o Acceso No Existen", "Pulse Clic En Aceptar");
                           TXTUSUARIO.Text = "";
                           TXTCONTRA.Text = "";
                           TXTUSUARIO.Focus();
                           contador += 1;
                           if (contador == 3)
                           {
                               MessageBox.Show("LLego A Su Limite de Intentos", "Pulse Clic En Aceptar");
                               //Salir del Sistema
                               Application.Exit();
                           }
                       }
                }
            }
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
