using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Choices : BaseModel
    {
        public string Text { get; set; }
        public bool IsRightAnswer { get; set; }
        public int QuestionId { get; set; }
        public Questions Question { get; set; }

    }
}
