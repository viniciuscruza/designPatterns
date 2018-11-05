using System;

namespace observerApp.classes
{
    public class MobileUser : AppUser, IObserver
    {

        public MobileUser(string name)
        {
            sub = Subject.GetSubject();
            sub.add(this);
            this.name = name;
        }

        public void update()
        {
            Console.WriteLine("[MOBILE] Notificação enviada: " + this.name + ", " + sub.GetState());
        }
    }
}