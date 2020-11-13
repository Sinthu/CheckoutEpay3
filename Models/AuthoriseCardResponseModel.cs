using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckoutEPay.Models
{
    public class AuthoriseCardResponseModel
    {
        public AuthoriseCardResponseModel()
        {

        }

        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("merchantId")]
        public string MerchantId { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("maskedCardNumber")]
        public string MaskedCardNumber { get; set; }

        [JsonProperty("processedDate")]
        public DateTime ProcessedDate { get; set; }
    }

}

