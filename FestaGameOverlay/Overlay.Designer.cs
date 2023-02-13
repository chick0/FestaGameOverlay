namespace FestaGameOverlay
{
    partial class Overlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OverlayBackground = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Stage = new System.Windows.Forms.Label();
            this.Match = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OverlayBackground
            // 
            this.OverlayBackground.BackColor = System.Drawing.Color.White;
            this.OverlayBackground.Location = new System.Drawing.Point(0, 0);
            this.OverlayBackground.Margin = new System.Windows.Forms.Padding(0);
            this.OverlayBackground.Name = "OverlayBackground";
            this.OverlayBackground.Size = new System.Drawing.Size(760, 120);
            this.OverlayBackground.TabIndex = 5;
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(169)))), ((int)(((byte)(194)))));
            this.Player1.Font = new System.Drawing.Font("Pretendard", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player1.ForeColor = System.Drawing.Color.White;
            this.Player1.Location = new System.Drawing.Point(0, 0);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(200, 120);
            this.Player1.TabIndex = 10;
            this.Player1.Text = "1 플레이어";
            this.Player1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(74)))), ((int)(((byte)(46)))));
            this.Player2.Font = new System.Drawing.Font("Pretendard", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player2.ForeColor = System.Drawing.Color.White;
            this.Player2.Location = new System.Drawing.Point(560, 0);
            this.Player2.Margin = new System.Windows.Forms.Padding(0);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(200, 120);
            this.Player2.TabIndex = 11;
            this.Player2.Text = "2 플레이어";
            this.Player2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stage
            // 
            this.Stage.BackColor = System.Drawing.Color.White;
            this.Stage.Font = new System.Drawing.Font("Pretendard", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stage.ForeColor = System.Drawing.Color.Black;
            this.Stage.Location = new System.Drawing.Point(200, 0);
            this.Stage.Margin = new System.Windows.Forms.Padding(0);
            this.Stage.Name = "Stage";
            this.Stage.Size = new System.Drawing.Size(360, 75);
            this.Stage.TabIndex = 12;
            this.Stage.Text = "Stage 1";
            this.Stage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Match
            // 
            this.Match.BackColor = System.Drawing.Color.White;
            this.Match.Font = new System.Drawing.Font("Pretendard", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Match.ForeColor = System.Drawing.Color.Black;
            this.Match.Location = new System.Drawing.Point(200, 75);
            this.Match.Margin = new System.Windows.Forms.Padding(0);
            this.Match.Name = "Match";
            this.Match.Size = new System.Drawing.Size(360, 45);
            this.Match.TabIndex = 13;
            this.Match.Text = "토너먼트 1경기";
            this.Match.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 120);
            this.Controls.Add(this.Match);
            this.Controls.Add(this.Stage);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.OverlayBackground);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlay";
            this.ShowIcon = false;
            this.Text = "오버레이";
            this.Load += new System.EventHandler(this.Overlay_Load);
            this.FormClosing += new FormClosingEventHandler(this.Overlay_Closing);
            this.ResumeLayout(false);
        }

        #endregion

        private Label OverlayBackground;
        private Label Player1;
        private Label Player2;
        private Label Stage;
        private Label Match;
    }
}
