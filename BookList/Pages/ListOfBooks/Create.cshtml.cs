using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookList.Models;

namespace BookList.Pages.ListOfBooks
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Book book { get; set; }
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid) { return Page(); } // For example if user tries to add book w/ no name

            _db.Book.Add(book);
            await _db.SaveChangesAsync();
            return Redirect("Index");
        }
    }
}