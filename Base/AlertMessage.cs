using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator
{
    class AlertMessage : Message
    {
        public AlertMessage(string text) : base(text) { }
        public override void PrintMessage()
        {
            Console.Beep();
            Console.WriteLine(_text);
        }
    }
}
