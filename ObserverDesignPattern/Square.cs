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
            return $"sideLength = {SideLength}";
        }
    }
}
