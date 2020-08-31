using BlazorClientApp.Models;
using System.Threading.Tasks;

namespace BlazorClientApp.Repository
{
    public interface ISupplierRepository
    {
        Task CreateSupplier(Supplier supplier);
    }
}