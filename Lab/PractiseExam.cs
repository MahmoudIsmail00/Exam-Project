using System;

namespace Lab
{
    public class PractiseExam : Exam
    {
        public PractiseExam()
        {
            NumberOfQuestions = 5;

            QuestionModelAnswer = Repository.CreateQuestions(NumberOfQuestions);

            foreach (var question in QuestionModelAnswer.Keys)
            {
                FinalGrade += question.Mark;
            }

        }
        public PractiseExam(int _num)
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
            foreach (var item in QuestionModelAnswer)
            {
                Console.WriteLine($"{item.Key.Body}");
                int ctr = 1;
                foreach (var ans in item.Value)
                {
                    Console.WriteLine($"{ctr}) {ans.Text}");
                    ctr++;
                }
                Console.WriteLine("=====================================================");
                var items = item.Value.FindAll(x => x.IsCorrect == true);
                foreach (var modelAnswer in items)
                {
                    Console.WriteLine($"Answer: {modelAnswer.Text}");
                }
                Console.WriteLine("=====================================================");
            }
            Console.WriteLine($"Your grade is: {grade}/{FinalGrade}");
        }
    }
}
