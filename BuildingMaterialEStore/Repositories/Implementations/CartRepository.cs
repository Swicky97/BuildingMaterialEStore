using BuildingMaterialEStore.Database;
using BuildingMaterialEStore.Models.Cart;
using System.Collections.Generic;

namespace BuildingMaterialEStore.Repositories.Implementations
{
    public class CartRepository : ICartRepository
    {
        private BmesDbContext _context;

        public CartRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Cart FindCartById(long id)
        {
            var cart = _context.Carts.Find(id);
            return cart;
        }

        public IEnumerable<Cart> GetAllCarts()
        {
            var carts = _context.Carts;
            return carts;
        }

        public void SaveCart(Cart cart)
        {
            _context.Carts.Add(cart);
            _context.SaveChanges();
        }

        public void UpdateCart(Cart cart)
        {
            _context.Carts.Update(cart);
            _context.SaveChanges();
        }

        public void DeleteCart(Cart cart)
        {
            _context.Carts.Remove(cart);
            _context.SaveChanges();
        }
    }
}
