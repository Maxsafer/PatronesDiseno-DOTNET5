// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    class ConcreteFactory2 : AbstractFactory
    {

        public override AbstractProductA CreateProductA()
        {
            return new Queso2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new Galleta2();
        }

    }

    abstract class AbstractProductA
    {

    }


    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    class Queso2 : AbstractProductA
    {
    }


    class Galleta2 : AbstractProductB
    {

        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interactúa con " + a.GetType().Name);
        }

    }

}

