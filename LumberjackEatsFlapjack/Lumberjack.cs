using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberjackEatsFlapjack
{
    internal class Lumberjack
    {
        public string Name { get; private set; }
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();
        private static readonly Random random = new Random();

        public Lumberjack(string name)
        {
            Name = name;
        }

        public void TakeFlapjack()
        {
            flapjackStack.Push((Flapjack)random.Next(4));
        }

        public void EatFlapjack()
        {
            Console.WriteLine($"{Name} je naleśniki.");
            while (flapjackStack.Count > 0)
                Console.WriteLine($"{Name} je {flapjackStack.Pop()} naleśnik.");
        }
    }
}
