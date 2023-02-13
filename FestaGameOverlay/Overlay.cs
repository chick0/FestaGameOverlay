using FestaGameOverlay.Properties;

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
        }

        public void LoadFromCPanel()
        {
            // 플레이어 목록 불러오기
            playerList = new List<Player>() { Program.A, Program.B, Program.C, Program.D, Program.E };
            playerList = playerList.Where(player => player.OnStage).ToList();

            if (playerList.Count != 2)
            {
                DialogResult result = MessageBox.Show(
                    "오버레이를 실행하려면 두 명의 선수를 선택해야합니다.",
                    "경고",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK || One == null)
                {
                    Program.OpenedOverlay?.Close();
                }

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
                Player1.Image = Resources.Winner;
            }
            else if (playerId == 2)
            {
                Player2.Image = Resources.Winner;
            }
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
            Player1.Image = null;
            Player2.Image = null;
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            LoadFromCPanel();

            // Apply Font
            Player1.Font = Program.fontManager.ToFont(2, 25f);
            Player2.Font = Program.fontManager.ToFont(2, 25f);

            Stage.Font = Program.fontManager.ToFont(1, 38f);
            Match.Font = Program.fontManager.ToFont(2, 25f);
        }

        private void Overlay_Closing(object sender, EventArgs e)
        {
            Program.OpenedOverlay = null;
        }
    }
}
