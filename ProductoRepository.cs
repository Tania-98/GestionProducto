using System.Collections.Generic;
using System.Linq;

namespace GestionProdusctos
{
    public class ProductoRepository : IProductoRepository
    {
        private List<Producto> listaProductos;

        public ProductoRepository()
        {
            listaProductos = new List<Producto>();

            listaProductos.Add(new Producto(1, "Notebook Lenovo", 120000m, "Tecnologia", true));
            listaProductos.Add(new Producto(2, "Auriculares Bluetooth", 25000m, "Tecnologia", true));
            listaProductos.Add(new Producto(3, "Mochila Turística", 45000m, "Equipamiento", true));
            listaProductos.Add(new Producto(4, "Botella Térmica", 15000m, "Equipamiento", false));
        }

        public void Agregar(Producto producto)
        {
            listaProductos.Add(producto);
        }

        public List<Producto> ObtenerTodos()
        {
            return listaProductos;
        }

        public Producto? ObtenerPorId(int id)
        {
            Producto? encontrado = listaProductos.FirstOrDefault(p => p.Id == id);
            return encontrado;
        }

        public List<Producto> BuscarPorCategoria(string categoria)
        {
            List<Producto> filtrados = listaProductos.Where(p => p.Categoria == categoria).ToList();
            return filtrados;
        }
    }
}