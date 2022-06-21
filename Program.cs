   var cantidad = constantes.cantidadEmpleados;
        string nombre;
        string apellido;
        char estadoCivil;
        char genero;
        DateOnly fechaNacimiento;
        DateOnly fechaIngreso;
        int dia;
        int mes;
        int anio;
        int cargo;
        double sueldoBasico;
        for (int i = 0; i < cantidad; i++)
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            Console.WriteLine("--");
            System.Console.WriteLine($"\tEmpleado: {i + 1}");
            System.Console.WriteLine("--");;
            Console.Write("Ingrese el apellido: ");
            apellido = Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("Ingrese estado civil (S - Soltero, P - En pareja, C - Casado, V - Viudo): ");
            estadoCivil = char.ToUpper(Console.ReadKey().KeyChar);
            System.Console.WriteLine();
            System.Console.Write("Ingrese el genero (M - Masculino, F - Femenino): ");
            genero = char.ToUpper(Console.ReadKey().KeyChar);
            System.Console.WriteLine();
            System.Console.WriteLine("Fecha de Nacimiento: ");
            System.Console.Write("Dia: ");
            dia = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Mes: ");
            mes = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Anio: ");
            anio = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
        }


