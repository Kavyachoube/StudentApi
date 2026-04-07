using Microsoft.Data.SqlClient;
using StudentApi.Models;
using System.Data;

namespace StudentApi.Repositories
{
    public class StudentRepository
    {
        private readonly string _connection;

        public StudentRepository(IConfiguration config)
        {
            _connection = config.GetConnectionString("DefaultConnection");
        }

        public List<Student> GetAll()
        {
            var list = new List<Student>();

            using SqlConnection con = new SqlConnection(_connection);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Student
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    Email = reader["Email"].ToString(),
                    Age = (int)reader["Age"],
                    Course = reader["Course"].ToString(),
                    CreatedDate = (DateTime)reader["CreatedDate"]
                });
            }

            return list;
        }

        public void Add(Student s)
        {
            using SqlConnection con = new SqlConnection(_connection);

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Students(Name,Email,Age,Course) VALUES(@Name,@Email,@Age,@Course)", con);

            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@Email", s.Email);
            cmd.Parameters.AddWithValue("@Age", s.Age);
            cmd.Parameters.AddWithValue("@Course", s.Course);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void Update(Student s)
        {
            using SqlConnection con = new SqlConnection(_connection);

            SqlCommand cmd = new SqlCommand(
                "UPDATE Students SET Name=@Name, Email=@Email, Age=@Age, Course=@Course WHERE Id=@Id", con);

            cmd.Parameters.AddWithValue("@Id", s.Id);
            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@Email", s.Email);
            cmd.Parameters.AddWithValue("@Age", s.Age);
            cmd.Parameters.AddWithValue("@Course", s.Course);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using SqlConnection con = new SqlConnection(_connection);

            SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}