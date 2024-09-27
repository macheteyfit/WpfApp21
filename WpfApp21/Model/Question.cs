using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp21.Model;

namespace WpfApp21.Model
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }

        public Question(int id, string text, List<Answer> answers)
        {
            Id = id;
            Text = text;
            Answers = answers;
        }
    }
}
