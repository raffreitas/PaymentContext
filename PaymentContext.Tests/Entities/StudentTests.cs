using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void AdicionarAssinatura()
    {
        var subscription = new Subscription(null);
        var student = new Student("Rafael", "Freitas", "3242234", "rafeal@email.com");
        student.AddSubscription(subscription);
    }
}
