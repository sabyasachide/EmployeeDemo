using EmployeeDemo.Models;

namespace EmployeeDemo.Repository
{
    public interface IEmployeeRepository

    {
        Task<IEnumerable<Employee>> GetAllAsync();

        Task<Employee?> GetByIdAsync(int id);

        Task<Employee> SaveAsync(Employee employee);

        Task<Employee?> UpdateEmployeeAsync(int id,Employee employee);

        Task<bool> DeleteByIdAsync(int id);
    }
}
