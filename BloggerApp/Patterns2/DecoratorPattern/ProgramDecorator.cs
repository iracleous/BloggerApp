using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns2.DecoratorPattern;
/// <summary>
/// Component Interface (IMessage): Defines a GetContent method.
/// Concrete Component(TextMessage): Implements IMessage and provides the base message.
/// Abstract Decorator(MessageDecorator): Implements IMessage and takes an IMessage object to add functionality.
/// Concrete Decorators (EncryptedMessage and CompressedMessage):
///     Modify the behavior of the message by adding encryption and compression features.
/// </summary>
public static class ProgramDecorator
{
    public static void MainDecorator()
    {
        IMessage message = new TextMessage("Hello, World!");

        Console.WriteLine("Original Message: " + message.GetContent());

        IMessage encryptedMessage = new EncryptedMessage(message);
        Console.WriteLine("Encrypted Message: " + encryptedMessage.GetContent());

        IMessage compressedMessage = new CompressedMessage(encryptedMessage);
        Console.WriteLine("Encrypted & Compressed Message: " + compressedMessage.GetContent());
    }
}
