using System.Collections.Generic;
using WebApplication4.Data.Models;

namespace WebApplication4.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
