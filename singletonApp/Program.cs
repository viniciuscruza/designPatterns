using System;

namespace singletonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton primeiraChamada = Singleton.getInstance();
            Console.WriteLine("Saldo: " + primeiraChamada.Saldo);
            primeiraChamada.Saldo = 10;

            Singleton segundaChamada = Singleton.getInstance();
            Console.WriteLine("Saldo: " + segundaChamada.Saldo);
            segundaChamada.Saldo = 50;

            Singleton terceiraChamada = Singleton.getInstance();
            Console.WriteLine("Saldo: " + terceiraChamada.Saldo);
        }
    }
}
