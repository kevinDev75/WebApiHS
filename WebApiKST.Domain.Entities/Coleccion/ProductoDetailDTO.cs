using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiKST.Domain.Entities.Coleccion
{
     public class ProductoDetailDTO
    {

        public string id_prod { get; set; }
        public string isbn { get; set; }
        public decimal precio { get; set; }
        public string titulo { get; set; }
        public string paginas { get; set; }
        public string tamanio { get; set; }
        public string resenia { get; set; }
        public string foto { get; set; }
        public string tipo { get; set; }
        public EditorialDTO editorial { get; set; }
        public string estado { get; set; }
        public string fch_lanzamiento { get; set; }
        public int valoracion { get; set; }
        public FormatoDTO formato { get; set; }
        public ColeccionDTO coleccion { get; set; }
        public string referencia { get; set; }
        public DemografiaDTO demografia { get; set; }
        public AutorDTO autor { get; set; }
        public string rutaImg { get; set; }

    }
}
