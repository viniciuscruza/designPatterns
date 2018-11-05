using System;
using observerApp.classes;

namespace observerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject sub = Subject.GetSubject();

            MobileUser mUser = new MobileUser("Dave Grohl");
            DesktopUser dUser = new DesktopUser("Taylor Hawkins");

            sub.SetState("seja bem vindo ao nosso App!");
            sub.SetState("confira nossas promoções.");

        }
    }
}
