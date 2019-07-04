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

namespace labs_38_WPF_stackPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<String> questions = new List<String>();
        public List<QuestionBank> questionswithanswers = new List<QuestionBank>();
        
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            StackPanel01.Visibility = Visibility.Visible;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Hidden;

            questions.Add("What is the capital of Italy?");
            questions.Add("What is the capital of Mongolia?");
            questions.Add("How do you spell Llanfair........ fully?");
            questions.Add("What is 1/0 * 3");
            questions.Add("Who is the president of Singapore?");

            var qanda01 = new QuestionBank("What is the capital of Italy?", "Rome", 100) ;
            var qanda02 = new QuestionBank("What is the capital of Mongolia?", "Ulaanbaatar", 500) ;
            var qanda03 = new QuestionBank("How do you spell Llanfair...... fully?", "Llanfairpwllgwyngyllgogerychwyrndrobwllllantysiliogogogoch", 2500) ;
            var qanda04 = new QuestionBank("What is 1/0 * 3", "Undefined", 5000) ;
            var qanda05 = new QuestionBank("Who is the president of Singapore?", "Halimah Yacob", 10000) ;

            questionswithanswers.Add(qanda01);
            questionswithanswers.Add(qanda02);
            questionswithanswers.Add(qanda03);
            questionswithanswers.Add(qanda04);
            questionswithanswers.Add(qanda05);

            //Create a game to randomly show one of thr questions
            //Have a text box to receive the answer.
            //If it is right, display the appropriate message and add to the total points
            // if it is wrong, no points added to total and appropriate message
            //Create a winning condition
            //Add some imagery as well?
        }

        private void ShowPanel01(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Visible;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Hidden;
        }

        private void ShowPanel02(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Hidden;
            StackPanel02.Visibility = Visibility.Visible;
            StackPanel03.Visibility = Visibility.Hidden;
        }

        private void ShowPanel03(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Hidden;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Visible;
        }
    }

    public class QuestionBank
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Points { get; set; }

        public QuestionBank(string question, string answer, int points)
        {
            this.Question = question;
            this.Answer = answer;
            this.Points = points;
        }
    }
}
