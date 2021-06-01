using DependencyInjectionDesignPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDesignPattern.ConstructorInjectionBased
{
    public class ConstructorInjection
    {
        private IDocument _document;
        public ConstructorInjection(IDocument document)
        {
            _document = document;
        }
        public void Print()
        {
            _document.Print();
        }
    }
}
