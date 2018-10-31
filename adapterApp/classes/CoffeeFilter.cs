namespace adapterApp.classes
{
    public class CoffeeFilter : IFilter
    {
       private Coffee _cafe;

        public CoffeeFilter(Coffee cafe) => _cafe = cafe;

        public string GetCoffee()
        {
            return _cafe.GetCoffee() + " filtrado";
        }

    }
}