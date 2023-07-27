using ObserverDesignPattern;

var square = new Square();
var circle = new Circle();

var observer = new ConsoleShapeObserver();
square.RegisterObserver(observer);
circle.RegisterObserver(observer);

square.SideLength = 1;
circle.Radius = 2;