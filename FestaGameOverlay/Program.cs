namespace FestaGameOverlay
{
    internal class Player
    {
        public string Name;
        public bool Status;
        public bool OnStage;

        public Player()
        {
            Name = "";
            Status = true;
            OnStage = false;
        }
    }

    internal static class Program
    {
        public static string Stage = "Stage 1";
        public static string Match = "풀리그";
        public static string MatchDetail = "1경기";

        public static Player A = new();
        public static Player B = new();
        public static Player C = new();
        public static Player D = new();
        public static Player E = new();

        public static Overlay? OpenedOverlay = null;
        public static Deathmatch? OpenedDeathmatch = null;

        public static FontManager fontManager = new();

        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            _ = Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.Run(new CPanel());
        }
    }
}
