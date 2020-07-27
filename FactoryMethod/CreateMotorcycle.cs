namespace FactoryMethod
{
    class CreateMotorcycle : Creator
    {
        public override ITransport CreateTransport() => new Motorcycle();
    }
}
