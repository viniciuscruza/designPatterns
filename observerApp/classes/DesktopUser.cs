namespace observerApp.classes
{
    public class DesktopUser : AppUser, IObserver
    {
        public DesktopUser(string name)
        {
            sub = Subject.GetSubject();
            sub.add(this);
            this.name = name;
        }

        public void update()
        {
            System.Console.WriteLine("[DESKTOP] Notificação enviada: " + this.name + ", " + sub.GetState());
        }
    }
}