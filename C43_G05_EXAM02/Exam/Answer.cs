using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_EXAM02.Exam
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        public override string ToString() => $"{AnswerId}: {AnswerText}";
    }
}
