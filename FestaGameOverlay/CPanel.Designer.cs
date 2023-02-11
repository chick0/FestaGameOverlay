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
            this.SuspendLayout();
            // 
            // StageLabel
            // 
            this.StageLabel.Font = new System.Drawing.Font("넥슨Lv2고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StageLabel.Location = new System.Drawing.Point(12, 11);
            this.StageLabel.Name = "StageLabel";
            this.StageLabel.Size = new System.Drawing.Size(125, 50);
            this.StageLabel.TabIndex = 0;
            this.StageLabel.Text = "스테이지";
            this.StageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Stage
            // 
            this.Stage.Font = new System.Drawing.Font("넥슨Lv2고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stage.Location = new System.Drawing.Point(152, 22);
            this.Stage.Name = "Stage";
            this.Stage.Size = new System.Drawing.Size(173, 30);
            this.Stage.TabIndex = 1;
            this.Stage.Text = "Stage 1";
            this.Stage.TextChanged += new System.EventHandler(this.Stage_TextChanged);
            // 
            // Match
            // 
            this.Match.Font = new System.Drawing.Font("넥슨Lv2고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Match.Location = new System.Drawing.Point(152, 74);
            this.Match.Name = "Match";
            this.Match.Size = new System.Drawing.Size(173, 30);
            this.Match.TabIndex = 3;
            this.Match.Text = "풀리그";
            this.Match.TextChanged += new System.EventHandler(this.Match_TextChanged);
            // 
            // MatchLabel
            // 
            this.MatchLabel.Font = new System.Drawing.Font("넥슨Lv2고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatchLabel.Location = new System.Drawing.Point(12, 61);
            this.MatchLabel.Name = "MatchLabel";
            this.MatchLabel.Size = new System.Drawing.Size(125, 50);
            this.MatchLabel.TabIndex = 2;
            this.MatchLabel.Text = "경기";
            this.MatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MatchDetail
            // 
            this.MatchDetail.Font = new System.Drawing.Font("넥슨Lv2고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatchDetail.Location = new System.Drawing.Point(343, 74);
            this.MatchDetail.Name = "MatchDetail";
            this.MatchDetail.Size = new System.Drawing.Size(111, 30);
            this.MatchDetail.TabIndex = 5;
            this.MatchDetail.Text = "1경기";
            this.MatchDetail.TextChanged += new System.EventHandler(this.MatchDetail_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("넥슨Lv2고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "선수";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayerA
            // 
            this.PlayerA.Font = new System.Drawing.Font("넥슨Lv2고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerA.Location = new System.Drawing.Point(152, 176);
            this.PlayerA.Name = "PlayerA";
            this.PlayerA.Size = new System.Drawing.Size(173, 30);
            this.PlayerA.TabIndex = 7;
            this.PlayerA.TextChanged += new System.EventHandler(this.PlayerA_TextChanged);
            // 
            // PlayerB
            // 
            this.PlayerB.Font = new System.Drawing.Font("넥슨Lv2고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerB.Location = new System.Drawing.Point(152, 216);
            this.PlayerB.Name = "PlayerB";
            this.PlayerB.Size = new System.Drawing.Size(173, 30);
            this.PlayerB.TabIndex = 8;
            this.PlayerB.TextChanged += new System.EventHandler(this.PlayerB_TextChanged);
            // 
            // PlayerD
            // 
            this.PlayerD.Font = new System.Drawing.Font("넥슨Lv2고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerD.Location = new System.Drawing.Point(152, 296);
            this.PlayerD.Name = "PlayerD";
            this.PlayerD.Size = new System.Drawing.Size(173, 30);
            this.PlayerD.TabIndex = 10;
            this.PlayerD.TextChanged += new System.EventHandler(this.PlayerD_TextChanged);
            // 
            // PlayerC
            // 
            this.PlayerC.Font = new System.Drawing.Font("넥슨Lv2고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerC.Location = new System.Drawing.Point(152, 256);
            this.PlayerC.Name = "PlayerC";
            this.PlayerC.Size = new System.Drawing.Size(173, 30);
            this.PlayerC.TabIndex = 9;
            this.PlayerC.TextChanged += new System.EventHandler(this.PlayerC_TextChanged);
            // 
            // PlayerE
            // 
            this.PlayerE.Font = new System.Drawing.Font("넥슨Lv2고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerE.Location = new System.Drawing.Point(152, 336);
            this.PlayerE.Name = "PlayerE";
            this.PlayerE.Size = new System.Drawing.Size(173, 30);
            this.PlayerE.TabIndex = 11;
            this.PlayerE.TextChanged += new System.EventHandler(this.PlayerE_TextChanged);
            // 
            // PlayerAStatusControl
            // 
            this.PlayerAStatusControl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PlayerAStatusControl.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerAStatusControl.Location = new System.Drawing.Point(343, 176);
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
            this.PlayerAGameControl.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerAGameControl.Location = new System.Drawing.Point(443, 176);
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
            this.PlayerBGameControl.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerBGameControl.Location = new System.Drawing.Point(443, 216);
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
            this.PlayerBStatusControl.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerBStatusControl.Location = new System.Drawing.Point(343, 216);
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
            this.PlayerDGameControl.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerDGameControl.Location = new System.Drawing.Point(443, 296);
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
            this.PlayerDStatusControl.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerDStatusControl.Location = new System.Drawing.Point(343, 296);
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
            this.PlayerCGameControl.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerCGameControl.Location = new System.Drawing.Point(443, 256);
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
            this.PlayerCStatusControl.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerCStatusControl.Location = new System.Drawing.Point(343, 256);
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
            this.PlayerEGameControl.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerEGameControl.Location = new System.Drawing.Point(443, 336);
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
            this.PlayerEStatusControl.Font = new System.Drawing.Font("넥슨Lv2고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerEStatusControl.Location = new System.Drawing.Point(343, 336);
            this.PlayerEStatusControl.Name = "PlayerEStatusControl";
            this.PlayerEStatusControl.Size = new System.Drawing.Size(94, 30);
            this.PlayerEStatusControl.TabIndex = 20;
            this.PlayerEStatusControl.Text = "생존";
            this.PlayerEStatusControl.UseVisualStyleBackColor = false;
            this.PlayerEStatusControl.Click += new System.EventHandler(this.PlayerEStatusControl_Click);
            // 
            // OpenOverlay
            // 
            this.OpenOverlay.Font = new System.Drawing.Font("넥슨Lv2고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenOverlay.Location = new System.Drawing.Point(152, 389);
            this.OpenOverlay.Name = "OpenOverlay";
            this.OpenOverlay.Size = new System.Drawing.Size(385, 56);
            this.OpenOverlay.TabIndex = 22;
            this.OpenOverlay.Text = "오버레이 실행";
            this.OpenOverlay.UseVisualStyleBackColor = true;
            this.OpenOverlay.Click += new System.EventHandler(this.OpenOverlay_Click);
            // 
            // CPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(562, 469);
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
    }
}
