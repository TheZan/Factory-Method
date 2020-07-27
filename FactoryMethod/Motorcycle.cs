using System;

namespace FactoryMethod
{
    class Motorcycle : ITransport
    {
        public void Run()
        {
            Console.WriteLine("Run Moto!111");
        }
    }
}
