using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiKST.Domain.Entities.cliente
{
    public class ClienteDTO
    {
        public int idCliente { get; set; }
        public string codigo { get; set; }
        public int idTipoDocumento { get; set; }
        public string nombres { get; set; }
        public string ape_pat { get; set; }
        public string ape_mat { get; set; }
        public string nroDocumento { get; set; }
        public int idDepartamento { get; set;}
        public int idProvincia { get; set; }
        public int ubigeo { get; set; }
        public int condicion { get; set; }
        public int idcondicion { get; set; }
        public int celular { get; set; }
        public int fijo { get; set; }
        public string correo { get; set; }
        public string clienteCol { get; set; }
    }
}
