using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Interface
{
    public interface IAnswer
    {
        string Text { get; }
        bool IsCorrect { get; }
    }
}
