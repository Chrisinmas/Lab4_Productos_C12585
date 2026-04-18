// Controllers/ProductosController.cs
using Lab4_Productos_C12585.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab4_Productos_C12585.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ProductoRepositorio _repositorio = new();

        public IActionResult Index()
        {
            var productos = _repositorio.ObtenerTodos();
            return View(productos);
        }

        public IActionResult Detalles(int id)
        {
            var producto = _repositorio.ObtenerPorId(id);
            if (producto == null) return NotFound();

            return View(producto);
        }

        public IActionResult Crear() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Producto producto)
        {
            if (!ModelState.IsValid) return View(producto);

            _repositorio.Agregar(producto);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Editar(int id)
        {
            var producto = _repositorio.ObtenerPorId(id);
            if (producto == null) return NotFound();

            return View(producto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Producto producto)
        {
            if (!ModelState.IsValid) return View(producto);

            _repositorio.Actualizar(producto);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Eliminar(int id)
        {
            var producto = _repositorio.ObtenerPorId(id);
            if (producto == null) return NotFound();

            return View(producto);
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public IActionResult EliminarConfirmado(int id)
        {
            _repositorio.Eliminar(id);
            return RedirectToAction(nameof(Index));
        }
    }
}