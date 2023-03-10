namespace FestaGameOverlay
{
    public partial class Overlay : Form
    {
        private Player? One;
        private Player? Two;
        private List<Player>? playerList;

        public Overlay()
        {
            InitializeComponent();

            // Set SizeMode
            Status1.SizeMode = PictureBoxSizeMode.Zoom;
            Status2.SizeMode = PictureBoxSizeMode.Zoom;

            // Set Parent
            Status1.Parent = Player1;
            Status2.Parent = Player2;

            // Set Font
            Player1.Font = Program.fontManager.ToFont(FontId.Light, 45f);
            Player2.Font = Program.fontManager.ToFont(FontId.Light, 45f);

            Stage.Font = Program.fontManager.ToFont(FontId.Black, 70f);
            Match.Font = Program.fontManager.ToFont(FontId.Default, 45f);

            LoadFromCPanel();
        }

        public void LoadFromCPanel()
        {
            // 플레이어 목록 불러오기
            playerList = new List<Player>() { Program.A, Program.B, Program.C, Program.D, Program.E };
            playerList = playerList.Where(player => player.OnStage).ToList();

            if (playerList.Count != 2)
            {
                _ = MessageBox.Show(
                    "오버레이를 실행하려면 두 명의 선수를 선택해야합니다.",
                    "경고",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                return;
            }

            One = playerList[0];
            Two = playerList[1];

            UpdateLabel();
        }

        public void ChangeOneTwo()
        {
            (Two, One) = (One, Two);
            UpdateLabel();
        }

        public void PlayerWin(int playerId)
        {
            ResetStatusImage();

            if (playerId == 1)
            {
                Status1.Image = Properties.Resources.Winner;
                Status2.Image = Properties.Resources.Loser;
            }
            else if (playerId == 2)
            {
                Status1.Image = Properties.Resources.Loser;
                Status2.Image = Properties.Resources.Winner;
            }

            Status1.Location = new(0, 160);
            Status2.Location = new(0, 160);
        }

        private void UpdateLabel()
        {
            Stage.Text = Program.Stage;
            Match.Text = Program.Match + " " + Program.MatchDetail;

            Player1.Text = One?.Name;
            Player2.Text = Two?.Name;

            ResetStatusImage();
        }

        private void ResetStatusImage()
        {
            Status1.Location = new(0, 200);
            Status2.Location = new(0, 200);
        }

        private void Overlay_Closing(object sender, EventArgs e)
        {
            Program.OpenedOverlay = null;
        }
    }
}
