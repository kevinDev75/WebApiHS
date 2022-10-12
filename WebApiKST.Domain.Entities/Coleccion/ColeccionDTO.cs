using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiKST.Domain.Entities.Coleccion
{
    public class ColeccionDTO
    {
        public int idColeccion { get; set; }
        public string descColeccion { get; set; }
        public int idDemografia { get; set; }
        public int idAutor { get; set; }
        public int flgTerminado { get; set; }
        public string descripcion { get; set; }
        public int CantTomos { get; set; }



    }
}
