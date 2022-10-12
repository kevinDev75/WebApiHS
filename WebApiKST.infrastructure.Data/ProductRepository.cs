using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WebApiKST.Domain.Entities;
using WebApiKST.Domain.Entities.Coleccion;

namespace WebApiKST.infrastructure.Data
{
    public class ProductRepository
    {
        // public static string constr = "server=108.167.181.190;user=atahost_user_des;database=atahost_kstStore;port=3306;password=kst753";
        public static string constr = "server=localhost;user=root;database=databasekst;port=3306;password=admin";
        public string rutaDefecto = @"assets\images\Mangas\";

        public ApiResponseDTO RegisterProduct(ProductoDTO _objRegister)
        {
            int pcode = 1;
            string pmessage = "";
            ApiResponseDTO resp = new ApiResponseDTO();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_INSERT_PRODUCT", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@isbn", _objRegister.isbn);
                        cmd.Parameters["@isbn"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@precio", _objRegister.precio);
                        cmd.Parameters["@precio"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@titulo", _objRegister.titulo);
                        cmd.Parameters["@titulo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@paginas", _objRegister.paginas);
                        cmd.Parameters["@paginas"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@tamanho", _objRegister.tamanio);
                        cmd.Parameters["@tamanho"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@resenha", _objRegister.resenia);
                        cmd.Parameters["@resenha"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@foto", _objRegister.foto);
                        cmd.Parameters["@foto"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@tipo", _objRegister.tipo);
                        cmd.Parameters["@tipo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@id_editorial", _objRegister.id_editorial);
                        cmd.Parameters["@id_editorial"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@estado", _objRegister.estado);
                        cmd.Parameters["@estado"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@fch_lanzamiento", Convert.ToDateTime(_objRegister.fch_lanzamiento));
                        cmd.Parameters["@fch_lanzamiento"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@valoracion", _objRegister.valoracion);
                        cmd.Parameters["@valoracion"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@id_formato", _objRegister.idformato);
                        cmd.Parameters["@id_formato"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@id_colecion", _objRegister.id_coleccion);
                        cmd.Parameters["@id_colecion"].Direction = ParameterDirection.Input;

                    

                        cmd.Parameters.AddWithValue("@pcode", pcode);
                        cmd.Parameters["@pcode"].Direction = ParameterDirection.Output;

                        cmd.Parameters.AddWithValue("@pmessage",pmessage);
                        cmd.Parameters["@pmessage"].Direction = ParameterDirection.Output;

                        con.Open();
                        var ex = cmd.ExecuteNonQuery();
                        if(ex != -1)
                        {
                            resp.pcode =  Int32.Parse(cmd.Parameters["@pcode"].Value.ToString());
                            resp.pmessage= cmd.Parameters["@pmessage"].Value.ToString();
                        }
                        else
                        {
                            resp.pcode = 1;
                            resp.pmessage = "Error al registrar producto";
                        }

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                resp.pmessage = ex.Message;
                resp.pcode = 1;
            }
            return resp;

        }

      
        public ApiResponseDTO UpdateProduct(ProductoDTO _objRegister)
        {
            int pcode = 1;
            string pmessage = "";
            ApiResponseDTO resp = new ApiResponseDTO();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_UPDATE_PRODUCT", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", _objRegister.id_prod);
                        cmd.Parameters["@id"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@isbn", _objRegister.isbn);
                        cmd.Parameters["@isbn"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@precio", _objRegister.precio);
                        cmd.Parameters["@precio"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@titulo", _objRegister.titulo);
                        cmd.Parameters["@titulo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@paginas", _objRegister.paginas);
                        cmd.Parameters["@paginas"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@tamanho", _objRegister.tamanio);
                        cmd.Parameters["@tamanho"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@resenha", _objRegister.resenia);
                        cmd.Parameters["@resenha"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@foto", _objRegister.foto);
                        cmd.Parameters["@foto"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@tipo", _objRegister.tipo);
                        cmd.Parameters["@tipo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@id_editorial", _objRegister.id_editorial);
                        cmd.Parameters["@id_editorial"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@estado", _objRegister.estado);
                        cmd.Parameters["@estado"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@fch_lanzamiento", Convert.ToDateTime(_objRegister.fch_lanzamiento));
                        cmd.Parameters["@fch_lanzamiento"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@valoracion", _objRegister.valoracion);
                        cmd.Parameters["@valoracion"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@id_formato", _objRegister.idformato);
                        cmd.Parameters["@id_formato"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@id_colecion", _objRegister.id_coleccion);
                        cmd.Parameters["@id_colecion"].Direction = ParameterDirection.Input;



                        cmd.Parameters.AddWithValue("@pcode", pcode);
                        cmd.Parameters["@pcode"].Direction = ParameterDirection.Output;

                        cmd.Parameters.AddWithValue("@pmessage", pmessage);
                        cmd.Parameters["@pmessage"].Direction = ParameterDirection.Output;

                        con.Open();
                        var ex = cmd.ExecuteNonQuery();
                        if (ex != -1)
                        {
                            resp.pcode = Int32.Parse(cmd.Parameters["@pcode"].Value.ToString());
                            resp.pmessage = cmd.Parameters["@pmessage"].Value.ToString();
                        }
                        else
                        {
                            resp.pcode = 1;
                            resp.pmessage = "Error al actualizar el producto";
                        }

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                resp.pmessage = ex.Message;
                resp.pcode = 1;
            }
            return resp;

        }
        public List<ProductoDetailDTO> getProductDestacados()
        {   
            List<ProductoDetailDTO> resp = new List<ProductoDetailDTO>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_PRODUCT_POPU", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {
                                    ProductoDetailDTO item = new ProductoDetailDTO();
                                    item.editorial = new EditorialDTO();
                                    item.coleccion = new ColeccionDTO();
                                    item.autor = new AutorDTO();
                                    item.demografia = new DemografiaDTO();
                                    item.formato = new FormatoDTO();
                                    item.id_prod = (row["id"] != DBNull.Value ? row["id"].ToString() : string.Empty);
                                    item.isbn = (row["isbn"] != DBNull.Value ? row["isbn"].ToString() : string.Empty);
                                    item.precio = (row["precio"] != DBNull.Value ? Decimal.Parse(row["precio"].ToString()) : 0);
                                    item.titulo = (row["titulo"] != DBNull.Value ? row["titulo"].ToString() : string.Empty);
                                    item.paginas = (row["paginas"] != DBNull.Value ? row["paginas"].ToString() : string.Empty);
                                    item.tamanio = (row["tamanho"] != DBNull.Value ? row["tamanho"].ToString() : string.Empty);


                                    item.editorial.idEditorial = (row["id_editorial"] != DBNull.Value ? Int32.Parse(row["id_editorial"].ToString()) : 0);
                                    item.editorial.descEditorial = (row["desc_editorial"] != DBNull.Value ? row["desc_editorial"].ToString() : string.Empty);

                                    item.estado = (row["estado"] != DBNull.Value ? row["estado"].ToString() : string.Empty);
                                    item.fch_lanzamiento = (row["fch_lanzamiento"] != DBNull.Value ? row["fch_lanzamiento"].ToString() : string.Empty);
                                    item.valoracion = (row["valorizacion"] != DBNull.Value ? Int32.Parse(row["valorizacion"].ToString()) : 0);

                                    item.formato.idFormato = (row["idformato"] != DBNull.Value ? Int32.Parse(row["idformato"].ToString()) : 0);
                                    item.formato.DescFormato = (row["desc_formato"] != DBNull.Value ? row["desc_formato"].ToString() : string.Empty);

                                    item.coleccion.idColeccion = (row["idcoleccion"] != DBNull.Value ? Int32.Parse(row["idcoleccion"].ToString()) : 0);
                                    item.coleccion.descColeccion = (row["descColeccion"] != DBNull.Value ? row["descColeccion"].ToString() : string.Empty);
                                    item.coleccion.descripcion = (row["descripcion"] != DBNull.Value ? row["descripcion"].ToString() : string.Empty);

                                    item.demografia.idDemografia = (row["idDemografia"] != DBNull.Value ? Int32.Parse(row["idDemografia"].ToString()) : 0);
                                    item.demografia.descDemografia = (row["descDemografia"] != DBNull.Value ? row["descDemografia"].ToString() : string.Empty);

                                    item.autor.idAutor = (row["idAutor"] != DBNull.Value ? Int32.Parse(row["idAutor"].ToString()) : 0);
                                    item.autor.descAutor = (row["descAutor"] != DBNull.Value ? row["descAutor"].ToString() : string.Empty);


                                    item.resenia= (row["resenha"] != DBNull.Value ? row["resenha"].ToString() : string.Empty);
                                    item.foto= (row["foto"] != DBNull.Value ? row["foto"].ToString() : string.Empty);
                                    item.tipo= (row["tipo"] != DBNull.Value ? row["tipo"].ToString() : string.Empty);
                                    
                                    item.estado = (row["estado"] != DBNull.Value ? row["estado"].ToString() : string.Empty);
                                    item.fch_lanzamiento = (row["fch_lanzamiento"] != DBNull.Value ? row["fch_lanzamiento"].ToString() : string.Empty);
                                    item.valoracion = (row["valorizacion"] != DBNull.Value ? Int32.Parse(row["valorizacion"].ToString()) : 0);
                                    
                                    item.rutaImg = rutaDefecto + (row["ruta"] != DBNull.Value ? row["ruta"].ToString() : string.Empty);
                                    resp.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resp;
        }

        public List<EditorialDTO> getEditorial()
        {
            List<EditorialDTO> resp = new List<EditorialDTO>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_EDITORIAL", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {
                                    EditorialDTO item = new EditorialDTO();
                                    item.idEditorial = (row["id_editorial"] != DBNull.Value ? Int32.Parse(row["id_editorial"].ToString()) : 0);
                                    item.pais = (row["pais"] != DBNull.Value ? row["pais"].ToString() : string.Empty);
                                    item.descEditorial = (row["desc_editorial"] != DBNull.Value ? row["desc_editorial"].ToString() : string.Empty);
                                    item.referencia = (row["referencia"] != DBNull.Value ? row["referencia"].ToString() : string.Empty);
                                    item.porAdelanto = (row["porcAdelanto"] != DBNull.Value ? Int32.Parse(row["porcAdelanto"].ToString()) : 0);
                                    item.totalTomos = (row["totalTomos"] != DBNull.Value ? Int32.Parse(row["totalTomos"].ToString()) : 0);
                                    
                                    resp.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resp;

        }


        public List<FormatoDTO> getFormato()
        {

            List<FormatoDTO> resp = new List<FormatoDTO>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_FORMATO", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {
                                    FormatoDTO item = new FormatoDTO();
                                    item.idFormato = (row["idformato"] != DBNull.Value ? Int32.Parse(row["idformato"].ToString()) : 0);
                                    item.DescFormato = (row["desc_formato"] != DBNull.Value ? row["desc_formato"].ToString() : string.Empty);
                                    resp.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resp;

        }


        public List<ProductoDetailDTO> getSearchProduct(SearchProductDTO entidad)
        {
            List<ProductoDetailDTO> resp = new List<ProductoDetailDTO>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_SEARCH_PRODUCT", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@texto", entidad.texto);
                        cmd.Parameters["@texto"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@editorial", entidad.editorial);
                        cmd.Parameters["@editorial"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@demografia", entidad.demografia);
                        cmd.Parameters["@demografia"].Direction = ParameterDirection.Input;

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {
                                    ProductoDetailDTO item = new ProductoDetailDTO();
                                    item.editorial = new EditorialDTO();
                                    item.coleccion = new ColeccionDTO();
                                    item.autor = new AutorDTO();
                                    item.demografia = new DemografiaDTO();
                                    item.formato = new FormatoDTO();
                                    item.id_prod = (row["id"] != DBNull.Value ? row["id"].ToString() : string.Empty);
                                    item.isbn = (row["isbn"] != DBNull.Value ? row["isbn"].ToString() : string.Empty);
                                    item.precio = (row["precio"] != DBNull.Value ? Decimal.Parse(row["precio"].ToString()) : 0);
                                    item.titulo = (row["titulo"] != DBNull.Value ? row["titulo"].ToString() : string.Empty);
                                    item.paginas = (row["paginas"] != DBNull.Value ? row["paginas"].ToString() : string.Empty);
                                    item.tamanio = (row["tamanho"] != DBNull.Value ? row["tamanho"].ToString() : string.Empty);


                                    item.editorial.idEditorial = (row["id_editorial"] != DBNull.Value ? Int32.Parse(row["id_editorial"].ToString()) : 0);
                                    item.editorial.descEditorial = (row["desc_editorial"] != DBNull.Value ? row["desc_editorial"].ToString() : string.Empty);

                                    item.estado = (row["estado"] != DBNull.Value ? row["estado"].ToString() : string.Empty);
                                    item.fch_lanzamiento = (row["fch_lanzamiento"] != DBNull.Value ? row["fch_lanzamiento"].ToString() : string.Empty);
                                    item.valoracion = (row["valorizacion"] != DBNull.Value ? Int32.Parse(row["valorizacion"].ToString()) : 0);

                                    item.formato.idFormato = (row["idformato"] != DBNull.Value ? Int32.Parse(row["idformato"].ToString()) : 0);
                                    item.formato.DescFormato = (row["desc_formato"] != DBNull.Value ? row["desc_formato"].ToString() : string.Empty);

                                    item.coleccion.idColeccion = (row["idcoleccion"] != DBNull.Value ? Int32.Parse(row["idcoleccion"].ToString()) : 0);
                                    item.coleccion.descColeccion = (row["descColeccion"] != DBNull.Value ? row["descColeccion"].ToString() : string.Empty);
                                    item.coleccion.descripcion = (row["descripcion"] != DBNull.Value ? row["descripcion"].ToString() : string.Empty);

                                    item.demografia.idDemografia = (row["idDemografia"] != DBNull.Value ? Int32.Parse(row["idDemografia"].ToString()) : 0);
                                    item.demografia.descDemografia = (row["descDemografia"] != DBNull.Value ? row["descDemografia"].ToString() : string.Empty);

                                    item.autor.idAutor = (row["idAutor"] != DBNull.Value ? Int32.Parse(row["idAutor"].ToString()) : 0);
                                    item.autor.descAutor = (row["descAutor"] != DBNull.Value ? row["descAutor"].ToString() : string.Empty);


                                    item.resenia = (row["resenha"] != DBNull.Value ? row["resenha"].ToString() : string.Empty);
                                    item.foto = (row["foto"] != DBNull.Value ? row["foto"].ToString() : string.Empty);
                                    item.tipo = (row["tipo"] != DBNull.Value ? row["tipo"].ToString() : string.Empty);

                                    item.estado = (row["estado"] != DBNull.Value ? row["estado"].ToString() : string.Empty);
                                    item.fch_lanzamiento = (row["fch_lanzamiento"] != DBNull.Value ? row["fch_lanzamiento"].ToString() : string.Empty);
                                    item.valoracion = (row["valorizacion"] != DBNull.Value ? Int32.Parse(row["valorizacion"].ToString()) : 0);

                                    item.rutaImg = rutaDefecto + (row["ruta"] != DBNull.Value ? row["ruta"].ToString() : string.Empty);
                                    resp.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resp;
        }
        public List<DemografiaDTO> getDemografia()
        {
            
            List<DemografiaDTO> resp = new List<DemografiaDTO>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_DEMOGRAFIA", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {
                                    DemografiaDTO item = new DemografiaDTO();
                                    item.idDemografia = (row["idDemografia"] != DBNull.Value ? Int32.Parse(row["idDemografia"].ToString()) : 0);
                                    item.descDemografia = (row["descDemografia"] != DBNull.Value ? row["descDemografia"].ToString() : string.Empty);
                                    resp.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resp;

        }


        public List<ColeccionDTO> getColeccionSearch(ColeccionDTO entidad)
        {

            List<ColeccionDTO> resp = new List<ColeccionDTO>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_COLECCION_SEARCH", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@texto", entidad.descripcion);
                        cmd.Parameters["@texto"].Direction = ParameterDirection.Input;

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {
                                    ColeccionDTO item = new ColeccionDTO();
                                    item.idColeccion = (row["idcoleccion"] != DBNull.Value ? Int32.Parse(row["idcoleccion"].ToString()) : 0);
                                    item.descColeccion = (row["descColeccion"] != DBNull.Value ? row["descColeccion"].ToString() : string.Empty);
                                    item.idAutor = (row["idAutor"] != DBNull.Value ? Int32.Parse(row["idAutor"].ToString()) : 0);
                                    item.idDemografia = (row["idDemografia"] != DBNull.Value ? Int32.Parse(row["idDemografia"].ToString()) : 0);
                                    item.flgTerminado = (row["flgTerminado"] != DBNull.Value ? Int32.Parse(row["flgTerminado"].ToString()) : 0);
                                    item.CantTomos = (row["CantTomos"] != DBNull.Value ? Int32.Parse(row["CantTomos"].ToString()) : 0);
                                    resp.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resp;

        }




        public List<ColeccionDTO> getColeccion()
        {
            
            List<ColeccionDTO> resp = new List<ColeccionDTO>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_COLECCION", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //cmd.Parameters.AddWithValue("@P_ID_PAIS", idPais);
                        //cmd.Parameters["@P_ID_PAIS"].Direction = ParameterDirection.Input;

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                
                                foreach (DataRow row in dt.Rows)
                                {
                                    ColeccionDTO item = new ColeccionDTO();
                                    item.idColeccion = (row["idcoleccion"] != DBNull.Value ? Int32.Parse(row["idcoleccion"].ToString()) : 0);
                                    item.descColeccion = (row["descColeccion"] != DBNull.Value ? row["descColeccion"].ToString() : string.Empty);
                                    item.idAutor = (row["idAutor"] != DBNull.Value ? Int32.Parse(row["idAutor"].ToString()) : 0);
                                    item.idDemografia = (row["idDemografia"] != DBNull.Value ? Int32.Parse(row["idDemografia"].ToString()) : 0);
                                    item.flgTerminado = (row["flgTerminado"] != DBNull.Value ? Int32.Parse(row["flgTerminado"].ToString()) : 0);
                                    item.CantTomos = (row["CantTomos"] != DBNull.Value ? Int32.Parse(row["CantTomos"].ToString()) : 0);
                                    resp.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resp;

        }



        public ProductoDetailDTO getProductXID(int idProduct)
        {
            ProductoDetailDTO resp = new ProductoDetailDTO();
            resp.editorial = new EditorialDTO();
            resp.coleccion = new ColeccionDTO();
            resp.autor = new AutorDTO();
            resp.demografia = new DemografiaDTO();
            resp.formato = new FormatoDTO();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_X_ID_PRODUCT", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idProduct", idProduct);
                        cmd.Parameters["@idProduct"].Direction = ParameterDirection.Input;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {
                                    resp.id_prod = (row["id"] != DBNull.Value ? row["id"].ToString() : string.Empty);
                                    resp.isbn = (row["isbn"] != DBNull.Value ? row["isbn"].ToString() : string.Empty);
                                    resp.precio = (row["precio"] != DBNull.Value ? Decimal.Parse(row["precio"].ToString()) : 0);
                                    resp.titulo = (row["titulo"] != DBNull.Value ? row["titulo"].ToString() : string.Empty);
                                    resp.paginas = (row["paginas"] != DBNull.Value ? row["paginas"].ToString() : string.Empty);
                                    resp.tamanio = (row["tamanho"] != DBNull.Value ? row["tamanho"].ToString() : string.Empty);
                                    resp.resenia = (row["resenha"] != DBNull.Value ? row["resenha"].ToString() : string.Empty);
                                    resp.foto = (row["foto"] != DBNull.Value ? row["foto"].ToString() : string.Empty);
                                    resp.tipo = (row["tipo"] != DBNull.Value ? row["tipo"].ToString() : string.Empty);

                                    resp.editorial.idEditorial = (row["id_editorial"] != DBNull.Value ? Int32.Parse(row["id_editorial"].ToString()) : 0);
                                    resp.editorial.descEditorial = (row["desc_editorial"] != DBNull.Value ? row["desc_editorial"].ToString() : string.Empty);

                                    resp.estado = (row["estado"] != DBNull.Value ? row["estado"].ToString() : string.Empty);
                                    resp.fch_lanzamiento = (row["fch_lanzamiento"] != DBNull.Value ? row["fch_lanzamiento"].ToString() : string.Empty);
                                    resp.valoracion = (row["valorizacion"] != DBNull.Value ? Int32.Parse(row["valorizacion"].ToString()) : 0);

                                    resp.formato.idFormato = (row["idformato"] != DBNull.Value ? Int32.Parse(row["idformato"].ToString()) : 0);
                                    resp.formato.DescFormato = (row["desc_formato"] != DBNull.Value ? row["desc_formato"].ToString() : string.Empty);

                                    resp.coleccion.idColeccion= (row["idcoleccion"] != DBNull.Value ? Int32.Parse(row["idcoleccion"].ToString()) : 0);
                                    resp.coleccion.descColeccion = (row["descColeccion"] != DBNull.Value ? row["descColeccion"].ToString() : string.Empty);
                                    resp.coleccion.descripcion = (row["descripcion"] != DBNull.Value ? row["descripcion"].ToString() : string.Empty);
                                    
                                    resp.demografia.idDemografia = (row["idDemografia"] != DBNull.Value ? Int32.Parse(row["idDemografia"].ToString()) : 0);
                                    resp.demografia.descDemografia = (row["descDemografia"] != DBNull.Value ? row["descDemografia"].ToString() : string.Empty);

                                    resp.autor.idAutor = (row["idAutor"] != DBNull.Value ? Int32.Parse(row["idAutor"].ToString()) : 0);
                                    resp.autor.descAutor= (row["descAutor"] != DBNull.Value ? row["descAutor"].ToString() : string.Empty);

                                    
                                    resp.rutaImg = rutaDefecto + (row["ruta"] != DBNull.Value ? row["ruta"].ToString() : string.Empty);
                                   
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resp;
        }

    }
}
