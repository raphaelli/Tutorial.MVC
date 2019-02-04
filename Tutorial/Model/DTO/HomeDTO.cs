using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial.Model.DTO
{
    public class HomeDTO
    {
        public IEnumerable<StudentInfoDTO> Students { get; set; }
    }
}
