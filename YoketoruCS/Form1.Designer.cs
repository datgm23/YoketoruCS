namespace YoketoruCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            buttonStart = new Button();
            labelGameover = new Label();
            buttonTitle = new Button();
            labelClear = new Label();
            labelScore = new Label();
            labelHighScore = new Label();
            tempPlayer = new Label();
            labelTimer = new Label();
            labelCopyright = new Label();
            tempObstacle = new Label();
            tempItem = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(236, 67);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(153, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "よけとるCS";
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(224, 167);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(176, 50);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "スタート!!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameover.Location = new Point(214, 138);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(196, 45);
            labelGameover.TabIndex = 2;
            labelGameover.Text = "GAME OVER";
            // 
            // buttonTitle
            // 
            buttonTitle.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTitle.Location = new Point(224, 250);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(176, 45);
            buttonTitle.TabIndex = 3;
            buttonTitle.Text = "タイトルへ";
            buttonTitle.UseVisualStyleBackColor = true;
            buttonTitle.Click += buttonTitle_Click;
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelClear.Location = new Point(248, 138);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(129, 45);
            labelClear.TabIndex = 4;
            labelClear.Text = "CLEAR!!";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(260, -2);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(107, 37);
            labelScore.TabIndex = 5;
            labelScore.Text = "00000";
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHighScore.Location = new Point(231, 35);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(162, 19);
            labelHighScore.TabIndex = 6;
            labelHighScore.Text = "High Score: 00000";
            // 
            // tempPlayer
            // 
            tempPlayer.AutoSize = true;
            tempPlayer.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tempPlayer.Location = new Point(58, 162);
            tempPlayer.Name = "tempPlayer";
            tempPlayer.Size = new Size(49, 21);
            tempPlayer.TabIndex = 7;
            tempPlayer.Text = "(・ω・)";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.Location = new Point(541, 315);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(71, 37);
            labelTimer.TabIndex = 8;
            labelTimer.Text = "000";
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Location = new Point(263, 332);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(99, 15);
            labelCopyright.TabIndex = 9;
            labelCopyright.Text = "(C) 2023 たなかゆう";
            // 
            // tempObstacle
            // 
            tempObstacle.AutoSize = true;
            tempObstacle.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tempObstacle.Location = new Point(46, 236);
            tempObstacle.Name = "tempObstacle";
            tempObstacle.Size = new Size(26, 21);
            tempObstacle.TabIndex = 10;
            tempObstacle.Text = "◆";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tempItem.ForeColor = Color.FromArgb(255, 128, 0);
            tempItem.Location = new Point(142, 250);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(35, 30);
            tempItem.TabIndex = 11;
            tempItem.Text = "★";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 361);
            Controls.Add(tempItem);
            Controls.Add(tempObstacle);
            Controls.Add(labelCopyright);
            Controls.Add(labelTimer);
            Controls.Add(tempPlayer);
            Controls.Add(labelHighScore);
            Controls.Add(labelScore);
            Controls.Add(labelClear);
            Controls.Add(buttonTitle);
            Controls.Add(labelGameover);
            Controls.Add(buttonStart);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Button buttonStart;
        private Label labelGameover;
        private Button buttonTitle;
        private Label labelClear;
        private Label labelScore;
        private Label labelHighScore;
        private Label tempPlayer;
        private Label labelTimer;
        private Label labelCopyright;
        private Label tempObstacle;
        private Label tempItem;
    }
}