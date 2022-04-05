using CourseProject;
using Ordering_App.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering_App.mocks
{
    public class ManufacturerMock : IManufacturer
    {
        public IEnumerable<manufacturer> GetManufacturers
        {
            get
            {
                return new List<manufacturer> { new manufacturer { name = "Jam Monster" } };
            }
        }
    }
}
