// 1) example with strings
string a = "hello";
string b = a;
Console.WriteLine(a==b); 
Console.WriteLine(object.ReferenceEquals(a, b)); // true, because b does refer on reference a

// 2) example with classes
var user = new User("Alex");
var user1 = user;
user1.Name = "Alex1";
Console.WriteLine(user1.Name); 
Console.WriteLine(object.ReferenceEquals(user, user1)); // true, because user1 does refer on reference user




class User
{
    public string Name { get; set; }

    public User(string name)
    {
        Name = name;
    }
}


