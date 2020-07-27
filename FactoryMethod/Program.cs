using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITransport> transports = new List<ITransport>();

            Creator creator = new CreateCar();
            transports.Add(creator.CreateTransport());

            creator = new CreateMotorcycle();
            transports.Add(creator.CreateTransport());

            creator = new CreateMotorcycle();
            transports.Add(creator.CreateTransport());

            foreach (var transport in transports)
            {
                transport.Run();
            }

            Console.ReadKey();
        }
    }
}
