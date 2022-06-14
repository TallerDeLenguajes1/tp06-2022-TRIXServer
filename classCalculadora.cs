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

    public void sumar(double valor)
    {
        resultado += valor;

    }

    public void restar(double valor)
    {
        resultado -= valor;

    }

    public void multiplicar(double valor)
    {
        resultado *= valor;

    }

    public void dividir(double valor)
    {
        resultado = valor != 0 ? resultado /= valor : resultado;

    }

    public void limpiar()
    {
        resultado = 0;

    }
}