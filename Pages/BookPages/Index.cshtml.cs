using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Niste_Marius_Lab2.Models;

namespace Niste_Marius_Lab2.Pages.BookPages;

public class IndexModel : PageModel
{
    private readonly Niste_Marius_Lab2Context _context;

    public IndexModel(Niste_Marius_Lab2Context context)
    {
        _context = context;
    }

    public IList<Book> Book { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync();
    }
}
