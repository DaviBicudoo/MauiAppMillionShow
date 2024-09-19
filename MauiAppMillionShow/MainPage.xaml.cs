using MauiAppMillionShow.Models;
using Plugin.Maui.Audio;

namespace MauiAppMillionShow
{
    public partial class MainPage : ContentPage
    {
        double reward = 0;
        int questionCount = 0;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = App.getRandomEasyQuestion();

            labelLevel.Text = "Easy";
            labelReward.Text = reward.ToString("C");
            labelQuestionNumber.Text = questionCount.ToString();

            Stream track =
                    FileSystem.OpenAppPackageFileAsync("0.mp3").Result;
            AudioManager.Current.CreatePlayer(track).Play();
        }

        private void PlaySong()
        {
            string track = "";

            switch (questionCount)
            {
                case 1:
                    track = "1.wav";
                break;

                case 2:
                    track = "2.wav";
                break;

                case 3:
                    track = "3.wav";
                break;

                case 4:
                    track = "4.wav";
                break;

                case 5:
                    track = "5.wav";
                    break;

                case 6:
                    track = "6.wav";
                    break;

                case 7:
                    track = "7.wav";
                    break;

                case 8:
                    track = "8.wav";
                    break;

                case 9:
                    track = "9.wav";
                    break;

                case 10:
                    track = "10.wav";
                    break;

                case 11:
                    track = "11.wav";
                    break;

                case 12:
                    track = "12.wav";
                    break;

                case 13:
                    track = "13.wav";
                    break;

                case 14:
                    track = "14.wav";
                    break;

                case 15:
                    track = "15.wav";
                    break;
            }

            //AudioManager.Current.CreatePlayer(
            //    FileSystem.OpenAppPackageFileAsync(track));
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
