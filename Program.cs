using Projekt.Interface;
using Projekt.Repo;

namespace Projekt
{

    class Program
    {
        static void Main(string[] args)
        {
            Repository<IQuiz> quizRepository = new Repository<IQuiz>();

            IQuiz quiz = new Quiz("Quiz z C#", "Podstawy programowania obiektowego");

            quizRepository.Add(quiz);

            var allQuizzes = quizRepository.GetAll();
            Console.WriteLine("Liczba quizow: " + quizRepository.Count);

            Repository<IQuestion> questionRepository = new Repository<IQuestion>();

            Repository<IAnswer> answerRepository = new Repository<IAnswer>();


        }
}
}