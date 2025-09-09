namespace Domain.Entities;

public class Brand : BaseEntity<int>
{
    public string? Name { get; set; } = default!;
    private Brand() { }
}