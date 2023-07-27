namespace ObserverDesignPattern
{
    public interface IShapeObserver
    {
        void Notify(IShapeObservable observable);
    }
}
