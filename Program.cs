namespace Harmonic_Number
{
    class Program
    {
        public void Calculation()
        {
            int i, n;
            Console.WriteLine("enter the Nth value : ");
            n=int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                Console.WriteLine(" 1/{0} +",i);
            }
        }
    }
    class Result
    {
        public static void Main(string[]args)
        {
            Program program = new Program();
            program.Calculation();
        }
    }
}