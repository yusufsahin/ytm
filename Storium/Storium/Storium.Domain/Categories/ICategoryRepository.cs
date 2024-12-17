using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storium.Domain.Categories
{
    public interface ICategoryRepository
    {
         Task CreateAsyc(string name, CancellationToken cancellationToken=default);
         Task<List<Category>> GetAllAsync(CancellationToken cancellationToken=default);
    }
}
