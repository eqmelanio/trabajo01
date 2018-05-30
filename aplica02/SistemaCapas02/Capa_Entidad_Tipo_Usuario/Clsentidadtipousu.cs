using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_Entidad_Tipo_Usuario
{
    public class Clsentidadtipousu
    {
        private String xcodtipousuario;
        //Propiedad Xcodtipousuario
        public String Xcodtipousuario
        {
            //se retorna el valor de la propiedad
            get { return xcodtipousuario; }
            //con el set se almacena el valor
            //de la propiedad
            set { xcodtipousuario = value; }
        }
        private String xnomtipousuario;

        public String Xnomtipousuario
        {
            get { return xnomtipousuario; }
            set { xnomtipousuario = value; }
        }
    }
}
