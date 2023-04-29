using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator
{
    class NormalDecorator : MessageDecorator
    {
        public NormalDecorator(Message message) : base(message) { }
        public override void PrintMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _message.PrintMessage();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
