namespace example01.Component
{
    public interface IPowerSupplier
    {
        string Name { get; }
        void TurnOn();

        void TurnOff();
    }
}