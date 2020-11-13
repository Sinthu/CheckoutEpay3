using CheckoutEPay.Controllers;
using CheckoutEPay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckoutEPay.ApiGateway
{
    public class ApiInteractor: ControllerBase  
    {
        private readonly EpayContext _context;

        public ApiInteractor()
        {
                
        }

        public ApiInteractor(EpayContext context)
        {
            _context = context;
        }

        //Function to do Authorisation Process
        public async Task<ActionResult<AuthoriseCardRequestModel>> DoAuthoriseProcess(AuthoriseCardRequestModel model)
        {
            _context.AuthoriseCardRequestModels.Add(model);
            await _context.SaveChangesAsync();
            var apiResponse = CreatedAtAction(nameof(GetAuthoriseCardRequestModel), new { id = model.Id}, model);

            var authoriseCardResponseModel = new AuthoriseCardResponseModel
            {
                //Get API response status code
                StatusCode = apiResponse.StatusCode.ToString()
            };

            if (authoriseCardResponseModel.StatusCode == "201")
            {
                return apiResponse;
            }

            return null;
        }

        public async Task<ActionResult<IEnumerable<AuthoriseCardRequestModel>>> GetAuthoriseCardRequestModel()
        {
            return await _context.AuthoriseCardRequestModels.ToListAsync();
        }

        public async Task<ActionResult<AuthoriseCardRequestModel>> GetAuthoriseCardRequestModel(int id)
        {
            var authoriseCardRequestModel = await _context.AuthoriseCardRequestModels.FindAsync(id);

            if (authoriseCardRequestModel == null)
            {
                return NotFound();
            }

            return authoriseCardRequestModel;
        }

    }
}
