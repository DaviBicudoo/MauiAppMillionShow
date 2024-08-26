using MauiAppMillionShow.Models;

namespace MauiAppMillionShow
{
    public partial class MainPage : ContentPage
    {
        double reward = 0;
        int questionCount = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_EasyQuestion(object sender, EventArgs e)
        {
            this.BindingContext = App.getRandomEasyQuestion();
        }

        private async void Button_Clicked_Next(object sender, EventArgs e)
        {
            string statementText = "";

            bool correctAnswer = false;
            bool value;

            if(alternative1.IsChecked)
            {
                if((bool) alternative1.Value)
                {
                    correctAnswer = true;
                    statementText = alternative1.Content.ToString();
                }
            }

            if (alternative2.IsChecked)
            {
                if ((bool)alternative2.Value)
                {
                    correctAnswer = true;
                    statementText = alternative2.Content.ToString();
                }
            }

            if (alternative3.IsChecked)
            {
                if ((bool)alternative3.Value)
                {
                    correctAnswer = true;
                    statementText = alternative3.Content.ToString();
                }
            }

            if (alternative4.IsChecked)
            {
                if ((bool)alternative4.Value)
                {
                    correctAnswer = true;
                    statementText = alternative4.Content.ToString();
                }
            }

            if (correctAnswer)
            {
                this.BindingContext = App.getRandomEasyQuestion();

                DisplayAlert("Correct!", statementText, "Next!");
            } else
            {
                DisplayAlert("Error!", "Burro!", "Try again!");
            }

            if(correctAnswer)
            {
                await DisplayAlert("YOU GOT IT RIGHT!", statementText, "OK");
                NextQuestion();
            }
            else
            {
                await DisplayAlert("YOU'RE WRONG", statementText, "OK");
            }
        }

        void NextQuestion()
        {
            if(questionCount <= 5)
            {
                reward += 1000;
                this.BindingContext = App.getRandomEasyQuestion();
            }

            if(questionCount > 5 && questionCount <= 10)
            {
                reward += 10000;
                this.BindingContext = App.getRandomMediumQuestion();
            }
            
            if(questionCount > 10 && questionCount < 15)
            {
                reward += 100000;
                this.BindingContext = App.getRandomHardQuestion();
            }
        }


    }

}
