using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptures3.Data;
using MyScriptures3.Models;

namespace MyScriptures3.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptures3.Data.MyScriptures3Context _context;

        public IndexModel(MyScriptures3.Data.MyScriptures3Context context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Scripture = await _context.Scripture.ToListAsync();
        }
    }
}
