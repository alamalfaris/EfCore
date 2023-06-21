using DataTransferObjects.Student;

namespace EfCoreCodeFirst.Repository.Student
{
    public interface IStudentRepository
    {
        Task CreateStudent(CreateUpdateStudentDto request);
    }
}
