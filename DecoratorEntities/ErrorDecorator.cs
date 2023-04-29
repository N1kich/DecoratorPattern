using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator
{
    class ErrorDecorator : MessageDecorator
    {
        public ErrorDecorator(Message message) : base(message) { }
        public override void PrintMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            _message.PrintMessage();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
