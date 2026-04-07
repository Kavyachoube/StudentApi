using StudentApi.Models;
using StudentApi.Repositories;

namespace StudentApi.Services
{
    public class StudentService
    {
        private readonly StudentRepository _repo;

        public StudentService(StudentRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetAll() => _repo.GetAll();
        public void Add(Student s) => _repo.Add(s);
        public void Update(Student s) => _repo.Update(s);
        public void Delete(int id) => _repo.Delete(id);
    }
}