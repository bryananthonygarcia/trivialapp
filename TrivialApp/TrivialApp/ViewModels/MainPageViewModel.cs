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
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;

        public DelegateCommand<string> NavigateToQuestionsCommand => new DelegateCommand<string>(NavigateToQuestions);
        public DelegateCommand<string> GoToDifficultyCommand => new DelegateCommand<string>(GoToDifficulty);

        private bool _isDifficultyVisible;
        public bool IsDifficultyVisible
        {
            get { return _isDifficultyVisible; }
            set { SetProperty(ref _isDifficultyVisible, value); }
        }

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { SetProperty(ref _amount, value); }
        }

        private int _category;
        public int Category
        {
            get { return _category; }
            set { SetProperty(ref _category, value); }
        }

        private string _difficulty;
        public string Difficulty
        {
            get { return _difficulty; }
            set { SetProperty(ref _difficulty, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            IsDifficultyVisible = false;
            Amount = 10;
        }

        private void GoToDifficulty(string category)
        {
            Category = Convert.ToInt32(category);
            IsDifficultyVisible = true;

        }
        private void NavigateToQuestions(string difficulty)
        {
            Difficulty = difficulty;
            IsDifficultyVisible = false;
            _navigationService.NavigateAsync(string.Format("QuestionsPage?amount={0}&category={1}&difficulty={2}", Amount, Category, Difficulty));


        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }
    }
}
