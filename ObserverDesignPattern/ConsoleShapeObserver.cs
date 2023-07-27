namespace ObserverDesignPattern
{
    public class ConsoleShapeObserver : IShapeObserver
    {
        public void Notify(IShapeObservable observable)
        {
            if (observable is Shape shape)
            {
                Console.WriteLine($"{shape.GetType().Name} updated: {shape.GetInfo()}");
            }
        }
    }
}
