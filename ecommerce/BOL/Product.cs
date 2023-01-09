namespace BOL;
public class Product
{
    public int ProductId { get; set; }
    public string Title { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public float UnitPrice { get; set; }
    public int Balance { get; set; }

    public Product()
    {

    }

    public Product(int productId, string title, string description, float unitPrice,
                    string category, int balance)
    {
        this.ProductId = productId;
        this.Title = title;
        this.Description = description;
        this.UnitPrice = unitPrice;
        this.Category = category;
        this.Balance = balance;
    }
}
