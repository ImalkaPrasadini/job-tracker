using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("/api/company")]
    [ApiController]
    public class CompanyController : Controller
    {
        private readonly MockCompanyRepo _companyRepo = new MockCompanyRepo();
        [HttpGet]
        public ActionResult<IEnumerable<Companies>> GetAllCompanies()
        {
            var companyList = _companyRepo.GetCompany();
            return Ok(companyList);
        }

        [HttpGet("/id")]
        public ActionResult<Companies> GetCompaniesById(int id)
        {
            var company = _companyRepo.getCompanyById(id);
            return Ok(company);
        }
    }
}
