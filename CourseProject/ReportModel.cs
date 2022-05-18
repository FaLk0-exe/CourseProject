using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class ReportModel
    {
        public string name { set; get; }
        public int count { set; get; }
        public string price { set; get; }
        public string fullPrice { 
            get { return string.Format("{0:0.00}", (Convert.ToDecimal(price) * count)); }
            set { }
        }
    }
}
