public class classCalculadora
{
    public double resultado;

    public classCalculadora(double valor)
    {
        resultado = valor;
    }

    public classCalculadora()
    {
    }

    public void suma(double valor)
    {
        resultado += valor;
    }

    public void resta(double valor)
    {
        resultado -= valor;
    }

    public void multiplicacion(double valor)
    {
        resultado *= valor;
    }

    public void dividir(double valor)
    {
        resultado = valor != 0 ? resultado /= valor : 0;
    }

    public void limpiar()
    {
        resultado = 0;   
    }
}