// See https://aka.ms/new-console-template for more information
using PatternDecorator;

var messages = new List<IMessage>
 {
 new NormalDecorator(new SimpleMessage("First Message!")),
 new NormalDecorator(new AlertMessage("Second Message with a beep!")),
 new ErrorDecorator(new AlertMessage("Third Message with a beep and in red!")),
 new SimpleMessage("Not Decorated...")
 };
foreach (var message in messages)
{
    message.PrintMessage();
}
Console.Read();