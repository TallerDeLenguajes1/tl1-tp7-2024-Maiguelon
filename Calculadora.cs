namespace EspacioCalculadora;

class Calculadora {
    // Campo
    private double resultado;

    // Método sumar
    public void Sumar(double termino) {
        resultado += termino;
    }

    // Método restar
    public void Restar(double termino) {
        resultado -= termino;
    }

    // Método multiplicar
    public void Multiplicar(double termino) {
        resultado *= termino;
    }

    // Método dividir
    public void Dividir(double termino) {
        if (termino != 0) {
            resultado /= termino;
        } else {
            Console.WriteLine("\nNo se puede dividir por cero\n");
        }
    }

    // Método limpiar
    public void Limpiar() {
        resultado = 0;
    }

    // Propiedad Resultado
    public double Resultado {
        get { return resultado; }
    }
}
