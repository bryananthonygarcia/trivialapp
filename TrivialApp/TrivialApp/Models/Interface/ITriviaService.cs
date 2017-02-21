using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrivialApp.Models.DataModels;

namespace TrivialApp.Models.Interface
{
    public interface ITriviaService
    {
        Task<TriviaModel> GetTriviaByCategory(int category, string difficulty, int amount = 10);
    }
}
