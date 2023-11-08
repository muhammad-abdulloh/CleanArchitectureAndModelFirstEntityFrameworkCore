namespace Demo.Domain.Models.KamronbekXModel;

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int PersonId { get; set; }
    public Person Person { get; set; }
}
