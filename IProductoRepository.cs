using System.Collections.Generic;

namespace GestionProdusctos
{
    public interface IProductoRepository
    {
        void Agregar(Producto producto);
        List<Producto> ObtenerTodos();
        Producto? ObtenerPorId(int id); // Usamos ? porque puede devolver null si no lo encuentra
        List<Producto> BuscarPorCategoria(string categoria);
    }
}