using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
public	class Farmaceutico
	{
		public int IdFarmaceutico { get; set; }
		public string  Nombre { get; set; }
		public string PrimerApellido { get; set; }
		public string SegundoApellido { get; set; }
		public string ci { get; set; }
		public string Sexo { get; set; }
		public int Edad { get; set; }
		public string  Direccion { get; set; }
		public int Telefono { get; set; }
		public byte estado { get; set; }
		public DateTime FechaRegistro { get; set; }
		public DateTime FechaActualizacion { get; set; }

		public Farmaceutico()
		{

		}
		/// <summary>
		/// constructor completo
		/// </summary>
		/// <param name="IdFarmaceutico"></param>
		/// <param name="Nombre"></param>
		/// <param name="SegundoApellido"></param>
		/// <param name="PrimerApellido"></param>
		/// <param name="ci"></param>
		/// <param name="Sexo"></param>
		/// <param name="Edad"></param>
		/// <param name="Direccion"></param>
		/// <param name="Telefono"></param>
		/// <param name="estado"></param>
		/// <param name="FechaRegistro"></param>
		/// /// <param name="FechaActualizacion"></param>
		public Farmaceutico(int IdFarmaceutico ,string  Nombre,	string SegundoApellido, string PrimerApellido, string ci ,string Sexo ,		int Edad,string  Direccion ,int Telefono,	byte estado ,	DateTime FechaRegistro, DateTime FechaActualizacion)
		{
			this.IdFarmaceutico=IdFarmaceutico;
		 this.Nombre=Nombre;
		 this.PrimerApellido=PrimerApellido;
		 this.SegundoApellido=SegundoApellido;
		 this.ci=ci;
		 this.Sexo=Sexo;
		 this.Edad=Edad;
		 this.Direccion=Direccion;
		 this.Telefono=Telefono;
	    this.estado=estado;
	    this.FechaRegistro = FechaRegistro;
			this.FechaActualizacion = FechaActualizacion;
		}
		/// <summary>
		/// constructor para el insert
		/// </summary>
		/// <param name="Nombre"></param>
		/// <param name="SegundoApellido"></param>
		/// <param name="PrimerApellido"></param>
		/// <param name="ci"></param>
		/// <param name="Sexo"></param>
		/// <param name="Edad"></param>
		/// <param name="Direccion"></param>
		/// <param name="Telefono"></param>
		/// <param name="FechaRegistro"></param

		public Farmaceutico( string Nombre, string SegundoApellido, string PrimerApellido,string ci, string Sexo, int Edad, string Direccion, int Telefono,  DateTime FechaRegistro)
		{
			
			this.Nombre = Nombre;
			this.PrimerApellido = PrimerApellido;
			this.SegundoApellido = SegundoApellido;
			this.ci = ci;
			this.Sexo = Sexo;
			this.Edad = Edad;
			this.Direccion = Direccion;
			this.Telefono = Telefono;
			this.FechaRegistro = FechaRegistro;
		
		

		}
	}
}
