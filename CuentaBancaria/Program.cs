
namespace CuentaBancaria
{
    public struct Cuenta
    {
        public double Saldo;

        public Cuenta(double saldo)
        {
            Saldo = saldo;
        }
    }
    internal class Banco
    {
        public class CuentaBancaria
        {
            public static Cuenta cuenta = new Cuenta();

            public static void Main()
            {
                cuenta.Saldo = 5000;
                int opcion;
                do
                {
                    Console.WriteLine("╔═══  Cuenta Bancaria  ═══╗");
                    Console.WriteLine("║                         ║");
                    Console.WriteLine("║  1. Consultar Saldo     ║");
                    Console.WriteLine("║  2. Depositar Dinero    ║");
                    Console.WriteLine("║  3. Retirar Dinero      ║");
                    Console.WriteLine("║  4. Salir               ║");
                    Console.WriteLine("║                         ║");
                    Console.WriteLine("╚═════════════════════════╝");
                    Console.Write("\nSeleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());
                    
                    switch (opcion)
                    {
                        case 1: ConsultarSaldo(); break;
                        case 2: Deposito(); break;
                        case 3: Retiro(); break;
                        case 4: break;
                        default: Console.Clear(); break;
                    }
                } while (opcion != 4);
            }
            public static void ConsultarSaldo()
            {
                Console.WriteLine();
                Console.Write($"El saldo actual de la cuenta es:{cuenta.Saldo:C2}");
                Console.WriteLine("\n");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            public static void Deposito()
            {
                Console.Write("Ingrese la cantidad a depositar: $");
                float dep = float.Parse(Console.ReadLine());
                if (dep > 0)
                    cuenta.Saldo = cuenta.Saldo + dep;
                else
                    Console.WriteLine("El deposito debe ser mayor a 0");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            public static void Retiro()
            {
                Console.Write("Ingrese la cantidad a Retirar: ");
                float ret = float.Parse(Console.ReadLine());
                if (ret < cuenta.Saldo)
                    cuenta.Saldo = cuenta.Saldo - ret;
                else
                    Console.WriteLine("La cuenta no dispone de fondos suficientes para realizar el retiro...");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
