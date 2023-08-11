namespace ejercicio_Tienda.clases
{ 
    public class Categoria
    { 
        public int id { get; set; }
        public string descripcion { get; set; }

        public static void agregarCategorias()
        {
            Console.Clear();
            Categoria categoria = new Categoria();
            Console.WriteLine("AGREGAR UNA CATEGORIA");
            Console.Write("\nIngresa el id de la categoria: ");
            categoria.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el nombre de la categoria: ");
            categoria.descripcion = Console.ReadLine();
            Console.WriteLine("\nCATEGORIA AGREGADA CORRECTAMENTE");
            Env.TiendaCampus.categorias.Add(categoria);
            Console.ReadKey();
        }

        public IEnumerable<Categoria> listarCategorias()
        {
            return from cate in Env.TiendaCampus.Categorias
                select cate;
        } 
    }
}