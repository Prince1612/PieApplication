using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieApplication.Models
{
    public interface ICatagoryRepository
    {
        IEnumerable<Catagory> Catagories { get; }
    }
}
