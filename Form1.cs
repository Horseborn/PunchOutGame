using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PunchOutGame
{
    public partial class Form1 : Form
    {

        bool blockAttack = false;

        List<string> enemyAttacks = new List<string> { "left", "right", "block" };

        Random rnd = new Random();

        int enemySpeed = 5;

        int i = 0;

        bool enemyBlocked;

        int playerHealth = 100;
        int enemyHealth = 100;

        public Form1()
        {
            InitializeComponent();

            playerLife.ForeColor = Color.Blue;
            enemyLife.ForeColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enemyMove_Tick(object sender, EventArgs e)
        {
            enemyBoxer.Left += enemySpeed;

            if (playerHealth > 1)
            {
                playerLife.Value = Convert.ToInt32(playerHealth);
            }

            if (enemyHealth > 1)
            {
                enemyLife.Value = Convert.ToInt32(enemyHealth);
            }

            if (enemyBoxer.Left > 480)
            {
                enemySpeed = -5;
            }
            if (enemyBoxer.Left < 315)
            {
                enemySpeed = 5;
            }


            if (enemyHealth < 1)
            {
                enemyTimer.Stop();
                enemyMove.Stop();

                MessageBox.Show("You win, click OK to play again.");

                resetGame();
            }

            if (playerHealth < 1 )
            {
                enemyTimer.Stop();
                enemyTimer.Stop();

                MessageBox.Show("Tough Rob won! Click OK to retry!");
                resetGame();
                

            }
        }

        private void enemyPunchEvent(object sender, EventArgs e)
        {
            i = rnd.Next(0, enemyAttacks.Count);

            switch (enemyAttacks[i].ToString())
            {
                case "left":
                    enemyBoxer.Image = Properties.Resources.enemy_punch1;
                    if (enemyBoxer.Bounds.IntersectsWith(boxer.Bounds) && !blockAttack)
                    {
                        playerHealth -= 20;
                    }
                    enemyBlocked = false;
                    break;

                case "right":
                    enemyBoxer.Image = Properties.Resources.enemy_punch2;
                    if(enemyBoxer.Bounds.IntersectsWith(boxer.Bounds) && !blockAttack)
                    {
                        playerHealth -= 20;
                    }
                        enemyBlocked = false;
                        break;

                case "block":
                    enemyBoxer.Image = Properties.Resources.enemy_block;
                    enemyBlocked = true;
                    break;
            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                boxer.Image = Properties.Resources.boxer_block;
                blockAttack = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                boxer.Image = Properties.Resources.boxer_left_punch;

                if (enemyBoxer.Bounds.IntersectsWith(boxer.Bounds) && !enemyBlocked)
                {
                    enemyHealth -= 5;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                boxer.Image = Properties.Resources.boxer_right_punch;

                if (enemyBoxer.Bounds.IntersectsWith(boxer.Bounds) && !enemyBlocked)
                {
                    
                    enemyHealth -= 5;
                }
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            boxer.Image = Properties.Resources.boxer_block;
            blockAttack = false;
        }

        private void resetGame()
        {
            enemyTimer.Start();
            enemyMove.Start();

            enemyBoxer.Left = 385;
            enemyBoxer.Top = 297;

            enemyBoxer.Image = Properties.Resources.enemy_stand;
            boxer.Image = Properties.Resources.boxer_stand;

            playerHealth = 100;
            enemyHealth = 100;
        }
    }
}
