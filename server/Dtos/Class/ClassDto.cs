using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Dtos.Class
{
    public class ClassDto
    {
        public int id { get; set; }
        public string tenLop { get; set; } = string.Empty;
        public string chuDe { get; set; } = string.Empty;
        public string phong { get; set; } = string.Empty;
        public string maLop { get; set; } = string.Empty;
        public bool state { get; set; } = false;
    }
}