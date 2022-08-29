using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerceUdemy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("products")]
        public async Task<ActionResult<ServiceResponse<List<CartProductResponse>>>> GetCartProducts(List<CartItem> cart)
        {
            var result = await _cartService.GetCartProducts(cart);
            return Ok(result);
        }
    }
}
