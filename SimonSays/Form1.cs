using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        //made a list for storing input values, a list for colors, a list for sound and a random number generator
        public static List<int> stored = new List<int>();
        public static List<SoundPlayer> sound = new List<SoundPlayer>();
        public static List<Color> colors = new List<Color>();
        public static Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///change add menuscreen to Form1
            ChangeScreen(this, new MenuScreen());

            //adds the sounds to the list right when form1 starts
            Sounds();
            //adds the colors to the list right when form1 starts
            Colours();

        }
        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f;
            if (sender is Form)
            {
                f = (Form)sender; //f is sender
            }
            else
            {
                UserControl current = (UserControl)sender;//create Usercontrol from sender
                f = current.FindForm(); //Find form usercontrol is on
                f.Controls.Remove(current); //removes Usercontrol
            }

            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);

            f.Controls.Add(next);
            next.Focus();
        }
        public void Sounds()
        {
            //adds all the sounds to the sound player list
            sound.Add(new SoundPlayer(Properties.Resources.dammit));
            sound.Add(new SoundPlayer(Properties.Resources.boring));
            sound.Add(new SoundPlayer(Properties.Resources.burp));
            sound.Add(new SoundPlayer(Properties.Resources.doh1_y));
            sound.Add(new SoundPlayer(Properties.Resources.darn_tootin));
        }
        public void Colours()
        {
            //adds all the colours to a colors list
            colors.Add(Color.LightGreen);
            colors.Add(Color.ForestGreen);
            colors.Add(Color.Red);
            colors.Add(Color.DarkRed);
            colors.Add(Color.Yellow);
            colors.Add(Color.Goldenrod);
            colors.Add(Color.Blue);
            colors.Add(Color.DarkBlue);
        }
    }
}
