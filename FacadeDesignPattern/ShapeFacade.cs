namespace FacadeDesignPattern
{
    public class ShapeFacade
    {
        private readonly Circle _circle;
        private readonly Square _square;

        public ShapeFacade(double circleRadius, double squareSideLength)
        {
            _circle = new Circle { Radius = circleRadius };
            _square = new Square { SideLength = squareSideLength };
        }

        public double TotalArea()
        {
            return _circle.Area() + _square.Area();
        }

        public void MoveShapes()
        {
            _circle.Move();
            _square.Move();
        }
    }
}
