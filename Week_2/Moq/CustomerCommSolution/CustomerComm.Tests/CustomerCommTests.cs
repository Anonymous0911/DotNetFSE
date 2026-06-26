using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace CustomerComm.Tests;

[TestFixture]
public class CustomerCommTests
{
    private Mock<IMailSender> mockMailSender;
    private CustomerCommLib.CustomerComm customerComm;

    [OneTimeSetUp]
    public void Init()
    {
        mockMailSender = new Mock<IMailSender>();

        mockMailSender
            .Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(true);

        customerComm = new CustomerCommLib.CustomerComm(mockMailSender.Object);
    }

    [TestCase]
    public void SendMailToCustomer_ReturnsTrue()
    {
        bool result = customerComm.SendMailToCustomer();

        Assert.That(result, Is.True);
    }
}