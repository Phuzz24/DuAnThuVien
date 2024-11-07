using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KhaKhau.Controllers
{
    [Authorize]
    public class CartController :Controller
    {
        private readonly ICartRepository _cartRepository;
        public CartController(ICartRepository cartRepository ) 
        {
            _cartRepository = cartRepository;
        }
        public async Task<IActionResult> AddItem(int  productId, int qty = 1, int redirect=0)
        {
            var cartCount = await _cartRepository.AddItem(productId, qty);
            if (redirect == 0)
            {
                return Ok(cartCount);
            }
            return RedirectToAction("GetUserCart");
        } 
        public async Task<IActionResult> RemoveItem(int  productId)
        {
           var cartCount=await _cartRepository.RemoveItem(productId);
            return RedirectToAction("GetUserCart");
        }public async Task<IActionResult> GetUserCart()
        {
           var cart=await _cartRepository.GetUserCart();
            return View(cart);
        }
        
        //public async Task<IActionResult> GetTotalItemInCart()
        //{
        //    int cartItem =_cartRepository.GetTo();
        //    return View();
        //}

    }
}
