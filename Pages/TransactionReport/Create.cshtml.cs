using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CheckoutEPay.Models;

namespace CheckoutEPay.Pages.TransactionReport
{
    public class CreateModel : PageModel
    {
        private readonly CheckoutEPay.Models.EpayContext _context;

        public CreateModel(CheckoutEPay.Models.EpayContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AuthoriseCardRequestModel AuthoriseCardRequestModel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AuthoriseCardRequestModels.Add(AuthoriseCardRequestModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
