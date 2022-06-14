classCalculadora calculadora = new classCalculadora();

int seleccion = 10;

do
{
    Console.Clear();
    Console.WriteLine("1. SUMA");
    Console.WriteLine("2. RESTA");
    Console.WriteLine("3. MULTIPLICACION");
    Console.WriteLine("4. DIVISION");
    Console.WriteLine("--");
    Console.WriteLine("0. SALIR");
    Console.WriteLine("--");
    Console.Write("Ingrese su opcion: ");
    seleccion = int.Parse(Console.ReadLine());
    
} while (seleccion != 0);

