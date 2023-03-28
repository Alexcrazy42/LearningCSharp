using System.Net.Mail;

MessageBuilder messageBuilder = WriteEmailMessage; // ковариантность
Message message = messageBuilder("Hello");
message.Print();    // Email: Hello

EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);

delegate Message MessageBuilder(string text);


class Message
{
    public string Text { get; }
    public Message(string text) => Text = text;
    public virtual void Print() => Console.WriteLine($"Message: {Text}");
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
    public override void Print() => Console.WriteLine($"Email: {Text}");
}
class SmsMessage : Message
{
    public SmsMessage(string text) : base(text) { }
    public override void Print() => Console.WriteLine($"Sms: {Text}");
}