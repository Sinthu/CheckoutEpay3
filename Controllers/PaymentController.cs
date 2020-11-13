using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CheckoutEPay.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Net;
using System.Diagnostics;
using CheckoutEPay.ApiGateway;

namespace CheckoutEPay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        private readonly EpayContext _context;
        private readonly ApiInteractor _apiInteractor;

        public PaymentController(EpayContext context, ApiInteractor apiInteractor)
        {
            _context = context;
            _apiInteractor = apiInteractor;
        }

        // GET: AuthoriseCardRequestModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.AuthoriseCardRequestModels.ToListAsync());
        }

        // GET: api/Payment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthoriseCardRequestModel>>> GetAuthoriseCardRequestModels()
        {
            return await _context.AuthoriseCardRequestModels.ToListAsync();
        }

        // POST: api/Payment
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostAuthoriseCardRequestModel([FromForm] AuthoriseCardRequestModel model) 
        {
            if (ModelState.IsValid)
            {

                var result = _apiInteractor.DoAuthoriseProcess(model);

                if (result != null)
                {
                    ViewBag.Result = true;
                    ViewBag.TransactionId = model.TransactionId;
                    return View("~/Views/Home/Index.cshtml", model);
                }
                else
                {
                    ViewBag.Result = false;
                    return View("~/Views/Home/Index.cshtml", model);
                }
            }
            return View(model);
        }

        // GET: api/Payment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthoriseCardRequestModel>> GetAuthoriseCardRequestModel(int id)
        {
            var authoriseCardRequestModel = await _context.AuthoriseCardRequestModels.FindAsync(id);

            if (authoriseCardRequestModel == null)
            {
                return NotFound();
            }

            return authoriseCardRequestModel;
        }

        private bool AuthoriseCardRequestModelExists(int id)
        {
            return _context.AuthoriseCardRequestModels.Any(e => e.Id == id);
        }
    }
}
