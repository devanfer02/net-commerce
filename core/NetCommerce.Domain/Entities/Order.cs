using System.ComponentModel.DataAnnotations.Schema;
using NetCommerce.Domain.Common;
using NetCommerce.Domain.Enums;

namespace NetCommerce.Domain.Entities;

public class Order : ModelBase
{
    public decimal Total { get; set; }
    public OrderStatus Status { get; set; }
    [ForeignKey("UserId")]
    public required User User { get; set; }
}