
using System;

namespace Learning05.Models
{
    
    public class Shape
    {
        
        private string _color;

        
        public Shape(string color)
        {
            _color = color;
        }

        
        public virtual double GetArea()
        {
            
            return 0.0;
        }

        
        public string GetColor()
        {
            return _color;
        }
    }
}
