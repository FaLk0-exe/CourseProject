using CourseProject;
using Ordering_App.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering_App.mocks
{
    public class CategoryMock : IProductCategory
    {
        public IEnumerable<product_category> AllCategories
        {
            get
            {
                return new List<product_category> { new product_category { name = "Жидкости", id = 1 } };
            }
        }
    }
}
