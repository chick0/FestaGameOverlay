namespace FestaGameOverlay
{
    public partial class Deathmatch : Form
    {
        private readonly Color ColorA = ColorTranslator.FromHtml("#ff3737");
        private readonly Color ColorB = ColorTranslator.FromHtml("#ffb040");
        private readonly Color ColorC = ColorTranslator.FromHtml("#4a9fff");
        private readonly Color ColorD = ColorTranslator.FromHtml("#ff009c");
        private readonly Color ColorE = ColorTranslator.FromHtml("#8c4dff");
        private readonly Color Fail = ColorTranslator.FromHtml("#3f3f3f");

        public Deathmatch()
        {
            InitializeComponent();
        }

        public void Render()
        {
            // Set Text
            PlayerA.Text = Program.A.Name;
            PlayerB.Text = Program.B.Name;
            PlayerC.Text = Program.C.Name;
            PlayerD.Text = Program.D.Name;
            PlayerE.Text = Program.E.Name;

            // Set Status
            if (Program.A.Status == true)
            {
                PlayerA.BackColor = ColorA;
                PlayerA.Image?.Dispose();
                PlayerA.Image = null;
            }
            else
            {
                PlayerA.BackColor = Fail;
                PlayerA.Image = Properties.Resources.BAN_RED_MINI;
            }

            if (Program.B.Status == true)
            {
                PlayerB.BackColor = ColorB;
                PlayerB.Image?.Dispose();
                PlayerB.Image = null;
            }
            else
            {
                PlayerB.BackColor = Fail;
                PlayerB.Image = Properties.Resources.BAN_RED_MINI;
            }

            if (Program.C.Status == true)
            {
                PlayerC.BackColor = ColorC;
                PlayerC.Image?.Dispose();
                PlayerC.Image = null;
            }
            else
            {
                PlayerC.BackColor = Fail;
                PlayerC.Image = Properties.Resources.BAN_RED_MINI;
            }

            if (Program.D.Status == true)
            {
                PlayerD.BackColor = ColorD;
                PlayerD.Image?.Dispose();
                PlayerD.Image = null;
            }
            else
            {
                PlayerD.BackColor = Fail;
                PlayerD.Image = Properties.Resources.BAN_RED_MINI;
            }

            if (Program.E.Status == true)
            {
                PlayerE.BackColor = ColorE;
                PlayerE.Image?.Dispose();
                PlayerE.Image = null;
            }
            else
            {
                PlayerE.BackColor = Fail;
                PlayerE.Image = Properties.Resources.BAN_RED_MINI;
            }
        }

        private void Deathmatch_Load(object sender, EventArgs e)
        {
            Render();

            // Apply Font
            PlayerA.Font = Program.fontManager.ToFont(2, 25f);
            PlayerB.Font = Program.fontManager.ToFont(2, 25f);
            PlayerC.Font = Program.fontManager.ToFont(2, 25f);
            PlayerD.Font = Program.fontManager.ToFont(2, 25f);
            PlayerE.Font = Program.fontManager.ToFont(2, 25f);
        }

        private void Deathmatch_Closing(object sender, EventArgs e)
        {
            Program.OpenedDeathmatch = null;
        }
    }
}
