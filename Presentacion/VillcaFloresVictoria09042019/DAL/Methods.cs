using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
public	  class Methods
	{

		#region Atributos
		static string cadenaConexion = "server=localhost;database=farmacia;Uid=root;pwd=;Port=33065";
		static SqlConnection conexion;
		#endregion

		#region Metodos de Creacion de comandos
		public static SqlCommand CreateBasicComand()
		{
			conexion = new SqlConnection(cadenaConexion);
			SqlCommand res = new SqlCommand();
			res.Connection = conexion;
			return res;
		}
		public static SqlCommand CreateBasicCommand(string query)
		{
			conexion = new SqlConnection(cadenaConexion);
			SqlCommand res = new SqlCommand(query);
			res.Connection = conexion;
			return res;

		}


		#region Ejecucion de Metodos
		public static void ExecuteBasicComand(SqlCommand cmd)
		{
			try
			{
				cmd.Connection.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				cmd.Connection.Close();
			}
		}


		//llenar a dataTable


		public static string ExecuteScalarCommand(SqlCommand cmd)
		{
			string res = null;
			try
			{
				cmd.Connection.Open();
				res = cmd.ExecuteScalar().ToString();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				cmd.Connection.Close();
			}
			return res;
		}

		#endregion



		/// <summary>
		/// es necesario cerrar la conexion desde el metodo que sea utilizado
		/// </summary>
		/// <param name="cmd"></param>
		/// <returns></returns>
		public static SqlDataReader ExecuteDataReaderCommand(SqlCommand cmd)
		{
			SqlDataReader res = null;
			try
			{
				cmd.Connection.Open();
				res = cmd.ExecuteReader();
			}
			catch (Exception ex)
			{

				throw ex;
			}

			return res;
		}

		#endregion
	}


}
    
	

