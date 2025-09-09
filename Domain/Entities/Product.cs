using Domain.ValueObjects;

namespace Domain.Entities;

public class Product : BaseEntity<int>
{
    public string? Name { get; set; } = default!;
    public string? Description { get; set; } = default!;
    public decimal Price { get; set; }
    public bool isActive { get; set; }
    private Product() { }
}