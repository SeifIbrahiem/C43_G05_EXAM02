using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_EXAM02.Exam
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark)
            : base(header, body, mark)
        {
            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));
        }
        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}\n{Body}");
            foreach (var answer in Answers)
            {
                Console.WriteLine(answer);
            }
        }
        public override bool CheckAnswer(int answerId)
        {
            return CorrectAnswer.AnswerId == answerId;
        }
    }
}
