using Northwind.Dal.Abstract.IRepository;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.InterfaceLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public DtoCustomer Add(DtoCustomer entity)
        {
            throw new Exception();
        }

        public Task<DtoCustomer> AddAsync(DtoCustomer entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DtoCustomer entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(DtoCustomer entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public DtoCustomer Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<DtoCustomer> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<DtoCustomer> GetAll(Expression<Func<Customer, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> GetIQueryable()
        {
            throw new NotImplementedException();
        }

        public DtoCustomer Update(DtoCustomer entity)
        {
            throw new NotImplementedException();
        }

        public Task<DtoCustomer> UpdateAsync(DtoCustomer entity)
        {
            throw new NotImplementedException();
        }
    }
}
