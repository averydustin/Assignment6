using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Assignment5.Models;
using Assignment5.Infrastructure;

namespace Assignment5.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBooksRepository repository;

        //Constructor
        public PurchaseModel (IBooksRepository repo, Cart cartservice)
        {
            repository = repo;
            Cart = cartservice;
        }
        //Properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //Methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.books.FirstOrDefault(b => b.BookId == bookId);

            Cart.AddItem(book, 1);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Book.BookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
