namespace Otus.HW_Interfaces
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var anInstanceofQuadcopter = new Quadcopter();
            anInstanceofQuadcopter.Charge();
            Console.WriteLine(anInstanceofQuadcopter.GetInfo());
        }
    }
}