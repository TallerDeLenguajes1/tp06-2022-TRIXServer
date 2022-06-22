static void Main(string[] args)
{
    var cantidad = constantes.cantidadEmpleados;
    var functions = new functions();

    var listaEmpleados = new List<empleado>();
    functions.cargarDatos(listaEmpleados);

    var antiguedad = new int[cantidad];
    var edad = new int[cantidad];
    var jubilacion = new int[cantidad];
    var salario = new double[cantidad];
    double adicional;

    for (int i = 0; i < cantidad; i++)
    {
        antiguedad[i] = DateTime.Now.Year - listaEmpleados[i].FechaIngreso.Year;

        if (DateTime.Now.Month < listaEmpleados[i].FechaIngreso.Month)
        {
            antiguedad[i]--;

        }
        else
        {
            if (DateTime.Now.Month == listaEmpleados[i].FechaIngreso.Month && DateTime.Now.Day < listaEmpleados[i].FechaIngreso.Day)
            {
                antiguedad[i]--;

            }
        }

        edad[i] = DateTime.Now.Year - listaEmpleados[i].FechaNacimiento.Year;

        if (DateTime.Now.Month < listaEmpleados[i].FechaNacimiento.Month)
        {
            edad[i]--;

        }
        else
        {
            if (DateTime.Now.Month == listaEmpleados[i].FechaNacimiento.Month && DateTime.Now.Day < listaEmpleados[i].FechaNacimiento.Day)
            {
                edad[i]--;

            }
        }

        if (Convert.ToString((genero)'M') == listaEmpleados[i].Genero)
        {
            jubilacion[i] = 65 - edad[i];

        }
        else
        {
            jubilacion[i] = 60 - edad[i];

        }

        adicional = 0;
        if (antiguedad[i] < 20)
        {
            adicional = (listaEmpleados[i].SueldoBasico / 100) * antiguedad[i];

        }
        else
        {
            adicional = (listaEmpleados[i].SueldoBasico / 100) * 20;

        }

        if ((Convert.ToString((cargo) 3)) == listaEmpleados[i].Cargo || Convert.ToString((cargo) 4) == listaEmpleados[i].Cargo);
        {
            adicional += (adicional / 2);

        }

        if (Convert.ToString((estadoCivil) 'C') == listaEmpleados[i].EstadoCivil)
        {
            adicional += 15000;

        }
        
        salario[i] = listaEmpleados[i].SueldoBasico + adicional;

    }
}