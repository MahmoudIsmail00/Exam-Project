using Lab;

namespace Lab
{
    public abstract class Question
    {
        public string Body { get; set; }
        public int Mark { get; init; }
        public string Header { get; init; }
        public virtual int ChooseAnswer(List<ModelAnswer> answers) { return 1; }
        public static Question CreateQue(QuestionType _type, string _body)
        {
            Question retQuestion;

            if (_type == QuestionType.TrueOrFalse)
            {
                retQuestion = new TrueOrFalse(_body);

            }
            else if (_type == QuestionType.ChooseOne)
            {
                retQuestion = new ChooseOne(_body);

            }
            else
            {
                retQuestion = new ChooseMultiple(_body);
            }
            return retQuestion;
        }
    }
}
