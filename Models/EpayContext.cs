using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckoutEPay.Models
{
    public class EpayContext : DbContext
    {
        public EpayContext(DbContextOptions<EpayContext> options) :base(options)
        {
        }

        public DbSet<AuthoriseCardRequestModel> AuthoriseCardRequestModels { get; set; }
    }
}
