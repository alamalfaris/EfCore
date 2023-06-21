using AutoMapper;
using DataTransferObjects.Student;
using EfCoreCodeFirst.Database;
using log4net;
using Logging;

namespace EfCoreCodeFirst.Repository.Student
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly ILog _log = LogManager.GetLogger(typeof(StudentRepository));

        public StudentRepository(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateStudent(CreateUpdateStudentDto request)
        {
            var newStudent = _mapper.Map<Models.Student>(request);
            _context.Students.Add(newStudent);
            await _context.SaveChangesAsync();

            _log.Info(string.Format(ILogMessage.CreateSuccessMessage, "Student"));
        }
    }
}
