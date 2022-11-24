// Patrón Adapter -- Ejemplo real  

using System;

namespace Patrones.AdapterReal
{

    /// <summary>

    /// Clase MainApp 

    /// Adapter Design Pattern.

    /// </summary>

    class MainApp
    {

        /// <summary>

        /// Aplicación

        /// </summary>

        static void Main()
        {
            // Elemento no adaptado

            Fruta desconocido = new Fruta("Manzana");
            desconocido.MostrarInfo();

            // Elementos adaptados
            Fruta l1 = new InformacionFruta("Manzana");
            l1.MostrarInfo();

            Fruta l2 = new InformacionFruta("Fresa");
            l2.MostrarInfo();

            Fruta l3 = new InformacionFruta("Pera");
            l3.MostrarInfo();

        }

    }

    /// <summary>

    /// The 'Target' class

    /// </summary>

    class Fruta
    {
        protected string _codigo;

        protected string _color;

        protected string _precio;

        protected string _tienda;

        protected string _popularidad;

        // Constructor

        public Fruta(string codigo)
        {
            this._codigo = codigo;
        }

        public virtual void MostrarInfo()
        {

            Console.WriteLine("Fruta: {0}", _codigo);

        }

    }



    /// <summary>

    /// The 'Adapter' class

    /// </summary>

    class InformacionFruta : Fruta
    {

        private Tianguis _tia;


        // Constructor


        public InformacionFruta(string codigo) : base(codigo)
        {
            Console.WriteLine(codigo);

        }

        public override void MostrarInfo()
        {
            // The Adaptee

            _tia = new Tianguis();


            _color = _tia.ObtenerColor(_codigo);

            _precio = _tia.ObtenerPrecio(_codigo);

            _tienda = _tia.ObtenerTienda(_codigo);

            _popularidad = _tia.ObtenerPopularidad(_codigo);


            //base.MostrarInfo();

            Console.WriteLine(" Precio: {0}", _precio);

            Console.WriteLine(" Color : {0}", _color);

            Console.WriteLine(" Tienda: {0}", _tienda);

            Console.WriteLine(" Popularidad: {0}", _popularidad);
        }
    }



    /// <summary>

    /// The 'Adaptee' class

    /// </summary>

    class Tianguis
    {

        // API heredada

        public string ObtenerColor(string fruta)
        {

            // Color
            switch (fruta)
            {

                case "Manzana": return "Roja, Verde, Amarilla";

                case "Fresa": return "Roja";

                case "Pera": return "Roja, Verde";

                default: return "";
            }

        }


        public string ObtenerPrecio(string fruta)
        {
            switch (fruta)
            {
                case "Manzana": return "$5";

                case "Fresa": return "$1";

                case "Pera": return "$8";

                default: return "";
            }
        }


        public string ObtenerTienda(string fruta)
        {
            switch (fruta)
            {
                case "Manzana": return "Walmart";

                case "Fresa": return "Comer";

                case "Pera": return "Chedrahui";

                default: return "";
            }
        }

        public string ObtenerPopularidad(string fruta)
        {
            switch (fruta)
            {
                case "Manzana": return "3/5";

                case "Fresa": return "2/5";

                case "Pera": return "4/5";

                default: return "";
            }
        }

    }

}


