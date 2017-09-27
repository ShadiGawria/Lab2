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

        public int winorlose()
        {

            int y1;
            if (Winorlose.Text.ToUpper().Equals("W") || Winorlose.Text.ToUpper() == "WIN")
            {
                y1 = 1;
                return y1;
            }
            else if (Winorlose.Text.ToUpper().Equals("L") || Winorlose.Text.ToUpper() == "LOSE")
            {
                y1 = 0;
                return y1;
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
            this.Close();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Listbox.Items.Clear();
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.Name.Text != "" && this.Teamname1.Text != "" && this.Winorlose.Text != "" && this.Score.Text != "" && this.Money.Text != "")
            {

                Listbox.Items.Add("Your name is:" + " " + Name.Text);
                Listbox.Items.Add("Your favorit team is: " + " " + Teamname1.Text);
                Listbox.Items.Add("Your are betting " + Teamname1.Text + " is going to" + " " + Winorlose.Text + " and score" + " " + Score.Text + " " + "Goals");

                Listbox.Items.Add("Your are playing with " + Money.Text + " $ ");
                this.Name.Focus();

                this.Teamname1.Focus();

                this.Winorlose.Focus();
                this.Score.Focus();
                this.Money.Focus();


                int score = Convert.ToInt32(Score.Text);
                int money = Convert.ToInt32(Money.Text);


                RandomGeneratorwinorlose winorloseGerate = new RandomGeneratorwinorlose();
                RandomGenerator scoreGenrate = new RandomGenerator();
                int x = scoreGenrate.RandomNr();
                int y = winorloseGerate.RandomWinorlose();
                if (y == winorlose() && x == score)
                {
                    double earnmony = (0.75) * money + money;
                    MessageBox.Show("You guessed right both the score and the winner ! Congratulation you won :" + " " + earnmony + " " + " $ ");
                }
                else if (y == winorlose() && x != score)
                {

                    double earnmoney1 = (0.25) * money + money;
                    MessageBox.Show("You guessed right the winner ! Congargulation you won :" + " " + earnmoney1 + " " + " $ ");
                }
                else
                {
                    MessageBox.Show("Sorry! You lost all your money");

                }

            }
            else
            {

                MessageBox.Show("Please enter all the informations", "Error", MessageBoxButton.OK);
                this.Name.Focus();
            }
            // clear the boxes
            this.Winorlose.Clear();
            this.Score.Clear();
            this.Money.Clear();
            this.Name.Clear();
            this.Teamname1.Clear();
        }



    }
}


