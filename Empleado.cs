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
}

public enum Cargo {
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}