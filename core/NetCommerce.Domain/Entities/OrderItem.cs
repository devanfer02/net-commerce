using System.ComponentModel.DataAnnotations.Schema;
using NetCommerce.Domain.Common;

namespace NetCommerce.Domain.Entities;

public class OrderItem : ModelBase
{
    public required decimal Price { get; set; }
    public required int Quantity { get; set; }
    [ForeignKey("OrderId")]
    public required Order Order { get; set; }
    [ForeignKey("ProductId")]
    public required Product Product { get; set; }
}