// Models/ProductoRepositorio.cs
namespace Lab4_Productos_C12585.Models
{
    public class ProductoRepositorio
    {
        private static List<Producto> _productos = new List<Producto>();
        private static int _contadorId = 1;

        public List<Producto> ObtenerTodos()
        {
            return _productos;
        }

        public Producto? ObtenerPorId(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public void Agregar(Producto producto)
        {
            producto.Id = _contadorId++;
            _productos.Add(producto);
        }

        public void Actualizar(Producto producto)
        {
            var indice = _productos.FindIndex(p => p.Id == producto.Id);
            if (indice >= 0)
                _productos[indice] = producto;
        }

        public void Eliminar(int id)
        {
            var producto = ObtenerPorId(id);
            if (producto != null)
                _productos.Remove(producto);
        }
    }
}