global using Demo.Domain.Models.KamronbekXModel;

namespace Demo.Application.Repositories.OrderRepositories;

public interface IOrderRepository
{
    ValueTask<IEnumerable<Order>> GetAllAsync();
    ValueTask<Order> GetOrderByIdAsync(int id);
    ValueTask<bool> CreateOrderAsync(Order order);
    ValueTask<bool> UpdateOrderAsync(Order order);
    ValueTask<bool> DeleteOrderAsync(int id);
}
