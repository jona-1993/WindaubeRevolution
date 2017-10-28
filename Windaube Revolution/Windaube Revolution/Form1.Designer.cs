namespace Windaube_Revolution
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.Temps = new System.Windows.Forms.Label();
            this.TempsLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.MessageResultat = new System.Windows.Forms.Label();
            this.SleepAndQuit = new System.Windows.Forms.Timer(this.components);
            this.Sleep = new System.Windows.Forms.Timer(this.components);
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.Label();
            this.ScorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.Transparent;
            this.ScorePanel.Controls.Add(this.Temps);
            this.ScorePanel.Controls.Add(this.TempsLabel);
            this.ScorePanel.Controls.Add(this.ScoreLabel);
            this.ScorePanel.Controls.Add(this.Score);
            this.ScorePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScorePanel.Location = new System.Drawing.Point(1247, 0);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(189, 609);
            this.ScorePanel.TabIndex = 4;
            // 
            // Temps
            // 
            this.Temps.AutoSize = true;
            this.Temps.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temps.Location = new System.Drawing.Point(95, 41);
            this.Temps.Name = "Temps";
            this.Temps.Size = new System.Drawing.Size(24, 27);
            this.Temps.TabIndex = 3;
            this.Temps.Text = "0";
            // 
            // TempsLabel
            // 
            this.TempsLabel.AutoSize = true;
            this.TempsLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempsLabel.Location = new System.Drawing.Point(4, 41);
            this.TempsLabel.Name = "TempsLabel";
            this.TempsLabel.Size = new System.Drawing.Size(94, 27);
            this.TempsLabel.TabIndex = 2;
            this.TempsLabel.Text = "Temps : ";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(3, 10);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(81, 27);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score: ";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(80, 10);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(24, 27);
            this.Score.TabIndex = 1;
            this.Score.Text = "0";
            // 
            // StartTimer
            // 
            this.StartTimer.Interval = 10000;
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // MessageResultat
            // 
            this.MessageResultat.AutoSize = true;
            this.MessageResultat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageResultat.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageResultat.Location = new System.Drawing.Point(0, 0);
            this.MessageResultat.Name = "MessageResultat";
            this.MessageResultat.Size = new System.Drawing.Size(74, 35);
            this.MessageResultat.TabIndex = 5;
            this.MessageResultat.Text = "None";
            this.MessageResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SleepAndQuit
            // 
            this.SleepAndQuit.Interval = 3000;
            this.SleepAndQuit.Tick += new System.EventHandler(this.SleepAndQuit_Tick);
            // 
            // Sleep
            // 
            this.Sleep.Interval = 1000;
            this.Sleep.Tick += new System.EventHandler(this.Sleep_Tick);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLabel.Location = new System.Drawing.Point(1005, 10);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(117, 27);
            this.DifficultyLabel.TabIndex = 6;
            this.DifficultyLabel.Text = "Difficulté: ";
            this.DifficultyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Difficulty
            // 
            this.Difficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Difficulty.AutoSize = true;
            this.Difficulty.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficulty.Location = new System.Drawing.Point(1116, 10);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(66, 27);
            this.Difficulty.TabIndex = 7;
            this.Difficulty.Text = "Facile";
            this.Difficulty.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windaube_Revolution.Properties.Resources.fondo_transparente_png_by_imsnowbieber_d3jme6i;
            this.ClientSize = new System.Drawing.Size(1436, 609);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.MessageResultat);
            this.Controls.Add(this.ScorePanel);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windaube Revolution";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer StartTimer;
        private System.Windows.Forms.Label Temps;
        private System.Windows.Forms.Label TempsLabel;
        private System.Windows.Forms.Label MessageResultat;
        private System.Windows.Forms.Timer SleepAndQuit;
        private System.Windows.Forms.Timer Sleep;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Label Difficulty;
    }
}

