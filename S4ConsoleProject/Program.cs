// See https://aka.ms/new-console-template for more information
using S4ConsoleProject;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de Ambiente web";
int edad = 22;
double salario = 2000;

var alumno = "Luis Chang";
var peso = 70;
var notaFinal = 18.50;

var persona1 = new Persona();
persona1.dni = 9922882;
persona1.telefono = "998399039";
persona1.nombreCompleto = "Paolo Guerrero";
persona1.estado = true;

var persona2 = new Persona()
{
    dni = 99888833,
    telefono = "998898939",
    nombreCompleto = "Gianluca Lapadula",
    estado = true
};

var persona3 = new Persona(18929211, "Claudio Pizarro", "323232323", false);

var personas = new List<Persona>();
personas.Add(persona1);
personas.Add(persona2);
personas.Add(persona3);

// lambda Expressions
var busqueda = personas.Where(x => x.dni == 9922882).FirstOrDefault();

if (busqueda != null)
    Console.WriteLine("La persona encontrada es: " + busqueda.nombreCompleto);
else
    Console.WriteLine("La persona no existe");


Console.ReadKey();