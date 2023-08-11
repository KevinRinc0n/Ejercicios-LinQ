using System;

class Repuesto
{
    public int id { get; set; }
    public string nombre { get; set; }
    public double precio { get; set; }
    public int categoria { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Repuesto> listaRepuestos = new List<Repuesto>()
        {
            new Repuesto() {id = 1, nombre = "tornillo", precio = 7.8, categoria = 2},
            new Repuesto() {id = 2, nombre = "pastillas", precio = 6.8, categoria = 3},
            new Repuesto() {id = 3, nombre = "aceite", precio = 7.9, categoria = 3},
            new Repuesto() {id = 4, nombre = "amortiguador", precio = 3.9, categoria = 2},
            new Repuesto() {id = 5, nombre = "barra", precio = 1.8, categoria = 2},
            new Repuesto() {id = 6, nombre = "ventanas", precio = 4.7, categoria = 1},
            new Repuesto() {id = 7, nombre = "grasa", precio = 4.7, categoria = 3},
            new Repuesto() {id = 8, nombre = "tablero", precio = 1.1, categoria = 1},
            new Repuesto() {id = 9, nombre = "motor", precio = 6.2, categoria = 1}
        };

        var resultado = from repuesto in listaRepuestos
                        group repuesto by repuesto.categoria;

        foreach (var repuestoAgrupado in resultado)
        {
            if (repuestoAgrupado.Key == 1)
            {
                Console.WriteLine("categoria: electricos");
            }
            else if (repuestoAgrupado.Key == 2)
            {
                Console.WriteLine("categoria: suspencion");
            }
            else
            {
                Console.WriteLine("categoria: frenos");
            }

            foreach (var repuesto in repuestoAgrupado)
            {
                Console.WriteLine($"idCategoria: {repuesto.categoria}    nombre: {repuesto.nombre}");
            }
        }
    }
}