using DependencyInjectionDesignPattern.Abstraction;
using DependencyInjectionDesignPattern.ConstructorInjectionBased;
using DependencyInjectionDesignPattern.PropertyInjectionBased;
using System;

namespace DependencyInjectionDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Constructor Injection
            ConstructorInjection constructorInjection = new ConstructorInjection(new WordDocument());
            constructorInjection.Print();

            //Property Injection
            PropertyInjection propertyInjection =new PropertyInjection();
            propertyInjection.Document = new XcelDocument();
            propertyInjection.Print();
        }
    }
}
