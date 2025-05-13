using System.ComponentModel.DataAnnotations;

namespace NetCommerce.Domain.Common;

public class ModelBase : IModelBase
{
    [Key]
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}