using System.ComponentModel.DataAnnotations;

namespace EspacioEmpleado;

// Clase empleado con sus chiches
class Employee {
    private string ?Nombre;
    private string ?Apellido;
    private DateTime FechaNacimiento;
    private char EstadoCivil;
    private DateTime FechaIngreso;
    private double SueldoBasico;
    private Cargo CargoEmpleado;
    // Metpdp para calcular antiguedad
    public double Antiguedad() {
        TimeSpan antiguedad = DateTime.Now - FechaIngreso;
        double antiguedadNumero = antiguedad.Days / 365.0;
        return antiguedadNumero;
    }
    // Metodo para la edad
    public int Edad() {
        TimeSpan edad = DateTime.Now - FechaNacimiento;
        int edadNumero = edad.Days / 365; // no tomo en cuenta años bisiestos...
        return edadNumero;
    }
    // Metodo para jubilacion
    public int Jubilacion() {
        int jubilacion = 65 - Edad(); 
        return jubilacion >= 0 ? jubilacion : 0; // En caso de que tenga más de 65
    }
}

public enum Cargo {
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}