namespace FestaGameOverlay
{
    partial class CPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StageLabel = new System.Windows.Forms.Label();
            this.Stage = new System.Windows.Forms.TextBox();
            this.Match = new System.Windows.Forms.TextBox();
            this.MatchLabel = new System.Windows.Forms.Label();
            this.MatchDetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerA = new System.Windows.Forms.TextBox();
            this.PlayerB = new System.Windows.Forms.TextBox();
            this.PlayerD = new System.Windows.Forms.TextBox();
            this.PlayerC = new System.Windows.Forms.TextBox();
            this.PlayerE = new System.Windows.Forms.TextBox();
            this.PlayerAStatusControl = new System.Windows.Forms.Button();
            this.PlayerAGameControl = new System.Windows.Forms.Button();
            this.PlayerBGameControl = new System.Windows.Forms.Button();
            this.PlayerBStatusControl = new System.Windows.Forms.Button();
            this.PlayerDGameControl = new System.Windows.Forms.Button();
            this.PlayerDStatusControl = new System.Windows.Forms.Button();
            this.PlayerCGameControl = new System.Windows.Forms.Button();
            this.PlayerCStatusControl = new System.Windows.Forms.Button();
            this.PlayerEGameControl = new System.Windows.Forms.Button();
            this.PlayerEStatusControl = new System.Windows.Forms.Button();
            this.OpenOverlay = new System.Windows.Forms.Button();
            this.Player2Win = new System.Windows.Forms.Button();
            this.Player1Win = new System.Windows.Forms.Button();
            this.ChangePosition = new System.Windows.Forms.Button();
            this.UpdateOverlay = new System.Windows.Forms.Button();
            this.OpenDeathmatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StageLabel
            // 
            this.StageLabel.Font = new System.Drawing.Font("Pretendard", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StageLabel.Location = new System.Drawing.Point(12, 9);
            this.StageLabel.Name = "StageLabel";
            this.StageLabel.Size = new System.Drawing.Size(108, 50);
            this.StageLabel.TabIndex = 0;
            this.StageLabel.Text = "스테이지";
            this.StageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Stage
            // 
            this.Stage.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stage.Location = new System.Drawing.Point(135, 20);
            this.Stage.Name = "Stage";
            this.Stage.Size = new System.Drawing.Size(173, 31);
            this.Stage.TabIndex = 1;
            this.Stage.Text = "Stage 1";
            this.Stage.TextChanged += new System.EventHandler(this.Stage_TextChanged);
            // 
            // Match
            // 
            this.Match.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Match.Location = new System.Drawing.Point(135, 72);
            this.Match.Name = "Match";
            this.Match.Size = new System.Drawing.Size(173, 31);
            this.Match.TabIndex = 3;
            this.Match.Text = "풀리그";
            this.Match.TextChanged += new System.EventHandler(this.Match_TextChanged);
            // 
            // MatchLabel
            // 
            this.MatchLabel.Font = new System.Drawing.Font("Pretendard", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatchLabel.Location = new System.Drawing.Point(12, 59);
            this.MatchLabel.Name = "MatchLabel";
            this.MatchLabel.Size = new System.Drawing.Size(108, 50);
            this.MatchLabel.TabIndex = 2;
            this.MatchLabel.Text = "경기";
            this.MatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatchDetail
            // 
            this.MatchDetail.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatchDetail.Location = new System.Drawing.Point(326, 72);
            this.MatchDetail.Name = "MatchDetail";
            this.MatchDetail.Size = new System.Drawing.Size(111, 31);
            this.MatchDetail.TabIndex = 5;
            this.MatchDetail.Text = "1경기";
            this.MatchDetail.TextChanged += new System.EventHandler(this.MatchDetail_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Pretendard", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "선수";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayerA
            // 
            this.PlayerA.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerA.Location = new System.Drawing.Point(135, 134);
            this.PlayerA.Name = "PlayerA";
            this.PlayerA.Size = new System.Drawing.Size(173, 31);
            this.PlayerA.TabIndex = 7;
            this.PlayerA.TextChanged += new System.EventHandler(this.PlayerA_TextChanged);
            // 
            // PlayerB
            // 
            this.PlayerB.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerB.Location = new System.Drawing.Point(135, 174);
            this.PlayerB.Name = "PlayerB";
            this.PlayerB.Size = new System.Drawing.Size(173, 31);
            this.PlayerB.TabIndex = 8;
            this.PlayerB.TextChanged += new System.EventHandler(this.PlayerB_TextChanged);
            // 
            // PlayerD
            // 
            this.PlayerD.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerD.Location = new System.Drawing.Point(135, 254);
            this.PlayerD.Name = "PlayerD";
            this.PlayerD.Size = new System.Drawing.Size(173, 31);
            this.PlayerD.TabIndex = 10;
            this.PlayerD.TextChanged += new System.EventHandler(this.PlayerD_TextChanged);
            // 
            // PlayerC
            // 
            this.PlayerC.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerC.Location = new System.Drawing.Point(135, 214);
            this.PlayerC.Name = "PlayerC";
            this.PlayerC.Size = new System.Drawing.Size(173, 31);
            this.PlayerC.TabIndex = 9;
            this.PlayerC.TextChanged += new System.EventHandler(this.PlayerC_TextChanged);
            // 
            // PlayerE
            // 
            this.PlayerE.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerE.Location = new System.Drawing.Point(135, 294);
            this.PlayerE.Name = "PlayerE";
            this.PlayerE.Size = new System.Drawing.Size(173, 31);
            this.PlayerE.TabIndex = 11;
            this.PlayerE.TextChanged += new System.EventHandler(this.PlayerE_TextChanged);
            // 
            // PlayerAStatusControl
            // 
            this.PlayerAStatusControl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PlayerAStatusControl.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerAStatusControl.Location = new System.Drawing.Point(326, 134);
            this.PlayerAStatusControl.Name = "PlayerAStatusControl";
            this.PlayerAStatusControl.Size = new System.Drawing.Size(94, 30);
            this.PlayerAStatusControl.TabIndex = 12;
            this.PlayerAStatusControl.Text = "생존";
            this.PlayerAStatusControl.UseVisualStyleBackColor = false;
            this.PlayerAStatusControl.Click += new System.EventHandler(this.PlayerAStatusControl_Click);
            // 
            // PlayerAGameControl
            // 
            this.PlayerAGameControl.BackColor = System.Drawing.Color.LightCoral;
            this.PlayerAGameControl.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerAGameControl.Location = new System.Drawing.Point(426, 134);
            this.PlayerAGameControl.Name = "PlayerAGameControl";
            this.PlayerAGameControl.Size = new System.Drawing.Size(94, 30);
            this.PlayerAGameControl.TabIndex = 13;
            this.PlayerAGameControl.Text = "대기";
            this.PlayerAGameControl.UseVisualStyleBackColor = false;
            this.PlayerAGameControl.Click += new System.EventHandler(this.PlayerAGameControl_Click);
            // 
            // PlayerBGameControl
            // 
            this.PlayerBGameControl.BackColor = System.Drawing.Color.LightCoral;
            this.PlayerBGameControl.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerBGameControl.Location = new System.Drawing.Point(426, 174);
            this.PlayerBGameControl.Name = "PlayerBGameControl";
            this.PlayerBGameControl.Size = new System.Drawing.Size(94, 30);
            this.PlayerBGameControl.TabIndex = 15;
            this.PlayerBGameControl.Text = "대기";
            this.PlayerBGameControl.UseVisualStyleBackColor = false;
            this.PlayerBGameControl.Click += new System.EventHandler(this.PlayerBGameControl_Click);
            // 
            // PlayerBStatusControl
            // 
            this.PlayerBStatusControl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PlayerBStatusControl.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerBStatusControl.Location = new System.Drawing.Point(326, 174);
            this.PlayerBStatusControl.Name = "PlayerBStatusControl";
            this.PlayerBStatusControl.Size = new System.Drawing.Size(94, 30);
            this.PlayerBStatusControl.TabIndex = 14;
            this.PlayerBStatusControl.Text = "생존";
            this.PlayerBStatusControl.UseVisualStyleBackColor = false;
            this.PlayerBStatusControl.Click += new System.EventHandler(this.PlayerBStatusControl_Click);
            // 
            // PlayerDGameControl
            // 
            this.PlayerDGameControl.BackColor = System.Drawing.Color.LightCoral;
            this.PlayerDGameControl.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerDGameControl.Location = new System.Drawing.Point(426, 254);
            this.PlayerDGameControl.Name = "PlayerDGameControl";
            this.PlayerDGameControl.Size = new System.Drawing.Size(94, 30);
            this.PlayerDGameControl.TabIndex = 19;
            this.PlayerDGameControl.Text = "대기";
            this.PlayerDGameControl.UseVisualStyleBackColor = false;
            this.PlayerDGameControl.Click += new System.EventHandler(this.PlayerDGameControl_Click);
            // 
            // PlayerDStatusControl
            // 
            this.PlayerDStatusControl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PlayerDStatusControl.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerDStatusControl.Location = new System.Drawing.Point(326, 254);
            this.PlayerDStatusControl.Name = "PlayerDStatusControl";
            this.PlayerDStatusControl.Size = new System.Drawing.Size(94, 30);
            this.PlayerDStatusControl.TabIndex = 18;
            this.PlayerDStatusControl.Text = "생존";
            this.PlayerDStatusControl.UseVisualStyleBackColor = false;
            this.PlayerDStatusControl.Click += new System.EventHandler(this.PlayerDStatusControl_Click);
            // 
            // PlayerCGameControl
            // 
            this.PlayerCGameControl.BackColor = System.Drawing.Color.LightCoral;
            this.PlayerCGameControl.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerCGameControl.Location = new System.Drawing.Point(426, 214);
            this.PlayerCGameControl.Name = "PlayerCGameControl";
            this.PlayerCGameControl.Size = new System.Drawing.Size(94, 30);
            this.PlayerCGameControl.TabIndex = 17;
            this.PlayerCGameControl.Text = "대기";
            this.PlayerCGameControl.UseVisualStyleBackColor = false;
            this.PlayerCGameControl.Click += new System.EventHandler(this.PlayerCGameControl_Click);
            // 
            // PlayerCStatusControl
            // 
            this.PlayerCStatusControl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PlayerCStatusControl.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerCStatusControl.Location = new System.Drawing.Point(326, 214);
            this.PlayerCStatusControl.Name = "PlayerCStatusControl";
            this.PlayerCStatusControl.Size = new System.Drawing.Size(94, 30);
            this.PlayerCStatusControl.TabIndex = 16;
            this.PlayerCStatusControl.Text = "생존";
            this.PlayerCStatusControl.UseVisualStyleBackColor = false;
            this.PlayerCStatusControl.Click += new System.EventHandler(this.PlayerCStatusControl_Click);
            // 
            // PlayerEGameControl
            // 
            this.PlayerEGameControl.BackColor = System.Drawing.Color.LightCoral;
            this.PlayerEGameControl.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerEGameControl.Location = new System.Drawing.Point(426, 294);
            this.PlayerEGameControl.Name = "PlayerEGameControl";
            this.PlayerEGameControl.Size = new System.Drawing.Size(94, 30);
            this.PlayerEGameControl.TabIndex = 21;
            this.PlayerEGameControl.Text = "대기";
            this.PlayerEGameControl.UseVisualStyleBackColor = false;
            this.PlayerEGameControl.Click += new System.EventHandler(this.PlayerEGameControl_Click);
            // 
            // PlayerEStatusControl
            // 
            this.PlayerEStatusControl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PlayerEStatusControl.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerEStatusControl.Location = new System.Drawing.Point(326, 294);
            this.PlayerEStatusControl.Name = "PlayerEStatusControl";
            this.PlayerEStatusControl.Size = new System.Drawing.Size(94, 30);
            this.PlayerEStatusControl.TabIndex = 20;
            this.PlayerEStatusControl.Text = "생존";
            this.PlayerEStatusControl.UseVisualStyleBackColor = false;
            this.PlayerEStatusControl.Click += new System.EventHandler(this.PlayerEStatusControl_Click);
            // 
            // OpenOverlay
            // 
            this.OpenOverlay.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenOverlay.Location = new System.Drawing.Point(544, 15);
            this.OpenOverlay.Name = "OpenOverlay";
            this.OpenOverlay.Size = new System.Drawing.Size(210, 41);
            this.OpenOverlay.TabIndex = 22;
            this.OpenOverlay.Text = "경기 오버레이";
            this.OpenOverlay.UseVisualStyleBackColor = true;
            this.OpenOverlay.Click += new System.EventHandler(this.OpenOverlay_Click);
            // 
            // Player2Win
            // 
            this.Player2Win.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(74)))), ((int)(((byte)(46)))));
            this.Player2Win.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player2Win.ForeColor = System.Drawing.Color.White;
            this.Player2Win.Location = new System.Drawing.Point(653, 268);
            this.Player2Win.Name = "Player2Win";
            this.Player2Win.Size = new System.Drawing.Size(102, 56);
            this.Player2Win.TabIndex = 26;
            this.Player2Win.Text = "2P 승리";
            this.Player2Win.UseVisualStyleBackColor = false;
            this.Player2Win.Click += new System.EventHandler(this.Player2Win_Click);
            // 
            // Player1Win
            // 
            this.Player1Win.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(169)))), ((int)(((byte)(194)))));
            this.Player1Win.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player1Win.ForeColor = System.Drawing.Color.White;
            this.Player1Win.Location = new System.Drawing.Point(544, 268);
            this.Player1Win.Name = "Player1Win";
            this.Player1Win.Size = new System.Drawing.Size(102, 56);
            this.Player1Win.TabIndex = 25;
            this.Player1Win.Text = "1P 승리";
            this.Player1Win.UseVisualStyleBackColor = false;
            this.Player1Win.Click += new System.EventHandler(this.Player1Win_Click);
            // 
            // ChangePosition
            // 
            this.ChangePosition.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangePosition.Location = new System.Drawing.Point(543, 210);
            this.ChangePosition.Name = "ChangePosition";
            this.ChangePosition.Size = new System.Drawing.Size(210, 41);
            this.ChangePosition.TabIndex = 23;
            this.ChangePosition.Text = "참가자 순서 바꾸기";
            this.ChangePosition.UseVisualStyleBackColor = true;
            this.ChangePosition.Click += new System.EventHandler(this.ChangePosition_Click);
            // 
            // UpdateOverlay
            // 
            this.UpdateOverlay.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateOverlay.Location = new System.Drawing.Point(544, 163);
            this.UpdateOverlay.Name = "UpdateOverlay";
            this.UpdateOverlay.Size = new System.Drawing.Size(209, 41);
            this.UpdateOverlay.TabIndex = 27;
            this.UpdateOverlay.Text = "경기 오버레이 업데이트";
            this.UpdateOverlay.UseVisualStyleBackColor = true;
            this.UpdateOverlay.Click += new System.EventHandler(this.UpdateOverlay_Click);
            // 
            // OpenDeathmatch
            // 
            this.OpenDeathmatch.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenDeathmatch.Location = new System.Drawing.Point(544, 62);
            this.OpenDeathmatch.Name = "OpenDeathmatch";
            this.OpenDeathmatch.Size = new System.Drawing.Size(210, 41);
            this.OpenDeathmatch.TabIndex = 28;
            this.OpenDeathmatch.Text = "대스매치 오버레이";
            this.OpenDeathmatch.UseVisualStyleBackColor = true;
            this.OpenDeathmatch.Click += new System.EventHandler(this.OpenDeathmatch_Click);
            // 
            // CPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(767, 343);
            this.Controls.Add(this.OpenDeathmatch);
            this.Controls.Add(this.UpdateOverlay);
            this.Controls.Add(this.Player2Win);
            this.Controls.Add(this.Player1Win);
            this.Controls.Add(this.ChangePosition);
            this.Controls.Add(this.OpenOverlay);
            this.Controls.Add(this.PlayerEGameControl);
            this.Controls.Add(this.PlayerEStatusControl);
            this.Controls.Add(this.PlayerDGameControl);
            this.Controls.Add(this.PlayerDStatusControl);
            this.Controls.Add(this.PlayerCGameControl);
            this.Controls.Add(this.PlayerCStatusControl);
            this.Controls.Add(this.PlayerBGameControl);
            this.Controls.Add(this.PlayerBStatusControl);
            this.Controls.Add(this.PlayerAGameControl);
            this.Controls.Add(this.PlayerAStatusControl);
            this.Controls.Add(this.PlayerE);
            this.Controls.Add(this.PlayerD);
            this.Controls.Add(this.PlayerC);
            this.Controls.Add(this.PlayerB);
            this.Controls.Add(this.PlayerA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MatchDetail);
            this.Controls.Add(this.Match);
            this.Controls.Add(this.MatchLabel);
            this.Controls.Add(this.Stage);
            this.Controls.Add(this.StageLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CPanel";
            this.ShowIcon = false;
            this.Text = "오버레이 제어판";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label StageLabel;
        private TextBox Stage;
        private TextBox Match;
        private Label MatchLabel;
        private TextBox MatchDetail;
        private Label label2;
        private TextBox PlayerA;
        private TextBox PlayerB;
        private TextBox PlayerD;
        private TextBox PlayerC;
        private TextBox PlayerE;
        private Button PlayerAStatusControl;
        private Button PlayerAGameControl;
        private Button PlayerBGameControl;
        private Button PlayerBStatusControl;
        private Button PlayerDGameControl;
        private Button PlayerDStatusControl;
        private Button PlayerCGameControl;
        private Button PlayerCStatusControl;
        private Button PlayerEGameControl;
        private Button PlayerEStatusControl;
        private Button OpenOverlay;
        private Button Player2Win;
        private Button Player1Win;
        private Button ChangePosition;
        private Button UpdateOverlay;
        private Button OpenDeathmatch;
    }
}
