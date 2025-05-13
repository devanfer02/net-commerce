using Microsoft.AspNetCore.Identity;
using NetCommerce.Domain.Common;

namespace NetCommerce.Domain.Entities;

public class User : IdentityUser, IModelBase
{
    public required string FullName { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}