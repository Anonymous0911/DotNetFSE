using Confluent.Kafka;

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer =
    new ProducerBuilder<Null, string>(config).Build();

Console.WriteLine("Producer Started");

while (true)
{
    Console.Write("You : ");

    string? message = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(message))
        continue;

    await producer.ProduceAsync(
        "chat",
        new Message<Null, string>
        {
            Value = message
        });

    Console.WriteLine("Message Sent");
}