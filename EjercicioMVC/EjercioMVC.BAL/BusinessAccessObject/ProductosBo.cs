using EjercicioMVC.DAL;
using System.Collections.Generic;

namespace EjercioMVC.BAL
{
    public class ProductosBo : IProductosBo
    {
        IProductosDao _productosDao;

        public ProductosBo(IProductosDao productosDao)
        {
            _productosDao = productosDao;
        }

        public List<ProductosDto> GetProductos()
        {
            List<ProductosDto> productosDtos = new List<ProductosDto>();
            //obtener los productos desde la capa de datos
            productosDtos = _productosDao.GetProductos();
            return productosDtos;
        }
    }
}
