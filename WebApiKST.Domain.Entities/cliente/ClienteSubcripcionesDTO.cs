using System;
using System.Collections.Generic;
using System.Text;
using WebApiKST.Domain.Entities.Coleccion;

namespace WebApiKST.Domain.Entities.cliente
{
    public class ClienteSubcripcionesDTO
    {
        public ClienteDTO cliente { get; set; }
        public string fecha_subcripcion { get; set; }
        public string fecha_salida { get; set; }
        public string flg_estado { get; set; }
        public string flg_wsp { get; set; }
        public string motivo { get; set; }
        public ColeccionDTO Coleccion { get; set; }
        public EditorialDTO editorial { get; set; }

    }
}
