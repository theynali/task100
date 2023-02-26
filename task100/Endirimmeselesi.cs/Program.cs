namespace Endirimmeselesi.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double mebleq = 5000;
            if (mebleq <= 100 && mebleq >0) 
            {
                Console.WriteLine(mebleq - (mebleq * 5 / 100));
            }
            else if (mebleq > 100 && mebleq <1000)
            {
                Console.WriteLine(mebleq - (mebleq * 8 / 100));
            }
            else if (mebleq > 1000 )
            {
                Console.WriteLine(mebleq - (mebleq * 10 / 100));
            }
            else
            {
                Console.WriteLine("Duzgun eded daxil edin: ");
            }
            
           
          




        }
    }
}