using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests;

[TestClass]
public class CreateBoletoSubscriptionCommandTests
{

    [TestMethod]
    public void ShouldReturnErrorWhenNameIsInvalid()
    {
        var command = new CreateBoletoSubscriptionCommand
        {
            FirstName = ""
        };

        command.Validate();

        Assert.AreEqual(false, command.Valid);
    }
}
