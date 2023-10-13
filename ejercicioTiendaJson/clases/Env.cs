using ejercicio_Tienda.clases;

namespace ejercicio_Tienda.clases 
{
    public static class Env 
    { 
        private static string filaName = "tiendaCampus.json";
        private static Tienda tiendaCampus = new Tienda();

        public static string FileName { get => filaName; set => filaName = value; }
        public static Tienda TiendaCampus { get => tiendaCampus; set => tiendaCampus = value; }

        public static void cargarAJson(string nombreArchivo)
        {
            using (StreamReader reader = new StreamReader(nombreArchivo))
            {
                string json = reader.ReadToEnd();
                Env.TiendaCampus = System.Text.Json.JsonSerializer.Deserialize<Tienda>(json, new System.Text.Json.JsonSerializerOptions() {PropertyNameCaseInsensitive = true}) ?? new Tienda();
            }
        }

        public static bool validarFile(string filaName)
        {
            if (!File.Exists(filaName))
            {
                return false;
            }
            return true;
        }

        public static void imprimirData<T>(string titulo, IEnumerable<T> lista)
        {
            Console.WriteLine("{0, -30}", titulo);
            
            foreach (var elemento in lista)
            {
                Type tipoClase = elemento.GetType();
                var propiedades = tipoClase.GetProperties();

                foreach (var propiedad in propiedades)
                {
                    Console.WriteLine($"{propiedad.Name}: {propiedad.GetValue(elemento)}");
                }
            }
            Console.ReadKey();
        }
    }
}
