using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WebApiKST.Domain.Entities;
using WebApiKST.Domain.Entities.cliente;
using WebApiKST.Domain.Entities.Coleccion;

namespace WebApiKST.infrastructure.Data
{
    public class ClientRepository
    {
        public static string constr = "server=localhost;user=root;database=databasekst;port=3306;password=admin";
        public string rutaDefecto = @"assets\images\Mangas\";


        public ApiResponseDTO UpdateClient(ClienteDTO _objRegister)
        {
            int pcode = 1;
            string pmessage = "";
            ApiResponseDTO resp = new ApiResponseDTO();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_UPDATE_CLIENTES", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", _objRegister.idCliente);
                        cmd.Parameters["@id"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@codigo", _objRegister.codigo);
                        cmd.Parameters["@codigo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@id_tipodocumento", _objRegister.idTipoDocumento);
                        cmd.Parameters["@codigo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@nombres", _objRegister.nombres);
                        cmd.Parameters["@nombres"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@ape_pat", _objRegister.ape_pat);
                        cmd.Parameters["@ape_pat"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@ape_mat", _objRegister.ape_mat);
                        cmd.Parameters["@ape_mat"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@ubigeo", _objRegister.ubigeo);
                        cmd.Parameters["@ubigeo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@idcondicion", _objRegister.idcondicion);
                        cmd.Parameters["@idcondicion"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@celular", _objRegister.celular);
                        cmd.Parameters["@celular"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@fijo", _objRegister.fijo);
                        cmd.Parameters["@fijo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@correo", _objRegister.correo);
                        cmd.Parameters["@correo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@numDocumento", _objRegister.nroDocumento);
                        cmd.Parameters["@numDocumento"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@clientecol", _objRegister.clienteCol);
                        cmd.Parameters["@clientecol"].Direction = ParameterDirection.Input;

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
                            resp.pmessage = "Error al actualizar cliente";
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


        public ApiResponseDTO InsertDireccionCliente(ClienteDireDTO _objRegister) {

            int pcode = 1;
            string pmessage = "";
            ApiResponseDTO resp = new ApiResponseDTO();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_INSERT_CLIENTES_DIREC", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigo", _objRegister.codigo);
                        cmd.Parameters["@codigo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@tipodireccion", _objRegister.tipoDirec);
                        cmd.Parameters["@tipodireccion"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@direccion", _objRegister.direccion);
                        cmd.Parameters["@direccion"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@referencia", _objRegister.referencia);
                        cmd.Parameters["@referencia"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@departamento", _objRegister.departamento);
                        cmd.Parameters["@departamento"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@provincia", _objRegister.provincia);
                        cmd.Parameters["@provincia"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@distrito", _objRegister.distrito);
                        cmd.Parameters["@distrito"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@estado", _objRegister.estado);
                        cmd.Parameters["@estado"].Direction = ParameterDirection.Input;

                    

                        cmd.Parameters.AddWithValue("@pcode", pcode);
                        cmd.Parameters["@pcode"].Direction = ParameterDirection.Output;

                        cmd.Parameters.AddWithValue("@pmessage", pmessage);
                        cmd.Parameters["@pmessage"].Direction = ParameterDirection.Output;

                        con.Open();
                        var ex = cmd.ExecuteNonQuery();
                        if (ex != -1)
                        {
                            resp.pcode = Int32.Parse((cmd.Parameters["@pcode"].Value.ToString()) == string.Empty ? "0" : cmd.Parameters["@pcode"].Value.ToString());
                            resp.pmessage = cmd.Parameters["@pmessage"].Value.ToString();
                        }
                        else
                        {
                            resp.pcode = 1;
                            resp.pmessage = "Error al registrar cliente";
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
        public ApiResponseDTO InsertClient(ClienteDTO _objRegister)
        {
            int pcode = 1;
            string pmessage = "";
            ApiResponseDTO resp = new ApiResponseDTO();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_INSERT_CLIENTES", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigo", _objRegister.codigo);
                        cmd.Parameters["@codigo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@id_tipodocumento", _objRegister.idTipoDocumento);
                        cmd.Parameters["@id_tipodocumento"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@nombres", _objRegister.nombres);
                        cmd.Parameters["@nombres"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@ape_pat", _objRegister.ape_pat);
                        cmd.Parameters["@ape_pat"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@ape_mat", _objRegister.ape_mat);
                        cmd.Parameters["@ape_mat"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@ubigeo", _objRegister.ubigeo);
                        cmd.Parameters["@ubigeo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@idcondicion", _objRegister.idcondicion);
                        cmd.Parameters["@idcondicion"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@celular", _objRegister.celular);
                        cmd.Parameters["@celular"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@fijo", _objRegister.fijo);
                        cmd.Parameters["@fijo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@correo", _objRegister.correo);
                        cmd.Parameters["@correo"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@numDocumento", _objRegister.nroDocumento);
                        cmd.Parameters["@numDocumento"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@clientecol", _objRegister.clienteCol);
                        cmd.Parameters["@clientecol"].Direction = ParameterDirection.Input;

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
                            resp.pmessage = "Error al registrar cliente";
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




        public List<ClienteDTO> getSearchCliente(SearchClienteDTO entidad)
        {
            List<ClienteDTO> resp = new List<ClienteDTO>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_SEARCH_CLIENTES", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigo", entidad.codigo);
                        cmd.Parameters["@codigo"].Direction = ParameterDirection.Input;


                        cmd.Parameters.AddWithValue("@texto", entidad.nombre);
                        cmd.Parameters["@texto"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@idDocument", entidad.idTipoDocumento);
                        cmd.Parameters["@idDocument"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@nroDocumento", entidad.nrodocumento);
                        cmd.Parameters["@nroDocumento"].Direction = ParameterDirection.Input;

                        

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {
                                    ClienteDTO item = new ClienteDTO();
                                    
                                    item.idTipoDocumento = (row["id_tipodocumento"] != DBNull.Value ? Int32.Parse(row["id_tipodocumento"].ToString()) : 0);
                                    item.codigo = (row["codigo"] != DBNull.Value ? row["codigo"].ToString() : string.Empty);
                                    item.idCliente = (row["idclient"] != DBNull.Value ? Int32.Parse(row["idclient"].ToString()) : 0);
                                    item.idDepartamento = (row["idDepa"] != DBNull.Value ? Int32.Parse(row["idDepa"].ToString()) : 0);
                                    item.idProvincia= (row["idProv"] != DBNull.Value ? Int32.Parse(row["idProv"].ToString()) : 0);
                                    item.nombres = (row["nombres"] != DBNull.Value ? row["nombres"].ToString() : string.Empty);
                                    item.ape_pat = (row["ape_pat"] != DBNull.Value ? row["ape_pat"].ToString() : string.Empty);
                                    item.ape_mat = (row["ape_mat"] != DBNull.Value ? row["ape_mat"].ToString() : string.Empty);
                                    item.ubigeo = (row["ubigeo"] != DBNull.Value ? Int32.Parse(row["ubigeo"].ToString()) : 0);
                                    item.condicion = (row["condicion_id_condicion"] != DBNull.Value ? Int32.Parse(row["condicion_id_condicion"].ToString()) : 0);
                                    item.celular = (row["celular"] != DBNull.Value ? Int32.Parse(row["celular"].ToString()) : 0);
                                    item.fijo = (row["fijo"] != DBNull.Value ? Int32.Parse(row["fijo"].ToString()) : 0);
                                    item.correo = (row["correo"] != DBNull.Value ? row["correo"].ToString() : string.Empty);
                                    item.nroDocumento = (row["num_documento"] != DBNull.Value ? row["num_documento"].ToString() : string.Empty);
                                    item.clienteCol = (row["clienteCol"] != DBNull.Value ? row["clienteCol"].ToString() : string.Empty);
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



        public List<ClienteSubcripcionesDTO> GetSuscripciones(SearchClienteSubcripcionesDTO entidad)
        {
            int pcode = 1;
            string pmessage = "";
           
            List<ClienteSubcripcionesDTO> resp = new List<ClienteSubcripcionesDTO>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_SUBSCRIPCIONES_X_COD", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigo", entidad.codigo);
                        cmd.Parameters["@codigo"].Direction = ParameterDirection.Input;


                        cmd.Parameters.AddWithValue("@pcode", pcode);
                        cmd.Parameters["@pcode"].Direction = ParameterDirection.Output;

                        cmd.Parameters.AddWithValue("@pmessage", pmessage);
                        cmd.Parameters["@pmessage"].Direction = ParameterDirection.Output;
                        



                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {
                                    ClienteSubcripcionesDTO item = new ClienteSubcripcionesDTO();
                                    item.cliente = new ClienteDTO();
                                    item.cliente.nombres = (row["nombres"] != DBNull.Value ? row["nombres"].ToString() : string.Empty);
                                    item.cliente.ape_mat = (row["ape_mat"] != DBNull.Value ? row["ape_mat"].ToString() : string.Empty);
                                    item.cliente.ape_pat = (row["ape_pat"] != DBNull.Value ? row["ape_pat"].ToString() : string.Empty);

                                   

                                    item.editorial = new EditorialDTO();
                                    item.editorial.descEditorial = (row["desc_editorial"] != DBNull.Value ? row["desc_editorial"].ToString() : string.Empty);
                                    item.editorial.idEditorial = (row["id_editorial"] != DBNull.Value ? Int32.Parse(row["id_editorial"].ToString()) : 0);

                                    item.Coleccion = new ColeccionDTO();
                                    item.Coleccion.idColeccion = (row["idcoleccion"] != DBNull.Value ? Int32.Parse(row["idcoleccion"].ToString()) : 0);
                                    item.Coleccion.descColeccion = (row["descColeccion"] != DBNull.Value ? row["descColeccion"].ToString() : string.Empty);  

                                    item.fecha_salida = (row["fecha_salida"] != DBNull.Value ? row["fecha_salida"].ToString() : string.Empty);
                                    item.fecha_subcripcion = (row["fecha_suscripcion"] != DBNull.Value ? row["fecha_suscripcion"].ToString() : string.Empty);
                                    item.flg_estado = (row["flgEstado"] != DBNull.Value ? row["flgEstado"].ToString() : string.Empty);
                                    item.flg_wsp = (row["flgWsp"] != DBNull.Value ? row["flgWsp"].ToString() : string.Empty);
                                    item.motivo= (row["Motivo_Baja"] != DBNull.Value ? row["Motivo_Baja"].ToString() : string.Empty);
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


        public List<DistritoDTO> getDistrito(int idProvincia)
        {


            List<DistritoDTO> resp = new List<DistritoDTO>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_DISTRITO", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idProv", idProvincia);
                        cmd.Parameters["@idProv"].Direction = ParameterDirection.Input;

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {
                                    DistritoDTO item = new DistritoDTO();
                                    item.idDist = (row["idDist"] != DBNull.Value ? Int32.Parse(row["idDist"].ToString()) : 0);
                                    item.idProv = (row["idProv"] != DBNull.Value ? Int32.Parse(row["idProv"].ToString()) : 0);
                                    item.distrito = (row["distrito"] != DBNull.Value ? row["distrito"].ToString() : string.Empty);
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

        public List<ProvinciaDTO> getProvincia(int idDepartamento)
        {


            List<ProvinciaDTO> resp = new List<ProvinciaDTO>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_PROVINCIA", con))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idDepa", idDepartamento);
                        cmd.Parameters["@idDepa"].Direction = ParameterDirection.Input;

                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {

                                foreach (DataRow row in dt.Rows)
                                {
                                    ProvinciaDTO item = new ProvinciaDTO();
                                    item.idDepa = (row["idDepa"] != DBNull.Value ? Int32.Parse(row["idDepa"].ToString()) : 0);
                                    item.idProv = (row["idProv"] != DBNull.Value ? Int32.Parse(row["idProv"].ToString()) : 0);
                                    item.provincia= (row["provincia"] != DBNull.Value ? row["provincia"].ToString() : string.Empty);
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

        public List<DepartamentoDTO> getDepartamento()
        {
            

            List<DepartamentoDTO> resp = new List<DepartamentoDTO>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_DEPARTAMENTO", con))
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
                                    DepartamentoDTO item = new DepartamentoDTO();
                                    item.idDepa = (row["idDepa"] != DBNull.Value ? Int32.Parse(row["idDepa"].ToString()) : 0);
                                    item.descDepa= (row["departamento"] != DBNull.Value ? row["departamento"].ToString() : string.Empty);
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


        public ApiResponseDTO RegisterSubscripcion(ClienteSubcripcionesDTO _objRegister)
        {
            int pcode = 1;
            string pmessage = "";
            ApiResponseDTO resp = new ApiResponseDTO();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_REGISTER_SUSPCRIPCION", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idClient", _objRegister.cliente.idCliente);
                        cmd.Parameters["@idClient"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@fecha_suscripcion", _objRegister.fecha_salida);
                        cmd.Parameters["@fecha_suscripcion"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@fecha_salida", Convert.ToDateTime(_objRegister.fecha_salida));
                        cmd.Parameters["@fecha_salida"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@flgEstado", _objRegister.flg_estado);
                        cmd.Parameters["@flgEstado"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@flgWsp", _objRegister.flg_wsp);
                        cmd.Parameters["@flgWsp"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@Motivo_Baja", _objRegister.motivo);
                        cmd.Parameters["@Motivo_Baja"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@idcoleccion", _objRegister.Coleccion.idColeccion);
                        cmd.Parameters["@idcoleccion"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@id_editorial", _objRegister.editorial.idEditorial);
                        cmd.Parameters["@id_editorial"].Direction = ParameterDirection.Input;

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
                            resp.pmessage = "Error al registrar la subscripcion";
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


        public List<TipoDocumentoDTO> getTipoDocumento()
        {

            List<TipoDocumentoDTO> resp = new List<TipoDocumentoDTO>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SP_LIST_TIP_DOCUMENTO", con))
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
                                    TipoDocumentoDTO item = new TipoDocumentoDTO();
                                    item.idTipoDocumento = (row["id_tipodocumento"] != DBNull.Value ? Int32.Parse(row["id_tipodocumento"].ToString()) : 0);
                                    item.descripcion = (row["descripcion"] != DBNull.Value ? row["descripcion"].ToString() : string.Empty);
                                   
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


    }
}
