using Projekt.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Answer : IAnswer
    {
        public string Text { get; }
        public bool IsCorrect { get; }

        public Answer(string text, bool isCorrect)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("Tekst odpoiwedzi nie moze byc pusty", nameof(text));

            Text = text;
            IsCorrect = isCorrect;
        }
    }
}
