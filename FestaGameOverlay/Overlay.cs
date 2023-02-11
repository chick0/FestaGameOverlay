namespace FestaGameOverlay
{
    public partial class Overlay : Form
    {
        private void LoadFromCPanel()
        {
            // 플레이어 목록 불러오기
            playerList = new List<Player>() { Program.A, Program.B, Program.C, Program.D, Program.E };
            playerList = playerList.Where(player => player.OnStage).ToList();

            if (playerList.Count != 2)
            {
                Program.OpenedOverlay?.Close();
                return;
            }

            One = playerList[0];
            Two = playerList[1];

            UpdateLabel();
        }

        private void UpdateLabel()
        {
            Stage.Text = Program.Stage;
            Match.Text = Program.Match;
            MatchDetail.Text = Program.MatchDetail;

            Player1.Text = One?.Name;
            Player2.Text = Two?.Name;

            // 승리 표시 초기화
            Player1Status.Image = null;
            Player2Status.Image = null;
        }

        Player? One;
        Player? Two;
        List<Player>? playerList;

        public Overlay()
        {
            InitializeComponent();
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            LoadFromCPanel();
        }

        private void UpdateOverlay_Click(object sender, EventArgs e)
        {
            LoadFromCPanel();
        }

        private void ChangePosition_Click(object sender, EventArgs e)
        {
            Player? tmp = One;
            One = Two;
            Two = tmp;

            UpdateLabel();
        }

        private void Player1Win_Click(object sender, EventArgs e)
        {
            UpdateLabel();
            Player1Status.Image = Properties.Resources.Winner;
        }

        private void Player2Win_Click(object sender, EventArgs e)
        {
            UpdateLabel();
            Player2Status.Image = Properties.Resources.Winner;
        }
    }
}
