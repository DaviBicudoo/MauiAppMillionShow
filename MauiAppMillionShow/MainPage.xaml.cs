namespace MauiAppMillionShow
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_EasyQuestion(object sender, EventArgs e)
        {
            this.BindingContext = App.getRandomEasyQuestion();
        }

        private void Button_Clicked_Next(object sender, EventArgs e)
        {
            string statementText = "";

            bool correctAnswer = false;

            if(alternative1.IsChecked)
            {
                statementText = alternative1.Content.ToString();
                correctAnswer = (bool)alternative1.Value;
            }

            if(alternative2.IsChecked)
            {
                statementText = alternative2.Content.ToString();
                correctAnswer = (bool)alternative2.Value;
            }

            if(alternative3.IsChecked)
            {
                statementText = alternative3.Content.ToString();
                correctAnswer = (bool)alternative3.Value;
            }

            if(alternative4.IsChecked)
            {
                statementText = alternative4.Content.ToString();
                correctAnswer = (bool)alternative4.Value;
            }

            if(correctAnswer)
            {
                this.BindingContext = App.getRandomEasyQuestion();

                DisplayAlert("Correct!", statementText, "Next!");
            } else
            {
                DisplayAlert("Error!", "Burro!", "Try again!");
            }

        }
    }

}
