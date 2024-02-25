using DomainLayer.Entities;

namespace DomainLayer.Interfaces
{
    public interface ICompanyService
    {
        void AddDepartment(int companyId, Department department);
        void DeleteSubdivision(int departmentId, int subdivisionId);
        void MoveSubdivision(int sourceDepartmentId, int destinationDepartmentId, int subdivisionId);
        void ExportToXml(string filePath);
        void ImportFromXml(string filePath);
        List<Company> GetAllCompanies();
        Company GetCompanyById(int companyId);
        void SaveCompany(Company company);
    }
}
