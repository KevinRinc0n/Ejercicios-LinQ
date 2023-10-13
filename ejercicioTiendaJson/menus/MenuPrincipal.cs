namespace ejercicio_Tienda.menus
{
    public class MenuPrincipal 
    {
        public int mostrarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------ SUPER TIENDA ABS ------------------------------------------");
            Console.WriteLine("1. Registrar Producto");
            Console.WriteLine("2. Registrar Categoria");
            Console.WriteLine("3. Listar Categorias");
            Console.WriteLine("4. Listar Productos");
            Console.WriteLine("5. Costo total del inventario");
            Console.WriteLine("6. Salir");
            Console.Write("\nIngresa la opciòn que deseas realizar: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    } 
}