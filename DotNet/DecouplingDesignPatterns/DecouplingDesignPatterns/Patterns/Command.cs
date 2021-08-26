using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouplingDesignPatterns.Patterns
{
    /* Overview:
     * In the command pattern, every concrete command implements a command interface
     * which requires implementation of an Execute() method. Because every concrete 
     * command implements this interface, vaious invoker classes can compose command
     * objects without worrying about what exactly the command does. Only that it will
     * Execute when the method is called.
     */
    class Command
    {
    }
}
