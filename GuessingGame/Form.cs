using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form : System.Windows.Forms.Form
    {
        int result;
        Random random;
        int @try;
        float score;
        float highscore;

        public Form()
        {
            InitializeComponent();
            InitializeVariables();
        }

        private void InitializeVariables()
        {
            random = new Random();
            result = random.Next(0, 100);
            //lbMessage.Text = string.Format("CHEAT: {0}", result); //ENABLE CHEAT
            score = 0;
            highscore = 0;
            @try = 0;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tb.Text, out int guess))
            {
                lbMessage.Text = "> Please enter a number to guess";
            }
            else
            {
                if (guess == result)
                {
                    Equal();
                }
                else if (guess < result)
                {
                    Less();
                }
                else
                {
                    Larger();
                }
            }

        }

        private void Equal()
        {
            lbMessage.Text = "> Congratulation!";
            @try++;
            score = 100f / @try;
            if (score > highscore)
            {
                highscore = score;
                lbHighscore.Text = string.Format("> Highscore - {0:0.00}%", highscore);
            }
        }

        private void Less()
        {
            lbMessage.Text = "> Too low!";
            @try++;
        }

        private void Larger()
        {
            lbMessage.Text = "> Too high!";
            @try++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbMessage.Text = "> Please enter your guess";
            result = random.Next(0, 100);
            //lbMessage.Text = string.Format("CHEAT: {0}", result); //ENABLE CHEAT
            @try = 0;
            score = 0;
        }
    }
}
