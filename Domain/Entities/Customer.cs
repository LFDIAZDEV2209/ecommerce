using Domain.ValueObjects;

namespace Domain.Entities;

public class Customer : BaseEntity<Guid>
{
    public string? FirstName { get; set; } = default!;
    public string? LastName { get; set; } = default!;
    public Email Email { get; set; }
    public Address Address { get; set; } = default!;
    private Customer() { }
}