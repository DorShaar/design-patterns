using System;

namespace MediatorPattern
{
    public class ComputerColleague : IColleague
    {
        public string Name { get; }

        public ComputerColleague(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Send further messages to this new Colleague from now onwards
        /// </summary>
        public void ReceiveRegisterNotification(object sender, ColleagueArgs colleagueArgs)
        {
            Console.WriteLine($"New Computer registered with name: {colleagueArgs.Colleague.Name}." +
                $" Received: {Name}");
        }

        /// <summary>
        /// Do not send further messages to this Colleague from now onwards
        /// </summary>
        public void ReceiveUnRegisterNotification(object sender, ColleagueArgs colleagueArgs)
        {
            Console.WriteLine($"New Computer left with name: {colleagueArgs.Colleague.Name}." +
                $" Received: {Name}");
        }
    }
}