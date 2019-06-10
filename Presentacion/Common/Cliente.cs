using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Cliente
    {
        #region ATRIBUTOS Y PROPIEDADES
        private int id_cliente;
        private string nombres;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private double credito;

        public double Credito
        {
            get { return credito; }
            set { credito = value; }
        }

        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        #endregion
    }
}
