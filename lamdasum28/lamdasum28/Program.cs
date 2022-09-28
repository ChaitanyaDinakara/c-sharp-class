namespace lamdasum28
{
    //public delegate void cal(int a);
    internal class Program
    {
        public delegate int cal(int a);
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            cal add = (p) =>
            {
                for (int i = 0; i <= n; i++)
                {
                    sum = sum + i;
                   
                }
                return sum;
            };

            cal obj = new cal(add);
            Console.WriteLine("the sum of the numbers is:"+obj.Invoke(n));

        }
    }
}