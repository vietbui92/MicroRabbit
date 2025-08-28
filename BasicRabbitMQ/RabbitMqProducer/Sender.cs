using RabbitMQ.Client;

namespace Producer
{
    public class Sender()
    {
        public static void Main()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare("BasicTest", false, false, false, null);

                string message = "Getting message from RabbitMQ!";
                var body = System.Text.Encoding.UTF8.GetBytes(message);

                channel.BasicPublish("", "BasicTest", null, body);
                Console.WriteLine(" Sent messgae {0}....", message);
            }
            Console.WriteLine(" Press [enter] to exit sender app.");
            Console.ReadLine();
        }
    }
}