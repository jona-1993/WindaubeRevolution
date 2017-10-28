using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Windaube_Revolution
{
    public partial class MenuPrincipal : Form
    {
        Form1 Game;
        int difficulty = 1;
        SoundPlayer player;
        System.IO.Stream s;

        public MenuPrincipal()
        {
            InitializeComponent();

            s = Properties.Resources.WindowsErrorRemix;

            player = new SoundPlayer(s);

            player.Play();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (SongButton.Text == "ON")
            {
                Game = new Form1(difficulty, false);
            }
            else
            {
                Game = new Form1(difficulty, true);
            }

            switch (difficulty)
            {
                case 1:
                    DureePartieTimer.Interval = 19000;
                    break;
                case 2:
                    DureePartieTimer.Interval = 39000;
                    break;
                case 3:
                    DureePartieTimer.Interval = 59000;
                    break;
            }

            if (difficulty != 3)
            {
                this.Visible = false;

                player.Stop();

                if (SongButton.Text == "ON")
                {
                    s = Properties.Resources.MicrosoftWindowsXPWelcomeMusic;

                    player = new SoundPlayer(s);

                    player.Play();
                }

                DureePartieTimer.Enabled = true;

                Game.Show();
            }
            else
            {
                if (MessageBox.Show("Etes-vous sur de vouloir jouer en difficile?\nEn cas d'échec, vous exposez des chances que votre ordinateur provoque un bluescreen et redémarre.\nVeuillez sauver tout document si tel est votre souhait.", "Avertissement: A utiliser à vos risques !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Visible = false;

                    player.Stop();

                    if (SongButton.Text == "ON")
                    {
                        s = Properties.Resources.MicrosoftWindowsXPWelcomeMusic;

                        player = new SoundPlayer(s);

                        player.Play();
                    }

                    DureePartieTimer.Enabled = true;

                    Game.Show();
                }
            }

            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DifficultyButton_Click(object sender, EventArgs e)
        {
            switch(difficulty)
            {
                case 1: difficulty = 2;
                    break;
                case 2: difficulty = 3;
                    break;
                case 3: difficulty = 1;
                    break;
            }

            switch(difficulty)
            {
                case 1: DifficultyLabel.ForeColor = Color.Black;
                        DifficultyLabel.Font = new Font(DifficultyLabel.Font.Name, 8, FontStyle.Regular);
                        DifficultyLabel.Text = "Mode de difficulté: Facile";
                        break;
                case 2: DifficultyLabel.Text = "Mode de difficulté: Moyen";
                        break;
                case 3: DifficultyLabel.ForeColor = Color.DarkRed;
                        DifficultyLabel.Font = new Font(DifficultyLabel.Font.Name, 8, FontStyle.Bold);
                        DifficultyLabel.Text = "Mode de difficulté: Difficile";
                        break;
            }
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            AboutForm win = new AboutForm();

            win.ShowDialog();

        }

        private void DureePartieTimer_Tick(object sender, EventArgs e)
        {
            this.Visible = true;

            DureePartieTimer.Enabled = false;

            if (SongButton.Text == "ON")
            {
                s = Properties.Resources.WindowsErrorRemix;

                player = new SoundPlayer(s);

                player.Play();
            }
        }

        private void SongButton_Click(object sender, EventArgs e)
        {
            if(SongButton.Text == "ON")
            {
                SongButton.Text = "OFF";
                player.Stop();
            }
            else
            {
                SongButton.Text = "ON";
                player.Play();
            }
        }
    }
}
