namespace factoryApp
{
    public class BotFactory
    {
        public static IBot createBot(BotType type)
        {
            switch(type)
            {
                case BotType.CT:
                    return new CBot();
                case BotType.T:
                    return new TBot();
                default:
                    return null;
            }
        }
    }
}
