using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiKST.Domain.Entities.cliente
{
    public class ClienteDireDTO
    {

        public int idCliente { get; set; }
        public int tipoDirec { get; set; }
        public string codigo { get; set; }
        public int idTipoDocu { get; set; }
        public string nombre { get; set; }
        public string apePat { get; set; }
        public string apeMat { get; set; }
        public string condicion { get; set; }
        public int celular { get; set; }
        public int estado { get; set; }
        public string direccion { get; set; }
        public string referencia { get; set; }
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }

        public string nroDocumento { get; set; }
        public string ClienteCol { get; set; }
    }
}
