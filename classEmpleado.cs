public class empleado
{
    private int idEmpleado;
    private string nombre;
    private string apellido;
    private DateOnly fechaNacimiento;
    private string estadoCivil;
    private string genero;
    private DateOnly fechaIngreso;
    private double sueldoBasico;
    private string cargo;

    public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateOnly FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public string Genero { get => genero; set => genero = value; }
    public DateOnly FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public string Cargo { get => cargo; set => cargo = value; }

    public empleado(string dataNombre, string dataApellido, char dataEstadoCivil, char dataGenero, int dataCargo, DateOnly dataFechaNacimiento, DateOnly dataFechaIngreso, double dataSueldoBasico)
    {
        nombre = dataNombre;
        apellido = dataApellido;
        estadoCivil = Convert.ToString((estadoCivil)dataEstadoCivil);
        genero = Convert.ToString((genero)dataGenero);
        cargo = Convert.ToString((cargo)dataCargo);
        fechaNacimiento = dataFechaNacimiento;
        fechaIngreso = dataFechaIngreso;
        sueldoBasico = dataSueldoBasico;

    }

}

class constantes
{
    public const int cantidadEmpleados = 3;

}


public enum estadoCivil
{
    Soltero = 'S',
    Pareja = 'P',
    Casado = 'C',
    Viudo = 'V'

}

public enum genero
{
    Masculino = 'M',
    Femenino = 'F'

}

public enum cargo
{
    Auxiliar = 1,
    Administrativo = 2,
    Ingeniero = 3,
    Especialista = 4,
    Investigador = 5

}

class functions
{

    public void cargarDatos(List<empleado> dataListaEmpleados)
    {
        var cantidad = constantes.cantidadEmpleados;
        string nombre;
        string apellido;
        char estadoCivil;
        char genero;
        for (int i = 0; i < cantidad; i++)
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            Console.WriteLine("--");
            System.Console.WriteLine($"\tEmpleado: {i + 1}");
            System.Console.WriteLine("--");;
            Console.Write("Ingrese el apellido: ");
            apellido = Console.ReadLine();
            System.Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            System.Console.Write("Ingrese estado civil (S - Soltero, P - En pareja, C - Casado, V - Viudo): ");
            estadoCivil = char.ToUpper(Console.ReadKey().KeyChar);
            System.Console.WriteLine();
            System.Console.Write("Ingrese el genero (M - Masculino, F - Femenino): ");
            genero = char.ToUpper(Console.ReadKey().KeyChar);
            System.Console.WriteLine();
            System.Console.WriteLine("Fecha de Nacimiento: ");
            System.Console.Write("Dia: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Anio: ");
            int anio = Convert.ToInt32(Console.ReadLine());
            DateOnly fechaNacimiento = new DateOnly(anio, mes, dia);
            System.Console.WriteLine("Fecha de Ingreso: ");
            System.Console.Write("Dia: ");
            dia = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Mes: ");
            mes = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Anio: ");
            anio = Convert.ToInt32(Console.ReadLine());
            DateOnly fechaIngreso = new DateOnly(anio, mes, dia);
            System.Console.Write("Ingrese el sueldo basico: ");
            double sueldoBasico = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Ingrese el cargo el que pertenece (1 - Auxiliar, 2 - Administrativo, 3 - Ingeniero, 4 - Especialista, 5 - Investigador): ");
            int cargo = Convert.ToInt32(Console.ReadLine());

            var empleado = new empleado(nombre, apellido, estadoCivil, genero, cargo, fechaNacimiento, fechaIngreso, sueldoBasico);

            dataListaEmpleados.Add(empleado);

        }
    }

    public void mostrarEmpleado(empleado dataEmpleado, double dataSalario, int dataAntiguedad, int dataEdad, int dataJubilacion)
    {
        System.Console.WriteLine($"Apellido y nombre: {dataEmpleado.Apellido}, {dataEmpleado.Nombre}");
        System.Console.WriteLine($"Estado civil: {dataEmpleado.EstadoCivil}");
        System.Console.WriteLine($"Genero: {dataEmpleado.Genero}");
        System.Console.WriteLine($"Fecha de nacimiento: {dataEmpleado.FechaNacimiento}");
        System.Console.WriteLine($"Fecha de ingreso: {dataEmpleado.FechaIngreso}");
        System.Console.WriteLine($"Sueldo basico: ${dataEmpleado.SueldoBasico}");
        System.Console.WriteLine($"Salario: ${dataSalario}");
        System.Console.WriteLine($"Cargo: {dataEmpleado.Cargo}");
        System.Console.WriteLine($"Antiguedad: {dataAntiguedad} anios");
        System.Console.WriteLine($"Edad: {dataEdad} anios");
        System.Console.WriteLine($"Anios que restan para jubilarse: {dataJubilacion}");
        
    }
}