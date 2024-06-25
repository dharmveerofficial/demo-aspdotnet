using DemoProject.Dtos;
using DemoProject.Models;
using Mapster;

namespace DemoProject
{
    public static class DtoMapping
    {
        private static readonly IList<Employee> employees = DemoData.CreatePersons();
        public static EmployeeDto MapPersonToNewDto(int id)
        {
            var dto = employees.Where(g=>g.Id == id).FirstOrDefault().Adapt<EmployeeDto>();
            return dto;
        }
        public static IList<EmployeeDto> MapPersonsToNewDto()
        {
            var dto = employees.Adapt<IList<EmployeeDto>>();
            return dto;
        }
    }
}
