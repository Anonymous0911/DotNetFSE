using System;

class Program
{
    static void Main(string[] args)
    {
        Notifier notifier = new EmailNotifier();

        notifier = new SMSNotifierDecorator(notifier);
        notifier = new SlackNotifierDecorator(notifier);

        notifier.Send("System maintenance scheduled at 10 PM.");
    }
}