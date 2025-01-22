using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_EXAM02.Exam
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> Answers { get; set; }
        public Answer CorrectAnswer { get; set; }
        protected Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = new List<Answer>();
        }
        public abstract void DisplayQuestion();
        public abstract bool CheckAnswer(int answerId);
    }
}
