// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    class ConcreteFactory1 : AbstractFactory
    {

        public override AbstractProductA CreateProductA()
        {
            return new Queso1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new Galleta1();
        }

    }
    class Queso1 : AbstractProductA
    {
    }
    class Galleta1 : AbstractProductB
    {

        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interactúa con " + a.GetType().Name);
        }

    }

}

