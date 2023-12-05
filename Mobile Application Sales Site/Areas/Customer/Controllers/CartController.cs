using AnkaX.DataAccess.Repository.IRepository;
using AnkaX.Models;
using AnkaX.Models.ViewModels;
using AnkaX.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Security.Claims;

namespace Mobile_Application_Sales_Site.Areas.Customer.Controllers
{
    [Area("customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShoppingCartVM ShoppingCartVM { get; set; }
        public CartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
           
        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            ShoppingCartVM = new()
            {
                ShoppingCartList = _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId,
                includeProperties: "Product")
                
            };
            foreach (var cart in ShoppingCartVM.ShoppingCartList)
            {
                cart.Price = GetPriceBasedOnQuantity(cart);
                ShoppingCartVM.OrderTotal += (cart.Price * cart.Count);
            }

            return View(ShoppingCartVM);
            
            public IActionResult Summary()
            {
                return View();
            }


            public IActionResult Plus(int cartId)
            {
                var cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.Id == cartId);
                cartFromDb.ProposedPrice += 1;
                _unitOfWork.ShoppingCart.Update(cartFromDb);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            public IActionResult Minus(int cartId)
            {
                var cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.Id == cartId);
                if (cartFromDb.ProposedPrice <= 1)
                {
                    //remove that from cart

                    _unitOfWork.ShoppingCart.Remove(cartFromDb);
                   
                }
                else
                {
                    cartFromDb.ProposedPrice -= 1;
                    _unitOfWork.ShoppingCart.Update(cartFromDb);
                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            public IActionResult Remove(int cartId)
            {
                var cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.Id == cartId);

                _unitOfWork.ShoppingCart.Remove(cartFromDb);

             
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }


            private double GetPriceBasedOnQuantity(ShoppingCart shoppingCart)
            {
                if (shoppingCart.ProposedPrice <= 1000000)
                {
                    return shoppingCart.Product.Price;
                }
                
                    
                
            }
        }
    }
}
