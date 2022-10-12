using System;
using System.Collections.Generic;
using System.Text;
using WebApiKST.Domain.Entities;
using WebApiKST.Domain.Entities.cliente;
using WebApiKST.infrastructure.Data;

namespace WebApiKST.Domain.Service
{
    public class ClientService
    {
        public List<ClienteDTO> getSearchCliente(SearchClienteDTO search)
        {
            return new ClientRepository().getSearchCliente(search);
        }
        public List<TipoDocumentoDTO> getTipoDocumento()
        {
            return new ClientRepository().getTipoDocumento();
        }
        public List<ClienteSubcripcionesDTO> GetSuscripciones(SearchClienteSubcripcionesDTO dt)
        {
            return new ClientRepository().GetSuscripciones(dt);
        }
        public List<DepartamentoDTO> getDepartamento()
        {
            return new ClientRepository().getDepartamento();
        }
        public ApiResponseDTO RegisterSubscripcion(ClienteSubcripcionesDTO dt)
        {
            return new ClientRepository().RegisterSubscripcion(dt);
        }
        
        public List<ProvinciaDTO> getProvincia(int idDepa)
        {
            return new ClientRepository().getProvincia(idDepa);
        }
        public List<DistritoDTO> getDistrito(int idProv)
        {
            return new ClientRepository().getDistrito(idProv);
        }
        public ApiResponseDTO InsertClient(ClienteDTO dt)
        {
            return new ClientRepository().InsertClient(dt);
        }
        public ApiResponseDTO InsertDireccionCliente(ClienteDireDTO dt)
        {
            return new ClientRepository().InsertDireccionCliente(dt);
        }
        public ApiResponseDTO UpdateClient(ClienteDTO dt)
        {
            return new ClientRepository().UpdateClient(dt);
        }


    }
}
