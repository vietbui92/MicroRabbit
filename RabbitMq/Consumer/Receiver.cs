using RabbitMQ.Client;

namespace Consumer
{
    public class Receiver
    {
        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare("BasicTest", false, false, false, null);
            var consumer = new RabbitMQ.Client.Events.EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = System.Text.Encoding.UTF8.GetString(body);
                Console.WriteLine("Received mesage {0}...", message);
            };

            channel.BasicConsume("BasicTest", true, consumer);
            Console.WriteLine(" Press [enter] to exit the Receiver.");
            Console.ReadLine();
        }
    }
}