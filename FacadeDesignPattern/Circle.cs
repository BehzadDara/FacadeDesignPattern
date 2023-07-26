namespace FacadeDesignPattern
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public void Move()
            => Console.WriteLine("circle moved");

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
