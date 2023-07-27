using System.Text.Json;

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

        public string GetInfo()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            return JsonSerializer.Serialize(this, GetType(), options);
        }
    }
}
