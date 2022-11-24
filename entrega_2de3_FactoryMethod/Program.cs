using MetodoFabrica02.Fabrica;
using MetodoFabrica02.Fabrica.Creadores;

namespace MetodoFabrica02
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            ELECTRODOM electrodom;
            Console.WriteLine("Cuanto dinero tienes para tu electrodomestico?");
            //dato = Console.ReadLine();
            dato = "1000";
            dinero = Convert.ToInt32(dato);
            // Obtenemos el electrodom de la fabrica
            electrodom = CCreador.MetodoFabrica(dinero);
            electrodom.Encender();
            electrodom.Apagar();
            electrodom.Cargar();
            electrodom.Actualizar();
        }
    }
}