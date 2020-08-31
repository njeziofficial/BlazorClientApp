using BlazorClientApp.Helpers;
using BlazorClientApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClientApp.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly IHttpService httpService;
        private string url = "http://localhost:7070/api/suppliers";

        public SupplierRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task CreateSupplier(Supplier supplier)
        {
            var response = await httpService.Post(url, supplier);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
