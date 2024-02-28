﻿using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;

public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        AddNotifications(new Contract()
            .Requires()
            .HasMinLen(FirstName, 3, "Name.FirstName", "O nome deve conter pelo menos 3 caracteres")
            .HasMinLen(LastName, 3, "Name.LastNameName", "O sobrenome deve conter pelo menos 3 caracteres")
            .HasMaxLen(FirstName, 40, "Name.FirstName", "O nome deve conter até 40 caracteres")
        );
    }

    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
}