using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDecorator
{
    abstract class MessageDecorator : IMessage
    {
        protected Message _message;
        public MessageDecorator(Message message)
        {
            _message = message;
        }
        public abstract void PrintMessage();
    }
}
