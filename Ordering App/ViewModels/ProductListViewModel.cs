using CourseProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering_App.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<product> GetGoods { get; set; }
        public string CurrCategory { get; set; }


    }
}
