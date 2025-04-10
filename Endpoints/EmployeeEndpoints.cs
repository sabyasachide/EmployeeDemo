using EmployeeDemo.Models;
using EmployeeDemo.Repository;

namespace EmployeeDemo.Endpoints
{
    public static class EmployeeEndpoints
    {
        public static void MapEmployeeEndpoints(this IEndpointRouteBuilder app)
        {
            //GET 
            app.MapGet("/employee", async (IEmployeeRepository repo) =>
            Results.Ok(await repo.GetAllAsync()));
            //Create
            app.MapPost("/employee", async (Employee emp, IEmployeeRepository repo) =>
            Results.Created($"/employee/{emp.Id}" ,await repo.SaveAsync(emp)));

            app.MapPut("/employee/{id}", async (int id, Employee emp, IEmployeeRepository repo) =>
            {
                var update = await repo.UpdateEmployeeAsync(id, emp);
                return update;
            });
        }
    }
}
