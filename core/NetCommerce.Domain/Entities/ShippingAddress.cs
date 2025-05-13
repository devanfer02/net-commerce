using System.ComponentModel.DataAnnotations.Schema;
using NetCommerce.Domain.Common;

namespace NetCommerce.Domain.Entities;

public class ShippingAddress : ModelBase
{
    [ForeignKey("UserId")]
    public required User User { get; set; }
    public required string Address { get; set;  }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string ZipCode { get; set; }
    public required string Country { get; set; }
    
}