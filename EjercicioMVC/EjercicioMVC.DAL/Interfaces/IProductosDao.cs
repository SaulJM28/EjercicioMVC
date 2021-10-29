using System.Collections.Generic;

namespace EjercicioMVC.DAL
{
    public interface IProductosDao
    {
        List<ProductosDto> GetProductos();
        ProductosDto GetProductosById(int id);
    }
}
