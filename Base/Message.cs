using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator
{
    abstract class Message: IMessage
    {
        protected string _text;
        public Message(string text)
        {
            _text = text;
        }
        abstract public void PrintMessage();

    }
}
