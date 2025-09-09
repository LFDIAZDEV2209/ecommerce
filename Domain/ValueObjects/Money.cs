namespace Domain.ValueObjects;

public readonly record struct Money
{
    public decimal Amount { get; }
    public string Currency { get; }

    public Money(decimal amount, string currency)
    {
        if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
        if (string.IsNullOrWhiteSpace(currency) || currency.Length is < 3 or > 3) throw new ArgumentException("Currency must be a 3-letter ISO code.", nameof(currency));

        Amount = decimal.Round(amount, 2);
        Currency = currency.ToUpperInvariant();
    }

    public static Money Zero(string currency) => new(0, currency);

    public Money Add(Money other)
    {
        if (Currency != other.Currency) throw new InvalidOperationException("Cannot add amounts with different currencies.");

        return new Money(Amount + other.Amount, Currency);
    }

    public Money Multiply(int qty)
    {
        if (qty < 0) throw new ArgumentOutOfRangeException(nameof(qty));
        return new Money(Amount * qty, Currency);
    }

    public override string ToString() => $"{Currency} {Amount:F2}";
    
}
