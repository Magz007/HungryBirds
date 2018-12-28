using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HungryBirds.Models;

namespace HungryBirds.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly HungryBirds.Models.PupilContext _context;

        public IndexModel(HungryBirds.Models.PupilContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
