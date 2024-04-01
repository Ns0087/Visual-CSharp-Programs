using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace Sample_01
{
    class RabbitMQConnectionChecker
    {
        public void ConnectionChecker()
        {
            string rabbitMQHost = "amqps://b-6441ac46-866f-47ea-9d53-af56e585474f.mq.ap-south-1.amazonaws.com"; // Replace with your RabbitMQ server host
            int rabbitMQPort = 5671; // Default RabbitMQ port
            var rabbitUri = new Uri("amqps://b-6441ac46-866f-47ea-9d53-af56e585474f.mq.ap-south-1.amazonaws.com:5671");
            ConnectionFactory factory = new ConnectionFactory
            {
                //Uri = new Uri("amqps://b-6441ac46-866f-47ea-9d53-af56e585474f.mq.ap-south-1.amazonaws.com:5671"),
                HostName = rabbitUri.Host,
                Port = rabbitUri.Port,
                UserName = "eduplanner",
                Password = "eduplanner123",
                ClientProvidedName = "eduplanner-test",
                Ssl = {Enabled = true}
            };

            try
            {
                var endpoint = factory.Endpoint;
                using (IConnection connection = factory.CreateConnection())
                {
                    Console.WriteLine("Connection to RabbitMQ established successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to RabbitMQ: {ex.Message}");
            }
        }
    }
}




