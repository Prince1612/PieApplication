using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieApplication.Models
{
    public class Catagory
    {
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
        public string Description { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
