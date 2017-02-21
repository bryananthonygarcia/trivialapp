using Prism.Unity;
using TrivialApp.Models;
using TrivialApp.Models.Interface;
using TrivialApp.Views;
using Microsoft.Practices.Unity;

namespace TrivialApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<ITriviaService, TriviaService>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<QuestionsPage>();
        }
    }
}
