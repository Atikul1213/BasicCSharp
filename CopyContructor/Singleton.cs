namespace CopyContructor
{
    public sealed class Singleton
    {
        private static int Counter = 0;
        private static Singleton Instance = null;
        private static readonly object Instancelock = new object();
        public static Singleton GetSingletonInstance()
        {
            lock (Instancelock)
            {
                if (Instance == null)
                    Instance = new Singleton();

                return Instance;
            }
        }

        private Singleton()
        {
            Counter++;
            Console.WriteLine("Singleton constructor execute: " + Counter);
        }

        public void SomeMethod(string mess)
        {
            Console.WriteLine("Some method called: " + mess);
        }
    }
}
