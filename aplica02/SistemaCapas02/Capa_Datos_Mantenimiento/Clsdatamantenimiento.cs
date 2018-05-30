using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capa_Entidad_Tipo_Usuario;
using System.Data.SqlClient;
using System.Data;
namespace Capa_Datos_Mantenimiento
{
    public class Clsdatamantenimiento
    {
        private SqlConnection cn = new SqlConnection("Server=(local);initial catalog=SISTEMALIBROS;user id=sa;pwd=soporte@123");
        #region "conexiones"
        public bool Conectar()
        {
            try
            {
                cn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Desconectar()
        {
            cn.Close();
        }

        #endregion
        #region "Operaciones"
        public String GeneraCodigo(String sentencia)
        {
            SqlDataAdapter adaptadorcodigo = new SqlDataAdapter();
            SqlParameter codigo;
            String xcodigogenera;
            adaptadorcodigo.SelectCommand = new SqlCommand(sentencia, cn);
            adaptadorcodigo.SelectCommand.CommandType = CommandType.StoredProcedure;
            codigo = new SqlParameter("@CODLIBRO", SqlDbType.Char, 7);
            //se declara que es un codigo de salida
            codigo.Direction = ParameterDirection.Output;
            adaptadorcodigo.SelectCommand.Parameters.Add(codigo);
            Conectar();
            adaptadorcodigo.SelectCommand.ExecuteNonQuery();
            Desconectar();
            xcodigogenera = adaptadorcodigo.SelectCommand.Parameters["@CODLIBRO"].Value.ToString();
            return xcodigogenera;
        }

        public String GeneraCodigoUsuario(String sentencia)
        {
            SqlDataAdapter adaptadorusuario = new SqlDataAdapter();
            SqlParameter codigousuario;
            String xcodigogenerausuario;
            adaptadorusuario.SelectCommand = new SqlCommand(sentencia, cn);
            adaptadorusuario.SelectCommand.CommandType = CommandType.StoredProcedure;
            codigousuario = new SqlParameter("@CODUSU", SqlDbType.Char, 7);
            //se declara que es un codigo de salida
            codigousuario.Direction = ParameterDirection.Output;
            adaptadorusuario.SelectCommand.Parameters.Add(codigousuario);
            Conectar();
            adaptadorusuario.SelectCommand.ExecuteNonQuery();
            Desconectar();
            xcodigogenerausuario = adaptadorusuario.SelectCommand.Parameters["@CODUSU"].Value.ToString();
            return xcodigogenerausuario;
        }

        public DataTable EjecutarListado(String sentencia)
        {
             SqlDataAdapter adaptadorlista = new SqlDataAdapter();
             adaptadorlista.SelectCommand = new SqlCommand(sentencia, cn);
             adaptadorlista.SelectCommand.CommandType = CommandType.StoredProcedure;
             DataSet resultadolista = new DataSet();
             adaptadorlista.Fill(resultadolista);
             return resultadolista.Tables[0];
        }
        
        public void EjecutarOperaciones(String sentencia, List<SqlParameter> parametros)
        {
             if (Conectar())
            {
                 SqlCommand comando = new SqlCommand(sentencia, cn);
                 comando.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter item in parametros)
                {
                    comando.Parameters.Add(item);
                }
                 comando.ExecuteNonQuery();
                 Desconectar();
            }
            else
            {
                throw new Exception("No Se Conecto A La Base De Datos");
            }
        }
        
        public DataTable EjecutarConsultas(String sentencia, List<SqlParameter> parametros)
        {
             SqlDataAdapter adaptador = new SqlDataAdapter();
             adaptador.SelectCommand = new SqlCommand(sentencia, cn);
             adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
             foreach (SqlParameter item in parametros)
            {
                 adaptador.SelectCommand.Parameters.Add(item);
            }
            DataSet resultado = new DataSet();
            adaptador.Fill(resultado);
            return resultado.Tables[0];
        }
        #endregion
    }
}
