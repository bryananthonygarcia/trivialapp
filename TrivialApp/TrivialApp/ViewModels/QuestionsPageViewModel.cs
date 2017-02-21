using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using TrivialApp.Models.DataModels;
using TrivialApp.Models.Interface;

namespace TrivialApp.ViewModels
{
    public class QuestionsPageViewModel : BindableBase, INavigationAware
    {
        private ITriviaService _triviaService;
        private TriviaModel _triviaList;
        public TriviaModel TriviaList
        {
            get { return _triviaList; }
            set { SetProperty(ref _triviaList, value); }
        }
        private List<Trivia> _questionList;
        public List<Trivia> QuestionList
        {
            get { return _questionList; }
            set { SetProperty(ref _questionList, value); }
        }

        public QuestionsPageViewModel(ITriviaService triviaService)
        {
            _triviaService = triviaService;

            TriviaList = new TriviaModel();
            QuestionList = new List<Trivia>();
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            var category = Convert.ToInt32(parameters["category"]);
            var amount = Convert.ToInt32(parameters["amount"]);
            var difficulty = parameters["difficulty"].ToString();
            if (category != 0 && amount != 0 && !String.IsNullOrEmpty(difficulty))
                TriviaList = await _triviaService.GetTriviaByCategory(category, difficulty, amount);

            QuestionList = TriviaList.Questions;
        }
    }
}
