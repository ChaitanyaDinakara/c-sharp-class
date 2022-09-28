using System;
using System.Runtime.ExceptionServices;

namespace delegates28
{
    public delegate void cal(int a);
    internal class program
    {
        public static void factorial(int a)
        {
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f = f * i;
            }
                Console.WriteLine("factorial is:"+f);
            
        }

        public static void fibonacci(int n1)
        {
            int t1 = 0, t2 = 1, nt=0;
            Console.WriteLine(t1 +"\n" + t2 );
            for(int i =1; i<=n1;i++)
            {
                nt = t1 + t2;
                Console.WriteLine(nt);
                t1 = t2;
                t2 = nt;
                
            }
            
        }

        public static void factors(int a)
        {
            for(int i=1;i<=a;i++)
            {
                if(a%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void multiples(int a)
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("{0} x {1}={2}\n",a,i,a*i);
            }
        }
        static void Main()
        {
            
            cal c = new cal(factorial);
            Console.WriteLine("enter the number for factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            c(n);
            
            Console.WriteLine("enter the number for fibonacci");
            int n1 = Convert.ToInt32(Console.ReadLine());
            c = fibonacci;
            c.Invoke(n1);
            Console.WriteLine("enter the number for factors");
            int n2= Convert.ToInt32(Console.ReadLine());
            c = factors;
            c.Invoke(n2);
            Console.WriteLine("enter the number for multiples");
            int n3= Convert.ToInt32(Console.ReadLine());
            c= multiples;
            c.Invoke(n3);
        }
    }

}