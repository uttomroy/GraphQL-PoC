using GraphQL_PoC.Model;

namespace GraphQL_PoC.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> students;
        public StudentRepository() { 
            students = new List<Student>()
            {
                new()
                {
                    Name = "Alice",
                    Id = 1
                },
                new()
                {
                    Name = "Bob",
                    Id = 2
                }
            };
        }
        public async Task<Student> GetStudent(int id)
        {
            return students.Where(x => x.Id == id).First();
        }
    }

    public interface IStudentRepository
    {
        Task<Student> GetStudent(int id);
    }
}
