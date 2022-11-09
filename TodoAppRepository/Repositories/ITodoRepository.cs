using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoAppDomain.Model;
using TodoAppRepository.Repositories.Base;

namespace TodoAppRepository.Repositories
{
    public interface ITodoRepository : IBaseRepository<Todo>
    {
        
    }
}
