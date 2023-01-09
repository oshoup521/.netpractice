namespace BLL;
using BOL;
using DAL;
public class CatalogManager
{
    public List<Product> allProducts(){
        List<Product> getAllProducts = new List<Product>();
        getAllProducts = DBManager.GetAllProducts();
        return getAllProducts;
    }
}
