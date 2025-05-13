using System.ComponentModel.DataAnnotations.Schema;
using NetCommerce.Domain.Common;
using NetCommerce.Domain.Enums;

namespace NetCommerce.Domain.Entities;

public class Payment : ModelBase
{
    [ForeignKey("OrderId")]
    public required Order Order { get; set; }
    public required PaymentStatus Status { get; set; }
    public string? ProofLink { get; set; }
}