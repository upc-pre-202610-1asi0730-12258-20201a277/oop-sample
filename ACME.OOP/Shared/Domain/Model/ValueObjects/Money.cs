namespace ACME.OOP.Shared.Domain.Model.ValueObjects;
/// <summary>
/// Represents a money value object containing amount and international currency code (ISO 4217)
/// </summary>
public record Money
{
    /// <summary>
    /// Creates a new instance of <see cref="Money"/>
    /// </summary>
    /// <param name="amount">The amount for the money value object</param>
    /// <param name="currency">The international currency code(ISO 4217) for the money value object. If given</param>
    /// <exception cref="ArgumentNullException"></exception>
    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = string.IsNullOrWhiteSpace(currency) || Currency.Length !=3 ? 
            throw new ArgumentNullException("Currency must be a valid 3-letter ISO code.", nameof(currency)) 
            : currency;
    }
    /// <summary>
    /// Provides a string representation for the <see cref="Money"/> value
    /// </summary>
    /// <returns></returns>A string in the format of "Amount Currency"
public override string ToString() => $"{Amount} {Currency}";

public Money Add(Money? other)
{
    if (other is not null && other.Currency != Currency)
        throw new ArgumentException("Cannot add more than one money.");
    return other == null ? this : new Money(Amount + other.Amount, Currency);
}


public Money Multiply (int multiplier) => new(Amount * multiplier, Currency);
    public decimal Amount { get; init; }
    public string Currency { get; init; }
    
    
    
    
}