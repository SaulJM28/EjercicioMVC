using EjercicioMVC.DAL;
using EjercioMVC.BAL;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EjercicioMVC.Controllers
{
    public class HomeController : Controller
    {
        public IProductosBo _productosBo;

        public HomeController(IProductosBo productosBo)
        {
            _productosBo = productosBo;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Lista de libros.";
            List<ProductosDto> productosDtos = _productosBo.GetProductos();
            return View(productosDtos);
        }
    }
}