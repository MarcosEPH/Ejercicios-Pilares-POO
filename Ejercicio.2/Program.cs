using Ejercicio._2.Clases;

class Program
{
    static void Main()
    {
        Console.WriteLine(" GERENTE ");
        Gerente g = new Gerente();
        Console.Write("Nombre del gerente: ");
        g.Nombre = Console.ReadLine();
        Console.Write("Salario del gerente: ");
        g.Salario = Convert.ToDouble(Console.ReadLine());
        g.TomarDecision();

        Console.WriteLine("\n DESARROLLADOR ");
        Desarrollador d = new Desarrollador();
        Console.Write("Nombre del desarrollador: ");
        d.Nombre = Console.ReadLine();
        Console.Write("Salario del desarrollador: ");
        d.Salario = Convert.ToDouble(Console.ReadLine());
        d.Programar();

        Console.WriteLine("\n AUTO ");
        Auto auto = new Auto();
        auto.Avanzar();
        auto.EncenderRadio();

        Console.WriteLine("\n MOTOCICLETA ");
        Motocicleta moto = new Motocicleta();
        moto.Avanzar();
        moto.HacerCaballito();

        Console.WriteLine("\n CUENTA AHORRO ");
        CuentaAhorro ca = new CuentaAhorro();
        Console.Write("Depositar en cuenta ahorro: ");
        double montoA = Convert.ToDouble(Console.ReadLine());
        ca.Depositar(montoA);
        ca.CalcularIntereses();

        Console.WriteLine("\n CUENTA CORRIENTE ");
        CuentaCorriente cc = new CuentaCorriente();
        Console.Write("Depositar en cuenta corriente: ");
        double montoC = Convert.ToDouble(Console.ReadLine());
        cc.Depositar(montoC);
        cc.CalcularIntereses();

        Console.WriteLine("\nFin del programa.");
    }
}