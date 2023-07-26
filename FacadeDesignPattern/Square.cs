namespace FacadeDesignPattern
{
    public class Square : IShape
    {
        public double SideLength { get; set; }

        public void Move()
            => Console.WriteLine("square moved");

        public double Area()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}
