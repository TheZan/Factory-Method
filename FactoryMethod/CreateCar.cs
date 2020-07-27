namespace FactoryMethod
{
    class CreateCar : Creator
    {
        public override ITransport CreateTransport() => new Car();
    }
}
