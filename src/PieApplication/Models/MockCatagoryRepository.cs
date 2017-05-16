using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieApplication.Models
{
    public class MockCatagoryRepository : ICatagoryRepository
    {
        public IEnumerable<Catagory> Catagories
        {
            get
            {
                return new List<Catagory>
                {
                    new Catagory { CatagoryId = 1, CatagoryName = "Fruit pies", Description="This is fruit pie." },
                    new Catagory { CatagoryId = 2, CatagoryName = "Cheese pies", Description="This is cheese pie." },
                    new Catagory{ CatagoryId = 3, CatagoryName = "Seasonal pies", Description="This is seasonal pie." }
                };
            }
        }
    }
}
