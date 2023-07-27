namespace ObserverDesignPattern
{
    public interface IShapeObservable
    {
        void RegisterObserver(IShapeObserver observer);
        void UnregisterObserver(IShapeObserver observer);
        void NotifyObservers();
    }
}
