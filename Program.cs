int seleccion = 10;
double numero = 0;

classCalculadora calculadora = new classCalculadora(numero);

do
{
    Console.Clear();
    Console.WriteLine("1. SUMAR");
    Console.WriteLine("2. RESTAR");
    Console.WriteLine("3. MULTIPLICAR");
    Console.WriteLine("4. DIVIDIR");
    Console.WriteLine("5. LIMPIAR");
    Console.WriteLine("--");
    Console.WriteLine("0. SALIR");
    Console.WriteLine("--");
    Console.WriteLine("Resultado = " + calculadora.resultado);
    Console.WriteLine("--");
    Console.Write("Ingrese su opcion: ");
    seleccion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (!(seleccion == 0 || seleccion == 5))
    {
        Console.Write("Ingrese el numero: ");
        numero = double.Parse(Console.ReadLine());

    }

    switch (seleccion)
    {        
        case 1:
            calculadora.sumar(numero);
            break;

        case 2:
            calculadora.restar(numero);
            break;

        case 3:
            calculadora.multiplicar(numero);
            break;

        case 4:
            calculadora.dividir(numero);
            break;

        case 5:
            calculadora.limpiar();
            break;
        
        default:
            break;
    }

} while (seleccion != 0);

