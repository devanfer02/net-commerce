using System.ComponentModel.DataAnnotations;

namespace NetCommerce.Domain.Common;

public interface IModelBase
{
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }   
}