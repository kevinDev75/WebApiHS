using System;
using System.Collections.Generic;
using System.Text;
using WebApiKST.Domain.Entities;
using WebApiKST.Domain.Entities.Coleccion;
using WebApiKST.infrastructure.Data;

namespace WebApiKST.Domain.Service
{
    public class ProductService
    {
        public List<ColeccionDTO> getColeccion()
        {
            return new ProductRepository().getColeccion();
        }
        public List<ProductoDetailDTO> getSearchProduct(SearchProductDTO entidad)
        {
            return new ProductRepository().getSearchProduct(entidad);
        }
        public List<ColeccionDTO> getColeccionSearch(ColeccionDTO entidad)
        {
            return new ProductRepository().getColeccionSearch(entidad);
        }
        public List<DemografiaDTO> getDemografia()
        {
            return new ProductRepository().getDemografia();
        }
        public List<FormatoDTO> getFormato()
        {
            return new ProductRepository().getFormato();
        }
        public List<EditorialDTO> getEditorial()
        {
            return new ProductRepository().getEditorial();
        }
        public ApiResponseDTO RegisterProduct(ProductoDTO _data)
        {
            return new ProductRepository().RegisterProduct(_data);
        }
        public ApiResponseDTO UpdateProduct(ProductoDTO _data)
        {
            return new ProductRepository().UpdateProduct(_data);
        }
        
        public List<ProductoDetailDTO> getProductDestacados()
        {
            return new ProductRepository().getProductDestacados();
        }
        public ProductoDetailDTO getProductXID(int id)
        {
            return new ProductRepository().getProductXID(id);
        }




    }
}
