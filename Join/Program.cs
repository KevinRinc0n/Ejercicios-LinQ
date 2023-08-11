using System;

List<Student> studentList = new List<Student>()
{
    new Student() {id = 1, nombre ="John", edad = 18, standartId = 1},
    new Student() {id = 2, nombre ="Gloria", edad = 43, standartId = 1},
    new Student() {id = 3, nombre ="Jose", edad = 87, standartId = 2},
    new Student() {id = 4, nombre ="Maria", edad = 10, standartId = 2},
    new Student() {id = 5, nombre ="Carlos", edad = 14}
};

List <Standart> standarList = new List<Standart>()
{
    new () {standartId = 1, standartNombre = "standart 1"},
    new () {standartId = 2, standartNombre = "standart 2"},
    new () {standartId = 3, standartNombre = "standart 3"},
};

var joinResult = studentList.Join(
        standarList,
        student => student.standartId,
        standart => standart.standartId,
        (student,standart) => new 
                    {
                        nombre = student.nombre,
                        standartNombre = standart.standartNombre
                    });

Console.Clear();
Console.WriteLine("{0, -30} {1,10}", "Nombre","Categoria");

foreach (var obj in joinResult)
{
    Console.WriteLine("{0, -32} {1,7}", obj.nombre,obj.standartNombre);
}
