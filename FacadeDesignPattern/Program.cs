using FacadeDesignPattern;

var facade = new ShapeFacade(circleRadius: 10, squareSideLength: 6);

facade.MoveShapes();
Console.WriteLine($"total area of circle with radius 10 and square with side length 6 is : {facade.TotalArea():0.00}");