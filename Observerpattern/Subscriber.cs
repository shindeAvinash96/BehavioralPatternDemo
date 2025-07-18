namespace Observer
{
    internal class Subscriber : IObserver
    {
        private string name;
        public Subscriber(string name)
        {
            this.name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{name} received news: {message}");
        }
    }
}