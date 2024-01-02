using GraphQL_PoC.Model;

namespace GraphQL_PoC.Schema
{
    public class Query
    {
        public string Name { get; set; } = "Pradip";

        public Student GetStudent()
        {
            return new Student()
            {
                Name = "test",
                Id = 10
            };
        }
    }
}
