using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //displayed the amount of score 
            lengthLabel.Text = $"{Form1.stored.Count}";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //goes back to the menu screen to either play again or close
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
