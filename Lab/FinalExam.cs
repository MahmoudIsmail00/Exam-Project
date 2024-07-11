namespace Lab
{
    public class FinalExam : Exam
    {
        public FinalExam()
        {
            NumberOfQuestions = 5;

            QuestionModelAnswer = Repository.CreateQuestions(NumberOfQuestions);

            foreach (var question in QuestionModelAnswer.Keys)
            {
                FinalGrade += question.Mark;
            }

        }
        public FinalExam(int _num)
        {
            NumberOfQuestions = _num;

            QuestionModelAnswer = Repository.CreateQuestions(_num);

            foreach (var question in QuestionModelAnswer.Keys)
            {
                FinalGrade += question.Mark;
            }
        }
        public override void ShowExam()
        {
            int grade = ShowQuestion();

            Console.WriteLine($"Your grade is: {grade}/{FinalGrade}");

        }
    }
}
