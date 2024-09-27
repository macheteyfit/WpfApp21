using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp21.Model;

namespace WpfApp21.Model
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        string Name { get; set; }

        public Quiz(List<Question> questions, string name)
        {
            Questions = questions;
            Name = name;
        } 

        public static Quiz GenerateQuiz()
        {
            List<Question> questions = new List<Question>();
            for(int j = 0; j < 10; j++)
            {
                List<Answer> answer = new List<Answer>();
                for (int i = 0; i < 3; i++)
                {
                    answer.Add(new Answer(i + 1, $"option{i + 1}", i == 1));
                }
                questions.Add(new Question(j + 1, $"question {j+1}?", answer));
            }
            return new Quiz(questions, "Quiz name");
        }
    }
}
