using Ejercicios___Pilares_POO.Clases;

class Program
{
    static void Main()
    {
        Console.WriteLine(" EMPLEADO ");
        Empleado emp = new Empleado();
        Console.Write("Ingrese nombre: ");
        emp.Nombre = Console.ReadLine();
        Console.Write("Ingrese salario: ");
        emp.Salario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nombre: " + emp.Nombre);
        Console.WriteLine("Salario: Q" + emp.Salario);

        Console.WriteLine("\n CUENTA BANCARIA ");
        Console.Write("Saldo inicial: ");
        double saldo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Límite de retiro diario: ");
        double limite = Convert.ToDouble(Console.ReadLine());
        CuentaBancaria cuenta = new CuentaBancaria(saldo, limite);
        Console.Write("Cantidad a retirar: ");
        double retiro = Convert.ToDouble(Console.ReadLine());
        cuenta.Retirar(retiro);
        cuenta.MostrarSaldo();

        Console.WriteLine("\n VEHÍCULO ");
        Vehiculo carro = new Vehiculo();
        Console.Write("¿Encender vehículo? (s/n): ");
        string opcion = Console.ReadLine();
        if (opcion == "s")
        {
            carro.Encender();
        }
        else
        {
            carro.Apagar();
        }
        Console.WriteLine("¿Está encendido? " + carro.Encendido);
    }
}