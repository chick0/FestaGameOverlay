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

            // Set Font
            PlayerA.Font = Program.fontManager.ToFont(FontId.Light, 45f);
            PlayerB.Font = Program.fontManager.ToFont(FontId.Light, 45f);
            PlayerC.Font = Program.fontManager.ToFont(FontId.Light, 45f);
            PlayerD.Font = Program.fontManager.ToFont(FontId.Light, 45f);
            PlayerE.Font = Program.fontManager.ToFont(FontId.Light, 45f);

            // Set Parent
            PicA.Parent = PlayerA;
            PicB.Parent = PlayerB;
            PicC.Parent = PlayerC;
            PicD.Parent = PlayerD;
            PicE.Parent = PlayerE;

            // Set SizeMode
            PicA.SizeMode = PictureBoxSizeMode.Zoom;
            PicB.SizeMode = PictureBoxSizeMode.Zoom;
            PicC.SizeMode = PictureBoxSizeMode.Zoom;
            PicD.SizeMode = PictureBoxSizeMode.Zoom;
            PicE.SizeMode = PictureBoxSizeMode.Zoom;

            Render();
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

                // Update Status
                if (player.Status == true)
                {
                    label.BackColor = color;
                    box.Location = new(0, 200);
                }
                else
                {
                    label.BackColor = Fail;
                    box.Location = new(0, 0);
                }

            }
        }

        private void Deathmatch_Closing(object sender, EventArgs e)
        {
            Program.OpenedDeathmatch = null;
        }
    }
}
