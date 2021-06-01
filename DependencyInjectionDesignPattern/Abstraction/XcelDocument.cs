using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDesignPattern.Abstraction
{
    public class XcelDocument : IDocument
    {
        public void Print()
        {
            Console.WriteLine("Here is the xcel sheet document");
        }
    }
}
