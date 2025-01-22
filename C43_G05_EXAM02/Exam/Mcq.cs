using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_EXAM02.Exam
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark)
            : base(header, body, mark)
        {
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
