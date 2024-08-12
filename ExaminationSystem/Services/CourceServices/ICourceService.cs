using Core.Models;
using ExaminationSystem.Dtos.CourceDtos;
using ExaminationSystem.Dtos.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Services.CourceServices
{
    public interface ICourceService
    {
        int Add(CourceDto courceDto);
        IEnumerable<CourceDto> GetAll();
        CourceDto GetByID(int id);
        int UpdateCource(int id, CourceDto courseDto);
        int DeleteCource(int id);

    }
}
