using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppDomain.Context;
using TodoAppDomain.Model;
using TodoAppRepository.Repositories;
using TodoAppService.Base;

namespace TodoAppService
{
    public class TodoRepository : BaseRepository<Todo>, ITodoRepository
    {
        private TodoDbContext _context;
        public TodoRepository(TodoDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
