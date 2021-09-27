using System;

namespace MediatorPattern
{
   
    public static class Program
    {
        public static void Main(string[] _)
        {
            IMediator mediator = new NetworkMediator();
            ComputerColleague colleague1 = new ComputerColleague("Eagle");
            ComputerColleague colleague2 = new ComputerColleague("Ostrich");
            ComputerColleague colleague3 = new ComputerColleague("Penguin");
            mediator.Register(colleague1);
            mediator.Register(colleague2);
            mediator.Register(colleague3);
            mediator.Unregister(colleague1);

            Console.ReadLine();
        }
    }
}