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
            this.ChangePosition = new System.Windows.Forms.Button();
            this.UpdateOverlay = new System.Windows.Forms.Button();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Stage = new System.Windows.Forms.Label();
            this.Match = new System.Windows.Forms.Label();
            this.Player1Win = new System.Windows.Forms.Button();
            this.Player2Win = new System.Windows.Forms.Button();
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
            // ChangePosition
            // 
            this.ChangePosition.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangePosition.Location = new System.Drawing.Point(235, 142);
            this.ChangePosition.Name = "ChangePosition";
            this.ChangePosition.Size = new System.Drawing.Size(217, 51);
            this.ChangePosition.TabIndex = 8;
            this.ChangePosition.Text = "참가자 순서 바꾸기";
            this.ChangePosition.UseVisualStyleBackColor = true;
            this.ChangePosition.Click += new System.EventHandler(this.ChangePosition_Click);
            // 
            // UpdateOverlay
            // 
            this.UpdateOverlay.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateOverlay.Location = new System.Drawing.Point(12, 142);
            this.UpdateOverlay.Name = "UpdateOverlay";
            this.UpdateOverlay.Size = new System.Drawing.Size(217, 51);
            this.UpdateOverlay.TabIndex = 9;
            this.UpdateOverlay.Text = "설정 불러오기";
            this.UpdateOverlay.UseVisualStyleBackColor = true;
            this.UpdateOverlay.Click += new System.EventHandler(this.UpdateOverlay_Click);
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
            // Player1Win
            // 
            this.Player1Win.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(169)))), ((int)(((byte)(194)))));
            this.Player1Win.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player1Win.ForeColor = System.Drawing.Color.White;
            this.Player1Win.Location = new System.Drawing.Point(538, 143);
            this.Player1Win.Name = "Player1Win";
            this.Player1Win.Size = new System.Drawing.Size(102, 51);
            this.Player1Win.TabIndex = 15;
            this.Player1Win.Text = "1P 승리";
            this.Player1Win.UseVisualStyleBackColor = false;
            this.Player1Win.Click += new System.EventHandler(this.Player1Win_Click);
            // 
            // Player2Win
            // 
            this.Player2Win.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(74)))), ((int)(((byte)(46)))));
            this.Player2Win.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player2Win.ForeColor = System.Drawing.Color.White;
            this.Player2Win.Location = new System.Drawing.Point(646, 143);
            this.Player2Win.Name = "Player2Win";
            this.Player2Win.Size = new System.Drawing.Size(102, 51);
            this.Player2Win.TabIndex = 16;
            this.Player2Win.Text = "2P 승리";
            this.Player2Win.UseVisualStyleBackColor = false;
            this.Player2Win.Click += new System.EventHandler(this.Player2Win_Click);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 206);
            this.Controls.Add(this.Player2Win);
            this.Controls.Add(this.Player1Win);
            this.Controls.Add(this.Match);
            this.Controls.Add(this.Stage);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.UpdateOverlay);
            this.Controls.Add(this.ChangePosition);
            this.Controls.Add(this.OverlayBackground);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlay";
            this.ShowIcon = false;
            this.Text = "오버레이";
            this.Load += new System.EventHandler(this.Overlay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label OverlayBackground;
        private Button ChangePosition;
        private Button UpdateOverlay;
        private Label Player1;
        private Label Player2;
        private Label Stage;
        private Label Match;
        private Button Player1Win;
        private Button Player2Win;
    }
}
