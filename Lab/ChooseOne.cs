using System.Text;

namespace Lab
{
    public class ChooseOne : Question
    {
        public ChooseOne()
        {
            Header = "Choose one Answer";
            Mark = 3;
            Body = "No Question";

        }
        public ChooseOne(string _body)
        {
            Header = "Choose one Answer";
            Mark = 3;
            Body = _body;
        }
        public override int ChooseAnswer(List<ModelAnswer> answers)
        {
            string res;
            List<string> s1 = new List<string>();
            int mark = 0;
            foreach (var ans in answers)
            {
                s1.Add(ans.Text);
            }
            bool flag = true;
            do
            {
                Console.Write($"{Header}: ");
                res = Console.ReadLine()!.ToLower();
                foreach (var item1 in s1)
                {
                    if (res == item1.ToLower())
                    {
                        flag = false;
                        break;
                    }
                }
            } while (flag);

            foreach (var item in answers)
            {
                if (res == item.Text.ToLower() && item.IsCorrect)
                {
                    mark = Mark;
                }

            }
            return mark;
        }
    }
}
