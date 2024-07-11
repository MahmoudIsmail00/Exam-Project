namespace Lab
{
    public class TrueOrFalse: Question
    {
        public TrueOrFalse()
        {
            Mark = 2;
            Header = "Yes or NO";
            Body = "No Question";
        }
        public TrueOrFalse(string _body)
        {
            Mark = 2;
            Header = "Yes or NO";
            Body = _body;
        }
        public override int ChooseAnswer(List<ModelAnswer> answers)
        {
            string res;
            int mark = 0;
            do
            {
                Console.Write($"{Header}: ");
                res = Console.ReadLine()!.ToLower();
            } while (res != "yes" && res != "no");

            foreach (var item in answers)
            {
                if(res == item.Text.ToLower() && item.IsCorrect)
                {
                    mark = Mark;
                }
            }
            return mark;
        }
    }
}
