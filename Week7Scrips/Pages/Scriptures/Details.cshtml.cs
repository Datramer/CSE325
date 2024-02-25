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
    public class DetailsModel : PageModel
    {
        private readonly MyScriptures3.Data.MyScriptures3Context _context;

        public DetailsModel(MyScriptures3.Data.MyScriptures3Context context)
        {
            _context = context;
        }

        public Scripture Scripture { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scripture = await _context.Scripture.FirstOrDefaultAsync(m => m.ID == id);
            if (scripture == null)
            {
                return NotFound();
            }
            else
            {
                Scripture = scripture;
            }
            return Page();
        }
    }
}
