using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieApplication.Models
{
    public class MockPieRepository : IPieRepository
    {
        public IEnumerable<Pie> Pies
        {
            get
            {
                return new List<Pie>
                {
                    new Pie {PieId = 1, Name="Strawberry Pie", Price= 15.95M, ShortDescription = "this is strawberry pie" },
                    new Pie {PieId = 2, Name="Cheese Pie", Price= 25.95M, ShortDescription = "this is cheese pie" },
                    new Pie {PieId = 3, Name="Rhubarb Pie", Price= 18.95M, ShortDescription = "this is rhubarb pie" },
                    new Pie {PieId = 4, Name="Pumpkin Pie", Price= 35.95M, ShortDescription = "this is pumpkin pie" },
                };
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get;
        }

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
