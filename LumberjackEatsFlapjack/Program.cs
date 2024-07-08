namespace LumberjackEatsFlapjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Lumberjack> lumberjackQueue = new Queue<Lumberjack>();
            Console.Write("Imię pierwszego drwala: ");
            lumberjackQueue.Enqueue(new Lumberjack(Console.ReadLine()));
            Console.Write("Libcza naleśników: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfFlapjack))
                for (int i = 0; i < numberOfFlapjack; i++)
                    lumberjackQueue.Peek().TakeFlapjack();
            string lumberjackName = "";
            do
            {
                Console.Write("Imię następnego drwala (pusty wiersz aby zakończyć): ");
                lumberjackName = Console.ReadLine();
                if (lumberjackName != "")
                {
                    lumberjackQueue.Enqueue(new Lumberjack(lumberjackName));
                    Console.Write("Liczba naleśników: ");
                    Stack<Lumberjack> lumberjackStack = new Stack<Lumberjack>(lumberjackQueue);
                    if (int.TryParse(Console.ReadLine(), out numberOfFlapjack))
                        for (int i = 0; i < numberOfFlapjack; i++)
                            lumberjackStack.Peek().TakeFlapjack();
                }
            } while (lumberjackName != "");

            while (lumberjackQueue.Count > 0)
                lumberjackQueue.Dequeue().EatFlapjack();
        }
    }
}
