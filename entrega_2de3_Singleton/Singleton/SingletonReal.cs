using System;
using System.Collections.Generic;

namespace Patrones
{
    class LoadBalancer
    {
        private static LoadBalancer? _instance;
        private List<string> _alumnos = new List<string>();
        private Random _random = new Random();
        // Lock synchronization object
        private static object syncLock = new object();
        // Constructor (protected)
        protected LoadBalancer()
        {
            // List of available alumnos
            _alumnos.Add("Max");
            _alumnos.Add("Rubs");
            _alumnos.Add("Aaron");
            _alumnos.Add("Rolo");
            _alumnos.Add("Henry");
        }
        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (_instance == null)
            {
                lock (syncLock)
                //https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/statements/lock
                //La instrucción lock adquiere el bloqueo de exclusión mutua de un objeto determinado, ejecuta un bloque de instrucciones y luego libera el bloqueo. Mientras se mantiene un bloqueo, el subproceso que lo mantiene puede volver a adquirir y liberar el bloqueo. Ningún otro subproceso puede adquirir el bloqueo y espera hasta que se libera
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
                Console.WriteLine(syncLock.ToString());
            }
            return _instance;
        }
        // Simple, but effective random load balancer
        public string Alumno
        {
            get
            {
                int r = _random.Next(_alumnos.Count);
                return _alumnos[r].ToString();
            }
        }
    }
}