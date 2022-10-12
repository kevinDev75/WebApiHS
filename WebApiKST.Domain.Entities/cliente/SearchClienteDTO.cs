using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiKST.Domain.Entities.cliente
{
    public class SearchClienteDTO
    {
        public int idTipoDocumento {get;set;}
        public string nrodocumento { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
    }
}
