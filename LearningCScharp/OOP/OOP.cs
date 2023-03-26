

class Program2
{
    static void Main(string[] args)
    {
        p.Person person = new p.Person("Alex", 12);
        
    }
}

namespace p
{
    class Person
    {
        private string name = "";
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public string GetName() => name;
        public int GetAge() => age;

        public void SetName(string name) => this.name = name;

        public void SetAge(int age) => this.age = age;
    }
}




 