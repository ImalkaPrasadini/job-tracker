using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class MockCompanyRepo : CompanyRepo
    {
        public IEnumerable<Companies> GetCompany()
        {
            var company = new List<Companies>
            {
                new Companies { Id = 1, CompanyName = "ABC" , Industry = "IT", Location = "Colombo" },
                new Companies { Id = 2, CompanyName = "XYZ" , Industry = "MED", Location = "Kandy" },
                new Companies { Id = 3, CompanyName = "DEF" , Industry = "IT", Location = "Colombo" },
            };

           return company;
        }

        public Companies getCompanyById(int id)
        {
            return new Companies { Id = 1, CompanyName = "ABC" , Industry = "IT", Location = "Colombo" };
        }

        IEnumerator<Companies> CompanyRepo.GetCompany()
        {
            throw new NotImplementedException();
        }
    }
}
