
namespace MauiAppTicTacToe
{
    public partial class MainPage : ContentPage
    {
        string turn = "O";
        ushort count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Button trigger = (Button)sender;

            trigger.IsEnabled = false;

            if(turn == "O")
            {
                trigger.Text = "O";
                turn = "X";
            } else
            {
                trigger.Text = "X";
                turn = "O";
            }

            count++;

            // Vertical wins
            if (btn01.Text == "X" && btn02.Text == "X" && btn03.Text == "X")
            {
                DisplayAlert("Finish game!", "X team won!", "Play Again");
            }
            else if (btn11.Text == "X" && btn12.Text == "X" && btn13.Text == "X")
            {
                DisplayAlert("Finish game!", "X team won!", "Play Again");
            }
            else if (btn21.Text == "X" && btn22.Text == "X" && btn23.Text == "X")
            {
                DisplayAlert("Finish game!", "X team won!", "Play Again");
            }
            // Horizontal wins
            else if (btn01.Text == "X" && btn11.Text == "X" && btn21.Text == "X")
            {
                DisplayAlert("Finish game!", "X team won!", "Play Again");
            }
            else if (btn02.Text == "X" && btn12.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Finish game!", "X team won!", "Play Again");
            }
            else if (btn03.Text == "X" && btn13.Text == "X" && btn23.Text == "X")
            {
                DisplayAlert("Finish game!", "X team won!", "Play Again");
            }
            // Diagonal wins
            else if (btn01.Text == "X" && btn12.Text == "X" && btn23.Text == "X")
            {
                DisplayAlert("Finish game!", "X team won!", "Play Again");
            }
            else if (btn03.Text == "X" && btn12.Text == "X" && btn21.Text == "X")
            {
                DisplayAlert("Finish game!", "X team won!", "Play Again");
            }

            // "O" Cases
            if (btn01.Text == "O" && btn02.Text == "O" && btn03.Text == "O")
            {
                DisplayAlert("Finish game!", "O team won!", "Play Again");
            }
            else if (btn11.Text == "O" && btn12.Text == "O" && btn13.Text == "O")
            {
                DisplayAlert("Finish game!", "O team won!", "Play Again");
            }
            else if (btn21.Text == "O" && btn22.Text == "O" && btn23.Text == "O")
            {
                DisplayAlert("Finish game!", "O team won!", "Play Again");
            }
            // Horizontal wins
            else if (btn01.Text == "O" && btn11.Text == "O" && btn21.Text == "O")
            {
                DisplayAlert("Finish game!", "O team won!", "Play Again");
            }
            else if (btn02.Text == "O" && btn12.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Finish game!", "O team won!", "Play Again");
            }
            else if (btn03.Text == "O" && btn13.Text == "O" && btn23.Text == "O")
            {
                DisplayAlert("Finish game!", "O3 team won!", "Play Again");
            }
            // Diagonal wins
            else if (btn01.Text == "O" && btn12.Text == "O" && btn23.Text == "O")
            {
                DisplayAlert("Finish game!", "O team won!", "Play Again");
            }
            else if (btn03.Text == "O" && btn12.Text == "O" && btn21.Text == "O")
            {
                DisplayAlert("Finish game!", "O team won!", "Play Again");
            }
            // Draw state
            else
            {
                if(count == 9)
                {
                    DisplayAlert("Finish game!", "Draw game!", "Play Again");
                }
            }
            
            if(btn01.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
            }        
        
        
        }

        private void limpar()
        {
            btn01.Text = "";
            btn01.IsEnabled = true;
            btn02.Text = "";
            btn02.IsEnabled = true;
            btn03.Text = "";
            btn03.IsEnabled = true;
            btn11.Text = "";
            btn11.IsEnabled = true;
            btn12.Text = "";
            btn12.IsEnabled = true;
            btn13.Text = "";
            btn13.IsEnabled = true;
            btn21.Text = "";
            btn21.IsEnabled = true;
            btn22.Text = "";
            btn22.IsEnabled = true;
            btn23.Text = "";
            btn23.IsEnabled = true;
        }


        private void resetGameButton_Clicked(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
