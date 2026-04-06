namespace oop_sample.SCM.Domain.Model.ValueObjects;
/// <summary>
/// Represent a supplier a identifier value object in the supply chain management (SCM) bounded context.
/// </summary>
public record SupplierId
{
    public string Identifier { get; init; }
    /// <summary>
    /// Creates a new instance of <see cref="SupplierId"/>
    /// </summary>
    /// <param name="identifier"></param>
    /// <exception cref="ArgumentException"></exception>
    public SupplierId(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentException("Supplier identifier cannot be null or empty.", nameof(identifier));
        Identifier = identifier;
    }
   
}