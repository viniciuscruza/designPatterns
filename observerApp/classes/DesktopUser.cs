namespace observerApp.classes
{
    public class DesktopUser : AppUser, IObserver
    {
        public DesktopUser()
        {
            sub = Subject.GetSubject();
            sub.add(this);
        }

        public void update()
        {
            System.Console.WriteLine("[DESKTOP] Notificação enviada: " + sub.GetState());
        }
    }
}