namespace Windaube_Revolution
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreditsButton = new System.Windows.Forms.Button();
            this.DifficultyButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DureePartieTimer = new System.Windows.Forms.Timer(this.components);
            this.SongLabel = new System.Windows.Forms.Label();
            this.SongButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.DifficultyLabel);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.CreditsButton);
            this.MainPanel.Controls.Add(this.DifficultyButton);
            this.MainPanel.Controls.Add(this.StartButton);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(316, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(400, 526);
            this.MainPanel.TabIndex = 0;
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Location = new System.Drawing.Point(147, 137);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(125, 13);
            this.DifficultyLabel.TabIndex = 5;
            this.DifficultyLabel.Text = "Mode de difficulté: Facile";
            this.DifficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(169, 477);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Quitter";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CreditsButton
            // 
            this.CreditsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreditsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditsButton.Location = new System.Drawing.Point(169, 439);
            this.CreditsButton.Name = "CreditsButton";
            this.CreditsButton.Size = new System.Drawing.Size(75, 23);
            this.CreditsButton.TabIndex = 3;
            this.CreditsButton.Text = "Credits";
            this.CreditsButton.UseVisualStyleBackColor = false;
            this.CreditsButton.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // DifficultyButton
            // 
            this.DifficultyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DifficultyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DifficultyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DifficultyButton.Location = new System.Drawing.Point(169, 399);
            this.DifficultyButton.Name = "DifficultyButton";
            this.DifficultyButton.Size = new System.Drawing.Size(75, 23);
            this.DifficultyButton.TabIndex = 2;
            this.DifficultyButton.Text = "Difficulté";
            this.DifficultyButton.UseVisualStyleBackColor = false;
            this.DifficultyButton.Click += new System.EventHandler(this.DifficultyButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(144, 200);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(128, 39);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Commencer";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "MS Windaube Revolution";
            // 
            // DureePartieTimer
            // 
            this.DureePartieTimer.Tick += new System.EventHandler(this.DureePartieTimer_Tick);
            // 
            // SongLabel
            // 
            this.SongLabel.AutoSize = true;
            this.SongLabel.BackColor = System.Drawing.Color.Transparent;
            this.SongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongLabel.Location = new System.Drawing.Point(870, 508);
            this.SongLabel.Name = "SongLabel";
            this.SongLabel.Size = new System.Drawing.Size(38, 16);
            this.SongLabel.TabIndex = 1;
            this.SongLabel.Text = "Son: ";
            // 
            // SongButton
            // 
            this.SongButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SongButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SongButton.Location = new System.Drawing.Point(914, 505);
            this.SongButton.Name = "SongButton";
            this.SongButton.Size = new System.Drawing.Size(41, 23);
            this.SongButton.TabIndex = 2;
            this.SongButton.Text = "ON";
            this.SongButton.UseVisualStyleBackColor = false;
            this.SongButton.Click += new System.EventHandler(this.SongButton_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Windaube_Revolution.Properties.Resources.BSOD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 562);
            this.Controls.Add(this.SongButton);
            this.Controls.Add(this.SongLabel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windaube Revolution - Menu Principal";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CreditsButton;
        private System.Windows.Forms.Button DifficultyButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer DureePartieTimer;
        private System.Windows.Forms.Label SongLabel;
        private System.Windows.Forms.Button SongButton;
    }
}