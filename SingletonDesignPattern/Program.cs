using System;

namespace SingletonDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton singletonObj1= Singleton.SingletonInstance();
            Singleton singletonObj2 = Singleton.SingletonInstance();

            if(singletonObj1 == singletonObj2)
            {
                Console.WriteLine("Both objects are the same instance....");
            }
        }
    }
}
