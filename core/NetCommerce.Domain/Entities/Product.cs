using System.ComponentModel.DataAnnotations.Schema;
using NetCommerce.Domain.Common;

namespace NetCommerce.Domain.Entities;

public class Product : ModelBase
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }
    public required int Stock { get; set; }
    [ForeignKey("CategoryId")]
    public required Category Category { get; set; }
}