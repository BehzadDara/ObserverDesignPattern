using System.Text.Json;

namespace ObserverDesignPattern
{
    public class Circle : Shape
    {
        private int radius;
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                NotifyObservers();
            }
        }

        public override string GetInfo()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            return JsonSerializer.Serialize(this, options);
        }
    }
}
