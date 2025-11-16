using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Question
    {
        public string Text { get; }
        public IReadOnlyList<Answer> Answers => _answers.AsReadOnly();
        public int Points { get; }

        private readonly List<Answer> _answers = new List<Answer>();

        public Question(string text, int points = 1)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Tresc pytania nie moze byc pusta.", nameof(text));

            if(points <= 0)
                throw new ArgumentOutOfRangeException(nameof(points), "Liczba punktow musi byc dodatnia.");

            Text = text;
            Points = points;
        }

        public void AddAnswer(Answer answer)
        {
            if (answer is null)
                throw new ArgumentNullException(nameof(answer));
            _answers.Add(answer);
        }

        public bool IsCorrect(int answerIndex)
        {
            if (answerIndex < 0 || answerIndex >= _answers.Count)
                throw new ArgumentOutOfRangeException(nameof(answerIndex), "Nieprawidlowy indeks odpowiedzi.");
                    return _answers[answerIndex].IsCorrect;
        }
    }
}
