using EmployeeDemo.Data;
using EmployeeDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDemo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync() =>
            await _context.Employees.ToListAsync();


        public Task<Employee?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> SaveAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee?> UpdateEmployeeAsync(int id, Employee updated)
        {
            var emp= await _context.Employees.FindAsync(id);
            if (emp == null)
                return null;
            // Update employee 
            emp.Email = updated.Email;
            emp.Phone= updated.Phone;

            await _context.SaveChangesAsync();
            return emp;




        }
    }
}
