using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands;

public class CreateBoletoSubscriptionCommand : Notifiable, ICommand
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Document { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public string BarCode { get; private set; } = string.Empty;
    public string BoletoNumber { get; private set; } = string.Empty;

    public string PaymentNumber { get; set; } = string.Empty;
    public DateTime PaidDate { get; set; }
    public DateTime ExpireDate { get; set; }
    public decimal Total { get; set; }
    public decimal TotalPaid { get; set; }
    public string Payer { get; set; } = string.Empty;
    public string PayerDocument { get; set; } = string.Empty;
    public string PayerEmail { get; set; } = string.Empty;
    public EDocumentType PayerDocumentType { get; set; }
    public string Street { get; private set; } = string.Empty;
    public string Number { get; private set; } = string.Empty;
    public string Neighborhood { get; private set; } = string.Empty;
    public string City { get; private set; } = string.Empty;
    public string State { get; private set; } = string.Empty;
    public string Country { get; private set; } = string.Empty;
    public string ZipCode { get; private set; } = string.Empty;

    public void Validate()
    {
        AddNotifications(new Contract()
                   .Requires()
                   .HasMinLen(FirstName, 3, "Name.FirstName", "O nome deve conter pelo menos 3 caracteres")
                   .HasMinLen(LastName, 3, "Name.LastNameName", "O sobrenome deve conter pelo menos 3 caracteres")
                   .HasMaxLen(FirstName, 40, "Name.FirstName", "O nome deve conter até 40 caracteres")
               );
    }
}
