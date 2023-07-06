using System.Runtime.InteropServices;

namespace YoketoruCS
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        static int PlayerMax => 1;
        static int ItemMax => 3;
        static int ObstacleMax => 3;
        static int PlayerIndex => 0;
        static int ObstacleIndex => PlayerIndex + PlayerMax;
        static int ItemIndex => ObstacleIndex + ObstacleMax;
        static int LabelMax => ItemIndex + ItemMax;
        Label[] chrLabels = new Label[LabelMax];
        int itemCount;
        
        // �񋓎qenum
        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear
        }

        State nextState = State.Title;
        State currentState = State.None;

        int score;
        int timer;
        int highScore = 100;
        int StartTimer => 200;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < LabelMax; i++)
            {
                chrLabels[i] = new Label();
                chrLabels[i].AutoSize = true;
                chrLabels[i].Top = i * 24;
                Controls.Add(chrLabels[i]);
                if (i < ObstacleIndex)
                {
                    chrLabels[i].Text = tempPlayer.Text;
                    chrLabels[i].Font = tempPlayer.Font;
                    chrLabels[i].ForeColor = tempPlayer.ForeColor; 
                }
                else if (i < ItemIndex)
                {
                    chrLabels[i].Text = tempObstacle.Text;
                    chrLabels[i].Font = tempObstacle.Font;
                    chrLabels[i].ForeColor = tempObstacle.ForeColor;
                }
                else
                {
                    chrLabels[i].Text = tempItem.Text;
                    chrLabels[i].Font = tempItem.Font;
                    chrLabels[i].ForeColor = tempItem.ForeColor;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeState();
            UpdateState();
        }

        void ChangeState()
        {
            if (nextState == State.None) return;

            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    labelTitle.Visible = true;
                    buttonStart.Visible = true;
                    labelGameover.Visible = false;
                    buttonTitle.Visible = false;
                    labelClear.Visible = false;
                    labelHighScore.Visible = true;
                    tempPlayer.Visible = false;
                    tempObstacle.Visible = false;
                    tempItem.Visible = false;
                    labelCopyright.Visible = true;
                    break;

                case State.Game:
                    labelTitle.Visible = false;
                    buttonStart.Visible = false;
                    labelHighScore.Visible = false;
                    labelCopyright.Visible = false;
                    score = 0;
                    timer = StartTimer;
                    break;

                case State.Gameover:
                    labelGameover.Visible = true;
                    buttonTitle.Visible = true;
                    labelHighScore.Visible = true;
                    break;

                case State.Clear:
                    labelClear.Visible = true;
                    buttonTitle.Visible = true;
                    labelHighScore.Visible = true;
                    break;
            }
        }

        void UpdateState()
        {
            switch (currentState)
            {
                case State.Game:
                    UpdateGame();
                    break;
            }
        }

        void UpdateGame()
        {
            if (GetAsyncKeyState((int)Keys.O) < 0)
            {
                nextState = State.Gameover;
            }
            if (GetAsyncKeyState((int)Keys.C) < 0)
            {
                nextState = State.Clear;
            }

            UpdatePlayer();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void buttonTitle_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        void UpdatePlayer()
        {
            var mpos = PointToClient(MousePosition);

            chrLabels[PlayerIndex].Left = mpos.X - chrLabels[PlayerIndex].Width / 2;
            chrLabels[PlayerIndex].Top = mpos.Y - chrLabels[PlayerIndex].Height / 2;
        }
    }
}