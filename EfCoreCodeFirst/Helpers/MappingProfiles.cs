using AutoMapper;
using DataTransferObjects;
using DataTransferObjects.Student;
using Models;

namespace EfCoreCodeFirst.Helpers
{
    public class MappingProfiles :Profile
    {
        public MappingProfiles()
        {
            CreateMap<Student, CreateUpdateStudentDto>().ReverseMap();
        }
    }
}
