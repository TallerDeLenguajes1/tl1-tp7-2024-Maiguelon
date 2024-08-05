// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;

class Program {
    static void Main(string[] args) {
        Calculadora calc = new Calculadora();
        double termino;

        // Pedir el primer número
        Console.WriteLine("Ingrese un número inicial:");
        while (!double.TryParse(Console.ReadLine(), out termino)) { // Control
            Console.WriteLine("Entrada inválida. Intente nuevamente:");
        }

        // Inicializar el valor de resultado con el primer número ingresado
        calc.Sumar(termino);

        string input;

        do {
            // Pido que se seleccione la operación o la salida
            Console.WriteLine("Ingrese una operación (+, -, *, /) o 'c' para limpiar, 'x' para salir:");
            input = Console.ReadLine(); // no sé como evitar un posible null

            if (input == "x") break; // sale

            if (input == "c") {
                calc.Limpiar(); // llamo al método de limpieza
                Console.WriteLine("Campo limpiado.");
                continue;
            }

            Console.WriteLine("Ingrese un número:");
            if (!double.TryParse(Console.ReadLine(), out termino)) { // control
                Console.WriteLine("Entrada inválida. Intente nuevamente.");
                continue;
            }

            // Según el switch se elige el método
            switch (input) {
                case "+":
                    calc.Sumar(termino);
                    break;
                case "-":
                    calc.Restar(termino);
                    break;
                case "*":
                    calc.Multiplicar(termino);
                    break;
                case "/":
                    calc.Dividir(termino);
                    break;
                default:
                    Console.WriteLine("Operación inválida. Intente nuevamente.");
                    break;
            }

            Console.WriteLine("Resultado actual: " + calc.Resultado); // Se escribe el result acualizado
        } while (true);
    }
}
