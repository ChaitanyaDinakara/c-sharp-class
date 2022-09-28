namespace anonymousinterest
{
    public delegate void interest(int p,double r,int t);
    internal class Program
    {
        static void Main(string[] args)
        {
            interest obj = delegate (int p,double r,int t)
            {
                Console.WriteLine("The simple interest that needs to be paid is :"+p * r * t);

            };
            Console.WriteLine("enter the principle amt");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the rate of interest");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of years");
            int y=Convert.ToInt32(Console.ReadLine());
            obj.Invoke(p, r, y);

        }
    }
}