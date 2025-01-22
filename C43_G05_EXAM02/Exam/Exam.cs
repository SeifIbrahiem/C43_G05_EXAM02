using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_EXAM02.Exam
{
    public class Exam
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public List<Question> Questions { get; set; }
        public Exam(string name, int time)
        {
            Name = name;
            Time = time;
            Questions = new List<Question>();
        }
        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
        public void DisplayExam()
        {
            Console.WriteLine($"Exam: {Name}\nTime: {Time} minutes\n");
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
                Console.WriteLine();
            }
        }
        public int TakeExam()
        {
            int score = 0;
            Console.WriteLine("Answer the following questions:\n");
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
                Console.Write("Your Answer (Enter the option number): ");
                int userAnswer = int.Parse(Console.ReadLine());
                if (question.CheckAnswer(userAnswer))
                {
                    score += question.Mark;
                }
                Console.WriteLine();
            }
            return score;
        }
    }
}
