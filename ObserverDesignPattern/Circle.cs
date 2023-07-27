﻿namespace ObserverDesignPattern
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
            return $"radius = {Radius}";
        }
    }
}
