using System;

namespace factoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IBot c = BotFactory.createBot(BotType.CT);
            Console.WriteLine("Bot CT: " + c.getSide());

            IBot t = BotFactory.createBot(BotType.T);
            Console.WriteLine("Bot T: " + t.getSide());

        }
    }
}
