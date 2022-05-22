using Domain.Entities;
using Persistence.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.Employees.Any())
            {
                context.Employees.Add(new Employee
                {
                    Name = "Ertunç",
                    Surname = "Köybaşı",
                    Address = "İstanbul/Turkey",
                    Email = "ertunckoybasi@msn.com",
                    Phone = "+905421111111",
                    Department = new Department { DepName = "Development", }
                }); 

                await context.SaveChangesAsync();
            }
        }
    }
}
