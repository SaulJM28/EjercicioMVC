using EjercicioMVC.DAL;
using System.Collections.Generic;

namespace EjercioMVC.BAL
{
    public interface IProductosBo
    {
        List<ProductosDto> GetProductos();
    }
}
