using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrivialApp.Models.DataModels;
using TrivialApp.Models.Interface;

namespace TrivialApp.Models
{
    public class TriviaService : ITriviaService
    {
        public async Task<TriviaModel> GetTriviaByCategory(int category, string difficulty, int amount = 10)
        {
            var triviaList = new TriviaModel();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(string.Format("{0}amount={1}&category={2}&difficulty={3}", AppConstants.TriviaEndpoint, amount, category, difficulty));
                triviaList = JsonConvert.DeserializeObject<TriviaModel>(response);
            }

            return triviaList;
        }
    }
}
