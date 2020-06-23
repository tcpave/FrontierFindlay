using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using FrontierNETCore.Code;

namespace FrontierNETCore.Models
{
    //provided to capture the raw data from the URI
    //used Json Serialization support to map the data to corresponding properties
    public class Account
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("LastName")]
        public string LastName { get; set; }
        [JsonPropertyName("Email")]
        public string Email { get; set; }
        [JsonPropertyName("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonPropertyName("AmountDue")]
        public decimal AmountDue { get; set; }
        [JsonPropertyName("PaymentDueDate")]
        public DateTime? PaymentDueDate { get; set; }
        [JsonPropertyName("AccountStatusId")]
        public AccountStatus AccountStatusId { get; set; }
    }
}
