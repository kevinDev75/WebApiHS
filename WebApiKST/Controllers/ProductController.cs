using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiKST.Domain.Entities;
using WebApiKST.Domain.Entities.Coleccion;
using WebApiKST.Domain.Service;

namespace WebApiKST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        

        [HttpGet("getProductDestacados")]
        public ActionResult<IEnumerable<ProductoDetailDTO>> getProductDestacados()
        {

            var dtColeccion = new ProductService().getProductDestacados();
            return Ok(dtColeccion);
        }

        [HttpPost("SearchProduct")]
        public ActionResult<IEnumerable<ProductoDetailDTO>> getSearchProduct(SearchProductDTO entidad)
        {

            var dtColeccion = new ProductService().getSearchProduct(entidad);
            return Ok(dtColeccion);
        }



        [HttpGet("getProductxID")]
        public ActionResult<ProductoDetailDTO> getProductXID(int idProduct)
        {

            var dtProduct = new ProductService().getProductXID(idProduct);
            return Ok(dtProduct);
        }
        


        [HttpGet("getColeccion")]
        public ActionResult<IEnumerable<ColeccionDTO>> getColeccion()
        {

            var dtColeccion = new ProductService().getColeccion();
            return Ok(dtColeccion);
        }
        [HttpPost("getColeccionSearch")]
        public ActionResult<IEnumerable<ColeccionDTO>> getColeccionSearch(ColeccionDTO dto)
        {

            var dtColeccion = new ProductService().getColeccionSearch(dto);
            return Ok(dtColeccion);
        }

        

        [HttpGet("getFormato")]
        public ActionResult<IEnumerable<ColeccionDTO>> getFormato()
        {

            var dtColeccion = new ProductService().getFormato();
            return Ok(dtColeccion);
        }

        [HttpGet("getDemografia")]
        public ActionResult<IEnumerable<ColeccionDTO>> getDemografia()
        {
            try
            {
                var dtDemografia = new ProductService().getDemografia();
                return Ok(dtDemografia);

            }catch(Exception ex)
            {
                return null;
            }   
        }

        [HttpGet("getEditorial")]
        public ActionResult<IEnumerable<ColeccionDTO>> getEditorial()
        {
            try
            {
                var dtDemografia = new ProductService().getEditorial();
                return Ok(dtDemografia);

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [HttpPost("RegisterProduct")]
        public ActionResult<ApiResponseDTO> RegisterProduct(ProductoDTO _data)
        {
            try
            {
                var dtresp = new ProductService().RegisterProduct(_data);
                return Ok(dtresp);

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [HttpPost("UpdateProduct")]
        public ActionResult<ApiResponseDTO> UpdateProduct(ProductoDTO _data)
        {
            try
            {
                var dtresp = new ProductService().UpdateProduct(_data);
                return Ok(dtresp);

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [HttpPost("DeleteProduct")]
        public ActionResult<ApiResponseDTO> DeleteProduct(ProductoDTO objproducto) 
        {
            try
            {
                var dtresp = new ProductService().DeleteProducto(objproducto);
                return Ok(dtresp);

            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
