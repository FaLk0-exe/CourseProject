using CourseProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering_App.interfaces
{
    public interface IProductCategory
    {
        IEnumerable<product_category> AllCategories { get; }
    }
}
