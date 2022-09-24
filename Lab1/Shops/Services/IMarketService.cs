using Shops.Entities;
using Shops.Models;

namespace Shops.Services
{
    public interface IMarketService
    {
        Shop AddShop(string name, string address);

        Buyer AddBuyer(string name);

        void TopUpBalance(Buyer buyer, decimal money);

        Order MakeOrder(Buyer buyer, Shop shop, Cart cart);

        // something more
    }
}
