using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capa_Datos_Mantenimiento;
using Capa_Entidad_Tipo_Usuario;
using Capa_Entidad_Usuario;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad_Autor;
using Capa_Entidad_Editorial;
using Capa_Entidad_Idioma;
using Capa_Entidad_Imprenta;
using Capa_Entidad_Pais;
using Capa_Entidad_Libro;
namespace Capa_Proceso_Mantenimiento
{
    public class ClsprocesoMantenimiento
    {
        #region "Tipo De Usuarios"
        //Listado de Tipo de Usuarios (Codigo y Tipo De Usuario)
        public static DataTable ListaTiposUsuarios(Clsentidadtipousu objusutipo)
        {
            Clsdatamantenimiento objdatatipo = new Clsdatamantenimiento();
            return objdatatipo.EjecutarListado("SP_TIPOS_USUARIOS");
        }
        //Acceso(Usuario, Contraseña, Tipo de Usuario)
        public static DataTable AccesoUsuario(Clsentidadusuario objusuario)
        {
            Clsdatamantenimiento objusu = new Clsdatamantenimiento();
            List<SqlParameter> buscarusu=new List<SqlParameter>();
            SqlParameter xnombreusu = new SqlParameter("@XNOMUSU", objusuario.Vnomusu);
            SqlParameter xclaveusu = new SqlParameter("@XCLAVEUSU", objusuario.Vclaveusu);
            SqlParameter xtipousu = new SqlParameter("@XNOMTIPOUSU", objusuario.Vnomtipousuario);
            //Agregando los parametros hacia el objeto buscarusu
            buscarusu.Add(xnombreusu);
            buscarusu.Add(xclaveusu);
            buscarusu.Add(xtipousu);
            return objusu.EjecutarConsultas("SP_ACCESO_USUARIO", buscarusu);
        }
     #endregion
    #region "Mantenimiento de Usuarios"
        //Listado de Usuarios
        public static DataTable ListaUsuarios(Clsentidadusuario objmantusu)
        {
            Clsdatamantenimiento objdatatipo = new Clsdatamantenimiento();
            return objdatatipo.EjecutarListado("SP_LISTADO_USUARIO");
        }
        //Ingreso de Usuarios
        public void RegistrarUsuarios(Clsentidadusuario objingusuario)
        {
            //Con la capa de datos
            Clsdatamantenimiento objdatausu = new Clsdatamantenimiento();
            //Lista de parametros
            List<SqlParameter> ListaUsu = new List<SqlParameter>();
            SqlParameter xcodusuario = new SqlParameter("@XCODUSU", objingusuario.Vcodusu);
            SqlParameter xnomusuario = new SqlParameter("@XNOMUSU", objingusuario.Vnomusu);
            SqlParameter xclaveusuario = new SqlParameter("@XCLAVEUSU", objingusuario.Vclaveusu);
            SqlParameter xcodtipousuario = new SqlParameter("@XCODTIPO", objingusuario.Vcodtipousu);
            SqlParameter xestusuario = new SqlParameter("@XESTADOUSU", objingusuario.Vestadousu);
            //Agregando los parametros
            ListaUsu.Add(xcodusuario);
            ListaUsu.Add(xnomusuario);
            ListaUsu.Add(xclaveusuario);
            ListaUsu.Add(xcodtipousuario);
            ListaUsu.Add(xestusuario);
            objdatausu.EjecutarOperaciones("SP_INGRESO_USUARIOS",ListaUsu);
        }
        //Busqueda de Usuarios Por Codigo
        public static DataTable BusquedaUsuario(Clsentidadusuario objusuario)
        {
            Clsdatamantenimiento objusu = new Clsdatamantenimiento();
            List<SqlParameter> buscarusuario = new List<SqlParameter>();
            SqlParameter xcodusuario = new SqlParameter("@XCODUSU", objusuario.Vcodusu);
            //Agregando los parametros hacia el objeto objusu
            buscarusuario.Add(xcodusuario);
            return objusu.EjecutarConsultas("SP_BUSQUEDA_USUARIOS", buscarusuario);
        }
        //Mostrar Usuarios
        public static DataTable MostrarUsuario(Clsentidadusuario objusuario)
        {
            Clsdatamantenimiento objusumostrar = new Clsdatamantenimiento();
            List<SqlParameter> mostrarusuario = new List<SqlParameter>();
            SqlParameter xcodusuario = new SqlParameter("@XCODUSU", objusuario.Vcodusu);
            //Agregando los parametros hacia el objeto objusu
            mostrarusuario.Add(xcodusuario);
            return objusumostrar.EjecutarConsultas("SP_MOSTRAR_USUARIOS", mostrarusuario);
        }
        //Actualizar Usuarios
        public void ActualizarUsuarios(Clsentidadusuario objactusuario)
        {
            //Con la capa de datos
            Clsdatamantenimiento objdatausu = new Clsdatamantenimiento();
            //Lista de parametros
            List<SqlParameter> actualizausu = new List<SqlParameter>();
            SqlParameter xcodusuario = new SqlParameter("@XCODUSU", objactusuario.Vcodusu);
            SqlParameter xnomusuario = new SqlParameter("@XNOMUSU", objactusuario.Vnomusu);
            SqlParameter xclaveusuario = new SqlParameter("@XCLAVEUSU", objactusuario.Vclaveusu);
            SqlParameter xcodtipousuario = new SqlParameter("@XCODTIPO", objactusuario.Vcodtipousu);
            SqlParameter xestusuario = new SqlParameter("@XESTADOUSU", objactusuario.Vestadousu);
            //Agregando los parametros
            actualizausu.Add(xcodusuario);
            actualizausu.Add(xnomusuario);
            actualizausu.Add(xclaveusuario);
            actualizausu.Add(xcodtipousuario);
            actualizausu.Add(xestusuario);
            objdatausu.EjecutarOperaciones("SP_ACTUALIZA_USUARIOS", actualizausu);
        }
        //Eliminar Usuarios
        public void EliminarUsuarios(Clsentidadusuario objeliusu)
        {
            //Con la capa de datos
            Clsdatamantenimiento objdatausu = new Clsdatamantenimiento();
            //Lista de parametros
            List<SqlParameter> eliminausu = new List<SqlParameter>();
            SqlParameter xcodusuario = new SqlParameter("@XCODUSU", objeliusu.Vcodusu);
            //Agregando los parametros
            eliminausu.Add(xcodusuario);
            objdatausu.EjecutarOperaciones("SP_ELIMINA_USUARIOS", eliminausu);
        }
    #endregion
    #region "Listado de Autores"
        public static DataTable ListaAutores(Clsentidadautor objlistaautor)
        {
            Clsdatamantenimiento objdataautor = new Clsdatamantenimiento();
            return objdataautor.EjecutarListado("SP_LISTA_AUTORES");
        }
    #endregion
    #region "Listado de Editoriales"
        public static DataTable ListaEditoriales(ClsentidadEditorial objlistaeditorial)
        {
            Clsdatamantenimiento objdataeditorial = new Clsdatamantenimiento();
            return objdataeditorial.EjecutarListado("SP_LISTA_EDITORIAL");
        }
    #endregion
    #region "Listado de Imprenta"
        public static DataTable ListadoImprenta(Clsentidadimprenta objlistaimprenta)
        {
            Clsdatamantenimiento objdataimprenta = new Clsdatamantenimiento();
            return objdataimprenta.EjecutarListado("SP_LISTADO_IMPRENTA");
        }
    #endregion
    #region "Listado de Idiomas"
        public static DataTable ListadoIdiomas(ClsentidadIdioma objlistaidioma)
        {
            Clsdatamantenimiento objdataidioma = new Clsdatamantenimiento();
            return objdataidioma.EjecutarListado("SP_LISTADO_IDIOMA");
        }
    #endregion
    #region "Listado de Pais"
        public static DataTable ListadoPais(ClsentidadPais objlistapais)
        {
            Clsdatamantenimiento objdatapais = new Clsdatamantenimiento();
            return objdatapais.EjecutarListado("SP_LISTADO_PAIS");
        }
    #endregion
   #region "Mantenimiento de Libros"
        //Codigo Autogenerado de Libros
        public static String CodigoAutogeneradoLibros(ClsentidadLibro objcodigolibro)
        {
            Clsdatamantenimiento objgeneralibro = new Clsdatamantenimiento();
            return objgeneralibro.GeneraCodigo("SP_CODIGO_GENERA_LIBROS");
        }
        //Codigo Autogenerado de Usuario
        public static String CodigoAutogeneradoUsuarios(Clsentidadusuario objcodigousu)
        {
            Clsdatamantenimiento objgenerausu = new Clsdatamantenimiento();
            return objgenerausu.GeneraCodigoUsuario("SP_CODIGO_GENERA_USUARIOS");
        }
   
