using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_NET_APP.Data;
using ASP_NET_APP.Model;

namespace ASP_NET_APP.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly ASP_NET_APP.Data.ASP_NET_APPContext _context;

        public IndexModel(ASP_NET_APP.Data.ASP_NET_APPContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
