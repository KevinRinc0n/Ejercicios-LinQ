using Newtonsoft.Json;
using ejercicio_Tienda.menus;
using ejercicio_Tienda.clases; 

internal class Program 
{ 
    private static void Main(string[] args)
    {
        MenuPrincipal menuPrincipal = new MenuPrincipal();
        int opcion;
        if (Env.validarFile(Env.FileName) == false)
        {
            File.WriteAllText(Env.FileName, "");   
        } 
        else 
        {
            Env.imprimirData("ddd", Env.tiendaCampus.Categorias);
        }

        do
        {
            opcion = menuPrincipal.mostrarMenuPrincipal();

            switch (opcion)
            {   
                case 1:
                    Producto productoAgregar = new Producto();
                    productoAgregar = productoAgregar.agregarProductos();
                    break;

                case 2:     
                    Categoria.agregarCategorias();
                    string json = JsonConvert.SerializeObject(Env.tiendaCampus,Formatting.Indented);
                    File.WriteAllText(Env.FileName, json);
                    break;

               /* case 3:
                    Listar categoriasListar = new Listar();
                    categoriasListar = categoriasListar.listarCategorias();
                    break;

                case 4:
                    Listar productosListar = new Listar();
                    productosListar = productosListar.listarProductos();
                    break;

                case 5:
                    Listar valorInventario = new Listar();
                    valorInventario = valorInventario.totalInventario();
                    break;     */   

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