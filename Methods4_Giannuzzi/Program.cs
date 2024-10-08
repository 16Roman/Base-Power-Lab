internal class Program
{
    
        public static long Power(int pbaseIn, int exponentIn)
        {
        
        checked
        {
            if (exponentIn == 1)
                return pbaseIn;
            else
                return pbaseIn * Power(pbaseIn, exponentIn-1);
        
        }
        }
        static void Main(string[] args)
        {
        checked //May not be needed, but why not be extra careful
        {

            Console.WriteLine("Enter the base");
            int pbase = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the exponent");
            int exponent = int.Parse(Console.ReadLine());
            try
            {
                long result = Power(pbase, exponent);
                Console.WriteLine($"The factor of {pbase} and {exponent} is {result}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow occured, result is large");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
    
}