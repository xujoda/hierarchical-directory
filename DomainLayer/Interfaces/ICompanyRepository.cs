using DomainLayer.Entities;

namespace DomainLayer.Interfaces
{
    public interface ICompanyRepository
    {
        Company GetCompanyById(int companyId);
        List<Company> GetAllCompanies();
        void SaveCompany(Company company);
    }
}
