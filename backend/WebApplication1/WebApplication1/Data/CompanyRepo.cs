using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface CompanyRepo
    {
        IEnumerator<Companies> GetCompany();
        Companies getCompanyById(int id);
    }
}
