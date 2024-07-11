namespace Lab
{
    public class ChooseMultiple : Question
    {
        public ChooseMultiple()
        {
            Header = "Choose Multiple Answers and separate them with , ";
            Mark = 5;
            Body = "No Question";

        }
        public ChooseMultiple(string _body)
        {
            Header = "Choose Multiple Answers and separate them with , ";
            Mark = 5;
            Body = _body;
        }
        public override int ChooseAnswer(List<ModelAnswer> answers)
        {
            int mark = 0;
            int NoCorrectAnswers = 0;
            foreach(var modelAnswer in answers)
            {
                if(modelAnswer.IsCorrect == true)
                {
                    NoCorrectAnswers++;
                }
            }
            Console.Write($"{Header}: ");
            string[] res = Console.ReadLine().Split(',');
           
            foreach (var item in answers)
            {
                foreach (var result in res)
                {
                    if (result == item.Text.ToLower() && item.IsCorrect)
                    {
                        mark += 1;
                        if (mark >= NoCorrectAnswers)
                            return Mark;
                    } 
                }               
            }
            return mark;
        }
    }
}
