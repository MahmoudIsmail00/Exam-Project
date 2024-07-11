namespace Lab
{
    public abstract class Exam
    {
        public int NumberOfQuestions { get; set; }
        public int FinalGrade { get; set; }
        public Dictionary<Question,List<ModelAnswer>> QuestionModelAnswer { get; set; }
        public int ShowQuestion() {
            int grade = 0;
            foreach (var item in QuestionModelAnswer)
            {
                Console.WriteLine($"{item.Key.Body}");
                int ctr = 1;
                foreach (var ans in item.Value)
                {
                    Console.WriteLine($"{ctr}) {ans.Text}");
                    ctr++;
                }
                Console.WriteLine("==============");
                grade += item.Key.ChooseAnswer(item.Value);
                Console.WriteLine("========================================");
            }

            return grade;
        }
        public virtual void ShowExam(){}
    }
}
