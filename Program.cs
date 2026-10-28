using System;
using System.Collections.Generic;

namespace GestionProdusctos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE GESTION DE PRODUCTOS ===");
            Console.WriteLine();

            // Instancia del repositorio usando  la  interfaz
            IProductoRepository repo = new ProductoRepository();

            // 1. Mostrar todos los productos
            Console.WriteLine("--- Lista completa de productos ---");
            List<Producto> todos = repo.ObtenerTodos();
            MostrarLista(todos);

            // 2. Buscar por ID
            Console.WriteLine("\n--- Busqueda por ID (ID = 2) ---");
            Producto? prodBuscado = repo.ObtenerPorId(2);
            if (prodBuscado != null)
            {
                Console.WriteLine("Producto encontrado: " + prodBuscado.Nombre + " - Precio: $" + prodBuscado.Precio);
            }
            else
            {
                Console.WriteLine("No se encontro el producto.");
            }

            // 3. Filtrar por Categoria
            Console.WriteLine("\n--- Productos de la categoria 'Tecnologia' ---");
            List<Producto> tecnologia = repo.BuscarPorCategoria("Tecnologia");
            MostrarLista(tecnologia);

            // 4. Agregar un nuevo producto usando el constructor
            Console.WriteLine("\n--- Agregando un nuevo producto ---");
            Producto nuevo = new Producto(5, "Campera Impermeable", 80000m, "Equipamiento", true);

            repo.Agregar(nuevo);
            Console.WriteLine("¡Producto agregado correctamente!");

            // Mostrar la lista actualizada
            Console.WriteLine("\n--- Lista actualizada despues de agregar ---");
            List<Producto> listaActualizada = repo.ObtenerTodos();
            MostrarLista(listaActualizada);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Metodo auxiliar sencillo para imprimir listas por pantalla
        static void MostrarLista(List<Producto> productos)
        {
            foreach (Producto p in productos)
            {
                string estado = "";
                if (p.Activo == true)
                {
                    estado = "Si";
                }
                else
                {
                    estado = "No";
                }

                Console.WriteLine("ID: " + p.Id + " | Nombre: " + p.Nombre + " | Precio: $" + p.Precio + " | Categoria: " + p.Categoria + " | Activo: " + estado);
            }
        }
    }
}