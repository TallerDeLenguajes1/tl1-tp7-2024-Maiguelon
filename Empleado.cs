using System.ComponentModel.DataAnnotations;

namespace EspacioEmpleado
{
    // Clase Employee con sus propiedades públicas
    public class Employee
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char EstadoCivil { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double SueldoBasico { get; set; }
        public Cargo CargoEmpleado { get; set; }

        // Método para calcular antigüedad
        public double Antiguedad()
        {
            TimeSpan antiguedad = DateTime.Now - FechaIngreso;
            double antiguedadNumero = antiguedad.Days / 365.0;
            return antiguedadNumero;
        }

        // Método para la edad
        public int Edad()
        {
            TimeSpan edad = DateTime.Now - FechaNacimiento;
            int edadNumero = edad.Days / 365; // no toma en cuenta años bisiestos...
            return edadNumero;
        }

        // Método para jubilación
        public int Jubilacion()
        {
            int jubilacion = 65 - Edad();
            return jubilacion >= 0 ? jubilacion : 0; // En caso de que tenga más de 65
        }

        // Método para calcular el salario
        public double Salario()
        {
            double Adicional;
            if (Antiguedad() < 20)
            {
                Adicional = SueldoBasico * 0.01 * Antiguedad();
            }
            else
            {
                Adicional = SueldoBasico * 0.25;
            }

            if (CargoEmpleado == Cargo.Ingeniero || CargoEmpleado == Cargo.Especialista)
            {
                Adicional *= 1.5;
            }

            if (EstadoCivil == 'c')
            {
                Adicional += 150000;
            }
            double SalarioFinal = SueldoBasico + Adicional;
            return SalarioFinal;
        }
    }

    public enum Cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public class EmployeeManejo
    {
        public Employee[] CargarEmpleados()
        {
            Employee[] empleados = new Employee[3];

            empleados[0] = new Employee()
            {
                Nombre = "Juan",
                Apellido = "Pérez",
                FechaNacimiento = new DateTime(1985, 3, 23),
                EstadoCivil = 'c',
                FechaIngreso = new DateTime(2010, 7, 15),
                SueldoBasico = 700000,
                CargoEmpleado = Cargo.Ingeniero
            };

            empleados[1] = new Employee()
            {
                Nombre = "Ana",
                Apellido = "Gómez",
                FechaNacimiento = new DateTime(1990, 8, 12),
                EstadoCivil = 's', // Soltera
                FechaIngreso = new DateTime(2015, 4, 1),
                SueldoBasico = 500000,
                CargoEmpleado = Cargo.Administrativo
            };

            empleados[2] = new Employee()
            {
                Nombre = "Carlos",
                Apellido = "Ramírez",
                FechaNacimiento = new DateTime(1978, 11, 30),
                EstadoCivil = 'c',
                FechaIngreso = new DateTime(2005, 2, 20),
                SueldoBasico = 800000,
                CargoEmpleado = Cargo.Especialista
            };

            return empleados;
        }
    }
}
