using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontierNETCore.Code;
using FrontierNETCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FrontierNETCore.Controllers
{
    public class AccountsController : Controller
    {
        //for this controller, the only appSetting value we need is the URI of fetching the account data
        //if other config settings were needed, this is where I would cache them
        private readonly string endpoint;

        //constructor dependency injection
        public AccountsController(IConfiguration config)
        {
            endpoint = config["AppSettings:StatusReportSource"];
        }

        //let another class handle the fetching of data, just provide the URI and let it do its thing
        public async Task<ViewResult> StatusReport()
        {
            var apiclient = new SourceAPI(endpoint);
            var list = await apiclient.FetchAccountStatusReport<Account>();
            var mappedList = MapDto(list);

            return View(mappedList);
        }

        //There could be a better place for the DTO mapping but since this is an isolated exercise,
        //this works fine for now. In a real world application, it would be better to use AutoMapper.
        //If more and other objects required the mapping functionality, I would create a folder to 
        //keep all the mappings together in one place
        private IEnumerable<AccountDto> MapDto(IEnumerable<Account> list)
        {
            var items = new List<AccountDto>();

            foreach (var item in list)
            {
                items.Add(
                    new AccountDto
                    {
                        Id = item.Id,
                        Name = item.LastName + ", " + item.FirstName,
                        Email = item.Email,
                        PhoneNumber = Convert.ToInt64(item.PhoneNumber),
                        AmountDue = item.AmountDue,
                        PaymentDueDate = item.PaymentDueDate,
                        AccountStatusId = item.AccountStatusId
                    });
            }

            return items.AsEnumerable<AccountDto>();
        }

    }
}
