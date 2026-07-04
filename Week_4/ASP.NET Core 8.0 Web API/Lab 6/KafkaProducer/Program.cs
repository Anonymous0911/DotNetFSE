using Confluent.Kafka;

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer =
    new ProducerBuilder<Null, string>(config).Build();

Console.WriteLine("Type message:");

while (true)
{
    string message = Console.ReadLine();

    await producer.ProduceAsync("chat",
        new Message<Null, string>
        {
            Value = message
        });

    Console.WriteLine("Sent");
}