// // See https://aka.ms/new-console-template for more information

// using EspacioCalculadora;

// class Program {
//     static void Main(string[] args) {
//         Calculadora calc = new Calculadora();
//         double termino;

//         // Pedir el primer número
//         Console.WriteLine("Ingrese un número inicial:");
//         while (!double.TryParse(Console.ReadLine(), out termino)) { // Control
//             Console.WriteLine("Entrada inválida. Intente nuevamente:");
//         }

//         // Inicializar el valor de resultado con el primer número ingresado
//         calc.Sumar(termino);

//         string input;

//         do {
//             // Pido que se seleccione la operación o la salida
//             Console.WriteLine("Ingrese una operación (+, -, *, /) o 'c' para limpiar, 'x' para salir:");
//             input = Console.ReadLine(); // no sé como evitar un posible null

//             if (input == "x") break; // sale

//             if (input == "c") {
//                 calc.Limpiar(); // llamo al método de limpieza
//                 Console.WriteLine("Campo limpiado.");
//                 continue;
//             }

//             Console.WriteLine("Ingrese un número:");
//             if (!double.TryParse(Console.ReadLine(), out termino)) { // control
//                 Console.WriteLine("Entrada inválida. Intente nuevamente.");
//                 continue;
//             }

//             // Según el switch se elige el método
//             switch (input) {
//                 case "+":
//                     calc.Sumar(termino);
//                     break;
//                 case "-":
//                     calc.Restar(termino);
//                     break;
//                 case "*":
//                     calc.Multiplicar(termino);
//                     break;
//                 case "/":
//                     calc.Dividir(termino);
//                     break;
//                 default:
//                     Console.WriteLine("Operación inválida. Intente nuevamente.");
//                     break;
//             }

//             Console.WriteLine("Resultado actual: " + calc.Resultado); // Se escribe el result acualizado
//         } while (true);
//     }
// }

// PUNTO 2

using EspacioEmpleado;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de EmployeeManejo para cargar los empleados
        EmployeeManejo manejo = new EmployeeManejo();
        Employee[] empleados = manejo.CargarEmpleados();

        // PMonto total de salarios
        double totalSalarios = 0;
        foreach (var empleado in empleados)
        {
            totalSalarios += empleado.Salario();
        }
        Console.WriteLine($"El monto total de lo que se paga en concepto de salarios es: {totalSalarios:C}");

        // Jubilacion
        Employee empleadoProximoJubilarse = empleados[0];
        foreach (var empleado in empleados)
        {
            if (empleado.Jubilacion() < empleadoProximoJubilarse.Jubilacion())
            {
                empleadoProximoJubilarse = empleado;
            }
        }

        // Mostrar los datos del empleado más próximo a jubilarse
        Console.WriteLine("\nEmpleado más próximo a jubilarse:");
        Console.WriteLine($"Nombre: {empleadoProximoJubilarse.Nombre} {empleadoProximoJubilarse.Apellido}");
        Console.WriteLine($"Edad: {empleadoProximoJubilarse.Edad()} años");
        Console.WriteLine($"Antigüedad: {empleadoProximoJubilarse.Antiguedad():F1} años");
        Console.WriteLine($"Años restantes para jubilarse: {empleadoProximoJubilarse.Jubilacion()} años");
        Console.WriteLine($"Salario: {empleadoProximoJubilarse.Salario():C}");
    }
}
