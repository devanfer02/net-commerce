namespace NetCommerce.Domain.Enums;

public enum OrderStatus
{
    PENDING = 1,
    CONFIRMED = 2,
    SHIPPED = 3,
    DELIVERED = 4,
    CANCELED = 5,
    REFUNDED = 6,
    FAILED = 7
}