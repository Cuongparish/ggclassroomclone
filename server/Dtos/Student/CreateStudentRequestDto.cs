using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Dtos.Student
{
    public class CreateStudentRequestDto
    {
        public int userId { get; set; }
        public int studentId { get; set; }
    }
}