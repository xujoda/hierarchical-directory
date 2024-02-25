using DomainLayer.Entities;
using DomainLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Company>> Get()
        {
            return _companyService.GetAllCompanies();
        }

        [HttpPost]
        public ActionResult<Company> Post(Company company)
        {
            _companyService.SaveCompany(company);
            return Ok();
        }

        [HttpDelete("{companyId,departmentId,subvisionId}")]
        public ActionResult<Company> Delete(int companyId, int departmentId,int subvisionId)
        {
            var company = _companyService.GetCompanyById(companyId);
            if (company == null)
            {
                return NotFound();
            }

            _companyService.DeleteSubdivision(departmentId, subvisionId);
            return company;
        }

        [HttpGet("export/{filePath}")]
        public ActionResult ExportToXml(string filePath)
        {
            try
            {
                _companyService.ExportToXml(filePath);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("import/{filePath}")]
        public ActionResult ImportFromXml(string filePath)
        {
            try
            {
                _companyService.ImportFromXml(filePath);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

