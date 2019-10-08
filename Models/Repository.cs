using System.Collections.Generic;

namespace BuckeyeLawnServices.Models
{
    public static class Repository
    {
        private static List<NewCustomerRequest> requests = new List<NewCustomerRequest>();

        public static IEnumerable<NewCustomerRequest> Requests
        {
            get
            {
                return requests;
            }
        }

        public static void AddRequest(NewCustomerRequest request)
        {
            requests.Add(request);
        }
    }
}
