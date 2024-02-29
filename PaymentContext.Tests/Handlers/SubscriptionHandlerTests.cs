using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests;

[TestClass]
public class SubscriptionHandlerTests
{
    [TestMethod]
    public void ShouldReturnErrorWhenDocumentExists()
    {
        var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
        var command = new CreateBoletoSubscriptionCommand
        {
            FirstName = "Bruce",
            LastName = "Wayne",
            Document = "999999999991",
            Email = "test@test.com",
            BarCode = "123456789",
            BoletoNumber = "123456789",
            PaymentNumber = "123456789",
            PaidDate = DateTime.Now,
            ExpireDate = DateTime.Now.AddMonths(1),
            Total = 60,
            TotalPaid = 60,
            Payer = "WAYNE CORP",
            PayerDocument = "12345678911",
            PayerDocumentType = EDocumentType.CPF,
            PayerEmail = "batman@dc.com",
            Street = "asdf",
            Number = "asdf",
            Neighborhood = "asdf",
            City = "asdf",
            State = "asdf",
            Country = "asdf",
            ZipCode = "asdf"
        };

        handler.Handle(command);

        Assert.AreEqual(false, handler.Valid);
    }
}
