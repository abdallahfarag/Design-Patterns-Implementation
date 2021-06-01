using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDesignPattern.Abstraction
{
    public class WordDocument : IDocument
    {
        public void Print()
        {
            Console.WriteLine("Here is the word document");
        }
    }
}
