public class empleado
{
    private int idEmpleado;
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private char genero;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private string cargos;

    public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public string Cargos { get => cargos; set => cargos = value; }

    
}

