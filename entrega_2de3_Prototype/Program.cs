
namespace Patron.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // invocamos el admin
            CAdminPrototipos admin = new CAdminPrototipos();

            //instanciamos dos obj
            CPersona uno = (CPersona)admin.ObtenPrototipo("Persona");
            CPersona dos = (CPersona)admin.ObtenPrototipo("Persona");
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("-----");

            //Modificamos el estado
            uno.Nombre = "Max";
            uno.Edaad = 23;
            dos.Nombre = "Edu";
            dos.Edaad = 22;
            CPersona tres = new CPersona("Ruben", 30);
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine(tres);
            Console.WriteLine("-----");

            //Creamos una instancia
            CAuto auto = new CAuto("BMW", 200000);

            //Lo colocamos como prototipo
            admin.AdicionaPrototipo("Auto", auto);

            //Obtenemos un objeto del prototipo anterior
            CAuto auto2 = (CAuto)admin.ObtenPrototipo("Auto");

            //Cambiamos el estado
            auto2.Modelo = "Mazda";
            auto2.Costo = 5;

            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("-----");

            //Obtenemos una instancia del COSTOSO
            CValores val = (CValores)admin.ObtenPrototipo("Valores");
            Console.WriteLine(val);
        }

    }
}