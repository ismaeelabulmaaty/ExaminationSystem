namespace ExaminationSystem.Dtos.ChoiceDto
{
    public class ChoicesDto
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public bool IsRightAnswer { get; set; }
        public int QuestionId { get; set; }
    }
}
