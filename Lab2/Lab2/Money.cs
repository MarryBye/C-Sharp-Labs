namespace Lab2;

public class Money
{
    private int quantity, denomination;

    public Money(int quantity, int denomination)
    {
        this.quantity = quantity;
        this.denomination = denomination;
    }

    public override string ToString()
    {
        return $"Количество: {this.quantity} | Номинал: {this.denomination} | Баланс: {get_balance()}";
    }

    public int get_balance()
    {
        return this.quantity * this.denomination;
    }

    public bool can_buy(int price)
    {
        return (get_balance() >= price);
    }

    public int max_can_buy((string name, int price) Product)
    {
        if (!can_buy(Product.price))
        {
            Console.WriteLine($"Нельзя купить {Product.name}!");
            return 0;
        };
        return get_balance() / Product.price;
    }
    
}