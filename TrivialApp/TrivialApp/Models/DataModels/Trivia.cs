using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrivialApp.Models.DataModels
{

    public class TriviaModel
    {
        [JsonProperty("response_code")]
        public int Status { get; set; }

        [JsonProperty("results")]
        public List<Trivia> Questions { get; set; }
    }

    public class Trivia
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        private string _question;

        [JsonProperty("question")]
        public string Question
        {
            get
            {
                return _question;
            }
            set
            {
                _question = System.Net.WebUtility.HtmlDecode(value);
            }
        }

        [JsonProperty("correct_answer")]
        public string CorrectAnswer { get; set; }

        [JsonProperty("incorrect_answers")]
        public List<string> IncorrectAnswers { get; set; }
    }

}
