using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CheckoutEPay.Models;

namespace CheckoutEPay.Pages.TransactionReport
{
    public class IndexModel : PageModel
    {
        private readonly CheckoutEPay.Models.EpayContext _context;

        public IndexModel(CheckoutEPay.Models.EpayContext context)
        {
            _context = context;
        }

        public IList<AuthoriseCardRequestModel> AuthoriseCardRequestModel { get;set; }

        public async Task OnGetAsync()
        {
            AuthoriseCardRequestModel = await _context.AuthoriseCardRequestModels.ToListAsync();
        }
    }
}
