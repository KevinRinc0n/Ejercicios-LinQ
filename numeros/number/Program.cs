var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

Random random = new Random();

List<int> numerosAleatorios = new List<int>();
List<int> numerosPrimos = new List<int>();
List<int> cuadrados = new List<int>();

for (int i = 0; i <= 100; i++)
{
    numerosAleatorios.Add(random.Next());
}

foreach (var numero in numerosAleatorios)
{
    Console.WriteLine(numero);
}

int total = 0;
foreach (var numero in numerosAleatorios)
{
    total += numero;
}
Console.WriteLine("Suma total: " + total);

foreach (var numero in numerosAleatorios)
{
    if (numero > 1 && Enumerable.Range(2, (int)Math.Sqrt(numero) - 1).All(i => numero % i != 0))
    {
        Console.WriteLine("Número primo: " + numero);
        numerosPrimos.Add(numero);
    }
}

foreach (var numero in numerosPrimos)
{
    Console.WriteLine("Numeros primos en la lista: " + numero);
}

foreach (var numero in numerosAleatorios)
{
    int cuadrado = numero * numero;
    cuadrados.Add(cuadrado);
    Console.WriteLine("El cuadradro del numero " + numero + " es: " + cuadrado);
}

foreach (var numero in numerosAleatorios)
{
    if (numero > 50)
    {
        var promedio = numero / 100;
        Console.WriteLine("El promedio del numero " + numero + " es: " + promedio);
    }
}

var par = 0;
var impar = 0;

foreach (var numero in numerosAleatorios)
{
    if (numero % 2 == 0)
    {
        par += 1;
    }
    else
    {
        impar += 1;
    }
}
Console.WriteLine("La cantidad de numeros pares es: " + par);
Console.WriteLine("La cantidad de numeros impares es: " + impar);

var conteoNumeros = new Dictionary<int, int>();

foreach (var numero in numerosAleatorios)
{
    if (conteoNumeros.ContainsKey(numero))
    {
        conteoNumeros[numero] += 1;
    }
    else
    {
        conteoNumeros[numero] = 1;
    }
}

foreach (var numero in conteoNumeros)
{
    Console.WriteLine($"{numero.Key}: {numero.Value}");
}

Console.WriteLine(numerosAleatorios.OrderByDesending());

List<int> numerosUnicos = new List<int>();

foreach (var numero in numerosAleatorios)
{
    if (numero )
    {
        numerosUnicos.Add(numero);
    }
}

Console.WriteLine(numerosUnicos);