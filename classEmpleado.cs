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

public enum cargo
{
    Auxiliar = 1,
    Administrativo = 2,
    Ingeniero = 3,
    Especialista = 4,
    Investigador = 5

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

class functions
{

    public void cargarDatos(List<empleado> dataListaEmpleados)
    {
        var cantidad = constantes.cantidadEmpleados;
        string nombre;
        string apellido;
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

        }
    }
}