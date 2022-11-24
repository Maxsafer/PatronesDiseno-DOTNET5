// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    class Program
    {
        public static void Main()
        {
            // Abstract factory #1
            AbstractFactory queso = new ConcreteFactory1();
            Client Max = new Client(queso);
            Max.Run();
            
            // Abstract factory #2
            AbstractFactory galleta = new ConcreteFactory2();
            Client Rubs = new Client(galleta);
            Rubs.Run();

            Console.WriteLine("");
        }

    }
}

