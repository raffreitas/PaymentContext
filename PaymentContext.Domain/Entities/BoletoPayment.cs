﻿using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain;

public class BoletoPayment : Payment
{
    public BoletoPayment(string barCode, string boletoNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string document, string address, string email)
        : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
    {
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }

    public string BarCode { get; private set; } = string.Empty;
    public string BoletoNumber { get; private set; } = string.Empty;
}
