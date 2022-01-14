using System.Collections.Generic;

namespace DAL.DTO
{
    public class EmployeeDTO
    {
        public List<DEPARTMENT> Departments { get; set; }

        public List<PositionDTO> Positions { get; set; }

        public List<EmployeeDetailDTO> Employees { get; set; }
    }
}
