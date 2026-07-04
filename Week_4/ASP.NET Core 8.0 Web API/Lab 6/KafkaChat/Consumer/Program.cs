using Confluent.Kafka;

var config = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",

    GroupId = Guid.NewGuid().ToString(),

    AutoOffsetReset = AutoOffsetReset.Earliest
};

using var consumer =
    new ConsumerBuilder<Ignore, string>(config).Build();

consumer.Subscribe("chat");

Console.WriteLine("Listening...");

while (true)
{
    var result = consumer.Consume();

    Console.WriteLine(result.Message.Value);
}