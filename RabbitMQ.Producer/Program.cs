﻿using RabbitMQ.Client;
using System;

namespace RabbitMQ.Producer
{
    static class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
             var connection = factory.CreateConnection();
             var channel = connection.CreateModel();
            QueueProducer.Publish(channel);
        }
    }
}
