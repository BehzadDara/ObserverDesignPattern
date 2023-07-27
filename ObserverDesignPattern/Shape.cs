namespace ObserverDesignPattern
{
    public abstract class Shape : IShapeObservable
    {
        private readonly List<IShapeObserver> Observers = new();

        public void RegisterObserver(IShapeObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnregisterObserver(IShapeObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Observers.ForEach(x => x.Notify(this));
        }

        public abstract string GetInfo();

    }
}
