using NetCommerce.Domain.Common;

namespace NetCommerce.Domain.Entities;

public class Category : ModelBase
{
    public required string Name { get; set; }
}