using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JobleGlobal.Models;

namespace JobleGlobal.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly JobleGlobal.Models.JobleDBContext _context;

        public IndexModel(JobleGlobal.Models.JobleDBContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
