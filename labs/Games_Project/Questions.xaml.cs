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
using System.Windows.Shapes;

namespace Games_Project
{
    /// <summary>
    /// Interaction logic for GameRulesWindow.xaml
    /// </summary>
    public partial class Questions : Window
    {
        public List<string> questions = new List<string>();
        public List<QuestionBank> QuestionAndAnswers = new List<QuestionBank>();
        public Random rand = new Random();
        public int i, score;
        public Questions()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            var questionandanswer1 = new QuestionBank("What is the product of the number of people in Engineering 35 and the number in the Engineering class?", "280", 500);
            var questionandanswer2 = new QuestionBank("Which country is Nice located in?", "France", 150);
            var questionandanswer3 = new QuestionBank("Which film beginning with M has the characters Alex, Marty, Gloria and Melman?", "Madagascar", 200);
            var questionandanswer4 = new QuestionBank("Which country topped the medal table at the 2016 Rio Olympics?", "United States of America", 300);
            var questionandanswer5 = new QuestionBank("Which political figure is widely known for having ornage coloured skin?", "Donald Trump", 100);
            var questionandanswer6 = new QuestionBank("What is the name of the character that said the following quote \" I am inevitable! \"?", "Thanos", 250);
            var questionandanswer7 = new QuestionBank("Which comic book universe is home to The Green Arrow, The Flash and Batman?", "DC Universe", 400);
            var questionandanswer8 = new QuestionBank("Which BBC TV show referenced the codename H?", "Line Of Duty", 300);
            var questionandanswer9 = new QuestionBank("The 2018/19 university intake included the first students to be born in what century?", "21st", 200);
            var questionandanswer10 = new QuestionBank("What company recently hired 6 Spartans from Engineering 35?", "BlueBay", 100);
            QuestionAndAnswers.Add(questionandanswer1);
            QuestionAndAnswers.Add(questionandanswer2);
            QuestionAndAnswers.Add(questionandanswer3);
            QuestionAndAnswers.Add(questionandanswer4);
            QuestionAndAnswers.Add(questionandanswer5);
            QuestionAndAnswers.Add(questionandanswer6);
            QuestionAndAnswers.Add(questionandanswer7);
            QuestionAndAnswers.Add(questionandanswer8);
            QuestionAndAnswers.Add(questionandanswer9);
            QuestionAndAnswers.Add(questionandanswer10);


        }

        private void SubmitAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionAndAnswers[i].Answer == Player1Answer.Text)
            {
                AnswerResult.Text = "Correct Answer! Your points have been added to your score! Please delete your answer and pass the computer over to Player 2";
                score += QuestionAndAnswers[i].Points;
            }
            else
            {
                AnswerResult.Text = "Sorry, incorrect answer! Please delete your answer and pass the computer to Player 2";
            }
            Player1Score.Text = "Score = " + score;
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
}