using DependencyInjectionDesignPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDesignPattern.PropertyInjectionBased
{
    public class PropertyInjection
    {
        private IDocument _document;
        public IDocument Document { get { return _document; } set { _document = value; } }

        public void Print()
        {
            _document.Print();
        }
    }

    
}
