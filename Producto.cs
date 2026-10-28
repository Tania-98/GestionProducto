using System;

namespace GestionProdusctos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public bool Activo { get; set; }

        // Constructor para inicializar las propiedades
        public Producto(int id, string nombre, decimal precio, string categoria, bool activo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Categoria = categoria;
            this.Activo = activo;
        }
    }
}