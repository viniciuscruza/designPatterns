using System;

namespace observerApp.classes
{
    public class MobileUser : AppUser, IObserver
    {

        public MobileUser()
        {
            sub = Subject.GetSubject();
            sub.add(this);
        }

        public void update()
        {
            Console.WriteLine("[MOBILE] Notificação enviada: " + sub.GetState());
        }
    }
}