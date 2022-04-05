using CourseProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering_App.interfaces
{
    public interface IProduct
    {
        IEnumerable<product> Products { get; }
        product GetObjectProduct(int id);
    }
}
