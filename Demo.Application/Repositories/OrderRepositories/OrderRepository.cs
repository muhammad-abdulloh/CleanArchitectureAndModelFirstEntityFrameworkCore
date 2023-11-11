global using Demo.Application.DataAcsess;
global using Microsoft.EntityFrameworkCore;

namespace Demo.Application.Repositories.OrderRepositories;

public class OrderRepository : IOrderRepository
{
    private readonly DemoDbContext _dbContext;

    public OrderRepository(DemoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<bool> CreateOrderAsync(Order order)
    {
        await _dbContext.AddAsync(order);
        int res = await _dbContext.SaveChangesAsync();
        return res > 0;
    }

    public async ValueTask<bool> DeleteOrderAsync(int id)
    {
        Order temp = await _dbContext.Orders.FirstOrDefaultAsync(x=>x.Id == id);
        if (temp is null)
            return false;
        _dbContext.Remove(temp);
        int res = await _dbContext.SaveChangesAsync();
        return res > 0;
    }

    public async ValueTask<IEnumerable<Order>> GetAllAsync()
    {
        return _dbContext.Orders.FromSql($"select * from orders");
        return await _dbContext.Orders.ToListAsync();
    }

    public async ValueTask<Order> GetOrderByIdAsync(int id)
    {
        Order temp = await _dbContext.Orders.FirstOrDefaultAsync(x => x.Id == id);
        return temp;
    }

    public async ValueTask<bool> UpdateOrderAsync(Order order)
    {
        Order temp = await _dbContext.Orders.FirstOrDefaultAsync(x=>x.Id == order.Id);
        if(temp is null)
            return false;
        temp.Name = order.Name;
        if(order.PersonId != 0)
            temp.PersonId = order.PersonId;

        int res = await _dbContext.SaveChangesAsync();
        return res > 0;
    }
}