        //Listado de Libros
        public static DataTable ListadoLibros(ClsentidadLibro objlistalibro)
        {
            Clsdatamantenimiento objdatalibro = new Clsdatamantenimiento();
            return objdatalibro.EjecutarListado("SP_LISTADO_LIBROS");
        }
        //Busqueda por codigo del libro
        public static DataTable BusquedaCodLibro(ClsentidadLibro objbuslibro)
        {
            Clsdatamantenimiento objlibro = new Clsdatamantenimiento();
            List<SqlParameter> buscarlibro = new List<SqlParameter>();
            SqlParameter xcodlibro = new SqlParameter("@XCODLIB", objbuslibro.Vcodlibro);
            //Agregando los parametros hacia el objeto objusu
            buscarlibro.Add(xcodlibro);
            return objlibro.EjecutarConsultas("SP_BUSQUEDA_CODIGOLIBRO", buscarlibro);
        }
        //Mostrar Libro
        public static DataTable BusMostrarLibro(ClsentidadLibro objmostlibro)
        {
            Clsdatamantenimiento objmostrarlibro = new Clsdatamantenimiento();
            List<SqlParameter> mostrarlibro = new List<SqlParameter>();
            SqlParameter xcodmostrar = new SqlParameter("@XCODLIBRO", objmostlibro.Vcodlibro);
            //Agregando los parametros hacia el objeto objusu
            mostrarlibro.Add(xcodmostrar);
            return objmostrarlibro.EjecutarConsultas("SP_BUSQUEDA_LIBROS", mostrarlibro);
        }
        //Insertar Libros
        public void RegistrarLibros(ClsentidadLibro objinglibro)
        {
            //Con la capa de datos
            Clsdatamantenimiento objdatalibro = new Clsdatamantenimiento();
            //Lista de parametros
            List<SqlParameter> Inglibro = new List<SqlParameter>();
            SqlParameter xcodlibro = new SqlParameter("@XCODLIB", objinglibro.Vcodlibro);
            SqlParameter xnomlibro = new SqlParameter("@XNOMLIB", objinglibro.Vnomlibro);
            SqlParameter xpreclibro = new SqlParameter("@XPRECLIB", objinglibro.Vpreclibro);
            SqlParameter xstocklibro = new SqlParameter("@XSTOCKLIB", objinglibro.Vstocklibro);
            SqlParameter xcodautor = new SqlParameter("@XCODAUTOR", objinglibro.Vcodautorlibro);
            SqlParameter xcodedit = new SqlParameter("@XCODEDIT", objinglibro.Vcodeditlibro);
            SqlParameter xcodimp = new SqlParameter("@XCODIMP", objinglibro.Vcodimplibro);
            SqlParameter xcodidioma = new SqlParameter("@XCODIDIOMA", objinglibro.Vcodidiomalibro);
            SqlParameter xcodpais = new SqlParameter("@XCODPAIS", objinglibro.Vcodpaislibro);
            //Agregando los parametros
            Inglibro.Add(xcodlibro);
            Inglibro.Add(xnomlibro);
            Inglibro.Add(xpreclibro);
            Inglibro.Add(xstocklibro);
            Inglibro.Add(xcodautor);
            Inglibro.Add(xcodedit);
            Inglibro.Add(xcodimp);
            Inglibro.Add(xcodidioma);
            Inglibro.Add(xcodpais);
            objdatalibro.EjecutarOperaciones("SP_INSERTAR_LIBROS", Inglibro);
        }
        //Actualizar Libros
        public void ActualizarLibros(ClsentidadLibro objactlibro)
        {
            //Con la capa de datos
            Clsdatamantenimiento objdatalibro = new Clsdatamantenimiento();
            //Lista de parametros
            List<SqlParameter> actualizarlibro = new List<SqlParameter>();
            SqlParameter xcodlibro = new SqlParameter("@XCODLIB", objactlibro.Vcodlibro);
            SqlParameter xnomlibro = new SqlParameter("@XNOMLIB", objactlibro.Vnomlibro);
            SqlParameter xpreclibro = new SqlParameter("@XPRECLIB", objactlibro.Vpreclibro);
            SqlParameter xstocklibro = new SqlParameter("@XSTOCKLIB", objactlibro.Vstocklibro);
            SqlParameter xcodautor = new SqlParameter("@XCODAUTOR", objactlibro.Vcodautorlibro);
            SqlParameter xcodedit = new SqlParameter("@XCODEDIT", objactlibro.Vcodeditlibro);
            SqlParameter xcodimp = new SqlParameter("@XCODIMP", objactlibro.Vcodimplibro);
            SqlParameter xcodidioma = new SqlParameter("@XCODIDIOMA", objactlibro.Vcodidiomalibro);
            SqlParameter xcodpais = new SqlParameter("@XCODPAIS", objactlibro.Vcodpaislibro);
            //Agregando los parametros
            actualizarlibro.Add(xcodlibro);
            actualizarlibro.Add(xnomlibro);
            actualizarlibro.Add(xpreclibro);
            actualizarlibro.Add(xstocklibro);
            actualizarlibro.Add(xcodautor);
            actualizarlibro.Add(xcodedit);
            actualizarlibro.Add(xcodimp);
            actualizarlibro.Add(xcodidioma);
            actualizarlibro.Add(xcodpais);
            objdatalibro.EjecutarOperaciones("SP_ACTUALIZA_LIBROS", actualizarlibro);
        }
        //Eliminar Libro
        public void EliminarLibros(ClsentidadLibro objelilibro)
        {
            //Con la capa de datos
            Clsdatamantenimiento objdatalibro = new Clsdatamantenimiento();
            //Lista de parametros
            List<SqlParameter> eliminarlibro = new List<SqlParameter>();
            SqlParameter xcodlibro = new SqlParameter("@XCODLIBRO", objelilibro.Vcodlibro);
            //Agregando los parametros
            eliminarlibro.Add(xcodlibro);
            objdatalibro.EjecutarOperaciones("SP_ELIMINA_LIBROS", eliminarlibro);
        }
   #endregion
    }
 }
