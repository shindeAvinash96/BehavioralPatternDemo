namespace Observer
{
    internal class NewsChannel                  //Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string news;

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine("New subscriber added.");
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
            Console.WriteLine("A subscriber has been removed.");
        }

        public void SetNews(string news)
        {
            this.news = news;
            NotifyAllObservers();
        }

        private void NotifyAllObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(news);
            }
        }
    }
}