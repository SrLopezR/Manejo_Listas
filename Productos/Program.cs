using System;
using System.Collections.Generic;
using System.Linq;

namespace Productos
{
    public struct Producto
    {
        public string Nombre, Codigo;
        public int Cantidad;
        public double Precio;

        public Producto(string nombre, string codigo, int cantidad, double precio)
        {
            Nombre = nombre;
            Codigo = codigo;
            Cantidad = cantidad;
            Precio = precio;
        }
    }

    public class Productos
    {
        private static List<Producto> productos = new List<Producto>();

        public static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("╔═══════ Productos ═══════╗");
                Console.WriteLine("║                         ║");
                Console.WriteLine("║  1. Nuevo Producto      ║");
                Console.WriteLine("║  2. Todos los Productos ║");
                Console.WriteLine("║  3. Modificar Producto  ║");
                Console.WriteLine("║  4. Eliminar Producto   ║");
                Console.WriteLine("║  5. Buscar Producto     ║");
                Console.WriteLine("║  6. Salir               ║");
                Console.WriteLine("║                         ║");
                Console.WriteLine("╚═════════════════════════╝");
                Console.Write("\nSeleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: AgregarProducto(); break;
                    case 2: LeerProductos(); break;
                    case 3: ActualizarProducto(); break;
                    case 4: EliminarProducto(); break;
                    case 5: BuscarProducto (); break;
                    case 6: break;
                    default: Console.Clear(); break;
                }
            } while (opcion != 6);
        }

        public static void AgregarProducto()
        {
            Console.Write("Ingrese el nombre del Producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el Codigo al que pertenece el producto: ");
            string codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto en stock: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio unitario del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Producto producto = new Producto(nombre, codigo, cantidad, precio);
            productos.Add(producto);  

            Console.WriteLine("Producto agregado exitosamente.");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void LeerProductos()
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos para mostrar.");
            }
            else
            {
                Console.WriteLine("\n\tProductos\n");
                foreach (var producto in productos)
                {
                    Console.WriteLine("──────────────────────────────────────────────────");
                    Console.WriteLine($"Nombre: {producto.Nombre}");
                    Console.WriteLine($"Codigo: {producto.Codigo}");
                    Console.WriteLine($"Cantidad: {producto.Cantidad} unds");
                    Console.WriteLine($"Precio unitario: ${producto.Precio}");
                    Console.WriteLine("──────────────────────────────────────────────────");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void EliminarProducto()
        {
            Console.Write("Ingrese el Nombre del Producto a eliminar: ");
            string search = Console.ReadLine();
            var producto = productos.FirstOrDefault(p => p.Nombre.ToLower() == search.ToLower());

            if (producto.Nombre != null)
            {
                productos.Remove(producto);
                Console.WriteLine("El Producto fue eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("El Producto no se ha encontrado.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ActualizarProducto()
        {
            Console.Write("Ingrese el nombre del Producto: ");
            string search = Console.ReadLine();
            var index = productos.FindIndex(p => p.Nombre.ToLower() == search.ToLower());

            if (index != -1)
            {
                Producto producto = productos[index];

                Console.Write("Ingrese el nuevo Codigo: ");
                producto.Codigo = Console.ReadLine();
                Console.Write("Ingrese la nueva cantidad: ");
                producto.Cantidad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nuevo precio: ");
                producto.Precio = double.Parse(Console.ReadLine());

                productos[index] = producto;  

                Console.WriteLine("El producto fue actualizado con éxito.");
            }
            else
            {
                Console.WriteLine("El producto no se ha encontrado.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void BuscarProducto()
        {
            Console.Write("Ingrese el nombre del Producto: ");
            string search = Console.ReadLine();
            var producto = productos.FirstOrDefault(p => p.Nombre.ToLower() == search.ToLower());

            if (producto.Nombre != null)
            {
                
                Console.WriteLine($"\n\tInformacion del producto buscado.\n");
                Console.WriteLine("──────────────────────────────────────────────────");
                Console.WriteLine($"Nombre: {producto.Nombre}\nCodigo: {producto.Codigo} \nCantidad: {producto.Cantidad} \nPrecio:{producto.Precio}");
                Console.WriteLine("──────────────────────────────────────────────────");
            }
            else
            {
                Console.WriteLine("El Producto no se ha encontrado.");
            }



            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
