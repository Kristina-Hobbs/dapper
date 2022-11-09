using System;
namespace Application
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments(); 
    }
}

