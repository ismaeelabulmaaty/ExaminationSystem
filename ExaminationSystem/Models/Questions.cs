using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Questions : BaseModel
    {
        public string Text { get; set; }
        public int Grade { get; set; }
        public ICollection<Choices> Choices { get; set; } = new HashSet<Choices>();
        public ICollection<ExamQuestion> ExamQuestions { get; set; } = new HashSet<ExamQuestion>();
    }
}
