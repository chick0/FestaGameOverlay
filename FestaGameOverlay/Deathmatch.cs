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
            Player[] players = new Player[] { Program.A, Program.B, Program.C, Program.D, Program.E };

            Label[] pLabel = new Label[] { PlayerA, PlayerB, PlayerC, PlayerD, PlayerE };
            Color[] colors = new Color[] { ColorA, ColorB, ColorC, ColorD, ColorE };

            PictureBox[] pBox = new PictureBox[] { PicA, PicB, PicC, PicD, PicE };

            for (int index = 0; index < players.Length; index++)
            {
                Player player = players[index];

                Label label = pLabel[index];
                Color color = colors[index];

                PictureBox box = pBox[index];

                // Update Label text
                label.Text = player.Name;

                // Set box Parent to label
                box.Parent = label;
                //box.BackColor = Fail;

                // Update Status
                if (player.Status == true)
                {
                    label.BackColor = color;
                    box.Location = new(200 * index, 120);
                }
                else
                {
                    label.BackColor = Fail;
                    box.Location = new(200 * index, 0);
                }

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
