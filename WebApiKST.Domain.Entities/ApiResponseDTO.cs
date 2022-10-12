using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiKST.Domain.Entities
{
    public class ApiResponseDTO
    {
     public int pcode { get; set; }
     public string pmessage { get; set; }
     public dynamic data { get; set; }

    }
}
