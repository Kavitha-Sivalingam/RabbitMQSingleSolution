using Microsoft.EntityFrameworkCore;

namespace RabbitMQPublisher.Data
{
    public interface IOrderDbContext
    {
        DbSet<Order> Order { get; set; }

        Task<int> SaveChangesAsync();
    }
}
