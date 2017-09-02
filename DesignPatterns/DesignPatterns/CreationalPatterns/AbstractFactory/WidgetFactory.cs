using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public abstract class WidgetFactory
    {
        public void CreateScrollBar()
        {

        }

        public void CreateWindow()
        {

        }

    }

    public class MotifWidgetFactory : WidgetFactory
    {
        public new void CreateScrollBar()
        {

        }

        public new void CreateWindow() 
        {

        }

    }
}
