namespace _14._03
{
    class Program
    {
        public delegate string Message(string Title, string Body);
        static void Main(string[] args)
        {
            SendMessage send = new SendMessage();
            Console.Write("Enter message title\n> ");
            string title = Console.ReadLine();
            Console.Write("Enter message body\n> ");
            string body = Console.ReadLine();

            Message message = send.Send_Message;
            Console.WriteLine(message(title, body));
        }
    }
    public class SendMessage
    {
        public string Send_Message(string Title, string Body)
        {
            return $"\t\t{Title}\n{Body}";
        }
    }
}
