namespace FestaGameOverlay
{
    public partial class CPanel : Form
    {
        private readonly Color Pass = Color.MediumSeaGreen;
        private readonly Color Fail = Color.LightCoral;

        public CPanel()
        {
            InitializeComponent();
        }

        private void Stage_TextChanged(object sender, EventArgs e)
        {
            Program.Stage = Stage.Text;
        }

        private void Match_TextChanged(object sender, EventArgs e)
        {
            Program.Match = Match.Text;
        }

        private void MatchDetail_TextChanged(object sender, EventArgs e)
        {
            Program.MatchDetail = MatchDetail.Text;
        }

        private void PlayerA_TextChanged(object sender, EventArgs e)
        {
            Program.A.Name = PlayerA.Text;
        }

        private void PlayerB_TextChanged(object sender, EventArgs e)
        {
            Program.B.Name = PlayerB.Text;
        }

        private void PlayerC_TextChanged(object sender, EventArgs e)
        {
            Program.C.Name = PlayerC.Text;
        }

        private void PlayerD_TextChanged(object sender, EventArgs e)
        {
            Program.D.Name = PlayerD.Text;
        }

        private void PlayerE_TextChanged(object sender, EventArgs e)
        {
            Program.E.Name = PlayerE.Text;
        }

        private void PlayerAStatusControl_Click(object sender, EventArgs e)
        {
            if (Program.A.Status == true)
            {
                Program.A.Status = false;
                PlayerAStatusControl.BackColor = Fail;
                PlayerAStatusControl.Text = "탈락";
            }
            else
            {
                Program.A.Status = true;
                PlayerAStatusControl.BackColor = Pass;
                PlayerAStatusControl.Text = "생존";
            }
        }

        private void PlayerAGameControl_Click(object sender, EventArgs e)
        {
            if (Program.A.OnStage == true)
            {
                Program.A.OnStage = false;
                PlayerAGameControl.BackColor = Fail;
                PlayerAGameControl.Text = "대기";
            }
            else
            {
                Program.A.OnStage = true;
                PlayerAGameControl.BackColor = Pass;
                PlayerAGameControl.Text = "출전";
            }
        }

        private void PlayerBStatusControl_Click(object sender, EventArgs e)
        {
            if (Program.B.Status == true)
            {
                Program.B.Status = false;
                PlayerBStatusControl.BackColor = Fail;
                PlayerBStatusControl.Text = "탈락";
            }
            else
            {
                Program.B.Status = true;
                PlayerBStatusControl.BackColor = Pass;
                PlayerBStatusControl.Text = "생존";
            }
        }

        private void PlayerBGameControl_Click(object sender, EventArgs e)
        {
            if (Program.B.OnStage == true)
            {
                Program.B.OnStage = false;
                PlayerBGameControl.BackColor = Fail;
                PlayerBGameControl.Text = "대기";
            }
            else
            {
                Program.B.OnStage = true;
                PlayerBGameControl.BackColor = Pass;
                PlayerBGameControl.Text = "출전";
            }

        }

        private void PlayerCStatusControl_Click(object sender, EventArgs e)
        {
            if (Program.C.Status == true)
            {
                Program.C.Status = false;
                PlayerCStatusControl.BackColor = Fail;
                PlayerCStatusControl.Text = "탈락";
            }
            else
            {
                Program.C.Status = true;
                PlayerCStatusControl.BackColor = Pass;
                PlayerCStatusControl.Text = "생존";
            }
        }

        private void PlayerCGameControl_Click(object sender, EventArgs e)
        {
            if (Program.C.OnStage == true)
            {
                Program.C.OnStage = false;
                PlayerCGameControl.BackColor = Fail;
                PlayerCGameControl.Text = "대기";
            }
            else
            {
                Program.C.OnStage = true;
                PlayerCGameControl.BackColor = Pass;
                PlayerCGameControl.Text = "출전";
            }

        }

        private void PlayerDStatusControl_Click(object sender, EventArgs e)
        {
            if (Program.D.Status == true)
            {
                Program.D.Status = false;
                PlayerDStatusControl.BackColor = Fail;
                PlayerDStatusControl.Text = "탈락";
            }
            else
            {
                Program.D.Status = true;
                PlayerDStatusControl.BackColor = Pass;
                PlayerDStatusControl.Text = "생존";
            }
        }

        private void PlayerDGameControl_Click(object sender, EventArgs e)
        {
            if (Program.D.OnStage == true)
            {
                Program.D.OnStage = false;
                PlayerDGameControl.BackColor = Fail;
                PlayerDGameControl.Text = "대기";
            }
            else
            {
                Program.D.OnStage = true;
                PlayerDGameControl.BackColor = Pass;
                PlayerDGameControl.Text = "출전";
            }

        }

        private void PlayerEStatusControl_Click(object sender, EventArgs e)
        {
            if (Program.E.Status == true)
            {
                Program.E.Status = false;
                PlayerEStatusControl.BackColor = Fail;
                PlayerEStatusControl.Text = "탈락";
            }
            else
            {
                Program.E.Status = true;
                PlayerEStatusControl.BackColor = Pass;
                PlayerEStatusControl.Text = "생존";
            }
        }

        private void PlayerEGameControl_Click(object sender, EventArgs e)
        {
            if (Program.E.OnStage == true)
            {
                Program.E.OnStage = false;
                PlayerEGameControl.BackColor = Fail;
                PlayerEGameControl.Text = "대기";
            }
            else
            {
                Program.E.OnStage = true;
                PlayerEGameControl.BackColor = Pass;
                PlayerEGameControl.Text = "출전";
            }

        }

        private void OpenOverlay_Click(object sender, EventArgs e)
        {
            Program.OpenedOverlay?.Close();

            Program.OpenedOverlay = new Overlay();
            Program.OpenedOverlay.Show();
        }
    }
}
