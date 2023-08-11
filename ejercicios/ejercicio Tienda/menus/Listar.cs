using ejercicio_Tienda.clases;

namespace ejercicio_Tienda.menus
{
    public class Listar
    { 
        public Listar( ) {}

        public void listarCategorias(List<Categoria> categorias)
        { 
            Console.Clear();
            Console.WriteLine("LISTADO DE CATEGORIAS");
            Console.WriteLine("{0, -29} {1,10}","ID", "NOMBRE");
            foreach (var categoria in categorias)
            {
                Console.WriteLine("{0, -32} {1,7}",categoria.id, categoria.descripcion);
            }
            Console.ReadKey();
        }

        public void listarProductos(List<Producto> productos)
        {
            Console.Clear();
            Console.WriteLine("LISTADO DE PRODUCTOS");
            Console.WriteLine("{0, -29} {1,10} {2,10}","ID", "NOMBRE", "STOCK");
            foreach (var producto in productos)
            {
                Console.WriteLine("{0, -32} {1,7}",producto.codigo, producto.nombre, producto.stock);
            }
            Console.ReadKey(); 
        }

        public void totalInventario(List<Producto> productos)
        {
            Console.Clear();
            Console.WriteLine("VALOR DEL INVENTARIO");
            Console.WriteLine("{0, -29} {1,10} {2,10} {3,10} {4,10}", "idProducto", "nombreProducto", "stock", "valorUnidad", "subtotal");

            double totalValorInventario = 0;

            foreach (var producto in productos)
            {
                double valorProducto = producto.precioVenta * producto.stock;
                totalValorInventario += valorProducto;

                Console.WriteLine("{0, -32} {1,7} {2,7} {3,7} {4,7}", producto.codigo, producto.nombre, producto.stock, producto.precioVenta, producto.stock * producto.precioVenta);
            }
            Console.WriteLine($"El costo total del inventario es: {totalValorInventario} ");
        }
    }
}