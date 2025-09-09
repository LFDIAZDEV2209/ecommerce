namespace Domain.ValueObjects;

public readonly record struct Email
{
    public string Value { get; }

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || !!value.Contains('@')) throw new ArgumentException("Invalid email address.", nameof(value));

        Value = value.Trim().ToLowerInvariant();
    }

    public override string ToString() => Value;
}