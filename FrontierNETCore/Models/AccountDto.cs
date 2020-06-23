using FrontierNETCore.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FrontierNETCore.Models
{
    //the DTO is used to contain validated and filtered data from each class instance
    //so that any data integrity issues can be addressed before passing to the view
    public class AccountDto
    {
        private long phone;
        private string email;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email
        {
            get { return email; }
            set
            {
                string pattern = @"([^\s]).+@([^\s])[^\.]+(\..+)";
                Regex rx = new Regex(pattern);

                if (rx.IsMatch(value))
                {
                    email = value;
                    return;
                }
                email = "[??] " + value;

            }
        }

        //PhoneNumber is captured as a string from the server, then transformed into a long
        //so that the format template can be applied easier.  Also some data range checks can
        //be done for validation
        public long PhoneNumber
        {
            get { return phone; }

            set
            {
                long input;
                if (Int64.TryParse(value.ToString(), out input))
                {
                    if (value.ToString().Length != 10)
                    {
                        phone = 0;
                        return;
                    }
                    phone = value;
                    return;
                }
                phone = 0;
            }
        }
        public decimal AmountDue { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public AccountStatus AccountStatusId { get; set; }
    }
}
