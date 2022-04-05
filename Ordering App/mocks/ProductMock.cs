using CourseProject;
using Ordering_App.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering_App.mocks
{
    public class ProductMock : IProduct
    {
        private readonly IProductCategory _productCategories=new CategoryMock();
        private readonly IManufacturer _productManufactures = new ManufacturerMock();
        public IEnumerable<product> Products {
            get
            {
                return new List<product> {
                    new product {
                        price=120,
                        manufacturer=_productManufactures.GetManufacturers.First(),
                        product_category=_productCategories.AllCategories.First(),
                        comment="Jam monster with strawberry"} };
            }

        }

        public product GetObjectProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
