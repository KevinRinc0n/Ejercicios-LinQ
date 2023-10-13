using Newtonsoft.Json;
using ejercicio_Tienda.menus;
using ejercicio_Tienda.clases; 

internal class Program  
{ 
    private static void Main(string[] args)
    {
        int opcion;
        string json;

        MenuPrincipal menuPrincipal = new MenuPrincipal();
        if (Env.validarFile(Env.FileName) == false)
        {
            File.WriteAllText(Env.FileName, ""); 
            Env.TiendaCampus.productos = new List<Producto>();  
            Env.TiendaCampus.categorias = new List<Categoria>();  
        } 
        else 
        {
            Env.cargarAJson(Env.FileName);
        }

        do
        {
            opcion = menuPrincipal.mostrarMenuPrincipal();

            switch (opcion)
            {   
                case 1:
                    Producto.agregarProductos();
                    json = JsonConvert.SerializeObject(Env.TiendaCampus,Formatting.Indented);
                    File.WriteAllText(Env.FileName, json);
                    break;

                case 2:     
                    Categoria.agregarCategorias();
                    json = JsonConvert.SerializeObject(Env.TiendaCampus,Formatting.Indented);
                    File.WriteAllText(Env.FileName, json);
                    break;

                case 3:
                    Categoria listaCategoria = new ();
                    Env.imprimirData<Categoria>("Lista Categorias ", listaCategoria.listarCategorias());
                    break;

                case 4:
                    Producto listaProducto = new ();
                    Env.imprimirData<Producto>("Lista Productos ", listaProducto.listarProductos());
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("VALOR DEL INVENTARIO");
                    Console.WriteLine("{0, -29} {1,10} {2,10} {3,10} {4,10}", "idProducto", "nombreProducto", "stock", "valorUnidad", "subtotal");
                    double totalValorInventario = 0;

                    foreach (var producto in Env.TiendaCampus.productos)
                    {
                        double valorProducto = producto.precioVenta * producto.stock;
                        totalValorInventario += valorProducto;

                        Console.WriteLine("{0, -22} {1,13} {2,15} {3,13} {4,11}", producto.codigo, producto.nombre, producto.stock, producto.precioVenta, valorProducto);
                    }
                    
                    Console.WriteLine($"\nEl costo total del inventario es: {totalValorInventario} ");
                    Console.ReadKey();
                    break;      

                case 6:
                    Console.WriteLine("ADIOS !!!");
                    break;
                default:
                    Console.WriteLine("OPCIÓN INVALIDA");
                    break;    
            }
        } while (opcion != 6);
    }
}