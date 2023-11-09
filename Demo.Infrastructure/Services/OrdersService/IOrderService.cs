global using Demo.Domain.Models.KamronbekXModel;

namespace Demo.Infrastructure.Services.OrdersService;

public interface IOrderService
{
    ValueTask<IEnumerable<Order>> GetOrdersAsync();
    ValueTask<Order> GetOrderByIdAsync(int id);
    ValueTask<bool> RemoveOrderAsync(int id);
    ValueTask<bool> CreateOrderAsync(int id, string name);
    ValueTask<bool> UpdateOrderAsync(int id, string name);
}
