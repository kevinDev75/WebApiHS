using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiKST.Domain.Entities.Coleccion
{
    public class ProductoDTO
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
        public Int32 id_editorial { get; set; }
        public string estado { get; set; }
        public string fch_lanzamiento { get; set; }
        public int valoracion { get; set; }
        public Int32 id_formato { get; set; }
        public Int32 id_coleccion { get; set; }
        public string descColeccion { get; set; }
        public Int32 idformato { get; set; }
        public string desc_formato { get; set; }
        public Int32 idDemografia { get; set; }
        public string descDemografia { get; set; }
        public Int32 idAutor { get; set; }
        public string descAutor { get; set; }
        public string rutaImg { get; set; }



    }
}
