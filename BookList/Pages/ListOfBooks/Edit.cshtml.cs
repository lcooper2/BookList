using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList.Pages.ListOfBooks
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        [BindProperty]
        public Book book { get; set; }

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            book = await _db.Book.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var BookFromDatabase = await _db.Book.FindAsync(book.Id);
                BookFromDatabase.Name = book.Name;
                BookFromDatabase.Author = book.Author;
                BookFromDatabase.ISBN = book.ISBN;
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}