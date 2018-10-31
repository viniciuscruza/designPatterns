using System;
using adapterApp.classes;

namespace adapterApp.main
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee cafe = new Coffee();
            Console.WriteLine("Pedido - Café puro: " + cafe.GetCoffee());

            IFilter cafeFiltrado = new CoffeeFilter(cafe);
            Console.WriteLine("Pedido - Café filtrado: " + cafeFiltrado.GetCoffee());
        }
    }
}
