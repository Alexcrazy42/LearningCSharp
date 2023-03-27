
Person sender = new Person("Александр");
Person receiver = new Person("Наталья");
Message message = new Message("Привет, как дела?");
Messenger<Message, Person> messenger = new Messenger<Message, Person>();
messenger.SendMessage(sender, receiver, message);


class Messenger<M, P>
    where M : Message 
    where P : Person
{ 
    public void SendMessage(P sender, P receiver, M message)
    {
        Console.WriteLine($"{sender.Name} to {receiver.Name}: {message.Text}");
    }
}




class Message
{
    private string text;
    public string Text
    {
        get { return text; }
        set { text = value; }
    }

    public Message(string text ) => this.text = text;
}

class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Person(string name) => this.name = name;
}
