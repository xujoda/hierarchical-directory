using DomainLayer.Entities;
using DomainLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly Company _company;

        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository, Company company)
        {
            _company = company;
            _companyRepository = companyRepository;
        }

        public void AddDepartment(int companyId, Department department)
        {
            /* проверяем, существует ли уже такой департамент,
             * если нет - то создаем новый департамент и сохраняем его в UnitOfWork
             * После добавления всех подразделений, делаем отложенное сохранение изменений в базе данных*/
        }

        public void DeleteSubdivision(int departmentId, int subdivisionId)
        {
            /* проверяем, существует ли подразделение с данными id
             * Если существует - удаляем его и сохраняем изменения в UnitOfWork*/
        }

        public void MoveSubdivision(int sourceDepartmentId, int destinationDepartmentId, int subdivisionId)
        {
            /* получаем подразделение по ID
             * Проверяем, существует ли департамент назначения
             * Если существует - то перемещаем подразделение и сохраняем изменения в UnitOfWork*/
        }

        public void ExportToXml(string filePath)
        {
            /* вытягиваем все данные с бд (департаменты и отделы), которые нужно экспортировать
             * Формируем документ. С использованием какой-нибудь библиотеки
             * Сохраняем документ в файл*/
        }

        public void ImportFromXml(string filePath)
        {
            /* читаем документ из файла
             * Создаем и добавляем департаменты и отделы в UnitOfWork
             * После добавления всех сущностей делаем отложенное сохранение в бд*/
        }

        public List<Company> GetAllCompanies()
        {
            return _companyRepository.GetAllCompanies();
        }

        public Company GetCompanyById(int companyId)
        {
            return _companyRepository.GetCompanyById(companyId);
        }
        

        public void SaveCompany(Company company)
        {
            _companyRepository.SaveCompany(company);
        }
    }
}
