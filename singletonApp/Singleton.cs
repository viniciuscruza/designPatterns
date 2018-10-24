class Singleton{
    private static Singleton _instance;
    public int Saldo {get;set;}

    private Singleton (){}

    public static Singleton getInstance()
    {
        if(_instance == null)
            _instance = new Singleton();
        
        return _instance;
    }
}