using System.Text.Json;

namespace ObserverDesignPattern
{
    public class Square : Shape
    {
        private int sideLength;
        public int SideLength
        {
            get { return sideLength; }
            set
            {
                sideLength = value;
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
