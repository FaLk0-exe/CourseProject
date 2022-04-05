using Microsoft.AspNetCore.Mvc;
using Ordering_App.interfaces;
using Ordering_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering_App.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _goods;
        private readonly IManufacturer _manufacturers;
        private readonly IProductCategory _categories;

        public ProductController(IProduct goods, IManufacturer manufacturers, IProductCategory categories)
        {
            _goods = goods;
            _manufacturers = manufacturers;
            _categories = categories;
        }

        public ViewResult List()
        {
            ProductListViewModel obj = new ProductListViewModel();
            obj.GetGoods = _goods.Products;
            obj.CurrCategory = "Рідини";
            return View(obj);
        }
    }
}

