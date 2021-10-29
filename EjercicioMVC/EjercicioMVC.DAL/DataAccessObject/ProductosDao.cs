using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace EjercicioMVC.DAL
{
    public class ProductosDao : IProductosDao
    {
        public List<ProductosDto> GetProductos()
        {
            List<ProductosDto> productosDtos = new List<ProductosDto>();

            try
            {
                //obteniendo productos de la base de datos
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringCon"].ToString()))
                {
                    con.Open();

                    string queryCode = "SELECT * FROM libros";

                    SqlCommand query = new SqlCommand(queryCode, con);
                    using (var dr = query.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //se crear un objeto para que contenga los datos que queremos de la base de datos    
                            ProductosDto productosDto = new ProductosDto();
                            productosDto.id = Convert.ToInt32(dr["id_lib"]);
                            productosDto.titulo = dr["titulo"].ToString();
                            productosDto.autor = dr["autor"].ToString();
                            productosDto.año_pub = dr["año_pub"].ToString();
                            productosDto.editorial = dr["editorial"].ToString();

                            //se llena el objeto con los datos extraidos de la base de datos
                            productosDtos.Add(productosDto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }

            return productosDtos;
        }

        public ProductosDto GetProductosById(int id)
        {
            ProductosDto productosDto = new ProductosDto();
            //obtener el producto de la base de datos
            return productosDto;
        }


    }
}
