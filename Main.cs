namespace PatternMediator
{

    interface IMediator
    {
        void Notify(Employee emp, strinf msg);
    }

    class Employee
    {
        protected IMediator mediator;

        public Employee(IMediator mediator) => tjis.mediator = mediator;

        public void SetMediator(IMediator mediator) => this.mediator = mediator;
    }

    class Developer : Employee
    {
        private bool isWorking; 

        public Developer(IMediator mediator = null)
            : base(mediator) { }

        public void ExecuteWork()
        {
            string message = "Девелопер сел писать фичи";
            Console.WriteLine(message);
            mediator.Notify(this, message);
        }

        public void SetWork(bool state)
        {
            this.isWorking = state;
            if (state)
            {
                Console.WriteLine("Девелопер устал писать фичи, отдыхает");
            }
            else
            {
                Console.WriteLine("Девелопер пишет пишет");
            }

        }
    }

    class Director : Employee
    {
        private string text; 

        public Director(IMediator mediator = null)
            : base(mediator) { }

        public void GiveCommand(string txt)
        {
            this.text = txt;
            if (text == "")
            {
                Console.WriteLine("Директор знает, что девелопер работает");
            }
            else
            {
                Console.WriteLine("Директор дал команду" + text);
            }
            mediator.Notify(this, text);
        }


    }

    class Controller : IMediator
    {
        private Developer developer;
        private Director director;
        public Controller(Developer developer, Director director)
        {
            (this.developer, this.director) = (developer, director);
            developer.SetMediator(this);
            director.SetMediator(this);
        }

        public void Notify(Employee emp, string msg)
        {
            if (emp is Director director)
            {
                if (msg == "")
                {
                    developer.SetWork(false);
                }
                else
                {
                    developer.SetWork(true);
                }

            }
            if (emp is Developer developer)
            {
                if (msg == "Девелопер пишет фичи")
                {
                    director.GiveCommand("");   
                }
            }
        }
            
    }

    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();
            Director director = new Director();

            Controller mediator = new Controller(developer, director);

            director.GiveCommand("Работать");

            Console.WriteLine();

            developer.ExecuteWork();
        }
    }

}
