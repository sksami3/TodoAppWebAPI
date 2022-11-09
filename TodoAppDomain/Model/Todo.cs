using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAppDomain.Model.Base;

namespace TodoAppDomain.Model
{
    public class Todo : BaseModel
    {
        public string Title { get; set; }
        public string? Desc { get; set; }
    }
}
