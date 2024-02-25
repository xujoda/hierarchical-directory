using DomainLayer.Entities;
using DomainLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DbContext _context;

        public CompanyRepository(DbContext context)
        {
            _context = context;
        }

        public Company GetCompanyById(int companyId)
        {
            // получение данных о компании из бд
            return new Company();
        }

        public List<Company> GetAllCompanies() 
        {
            return new List<Company>();
        }

        public void SaveCompany(Company company)
        {
            // сохранение данных о компании в бд
        }
    }
}
