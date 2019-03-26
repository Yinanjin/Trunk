using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Trunk.Models;

namespace Trunk.Pages.Inventorys
{
    public class IndexModel : PageModel
    {
        private readonly Trunk.Models.TrunkContext _context;

        public IndexModel(Trunk.Models.TrunkContext context)
        {
            _context = context;
        }

        public IList<Inventory> Inventory { get;set; }

        public async Task OnGetAsync()
        {
            Inventory = await _context.Inventory.ToListAsync();
        }
    }
}
