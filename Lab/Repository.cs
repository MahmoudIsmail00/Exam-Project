namespace Lab
{
    public class Repository
    {
        public static List<Question> Questions {  get; set; } = getQuestions();
        public static List<List<ModelAnswer>> ModelAnswers {  get; set; } = getAnswers();
        public static List<Question> getQuestions()
        {
            List<Question> result = new List<Question>()
            {
                Question.CreateQue(QuestionType.ChooseOne, "What is the largest planet in our solar system?"),
                Question.CreateQue(QuestionType.TrueOrFalse, "Is Python a programming language?"),
                Question.CreateQue(QuestionType.ChooseMultiple, "Select web browsers"),
                Question.CreateQue(QuestionType.ChooseOne, "Which element has the chemical symbol 'O'?"),
                Question.CreateQue(QuestionType.TrueOrFalse, "Do humans have 4 legs?"),
                Question.CreateQue(QuestionType.ChooseMultiple, "Select modes of transportation"),
                Question.CreateQue(QuestionType.ChooseMultiple, "Select prime numbers"),
                Question.CreateQue(QuestionType.ChooseOne, "What is the boiling point of water in Celsius?"),
                Question.CreateQue(QuestionType.TrueOrFalse, "Is JavaScript used for web development?"),
                Question.CreateQue(QuestionType.ChooseMultiple, "Select types of precipitation"),
                Question.CreateQue(QuestionType.ChooseOne, "Who wrote 'Hamlet'?"),
                Question.CreateQue(QuestionType.ChooseOne, "choose programming language"),
                Question.CreateQue(QuestionType.TrueOrFalse, "Can elephant fly?"),
                Question.CreateQue(QuestionType.ChooseMultiple, "choose devices"),
                Question.CreateQue(QuestionType.TrueOrFalse, "Is Plane faster than train?"),
                Question.CreateQue(QuestionType.ChooseOne, "Which is an OOP language?"),
                Question.CreateQue(QuestionType.ChooseMultiple, "What are Programming languages you must learn to be FullStack developer ")
            };
            return result;
        }
        public static List<List<ModelAnswer>> getAnswers()
        {
            List<List<ModelAnswer>> result = new List<List<ModelAnswer>>()
            {
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "Jupiter" , IsCorrect = true},
                        new ModelAnswer{Text = "Saturn" , IsCorrect = false},
                        new ModelAnswer{Text = "Earth" , IsCorrect = false},
                        new ModelAnswer{Text = "Mars" , IsCorrect = false}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "Yes" , IsCorrect = true},
                        new ModelAnswer{Text = "No" , IsCorrect = false}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "Chrome" , IsCorrect = true},
                        new ModelAnswer{Text = "Firefox" , IsCorrect = true},
                        new ModelAnswer{Text = "Safari" , IsCorrect = true},
                        new ModelAnswer{Text = "Excel" , IsCorrect = false}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "Oxygen" , IsCorrect = true},
                        new ModelAnswer{Text = "Gold" , IsCorrect = false},
                        new ModelAnswer{Text = "Silver" , IsCorrect = false},
                        new ModelAnswer{Text = "Hydrogen" , IsCorrect = false}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "Yes" , IsCorrect = false},
                        new ModelAnswer{Text = "No" , IsCorrect = true}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "Car" , IsCorrect = true},
                        new ModelAnswer{Text = "Bicycle" , IsCorrect = true},
                        new ModelAnswer{Text = "Television" , IsCorrect = false},
                        new ModelAnswer{Text = "Train" , IsCorrect = true}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "2" , IsCorrect = true},
                        new ModelAnswer{Text = "3" , IsCorrect = true},
                        new ModelAnswer{Text = "4" , IsCorrect = false},
                        new ModelAnswer{Text = "5" , IsCorrect = true}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "100" , IsCorrect = true},
                        new ModelAnswer{Text = "0" , IsCorrect = false},
                        new ModelAnswer{Text = "50" , IsCorrect = false},
                        new ModelAnswer{Text = "200" , IsCorrect = false}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "Yes" , IsCorrect = true},
                        new ModelAnswer{Text = "No" , IsCorrect = false}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "Rain" , IsCorrect = true},
                        new ModelAnswer{Text = "Snow" , IsCorrect = true},
                        new ModelAnswer{Text = "Sunshine" , IsCorrect = false},
                        new ModelAnswer{Text = "Hail" , IsCorrect = true}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "William Shakespeare" , IsCorrect = true},
                        new ModelAnswer{Text = "Charles Dickens" , IsCorrect = false},
                        new ModelAnswer{Text = "Jane Austen" , IsCorrect = false},
                        new ModelAnswer{Text = "Mark Twain" , IsCorrect = false}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "C#" , IsCorrect = true},
                        new ModelAnswer{Text = "English" , IsCorrect = false},
                        new ModelAnswer{Text = "France" , IsCorrect = false},
                        new ModelAnswer{Text = "German" , IsCorrect = false}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "Yes" , IsCorrect = false},
                        new ModelAnswer{Text = "No" , IsCorrect = true}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "laptop" , IsCorrect = true},
                        new ModelAnswer{Text = "spoon" , IsCorrect = false},
                        new ModelAnswer{Text = "PC" , IsCorrect = true},
                        new ModelAnswer{Text = "TV" , IsCorrect = true}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "Yes" , IsCorrect = true},
                        new ModelAnswer{Text = "No" , IsCorrect = false}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "C#" , IsCorrect = true},
                        new ModelAnswer{Text = "C" , IsCorrect = false},
                        new ModelAnswer{Text = "Css" , IsCorrect = false},
                        new ModelAnswer{Text = "Html" , IsCorrect = false}
                   },
                   new List<ModelAnswer>
                   {
                        new ModelAnswer{Text = "C#" , IsCorrect = true},
                        new ModelAnswer{Text = "JavaScript" , IsCorrect = true},
                        new ModelAnswer{Text = "Html" , IsCorrect = true},
                        new ModelAnswer{Text = "CSS" , IsCorrect = true}
                   }
            };
             return result;
        }
        public static  Dictionary<Question, List<ModelAnswer>> CreateQuestions(int _numberOfQuestions)
        {
            Dictionary<Question, List<ModelAnswer>> de1 = new Dictionary<Question, List<ModelAnswer>>();

            if (_numberOfQuestions > Questions.Count)
            {
                Console.WriteLine("you can't choose more than 10 questions");
                return null;
            }

            Random rnd = new Random();
            List<int> indices = Enumerable.Range(0, Questions.Count).OrderBy(x => rnd.Next()).Take(_numberOfQuestions).ToList();


            foreach (int index in indices)
            {
                de1.Add(Questions[index], ModelAnswers[index]);
            }

            return de1;
        }
    }
}
