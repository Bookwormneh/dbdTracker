using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbdTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            printFullLogsToScreen(logParser.parse());
            
            // infoBox.Text = logParser.getAcheivements();
        }

        private void printFullLogsToScreen(Game game)
        {
            Console.WriteLine("Printing...");
            Console.WriteLine(game.survivors[1].playerName);
            Console.WriteLine(game.survivors[1].logAchievements.Count);

            for (int i = 0; i < game.killer.logAchievements.Count; i++)
            {
                infoBox.Text += game.killer.logAchievements[i] + Environment.NewLine;
            }

            for (int i = 0; i < game.survivors[0].logAchievements.Count; i++)
            {
                survivorOneText.Text += game.survivors[0].logAchievements[i] + Environment.NewLine;
            }

            for (int i = 0; i < game.survivors[1].logAchievements.Count; i++)
            {
                survivorTwoText.Text += game.survivors[1].logAchievements[i] + Environment.NewLine;
            }

            for (int i = 0; i < game.survivors[2].logAchievements.Count; i++)
            {
                survivorThreeText.Text += game.survivors[2].logAchievements[i] + Environment.NewLine;
            }

            for (int i = 0; i < game.survivors[3].logAchievements.Count; i++)
            {
                survivorFourText.Text += game.survivors[3].logAchievements[i] + Environment.NewLine;
            }
        }
    }
}
