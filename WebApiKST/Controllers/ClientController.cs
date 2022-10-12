using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiKST.Domain.Entities;
using WebApiKST.Domain.Entities.cliente;
using WebApiKST.Domain.Service;

namespace WebApiKST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpPost("SearchClient")]
        public ActionResult<IEnumerable<ClienteDTO>> getSearchProduct(SearchClienteDTO entidad)
        {
            
            var lst = new ClientService().getSearchCliente(entidad);
            return Ok(lst);
        }
        [HttpPost("InsertClient")]
        public ActionResult<ApiResponseDTO> InsertClient(ClienteDTO entidad)
        {

            var lst = new ClientService().InsertClient(entidad);
            return Ok(lst);
        }
        [HttpPost("InsertClientDirec")]
        public ActionResult<ApiResponseDTO> InsertClientDirec(ClienteDireDTO entidad)
        {

            var lst = new ClientService().InsertDireccionCliente(entidad);
            return Ok(lst);
        }
        [HttpPost("UpdateClient")]
        public ActionResult<ApiResponseDTO> UpdateClient(ClienteDTO entidad)
        {

            var lst = new ClientService().UpdateClient(entidad);
            return Ok(lst);
        }

        [HttpGet("getTipoDocumento")]
        public ActionResult<IEnumerable<TipoDocumentoDTO>> getTipoDocumento()
        {

            var lst = new ClientService().getTipoDocumento();
            return Ok(lst);
        }
        [HttpGet("getDepartamento")]
        public ActionResult<IEnumerable<DepartamentoDTO>> getDepartamento()
        {

            var lst = new ClientService().getDepartamento();
            return Ok(lst);
        }
        [HttpGet("getProvincia")]
        public ActionResult<IEnumerable<ProvinciaDTO>> getProvincia(int idDepa)
        {

            var lst = new ClientService().getProvincia(idDepa);
            return Ok(lst);
        }
        [HttpGet("getDistrito")]
        public ActionResult<IEnumerable<DistritoDTO>> getDistrito(int idProv)
        {
            var lst = new ClientService().getDistrito(idProv);
            return Ok(lst);
        }
        [HttpPost("GetSuscripciones")]
        public ActionResult<IEnumerable<ClienteSubcripcionesDTO>> GetSuscripciones(SearchClienteSubcripcionesDTO entidad)
        {

            var lst = new ClientService().GetSuscripciones(entidad);
            return Ok(lst);
        }

        [HttpPost("RegisterSubscripcion")]
        public ActionResult<ApiResponseDTO> RegisterSubscripcion(ClienteSubcripcionesDTO entidad)
        {

            var lst = new ClientService().RegisterSubscripcion(entidad);
            return Ok(lst);
        }
    }
}
