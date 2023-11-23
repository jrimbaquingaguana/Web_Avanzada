using System;

// Definición de la interfaz
public interface IMostrarInformacion
{
    void MostrarInformacion();
}

// Definición de la clase base Empleado
public class Empleado : IMostrarInformacion
{
    // Atributos de la clase Empleado
    public string Nombre { get; set; }
    public double Salario { get; set; }

    // Constructor de la clase Empleado
    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    // Método para calcular el salario anual
    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    // Implementación del método de la interfaz
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Salario: {Salario:C}");
        Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
    }
}

// Definición de la clase derivada Gerente que hereda de Empleado
public class Gerente : Empleado
{
    // Nuevo atributo para el departamento que supervisa
    public string Departamento { get; set; }

    // Constructor de la clase Gerente
    public Gerente(string nombre, double salario, string departamento)
        : base(nombre, salario)
    {
        Departamento = departamento;
    }

    // Implementación del método de la interfaz (override)
    public new void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Departamento: {Departamento}");
    }
}

class Program
{
    static void Main()
    {
        // Crear instancia de Empleado
        Empleado empleado = new Empleado("Juan Pérez", 50000);

        // Crear instancia de Gerente
        Gerente gerente = new Gerente("Jose Imbaquinga", 70000, "Recursos Humanos");

        // Mostrar información utilizando polimorfismo a través de la interfaz
        Console.WriteLine("Información del Empleado:");
        MostrarInformacionConPolimorfismo(empleado);

        Console.WriteLine("\nInformación del Gerente:");
        MostrarInformacionConPolimorfismo(gerente);
    }

    // Método que utiliza la interfaz para mostrar información de cualquier objeto que la implemente
    static void MostrarInformacionConPolimorfismo(IMostrarInformacion objeto)
    {
        objeto.MostrarInformacion();
    }
}
