using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiKST.Domain.Entities.Coleccion
{
    public class EditorialDTO
    {
        public int idEditorial { get; set; }
        public string pais { get; set; }
        public string descEditorial { get; set; }
        public string referencia { get; set; }
        public int porAdelanto { get; set; }
        public int totalTomos { get; set; }


    }
}
