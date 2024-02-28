using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class Student
{
    private IList<Subscription> _subscriptions = [];
    public Student(Name name, Document document, Email email)
    {
        Name = name;
        Document = document;
        Email = email;
    }

    public Name Name { get; private set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public Address Address { get; private set; }
    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

    public void AddSubscription(Subscription subscription)
    {
        foreach (var sub in Subscriptions)
        {
            sub.Inactivate();
        }

        _subscriptions.Add(subscription);
    }
}