using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MLBRosterBuilder.Data;
using MLBRosterBuilder.Models;

namespace MLBRosterBuilder.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly MLBRosterBuilder.Data.MLBRosterBuilderContext _context;

        public IndexModel(MLBRosterBuilder.Data.MLBRosterBuilderContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; }

        public async Task OnGetAsync()
        {
            Player = await _context.Player.ToListAsync();
        }
    }
}
