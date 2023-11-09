using Demo.Application.Repositories.OrderRepositories;

namespace Demo.Infrastructure.Services.OrdersService;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async ValueTask<bool> CreateOrderAsync(string name, int id = 0)
    {
        var order = new Order() { Name = name, PersonId = id };
        return await _orderRepository.CreateOrderAsync(order);

    }

    public async ValueTask<bool> CreateOrderAsync(int id, string name)
    {
        var order = new Order() {  Id = id, Name = name };
        return await _orderRepository.CreateOrderAsync(order);
    }

    public async ValueTask<Order> GetOrderByIdAsync(int id)
    {
        return await _orderRepository.GetOrderByIdAsync(id);
    }

    public async ValueTask<IEnumerable<Order>> GetOrdersAsync()
    {
        return await _orderRepository.GetAllAsync();
    }

    public async ValueTask<bool> RemoveOrderAsync(int id)
    {
        return await _orderRepository.DeleteOrderAsync(id);
    }

    public ValueTask<bool> UpdateOrderAsync(int id, string name)
    {
        var order = new Order() { PersonId = id, Name = name };
        return _orderRepository.UpdateOrderAsync(order);
    }
}
