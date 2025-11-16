using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Interface
{
    public interface IQuiz
    {
        string Title { get; }
        string Description { get; }
        IReadOnlyList<IQuestion> Questions { get; }
        int GetMaxScore();
        int CalculateScore(IList<int> selectedAnswerIndexes);
    }
}
