 namespace C43_G05_EXAM02.Exam;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("please Enter the type of  Exam : ");
            string examName = Console.ReadLine();
            Console.Write("please Enter the time for exam  (minutes): ");
            int examTime = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Questions: ");
            int numQuestions = int.Parse(Console.ReadLine());
            var exam = new Exam(examName, examTime);
            for (int i = 0; i < numQuestions; i++)
            {
                Console.WriteLine($"\nEnter details for Question {i + 1}:");
                Console.Write("Enter Question Type (1 for True/False, 2 for MCQ): ");
                int questionType = int.Parse(Console.ReadLine());
                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();
                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();
                Console.Write("Enter Question Mark: ");
                int mark = int.Parse(Console.ReadLine());
                if (questionType == 1)
                {
                    var question = new TrueFalseQuestion(header, body, mark);
                    Console.Write("Enter Correct Answer (1 for True, 2 for False): ");
                    int correctAnswerId = int.Parse(Console.ReadLine());
                    question.CorrectAnswer = question.Answers.Find(a => a.AnswerId == correctAnswerId);
                    exam.AddQuestion(question);
                }
                else if (questionType == 2)
                {
                    var question = new MCQQuestion(header, body, mark);
                    Console.Write("Enter Number of Options: ");
                    int numOptions = int.Parse(Console.ReadLine());
                    for (int j = 0; j < numOptions; j++)
                    {
                        Console.Write($"Enter Option {j + 1}: ");
                        string optionText = Console.ReadLine();
                        question.Answers.Add(new Answer(j + 1, optionText));
                    }
                    Console.Write("Enter Correct Option Number: ");
                    int correctOption = int.Parse(Console.ReadLine());
                    question.CorrectAnswer = question.Answers.Find(a => a.AnswerId == correctOption);
                    exam.AddQuestion(question);
                }
            }
            Console.WriteLine("\n--- Exam Created ---");
            exam.DisplayExam();
            Console.WriteLine("\n--- Start Exam ---");
            int finalScore = exam.TakeExam();
            Console.WriteLine($"\nYour Final Score: {finalScore}/{exam.Questions.Count * exam.Questions[0].Mark}");
        }
    }




