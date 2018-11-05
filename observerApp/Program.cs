using System;
using observerApp.classes;

namespace observerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject sub = Subject.GetSubject();

            MobileUser mUser = new MobileUser();
            DesktopUser dUser = new DesktopUser();

            sub.SetState("Seja bem vindo ao nosso App!");
            sub.SetState("Confira nossas promoções");

        }
    }
}
