using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ClienteDAL : AbstractDAL
    {
        MySqlCommand cmd;
        Cliente cli;

        public Cliente Cli
        {
            get { return cli; }
            set { cli = value; }
        }
        public ClienteDAL(Cliente cli)
        {
            this.cli = cli;
        }
        public override void Insert()
        {
            string query = "insert into cliente(nombres, apellido_paterno,apellido_materno,credito)values(@nombres, @apellido_paterno,@apellido_materno,@credito) ";
            MySqlCommand  cmd= Methods.CreateBasiCommand(query);
            cmd.Parameters.AddWithValue("@nombres", cli.Nombres);
            cmd.Parameters.AddWithValue("@apellido_paterno",cli.ApellidoPaterno);
            cmd.Parameters.AddWithValue("@apellido_materno",cli.ApellidoMaterno);
             cmd.Parameters.AddWithValue("@credito",cli.Credito);
             Methods.EjecutarComandoBasico(cmd);

        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override System.Data.DataTable Select()
        {
            throw new NotImplementedException();
        }
    }
}
