using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capa_Entidad_Autor;
using Capa_Entidad_Editorial;
using Capa_Entidad_Idioma;
using Capa_Entidad_Imprenta;
using Capa_Entidad_Libro;
using Capa_Entidad_Pais;
using Capa_Entidad_Tipo_Usuario;
using Capa_Entidad_Usuario;
using Capa_Proceso_Mantenimiento;
using System.Data;
namespace Capa_Negocio_Mantenimiento
{
    public class ClsNegocioMantenimiento
    {
        #region "Negocio Tipo De Usuarios"
            public static DataTable ListaTiposDeUsuarios(Clsentidadtipousu objtipousu)
            {
                return ClsprocesoMantenimiento.ListaTiposUsuarios(objtipousu);
            }

            public static DataTable AccesoDeUsuarios(Clsentidadusuario objusuario)
            {
                return ClsprocesoMantenimiento.AccesoUsuario(objusuario);
            }

            public static String CodigoGeneraUsuarios(Clsentidadusuario objgenerausu)
            {
                return ClsprocesoMantenimiento.CodigoAutogeneradoUsuarios(objgenerausu);
            }

        #endregion

        #region "Negocio Mantenimiento De Usuarios"
            public static void RegistroDeUsuarios(Clsentidadusuario objregusuario)
            {
                ClsprocesoMantenimiento insertarusuarios = new ClsprocesoMantenimiento();
                insertarusuarios.RegistrarUsuarios(objregusuario);
            }

            public static DataTable BusquedaDeUsuarios(Clsentidadusuario objbususuario)
            {
                return ClsprocesoMantenimiento.BusquedaUsuario(objbususuario);
            }

            public static DataTable ImprimirUsuarios(Clsentidadusuario objmostrarusuario)
            {
                return ClsprocesoMantenimiento.MostrarUsuario(objmostrarusuario);
            }

            public static void ActualizacionDeUsuarios(Clsentidadusuario objactusuario)
            {
                ClsprocesoMantenimiento actualizarusuarios = new ClsprocesoMantenimiento();
                actualizarusuarios.ActualizarUsuarios(objactusuario);
            }

            public static void EliminacionDeUsuarios(Clsentidadusuario objeliusuario)
            {
                ClsprocesoMantenimiento eliminarusuarios = new ClsprocesoMantenimiento();
                eliminarusuarios.EliminarUsuarios(objeliusuario);
            }
        #endregion
        #region "Negocio Listado"
            public static DataTable ListadoDeAutores(Clsentidadautor objlistadeautor)
            {
                return ClsprocesoMantenimiento.ListaAutores(objlistadeautor);
            }

            public static DataTable ListadoDeEditoriales(ClsentidadEditorial objlistaeditorial)
            {
                return ClsprocesoMantenimiento.ListaEditoriales(objlistaeditorial);
            }

            public static DataTable ListadoDeImprenta(Clsentidadimprenta objlistaimprenta)
            {
                return ClsprocesoMantenimiento.ListadoImprenta(objlistaimprenta);
            }

            public static DataTable ListadoDeIdiomas(ClsentidadIdioma objlistaidioma)
            {
                return ClsprocesoMantenimiento.ListadoIdiomas(objlistaidioma);
            }

            public static DataTable ListadoDePais(ClsentidadPais objlistapais)
            {
                return ClsprocesoMantenimiento.ListadoPais(objlistapais);
            }
        #endregion

        #region "Negocio Mantenimiento de Libros"

            public static String CodigoGeneraLibros(ClsentidadLibro objgeneralibro)
            {
                return ClsprocesoMantenimiento.CodigoAutogeneradoLibros(objgeneralibro);
            }
            
            public static DataTable ListadoDeLibros(ClsentidadLibro objlistalibro)
            {
                return ClsprocesoMantenimiento.ListadoLibros(objlistalibro);
            }

            public static DataTable BusCodLibro(ClsentidadLibro objbuslibro)
            {
                return ClsprocesoMantenimiento.BusquedaCodLibro(objbuslibro);
            }

            public static DataTable ImprimirLibro(ClsentidadLibro objimplibro)
            {
                return ClsprocesoMantenimiento.BusMostrarLibro(objimplibro);
            }

            public static void RegistroDeLibros(ClsentidadLibro objreglibro)
            {
                ClsprocesoMantenimiento insertarlibro = new ClsprocesoMantenimiento();
                insertarlibro.RegistrarLibros(objreglibro);
            }

            public static void ActualizacionDeLibros(ClsentidadLibro objactlibro)
            {
                ClsprocesoMantenimiento actualizarlibro = new ClsprocesoMantenimiento();
                actualizarlibro.ActualizarLibros(objactlibro);
            }

            public static void EliminacionDeLibros(ClsentidadLibro objelilibro)
            {
                ClsprocesoMantenimiento eliminarlibro = new ClsprocesoMantenimiento();
                eliminarlibro.EliminarLibros(objelilibro);
            }
        #endregion
    }
}
