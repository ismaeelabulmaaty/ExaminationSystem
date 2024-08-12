using Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Dtos.CourceDtos
{
    public class CourceDto
    {
        public int CourceId { get; set; }
        public string Name { get; set; }
        public int CreditHours { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int InstructorsId { get; set; }
        public ICollection<int> Exams { get; set; }

    }
}
