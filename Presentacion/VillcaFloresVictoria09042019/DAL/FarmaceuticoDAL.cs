using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL
{
	class FarmaceuticoDAL : AbstractDAL
	{
		#region
		public Farmaceutico far { get; set; }
		public FarmaceuticoDAL()
		{

		}
		public FarmaceuticoDAL( Farmaceutico far)
		{
			this.far = far;
		}
		#endregion
		public override void Delete()
		{
			throw new NotImplementedException();
		}

		public override void Insert()
		{

			string query = @"insert into cliente(Nombre,PrimerApellido,SegundoApellido,Direccion,Telefono)
                              values(@Nombre, @PrimerApellido, @SegundoApellido, @Direccion, @Telefono)";


			SqlCommand cmd;
			try
			{
				cmd = Methods.CreateBasicCommand(query);
				cmd.Parameters.AddWithValue("@Nombre", client.Nombre);
				cmd.Parameters.AddWithValue("@PrimerApellido", client.PrimerApellido);
				cmd.Parameters.AddWithValue("@SegundoApellido", client.SegundoApellido);
				cmd.Parameters.AddWithValue("@Direccion", client.Direccion);
				cmd.Parameters.AddWithValue("@Telefono", client.Telefono);

				Methods.ExecuteBasicComand(cmd);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public override DataTable Select()
		{
			throw new NotImplementedException();
		}

		public override void Update()
		{
			throw new NotImplementedException();
		}
	}
}
