
namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewsChannel channel = new NewsChannel();

            Subscriber s1 = new Subscriber("Srija");
            Subscriber s2 = new Subscriber("Shreya");
            channel.Subscribe(s1);
            channel.Subscribe(s2);

            channel.SetNews("Breaking: New Design Pattern Released!");

            // Unsubscribe one observer
            channel.Unsubscribe(s2);

            // Set another news
            channel.SetNews("AI beats human in chess again!");
        }

    }
}