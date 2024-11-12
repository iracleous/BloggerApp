using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns2.DecoratorPattern;

// Step 1: Create a component interface
public interface IMessage
{
    string GetContent();
}

// Step 2: Implement the concrete component
public class TextMessage : IMessage
{
    private readonly string _content;

    public TextMessage(string content)
    {
        _content = content;
    }

    public string GetContent()
    {
        return _content;
    }
}

// Step 3: Create an abstract decorator class that implements the component interface
public abstract class MessageDecorator : IMessage
{
    protected IMessage _message;

    public MessageDecorator(IMessage message)
    {
        _message = message;
    }

    public virtual string GetContent()
    {
        return _message.GetContent();
    }
}

// Step 4: Implement concrete decorators
public class EncryptedMessage : MessageDecorator
{
    public EncryptedMessage(IMessage message) : base(message) { }

    public override string GetContent()
    {
        // Here, we just simulate encryption by reversing the string
        var content = _message.GetContent();
        char[] charArray = content.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

public class CompressedMessage : MessageDecorator
{
    public CompressedMessage(IMessage message) : base(message) { }

    public override string GetContent()
    {
        // Simulate compression by converting to uppercase
        return _message.GetContent().ToUpper();
    }
}