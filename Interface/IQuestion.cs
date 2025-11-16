using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Interface
{
    public interface IQuestion
    {
        string Text { get; }

        IReadOnlyList<Answer> Answers { get; }

        int Points { get; }
        bool IsCorrect(int answerIndex);    
    }
}
