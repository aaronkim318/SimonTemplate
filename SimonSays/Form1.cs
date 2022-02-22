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
        //TODO: create a List to store the pattern. Must be accessable on other screens
        public static List<int> stored = new List<int>();
        public static Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: Launch MenuScreen
            Form f = this.FindForm();
            f.Controls.Remove(f);

            MenuScreen mm = new MenuScreen();

            this.Location = new Point((f.ClientSize.Width - mm.Width) / 2,
                (f.ClientSize.Height - mm.Height) / 2);

            f.Controls.Add(mm);
            mm.Focus();

        }
    }
}
