using SkillsDatabase;
using System.Security.Cryptography.X509Certificates;

namespace SkillsBackend.UnitTest
{
    public class ClientIntegrationTest
    {
        
        
        
        [Fact]
        public async void GetEmployeesAsync()
        {
            var employees = await Program.client.GetEmployeesAsync();
            Assert.NotNull(employees);
            Assert.NotEmpty(employees);
            Assert.IsType<List<Employee>?>(employees);
        }

        [Theory]
        [InlineData(1)]
        public async void GetEmployeeAsync(int id)
        {
            var employee = await Program.client.GetEmployeeAsync(id);
            Assert.NotNull(employee);
            Assert.IsType<Employee?>(employee);
        }

        [Theory]
        [InlineData("Richard")]
        public async void SearchEmployeesAsync(string searchQuery)
        {
            var employee = await Program.client.GetEmployeeAsync(searchQuery);
            Assert.NotNull(employee);
            Assert.NotEmpty(employee);
            Assert.IsType<List<Employee>?>(employee);
        }
        [Theory]
        [InlineData(9)]
        public async void GetProficienciesAsync(int id)
        {
            var proficienciesOfAnEmployee = await Program.client.GetProficiencyAsync(id);
            Assert.NotNull(proficienciesOfAnEmployee);
            Assert.NotEmpty(proficienciesOfAnEmployee);
            Assert.IsType<List<Proficiency>>(proficienciesOfAnEmployee);
        }

        [Fact]
        public async void GetAllProficienciesAsync()
        {
            var proficiencies = await Program.client.GetProficienciesAsync();
            Assert.NotNull(proficiencies);
            Assert.NotEmpty(proficiencies);
            Assert.IsType<List<Proficiency>>(proficiencies);
        }

        [Fact]
        public async void GetSkillsAsync()
        {
            var skills = await Program.client.GetSkillsAsync();
            Assert.NotNull(skills);
            Assert.NotEmpty(skills);
            Assert.IsType<List<string>>(skills);
        }
    }
}