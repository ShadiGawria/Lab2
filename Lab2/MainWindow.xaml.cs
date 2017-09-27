using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab2
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Method to return the worl(winorlose)variable depends on the user input 
        public int winorlose()
        {
            
            int worl;
            if (Winorlose.Text.ToUpper().Equals("W") || Winorlose.Text.ToUpper().Equals("WIN"))
            {
                worl = 1;
                return worl;
            }
            else if (Winorlose.Text.ToUpper().Equals("L") || Winorlose.Text.ToUpper().Equals("LOSE"))
            {
                worl = 0;
                return worl;
            }
            else if (Winorlose.Text.ToUpper().Equals("D") || Winorlose.Text.ToUpper().Equals("DRAW"))
            {
                worl = 2;
                return worl;
            }
            else


            {
                MessageBox.Show("Fel input");

                return -1;
            }

        }

        public MainWindow()
        {

            InitializeComponent();

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            // Close button
            this.Close();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            // clear the Listbox button
            Listbox.Items.Clear();
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.Name.Text != "" && this.Teamname1.Text != "" && this.Winorlose.Text != "" && this.Score.Text != "" && this.Money.Text != "")
            {
                // Let's play Button
                Listbox.Items.Add("Your name is:" + " " + Name.Text);
                Listbox.Items.Add("Your favorit team is: " + " " + Teamname1.Text);
                Listbox.Items.Add("Your are betting " + Teamname1.Text + " is going to" + " " + Winorlose.Text + " and score" + " " + Score.Text + " " + "Goals");

                Listbox.Items.Add("Your are playing with " + Money.Text + " $ ");
                this.Name.Focus();

                this.Teamname1.Focus();

                this.Winorlose.Focus();
                this.Score.Focus();
                this.Money.Focus();


                int userScore = Convert.ToInt32(Score.Text);
                int userMoney = Convert.ToInt32(Money.Text);


                RandomGeneratorwinorlose winorloseGerate = new RandomGeneratorwinorlose();
                RandomGenerator scoreGenrate = new RandomGenerator();
                int scoreGenerat = scoreGenrate.RandomNr();
                int resultGenerat = winorloseGerate.RandomWinorlose();
                if (resultGenerat == winorlose() && scoreGenerat == userScore)
                {
                    double earnmony = (0.75) * userMoney + userMoney;
                    MessageBox.Show("You guessed right both the score and the match result ! Congratulation you won :" + " " + earnmony + " " + " $ ");
                }
                else if (resultGenerat == winorlose() && scoreGenerat != userScore)
                {

                    double earnmoney1 = (0.25) * userMoney + userMoney;
                    MessageBox.Show("You guessed right the match result ! Congargulation you won :" + " " + earnmoney1 + " " + " $ ");
                }
                else
                {
                    MessageBox.Show("Sorry! You lost all your money");

                }

            }
            else
            {
                //Error Message 
                MessageBox.Show("Please fill all the boxes ", "Error", MessageBoxButton.OK);
                this.Name.Focus();
            }
            // clear the Textboxes
            this.Winorlose.Clear();
            this.Score.Clear();
            this.Money.Clear();
            this.Name.Clear();
            this.Teamname1.Clear();
        }



    }
}


