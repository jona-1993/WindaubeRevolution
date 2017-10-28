using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace Windaube_Revolution
{
    public partial class Form1 : Form
    {
        public int Compteur = 0, ecoule = 5, PagesRestantes = 9, Verrou = 0, timeout = 1, DifficultyLevel = 1;
        private bool mute;
        private List<Point> anc = new List<Point>();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int difficulte, bool son_off)
        {

            InitializeComponent();

            MessageResultat.Text = null;

            mute = son_off;

            switch(difficulte)
            {
                case 1: ecoule += 9;
                        PagesRestantes = 9;
                        Difficulty.Text = "Facile";
                        DifficultyLevel = 1;
                        break;
                case 2: StartTimer.Interval = 30000;
                        PagesRestantes = 29;
                        ecoule += 29;
                        Difficulty.Text = "Moyen";
                        DifficultyLevel = 2;
                        break;
                case 3: StartTimer.Interval = 50000;
                        PagesRestantes = 49;
                        ecoule += 49;
                        Difficulty.Text = "Difficile";
                        DifficultyLevel = 3;
                        break;
            }

        }

        private void Sleep_Tick(object sender, EventArgs e)
        {
            if(timeout <= 1)
            {
                if (PagesRestantes != 0)
                {
                    Verrou = 1;

                    MessageResultat.ForeColor = Color.Red;

                    switch (DifficultyLevel)
                    {
                        case 1:
                            MessageResultat.Text = "Le système à planté! Votre cervelle à conduit votre système à l'échec. C'est malin!";
                            break;
                        case 2:
                            MessageResultat.Text = "C'est entièrement votre faute! Vous êtes trop gourmand!";
                            break;
                        case 3:
                            MessageResultat.Text = "Vous cherchez à faire le boss alors que vous y êtes absolument pas! \nPour votre système, par pitié, ne réessayez pas..";
                            break;
                    }

                    SleepAndQuit.Enabled = true;

                }

                Sleep.Enabled = false;
            }
            else
            {
                timeout -= 1;

                ecoule -= 1;
                Temps.Text = ecoule.ToString();
            }
        }

        private void SleepAndQuit_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartTimer.Enabled = true;
            Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond + DateTime.Now.Second);
            
            int x = rnd.Next(this.Size.Width - 400); // -400

            int y = rnd.Next(this.Size.Height - 200); // -200

            
            if (y <= 100)
            {
                y += 100;
            }

            while (anc.Contains(new Point(x, y)))
            {
                rnd = new Random(DateTime.Now.Millisecond - DateTime.Now.Second);

                x = rnd.Next(this.Size.Width - 400); // -400

                y = rnd.Next(this.Size.Height - 200); // -200

                if (y <= 100)
                {
                    y += 100;
                }
            }
           

            anc.Add(new Point(x, y));

            Console.WriteLine("(" + x + ";" + y + ")");

            ErrorForm Msg = new ErrorForm(new Point(x, y), mute);

            ecoule -= 1;

            if (ecoule == 5)
            {
                Temps.ForeColor = Color.Red;
            }

            Temps.Text = ecoule.ToString();

            //Msg.Show();

            if (Msg.ShowDialog() == DialogResult.OK)
            {
                if (Verrou == 0)
                {
                    Compteur += Msg.Confirme;

                    Score.Text = Compteur.ToString();

                    PagesRestantes -= 1;
                }
            }


            if (PagesRestantes == 0)
            {
                if (Verrou == 0)
                {
                    switch (DifficultyLevel)
                    {
                        case 1: MessageResultat.Text = "Windows est parvenu à débloquer votre système.\nNous sommes désolés pour la gène occasionnée!";
                                break;
                        case 2: MessageResultat.Text = "C'est évident! Les employés de Microsoft sont des dieux !";
                                break;
                        case 3: MessageResultat.Text = "Vous ne voulez pas travailler chez Microsoft? Nous cherchons des gens comme vous!";
                                break;
                    }
                    SleepAndQuit.Enabled = true;
                }
            }
            

        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            StartTimer.Enabled = false;

            timeout = 5;
            
            Sleep.Enabled = true;


           

            
        }
    }
}
