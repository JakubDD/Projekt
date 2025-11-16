using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Quiz
    {
        public string Title { get; }
        public string Description { get; }

        public IReadOnlyList<Question> Questions => _questions.AsReadOnly();

        private readonly List<Question> _questions = new List<Question>();

        public Quiz(string title, string description = "")
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Tytul nie moze byc pusty.", nameof(title));
            Title = title;
            Description = description ?? string.Empty;
        }

        public void AddQuestion(Question question)
        {
            if (question is null)
                throw new ArgumentNullException(nameof(question));
            _questions.Add(question);
        }

        public int GetMaxScore()
        {
            int sum = 0;
            foreach (var q in _questions)
            {
                sum += q.Points;
            }
            return sum;
        }

        public int CalculateScore(IList<int> selectedAnswerIndexes)
        {
            if (selectedAnswerIndexes == null)
                throw new ArgumentNullException(nameof(selectedAnswerIndexes));

            if (selectedAnswerIndexes.Count != _questions.Count)
                throw new ArgumentException("Liczba odpowiedzi uzytkownika nie zgadza sie z liczba pytan.");

            int score = 0;

            for (int i = 0; i < _questions.Count; i++)
            {
                var question = _questions[i];
                int answerIndex = selectedAnswerIndexes[i];

                if(question.IsCorrect(answerIndex))
                {
                    score += question.Points;
                }
            }
            return score;

            
        }

    }
}
