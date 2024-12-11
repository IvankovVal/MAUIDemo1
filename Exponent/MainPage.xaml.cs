namespace Exponent {
    public partial class MainPage : ContentPage
    {
        public MainPage()    { InitializeComponent(); }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            double numBase = double.Parse(Base.Text);
            double numExponent = double.Parse(Exponent.Text);

            if (numExponent == 1) Answer.Text = $"{numBase}";
            if (numBase == 0) Answer.Text = $"{numBase}";
            if (numExponent > 0)
            {
                double result = numBase;
                for (int i = 1; i < numExponent; i = i + 1)
                {
                    result *= numBase;
                }
                Answer.Text = $"{result}";
            }
            else if (numExponent < 0)
            {
                double result = numBase;
                for (int i = 1; i < numExponent; i = i + 1)
                { result *= numBase;}
                Answer.Text = $"{result}";
                result = 1 / result;
                Answer.Text = $"{result}";
            }
            else Answer.Text = $"1";//Если степень равна 0
        }    }  }
