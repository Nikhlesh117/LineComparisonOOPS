namespace LineComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            CalculateLength UC4 = new CalculateLength();
            UC4.LengthLine();
            UC4.Equal();
            UC4.Compare();
            
        }
    }
}