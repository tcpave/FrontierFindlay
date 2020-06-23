using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace FrontierNETCore.Code
{
    public class SourceAPI
    {
        private readonly string _endpoint;
        public string ErrorMessage { get; set; }

        public SourceAPI(string endpoint)
        {
            _endpoint = endpoint;
        }

        //particular method to support the controller action for the account status report
        //there wouild be other single interface points like this for other controller actions
        //making them single instance allows for specific conditions to be managed for each if they arise
        public async Task<IEnumerable<T>> FetchAccountStatusReport<T>()
        {
            var data = await FetchDataAsync<T>();

            return data;

        }

        //the abstraction of fetching the data from the endpoint in list format
        private async Task<IEnumerable<T>> FetchDataAsync<T>()
        {
            if (string.IsNullOrEmpty(_endpoint)) return null;

            //there could stand to be more error checking but for now, this is sufficient to get a prototype done
            //-connection status
            //-server availability
            //-data type and/or format compatibility
            using (var client = new HttpClient())
            {
                try
                {
                    var data = client.GetStreamAsync(_endpoint);
                    return await JsonSerializer.DeserializeAsync<IEnumerable<T>>(await data);
                }
                catch (Exception exc)
                {
                    //at a minimum, save the error message from the exception to let the client know what
                    //caused it.  the logs would give full details
                    ErrorMessage = exc.Message;
                    //log error here
                }

                return null;
            }
        }

    }
}
