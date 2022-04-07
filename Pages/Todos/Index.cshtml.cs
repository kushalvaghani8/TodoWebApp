using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TodoWebApp.Data;
using TodoWebApp.Models;

namespace TodoWebApp.Pages.Todos
{
    public class IndexModel : PageModel
    {
        private readonly TodoWebApp.Data.TodoContext _context;

        public IndexModel(TodoWebApp.Data.TodoContext context)
        {
            _context = context;
        }

        public IList<Todo> Todo { get; set; }

        public async Task OnGetAsync()
        {
            Todo = await _context.Todo.ToListAsync();
        }
                        

    }
}
